using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NVK.Generator.Attributes;
using NVK.Generator.EqualityComparer;
using NVK.Generator.Extensions;
using NVK.Generator.Specification;

namespace NVK.Generator
{
    /// <summary>Handles generating C# code.</summary>
    public static class CodeGenerator
    {
        /*********
        ** Public Methods
        *********/
        /// <summary>Geenrates the C# files for a specification.</summary>
        /// <param name="specification">The specification to generate the code from.</param>
        public static void GenerateCode(VulkanSpecification specification)
        {
            var outputPath = "./Generated/";
            if (!Directory.Exists(outputPath))
                Directory.CreateDirectory(outputPath);

            GenerateVKFile(specification.Constants, specification.Commands, Path.Combine(outputPath, "VK.gen.cs"));
            GenerateEnumsFile(specification.Enums, Path.Combine(outputPath, "Enums.gen.cs"));
            GenerateDelegatesFile(specification.Delegates, Path.Combine(outputPath, "Delegates.gen.cs"));
            GenerateHandlesFile(specification.Handles, Path.Combine(outputPath, "Handles.gen.cs"));
            GenerateStructuresFile(specification.Structures, specification.Constants, Path.Combine(outputPath, "Structures.gen.cs"));
        }


        /*********
        ** Private Methods
        *********/
        /// <summary>Generates the C# file containing the Vulkan constants and commands.</summary>
        /// <param name="constantInfos">The constants to generate.</param>
        /// <param name="commandInfos">The commands to generate.</param>
        /// <param name="file">The VK file.</param>
        private static void GenerateVKFile(List<ConstantInfo> constantInfos, List<CommandInfo> commandInfos, string file)
        {
            using (var streamWriter = File.CreateText(file))
            {
                var csWriter = new CsWriter(streamWriter);

                csWriter.WriteHeader();
                csWriter.WriteLine();

                csWriter.WriteUsing("System");
                csWriter.WriteUsing("System.Runtime.InteropServices");
                csWriter.WriteLine();

                csWriter.WriteLine($"namespace Vulkan");
                csWriter.WriteScope(() =>
                {
                    csWriter.WriteLine($"public static class VK");
                    csWriter.WriteScope(() =>
                    {
                        // create constants
                        foreach (var constantInfo in constantInfos)
                            WriteConstant(csWriter, constantInfo);

                        // create delegates
                        foreach (var commandInfo in commandInfos)
                            WriteDelegates(csWriter, commandInfo);

                        // create fields
                        csWriter.WriteLine("private static readonly OSVulkanLibraryBase VulkanLibrary;");
                        foreach (var commandInfo in commandInfos)
                            WriteFields(csWriter, commandInfo);

                        // create class initialiser to retrieve the function pointers
                        csWriter.WriteLine("static VK()");
                        csWriter.WriteScope(() =>
                        {
                            csWriter.WriteLine("VulkanLibrary = OSVulkanLibraryBase.CreateOSVulkanLibrary();");
                            csWriter.WriteLine("InitialiseRequiredMethods();");
                        });

                        // create methods
                        void PopulateDelegateOverloads(CsWriter csWriter, CommandInfo commandInfo)
                        {
                            var overloads = Utilities.GenerateAllOverloads(commandInfo);
                            for (int i = 0; i < overloads.Count; i++)
                                csWriter.WriteLine($"{commandInfo.DisplayName}_{i} = Marshal.GetDelegateForFunctionPointer<{commandInfo.DelegateDisplayName}_{i}>({commandInfo.PointerDisplayName});");
                        }

                        var requiredMethods = new[] { "vkCreateInstance", "vkEnumerateInstanceExtensionProperties", "vkEnumerateInstanceLayerProperties", "vkGetInstanceProcAddr" };

                        csWriter.WriteLine("private static void InitialiseRequiredMethods()");
                        csWriter.WriteScope(() =>
                        {
                            foreach (var commandInfo in commandInfos.Where(commandInfo => requiredMethods.Contains(commandInfo.Name)))
                            {
                                csWriter.WriteLine($"{commandInfo.PointerDisplayName} = VulkanLibrary.GetFunctionPointer(\"{commandInfo.Name}\");");
                                PopulateDelegateOverloads(csWriter, commandInfo);
                            }
                        });

                        csWriter.WriteLine("public static void InitialiseInstanceMethods(VkInstance instance)");
                        csWriter.WriteScope(() =>
                        {
                            foreach (var commandInfo in commandInfos.Where(commandInfo => !requiredMethods.Contains(commandInfo.Name)))
                            {
                                if (commandInfo.Alias != null) // aliases don't have delegates
                                    continue;

                                csWriter.WriteLine($"{commandInfo.PointerDisplayName} = GetInstancePrecedureAddress(instance, \"{commandInfo.Name}\");");
                                csWriter.WriteLine($"if ({commandInfo.PointerDisplayName} != IntPtr.Zero)");
                                csWriter.WriteScope(() => PopulateDelegateOverloads(csWriter, commandInfo));
                            }
                        });

                        foreach (var commandInfo in commandInfos)
                            WriteMethods(csWriter, commandInfo, commandInfos);
                    });
                });
            }
        }

