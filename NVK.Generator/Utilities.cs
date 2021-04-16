﻿using System.Collections.Generic;
using System.Linq;
using NVK.Generator.Extensions;
using NVK.Generator.Specification;

namespace NVK.Generator
{
    /// <summary>Contains useful helper methods.</summary>
    public static class Utilities
    {
        /*********
        ** Public Methods
        *********/
        /// <summary>Prettifies a constant name.</summary>
        /// <param name="constantName">The constant name to prettify.</param>
        /// <returns>A pretty version of <paramref name="constantName"/>.</returns>
        public static string PrettifyConsantName(string constantName)
        {
            var splitConstantName = constantName.Substring(3).Split('_'); // remove "VK_" prefix
            return string.Concat(splitConstantName.Select(splitName => splitName.ToLower().FirstToUpper()));
        }

        /// <summary>Prettifies a constant value.</summary>
        /// <param name="constantValue">The constant value to prettify.</param>
        /// <returns>A pretty version of <paramref name="constantValue"/>.</returns>
        public static string PrettifyConsantValue(string constantValue) => constantValue.Trim('(', ')').Replace("LL", "L").Replace(".0f", "f");

        /// <summary>Prettifies a delegate name.</summary>
        /// <param name="delegateName">The delegate name to prettify.</param>
        /// <returns>A pretty version of <paramref name="delegateName"/>.</returns>
        public static string PrettifyDelegateName(string delegateName)
        {
            if (delegateName.StartsWith("PFN_vk")) // remove "PFN_vk" prefix
                delegateName = delegateName.Substring(6);
            else if (delegateName.StartsWith("vk")) // remove "vk" prefix
                delegateName = delegateName.Substring(2);

            return delegateName.ResolveAbbreviations() + "Delegate";
        }

        /// <summary>Prettifies a field name.</summary>
        /// <param name="fieldName">The field name to prettify.</param>
        /// <param name="pointerIndirection">The pointer indirection of the field.</param>
        /// <returns>A pretty version of <paramref name="fieldName"/>.</returns>
        public static string PrettifyFieldName(string fieldName, int pointerIndirection)
        {
            if (fieldName == "sType")
                return "SType";

            for (int i = 0; i < pointerIndirection; i++) // remove pointer prefix
                if (fieldName.StartsWith('p'))
                    fieldName = fieldName.Substring(1);

            fieldName = fieldName.Replace("PFN_vk", ""); // remove function pointer prefix

            // a single awkward case where two fields are only differentiated by the level of pointer indirection (and therefore the prefixed "p"'s that we've just removed), just suffix the second one with a '2'
            if (fieldName == "Geometries" && pointerIndirection == 2)
                fieldName += "2";

            return fieldName.ResolveAbbreviations().FirstToUpper();
        }

        /// <summary>Prettifies a command name.</summary>
        /// <param name="commandName">The command name to prettify.</param>
        /// <returns>A pretty version of <paramref name="commandName"/>.</returns>
        public static string PrettifyCommandName(string commandName)
        {
            if (commandName.StartsWith("vk")) // remove "vk" prefix
                commandName = commandName.Substring(2);

            return commandName.ResolveAbbreviations();
        }

        /// <summary>Prettifies a parameter name.</summary>
        /// <param name="parameterName">The parameter name to prettify.</param>
        /// <param name="pointerIndirection">The pointer indirection of the parameter.</param>
        /// <returns>A pretty version of <paramref name="parameterName"/>.</returns>
        public static string PrettifyParameterName(string parameterName, int pointerIndirection)
        {
            for (int i = 0; i < pointerIndirection; i++) // remove pointer prefix
                if (parameterName.StartsWith('p'))
                    parameterName = parameterName.Substring(1);

            return parameterName.ResolveAbbreviations().FirstToLower().EnsureIsntReserved();
        }

        /// <summary>Prettifies a structure name.</summary>
        /// <param name="structureName">The structure name to prettify.</param>
        /// <returns>A pretty version of <paramref name="structureName"/>.</returns>
        public static string PrettifyStructureName(string structureName)
        {
            return structureName;
        }

        /// <summary>Prettifies an enum name.</summary>
        /// <param name="enumName">The enum name to prettify.</param>
        /// <returns>A pretty version of <paramref name="enumName"/>.</returns>
        public static string PrettifyEnumName(string enumName)
        {
            return enumName;
        }

        /// <summary>Prettifies a enum field name.</summary>
        /// <param name="enumName">The name of the enum that adds the field.</param>
        /// <param name="enumFieldName">The enum field name to prettify.</param>
        /// <returns>A pretty version of <paramref name="enumFieldName"/>.</returns>
        public static string PrettifyEnumFieldName(string enumName, string enumFieldName)
        {
            enumName = enumName.Replace("FlagBits", "").RemoveSuffixesExtensionVendorTag();

            // remove the enum name from the field name
            var splitEnumName = enumName.SplitOnUpper().ToList();
            var splitEnumFieldName = enumFieldName.Split('_').ToList();

            for (int i = 0; i < splitEnumName.Count; i++)
                if (splitEnumName[i].ToLower() == splitEnumFieldName[i].ToLower())
                {
                    splitEnumName.RemoveAt(i);
                    splitEnumFieldName.RemoveAt(i--);
                }

            // bitfield enums have an unwanted 'Bit' in their field names
            splitEnumFieldName.Remove("BIT");

            // handle special enum cases
            if (enumName == "VkSampleCountFlags")
                splitEnumFieldName.Insert(0, "Count");

            // reconstruct the name and ensure it doesn't start with a digit (as that's not a valid C# identifier)
            var newEnumFieldName = string.Join("", splitEnumFieldName.Select(splitName => splitName.ToLower().FirstToUpper()));
            if (char.IsDigit(newEnumFieldName[0]))
                newEnumFieldName = $"_{newEnumFieldName}";

            return newEnumFieldName.ResolveAbbreviations();
        }