        /// <summary>Generates the C# file containing the Vulkan enums.</summary>
        /// <param name="enumInfos">The enums to generate.</param>
        /// <param name="file">The enums file.</param>
        private static void GenerateEnumsFile(List<EnumInfo> enumInfos, string file)
        {
            using (var streamWriter = File.CreateText(file))
            {
                var csWriter = new CsWriter(streamWriter);

                csWriter.WriteHeader();
                csWriter.WriteLine();

                csWriter.WriteUsing("System");
                csWriter.WriteLine();

                csWriter.WriteLine($"namespace Vulkan");
                csWriter.WriteScope(() =>
                {
                    foreach (var enumInfo in enumInfos)
                        WriteEnum(csWriter, enumInfo);
                });
            }
        }

        /// <summary>Generates the C# file containing the Vulkan function pointers.</summary>
        /// <param name="delegateInfos">The delegates to generate.</param>
        /// <param name="file">The delegates file.</param>
        /// <remarks>Note: this doesn't contain the delegates used for interop, those are stored in <c>VK.gen.cs</c> generated by <see cref="GenerateVKFile(List{ConstantInfo}, List{CommandInfo}, string)"/>.</remarks>
        private static void GenerateDelegatesFile(List<DelegateInfo> delegateInfos, string file)
        {
            using (var streamWriter = File.CreateText(file))
            {
                var csWriter = new CsWriter(streamWriter);

                csWriter.WriteHeader();
                csWriter.WriteLine();

                csWriter.WriteUsing("System");
                csWriter.WriteLine();

                csWriter.WriteLine($"namespace Vulkan");
                csWriter.WriteScope(() =>
                {
                    foreach (var delegateInfo in delegateInfos)
                        WriteDelegate(csWriter, delegateInfo);
                });
            }
        }

        /// <summary>Generates the C# file containing the Vulkan enums.</summary>
        /// <param name="handleInfos">The handles to generate.</param>
        /// <param name="file">The handles file.</param>
        private static void GenerateHandlesFile(List<HandleInfo> handleInfos, string file)
        {
            using (var streamWriter = File.CreateText(file))
            {
                var csWriter = new CsWriter(streamWriter);

                csWriter.WriteHeader();
                csWriter.WriteLine();

                csWriter.WriteUsing("System");
                csWriter.WriteLine();

                csWriter.WriteLine($"namespace Vulkan");
                csWriter.WriteScope(() =>
                {
                    foreach (var handleInfo in handleInfos)
                        WriteHandle(csWriter, handleInfo);
                });
            }
        }

        /// <summary>Generates the C# file containing the Vulkan structures.</summary>
        /// <param name="structureInfos">The structures to generate.</param>
        /// <param name="constantInfos">The constants to use when resolving array lengths for fields.</param>
        /// <param name="file">The structures file.</param>
        private static void GenerateStructuresFile(List<StructureInfo> structureInfos, List<ConstantInfo> constantInfos, string file)
        {
            using (var streamWriter = File.CreateText(file))
            {
                var csWriter = new CsWriter(streamWriter);

                csWriter.WriteHeader();
                csWriter.WriteLine();

                csWriter.WriteUsing("System");
                csWriter.WriteUsing("System.Runtime.InteropServices");
                csWriter.WriteLine();

                csWriter.WriteLine($"namespace Vulkan");
                csWriter.WriteScope(() =>
                {
                    foreach (var structureInfo in structureInfos.Where(structureInfo => structureInfo.Fields.Count > 0))
                        WriteStructure(csWriter, structureInfo, constantInfos);
                });
            }
        }

        /// <summary>Writes a constant to a <see cref="CsWriter"/>.</summary>
        /// <param name="csWriter">The <see cref="CsWriter"/> to write the constant to.</param>
        /// <param name="constantInfo">The constant to write to <paramref name="csWriter"/>.</param>
        private static void WriteConstant(CsWriter csWriter, ConstantInfo constantInfo) => csWriter.WriteLine($"public const {constantInfo.DisplayType} {constantInfo.DisplayName} = {constantInfo.DisplayValue};");

        /// <summary>Writes interop delegates to a <see cref="CsWriter"/>.</summary>
        /// <param name="csWriter">The <see cref="CsWriter"/> to write the delegates to.</param>
        /// <param name="commandInfo">The delegates to write to <paramref name="csWriter"/>.</param>
        private static void WriteDelegates(CsWriter csWriter, CommandInfo commandInfo)
        {
            if (commandInfo.Alias != null) // aliases don't need delegates as they call the aliased method, not a delegate
                return;

            var overloads = Utilities.GenerateAllOverloads(commandInfo);
            for (int i = 0; i < overloads.Count; i++)
            {
                var overload = overloads[i];
                csWriter.WriteLine($"private unsafe delegate {overload.ReturnType} {overload.DelegateDisplayName}_{i}({string.Join(", ", overload.Parameters.Select(parameterInfo => parameterInfo.ToString()))});");
            }
        }

        /// <summary>Writes a function pointer delegate to a <see cref="CsWriter"/>.</summary>
        /// <param name="csWriter">The <see cref="CsWriter"/> to write the delegate to.</param>
        /// <param name="delegateInfo">The delegate to write to <paramref name="csWriter"/>.</param>
        private static void WriteDelegate(CsWriter csWriter, DelegateInfo delegateInfo) => csWriter.WriteLine($"public unsafe delegate {delegateInfo.ReturnType} {delegateInfo.DisplayName}({string.Join(", ", delegateInfo.Parameters.Select(parameterInfo => parameterInfo.ToString()))});");

        /// <summary>Writes pointer and delegate fields to a <see cref="CsWriter"/>.</summary>
        /// <param name="csWriter">The <see cref="CsWriter"/> to write the fields to.</param>
        /// <param name="commandInfo">The fields to write to <paramref name="csWriter"/>.</param>
        private static void WriteFields(CsWriter csWriter, CommandInfo commandInfo)
        {
            if (commandInfo.Alias != null) // aliases don't have pointer or delegates
                return;

            // field containing function pointer
            csWriter.WriteLine($"private static IntPtr {commandInfo.PointerDisplayName};");

            // fields for each overload delegate
            var overloads = Utilities.GenerateAllOverloads(commandInfo);
            for (int i = 0; i < overloads.Count; i++)
                csWriter.WriteLine($"private static {commandInfo.DelegateDisplayName}_{i} {commandInfo.DisplayName}_{i};");
        }

        /// <summary>Writes methods to a <see cref="CsWriter"/>.</summary>
        /// <param name="csWriter">The <see cref="CsWriter"/> to write the methods to.</param>
        /// <param name="commandInfo">The methods to write to <paramref name="csWriter"/>.</param>
        /// <param name="commandInfos">The methods to use when resolving method aliasing.</param>
        private static void WriteMethods(CsWriter csWriter, CommandInfo commandInfo, List<CommandInfo> commandInfos)
        {
            var overloads = Utilities.GenerateAllOverloads(commandInfo);
            for (int i = 0; i < overloads.Count; i++)
            {
                var overload = overloads[i];
                var parametersString = string.Join(", ", overload.Parameters.Select(parameterInfo => parameterInfo.ToString()));

                // if the method is an alias, just call that instead of marshalling
                if (overload.Alias != null)
                {
                    var aliasedParameterNames = string.Join(", ", overload.Parameters.Select(parameterInfo => $"{parameterInfo.Modifier.GetAttribute<UnderlyingTypeAttribute>()?.UnderlyingType}{parameterInfo.DisplayName}"));

                    var aliasedCommand = commandInfos.Single(cInfo => cInfo.Name == overload.Alias);
                    csWriter.WriteLine($"public static unsafe {aliasedCommand.ReturnType} {overload.DisplayName}({parametersString}) => {overload.AliasDisplayName}({aliasedParameterNames});");
                    continue;
                }

                // create method
                var parameterNames = string.Join(", ", overload.Parameters.Select(parameterInfo => $"{parameterInfo.Modifier.GetAttribute<UnderlyingTypeAttribute>()?.UnderlyingType}{parameterInfo.DisplayName}"));
                csWriter.WriteLine($"public static unsafe {overload.ReturnType} {overload.DisplayName}({parametersString}) => {overload.DisplayName}_{i}({parameterNames});");
            }
        }