        /// <summary>Generates all overloads for a command.</summary>
        /// <param name="commandInfo">The command to generate the overloads of.</param>
        /// <returns>All the overloads that <paramref name="commandInfo"/> can have, including <paramref name="commandInfo"/> itself.</returns>
        /// <remarks>This only creates overloads with adjusted parameter modifiers, not any convenience overloads such as not needing to specify array lengths.<br/>Note: <paramref name="commandInfo"/> will be included in the returned list.</remarks>
        public static List<CommandInfo> GenerateAllOverloads(CommandInfo commandInfo)
        {
            var overloads = new List<CommandInfo> { commandInfo };

            // get all the version each parameter can be
            List<List<CommandParameterInfo>> parameterVariations = new();
            for (int i = 0; i < commandInfo.Parameters.Count; i++)
                parameterVariations.Add(GetParameterVariations(commandInfo, commandInfo.Parameters[i]));

            // get all parameter variations
            var parameterCombinations = GetParameterCombinations(parameterVariations);
            var temp = parameterCombinations.Select(parameterCombination => new CommandInfo(commandInfo.Name, commandInfo.ReturnType!, parameterCombination, commandInfo.Alias) { Extension = commandInfo.Extension }).ToList();
            return temp;
        }

        /// <summary>Generates all variaties of a parameter.</summary>
        /// <param name="commandInfo">The command the parameter belongs to</param>
        /// <param name="parameterInfo">The parameter to generate the variations of.</param>
        /// <returns>The variations that <paramref name="parameterInfo"/> can have, including <paramref name="parameterInfo"/> itself.</returns>
        private static List<CommandParameterInfo> GetParameterVariations(CommandInfo commandInfo, CommandParameterInfo parameterInfo)
        {
            var parameterVariations = new List<CommandParameterInfo>() { parameterInfo };

            // ensure parameter can have multiple variations
            if (parameterInfo.Type.PointerIndirection == 0 || parameterInfo.Type.Name == "void")
                return parameterVariations;

            // check if parameter is a byte pointer (meaning it's actually a string)
            if (parameterInfo.Type.Name == "byte")
            {
                if (parameterInfo.Type.PointerIndirection == 1) // convert byte* to string
                    parameterVariations.Add(new CommandParameterInfo(parameterInfo.Name, new TypeInfo("string"), ParameterModifier.None));
                else if (parameterInfo.Type.PointerIndirection == 2) // convert byte** to string[]
                    parameterVariations.Add(new CommandParameterInfo(parameterInfo.Name, new TypeInfo("string", arrayDimensions: 1), ParameterModifier.None));
            }

            // check if the parameter should be an array
            // note how the variations get set, not added. this is because having a pointer in place of an array is not necessary
            else if (parameterInfo.Name.EndsWith("Infos"))
                parameterVariations = new() { new CommandParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name, arrayDimensions: 1), ParameterModifier.None) };
            else if (commandInfo.DisplayName.StartsWith("Enumerate") && commandInfo.Parameters.Last() == parameterInfo)
                parameterVariations = new() { new CommandParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name, arrayDimensions: 1), ParameterModifier.InOut) };

            // check if parameter can have 'out' version
            else if ((commandInfo.DisplayName.StartsWith("Allocate") || commandInfo.DisplayName.StartsWith("Create") || commandInfo.DisplayName.StartsWith("Get")) && commandInfo.Parameters.Last() == parameterInfo)
                parameterVariations.Add(new CommandParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name), ParameterModifier.Out));

            // otherwise create a 'ref' version
            else
                parameterVariations.Add(new CommandParameterInfo(parameterInfo.Name, new TypeInfo(parameterInfo.Type.Name), ParameterModifier.Ref));

            return parameterVariations;
        }

        /// <summary>Generates all combinations of parameter variations.</summary>
        /// <param name="parameterVariations">The variations of each paramter of a command.</param>
        /// <returns>The combinations of parameter variations.</returns>
        private static List<List<CommandParameterInfo>> GetParameterCombinations(List<List<CommandParameterInfo>> parameterVariations)
        {
            var parameterCombinations = new List<List<CommandParameterInfo>>();
            var firstParameter = parameterVariations.First();
            var otherParameters = parameterVariations.Skip(1).ToList();

            // loop through each variations and recursively prepend that to the each combination of the other parameters
            foreach (var variation in firstParameter)
                if (otherParameters.Count == 0) // we're at the end of the paramter list, just add the variation
                    parameterCombinations.Add(new() { variation });
                else // recursively get the combination of other parameters
                {
                    var otherParameterVariations = GetParameterCombinations(otherParameters);
                    foreach (var otherParameterVariation in otherParameterVariations)
                    {
                        var combination = new List<CommandParameterInfo>() { variation };
                        combination.AddRange(otherParameterVariation);
                        parameterCombinations.Add(combination);
                    }
                }

            return parameterCombinations;
        }
    }
}