        /// <summary>Writes an enum to a <see cref="CsWriter"/>.</summary>
        /// <param name="csWriter">The <see cref="CsWriter"/> to write the handle to.</param>
        /// <param name="enumInfo">The enum to write to <paramref name="csWriter"/>.</param>
        private static void WriteEnum(CsWriter csWriter, EnumInfo enumInfo)
        {
            if (enumInfo.Type == EnumType.Bitmask)
                csWriter.WriteLine($"[Flags]");

            csWriter.WriteLine($"public enum {enumInfo.Name}{((enumInfo.BitWidth == 64) ? " : long" : "")}");
            csWriter.WriteScope(() =>
            {
                foreach (var enumValue in enumInfo.Values.Distinct(new EnumFieldInfoDisplayNameEqualityComparer()))
                    csWriter.WriteLine(enumValue.ToString());
            });
        }

        /// <summary>Writes a handle to a <see cref="CsWriter"/>.</summary>
        /// <param name="csWriter">The <see cref="CsWriter"/> to write the handle to.</param>
        /// <param name="handleInfo">The handle to write to <paramref name="csWriter"/>.</param>
        private static void WriteHandle(CsWriter csWriter, HandleInfo handleInfo)
        {
            var handleType = handleInfo.Dispatchable ? "UIntPtr" : "ulong";
            var nullValue = handleInfo.Dispatchable ? "UIntPtr.Zero" : "0";

            csWriter.WriteLine($"public struct {handleInfo.Name}");
            csWriter.WriteScope(() =>
            {
                // fields
                csWriter.WriteLine($"public readonly {handleType} Handle;");

                // accessors
                csWriter.WriteLine($"public bool IsNull => Handle == {nullValue};");
                csWriter.WriteLine($"public static {handleInfo.Name} Null => new({nullValue});");

                // public methods
                csWriter.WriteLine($"public {handleInfo.Name}({handleType} handle)");
                csWriter.WriteScope(() =>
                {
                    csWriter.WriteLine("Handle = handle;");
                });
                csWriter.WriteLine($"public override bool Equals(object obj) => obj is {handleInfo.Name} handle && this == handle;");
                csWriter.WriteLine($"public override int GetHashCode() => Handle.GetHashCode();");

                // operators
                csWriter.WriteLine($"public static bool operator ==({handleInfo.Name} left, {handleInfo.Name} right) => left.Handle == right.Handle;");
                csWriter.WriteLine($"public static bool operator !=({handleInfo.Name} left, {handleInfo.Name} right) => left.Handle != right.Handle;");
                csWriter.WriteLine($"public static bool operator ==({handleInfo.Name} left, {handleType} right) => left.Handle == right;");
                csWriter.WriteLine($"public static bool operator !=({handleInfo.Name} left, {handleType} right) => left.Handle != right;");
                csWriter.WriteLine($"public static bool operator ==({handleType} left, {handleInfo.Name} right) => left == right.Handle;");
                csWriter.WriteLine($"public static bool operator !=({handleType} left, {handleInfo.Name} right) => left != right.Handle;");
            });
        }

        /// <summary>Writes a structure to a <see cref="CsWriter"/>.</summary>
        /// <param name="csWriter">The <see cref="CsWriter"/> to write the structure to.</param>
        /// <param name="structureInfo">The structure to write to <paramref name="csWriter"/>.</param>
        /// <param name="constantInfos">The constants to use when resolving array lengths for fields.</param>
        private static void WriteStructure(CsWriter csWriter, StructureInfo structureInfo, List<ConstantInfo> constantInfos)
        {
            if (structureInfo.IsUnion)
                csWriter.WriteLine("[StructLayout(LayoutKind.Explicit)]");
            csWriter.WriteLine($"public unsafe struct {structureInfo.DisplayName}");
            csWriter.WriteScope(() =>
            {
                // fields
                foreach (var fieldInfo in structureInfo.Fields)
                {
                    if (structureInfo.IsUnion)
                        csWriter.WriteLine("[FieldOffset(0)]");
                    WriteField(csWriter, fieldInfo, constantInfos);
                }

                var structuresWithConstructors = new[] { "VkOffset2D", "VkOffset3D", "VkExtent2D", "VkExtent3D", "VkRect2D", "VkComponentMapping", "VkImageSubresource", "VkImageSubresourceLayers", "VkImageSubresourceRange", "VkClearDepthStencilValue", "VkClearColorValue" };

                // properties
                if (structureInfo.DisplayName.StartsWith("VkOffset") || structureInfo.DisplayName.StartsWith("VkExtent"))
                    csWriter.WriteLine($"public static {structureInfo.DisplayName} Zero => new();");
                else if (structureInfo.DisplayName == "VkComponentMapping")
                    csWriter.WriteLine("public static VkComponentMapping Identity => new(VkComponentSwizzle.Identity, VkComponentSwizzle.Identity, VkComponentSwizzle.Identity, VkComponentSwizzle.Identity);");

                // constructors
                if (structuresWithConstructors.Contains(structureInfo.DisplayName))
                {
                    // special constructors
                    if (structureInfo.DisplayName == "VkClearColorValue")
                    {
                        var parameterTypes = new[] { "float", "int", "uint" };
                        foreach (var parameterType in parameterTypes)
                        {
                            csWriter.WriteLine($"public VkClearColorValue({parameterType} r, {parameterType} g, {parameterType} b, {parameterType} a)");
                            csWriter.WriteScope(() =>
                            {
                                var fieldName = parameterType.FirstToUpper() + "32";
                                csWriter.WriteLine($"{fieldName}[0] = r;");
                                csWriter.WriteLine($"{fieldName}[1] = g;");
                                csWriter.WriteLine($"{fieldName}[2] = b;");
                                csWriter.WriteLine($"{fieldName}[3] = a;");
                            });
                        }
                    }

                    // auto generated constructor
                    else
                    {
                        var parametersString = string.Join(", ", structureInfo.Fields.Select(fieldInfo => $"{fieldInfo.Type} {fieldInfo.DisplayName.FirstToLower()}"));
                        csWriter.WriteLine($"public {structureInfo.DisplayName}({parametersString})");
                        csWriter.WriteScope(() =>
                        {
                            foreach (var fieldInfo in structureInfo.Fields)
                                csWriter.WriteLine($"{fieldInfo.DisplayName} = {fieldInfo.DisplayName.FirstToLower()};");
                        });
                    }
                }

                // operators
                if (structureInfo.DisplayName == "VkClearValue")
                {
                    csWriter.WriteLine("public static implicit operator VkClearValue(VkClearColorValue colour) => new() { Color = colour };");
                    csWriter.WriteLine("public static implicit operator VkClearValue(VkClearDepthStencilValue depthStencil) => new() { DepthStencil = depthStencil };");
                }
            });
        }

        /// <summary>Writes a field to a <see cref="CsWriter"/>.</summary>
        /// <param name="csWriter">The <see cref="CsWriter"/> to write the field to.</param>
        /// <param name="fieldInfo">The field to write to <paramref name="csWriter"/>.</param>
        /// <param name="constantInfos">The constants to use when resolving array lengths for fields.</param>
        private static void WriteField(CsWriter csWriter, FieldInfo fieldInfo, List<ConstantInfo> constantInfos)
        {
            if (fieldInfo.ElementCount == null)
                csWriter.WriteLine($"public {fieldInfo.Type} {fieldInfo.DisplayName};");
            else
            {
                int.TryParse(fieldInfo.ElementCount, out var numericArrayLength);
                if (fieldInfo.ElementCount.Contains("][")) // check if the field is an array of arrays, if so then set the array length to be that of a single dimensional one
                    numericArrayLength = fieldInfo.ElementCount.Split("][").Select(arrayDimension => int.Parse(arrayDimension)).Aggregate(1, (x, y) => x * y);

                // check if the type is allowed in a fixed array
                var fixedArrayTypes = new[] { "sbyte", "byte", "short", "ushort", "int", "uint", "long", "ulong", "bool", "char", "float", "double" };
                if (fixedArrayTypes.Contains(fieldInfo.Type.Name))
                {
                    var arrayLength = numericArrayLength.ToString();
                    if (numericArrayLength == 0) // if it's a constant (instead of a number), prefix it as such
                        arrayLength = $"(int)VK.{Utilities.PrettifyConsantName(fieldInfo.ElementCount)}";

                    csWriter.WriteLine($"public fixed {fieldInfo.Type} {fieldInfo.DisplayName}[{arrayLength}];");
                }

                // if it isn't, then create a separate field for each element
                else
                {
                    // if the array length is a Vulkan constant, resolve it to a numeric value
                    if (numericArrayLength == 0)
                        numericArrayLength = int.Parse(constantInfos.Single(constantInfo => constantInfo.Name == fieldInfo.ElementCount).DisplayValue);

                    for (int i = 0; i < numericArrayLength; i++)
                        csWriter.WriteLine($"public {fieldInfo.Type} {fieldInfo.DisplayName}_{i};");
                }
            }
        }
    }
}
