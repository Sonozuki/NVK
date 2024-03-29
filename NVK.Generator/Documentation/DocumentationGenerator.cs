﻿//namespace NVK.Generator.Documentation;

///// <summary>Handles generating documentation code.</summary>
//internal static class DocumentationGenerator
//{
//    /*********
//    ** Constants
//    *********/
//    /// <summary>The url of the documentation to scrape.</summary>
//    private const string DocumentationUrl = "https://raw.githubusercontent.com/KhronosGroup/Vulkan-Web-Registry/main/specs/1.3-extensions/html/vkspec.html";


//    /*********
//    ** Fields
//    *********/
//    /// <summary>The html of the documentation page at <see cref="DocumentationUrl"/>.</summary>
//    private static readonly string DocumentationHtml;

//    /// <summary>The regular expression used to extract the div.listingblock s from the html, each object to be documentated has been defined in one.</summary>
//    private static readonly Regex ListingBlockRegex = new(@"<div id="".{0,50}"" class=""listingblock"">.*?</div>\s*?</div>", RegexOptions.Compiled);

//    /// <summary>The regular expression used to extract the div.ulist that is directly after some div.listingblock s from the html, each object that has parameters or fields has those documented in one.</summary>
//    private static readonly Regex UlistRegex = new(@"\s*<div class=""ulist"">.*?</div>", RegexOptions.Compiled);

//    /// <summary>The regular expression used to extract each parameter/field documentation from the div.ulist retrieved from <see cref="UlistRegex"/>.</summary>
//    private static readonly Regex UlistElementRegex = new("<p><code>.+?</code>.*?</p>", RegexOptions.Compiled);

//    /// <summary>The regular expression used to extract the name of the parameter/field from the individual element retrieved from <see cref="UlistElementRegex"/>.</summary>
//    private static readonly Regex UlistElementNameRegex = new("<code>.+?</code>", RegexOptions.Compiled);

//    /// <summary>The regular expression used to extract the div.paragraph that is directly after some div.ulist s from the html, the remarks documentation for an object is one.</summary>
//    private static readonly Regex ParagraphRegex = new(@"\s*<div class=""paragraph"">.*?</div>", RegexOptions.Compiled);

//    /// <summary>The parsed specification to write the extracted documentation to.</summary>
//    private static VulkanSpecification Specification;


//    /*********
//    ** Constructors
//    *********/
//#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

//    /// <summary>Initialises the class.</summary>
//    static DocumentationGenerator()
//    {
//        //var documentationHtmlTask = new HttpClient().GetStringAsync(DocumentationUrl);
//        //documentationHtmlTask.Wait();
//        //
//        //DocumentationHtml = documentationHtmlTask.Result.ReplaceLineEndings(" "); // remove line endings for regex
//        DocumentationHtml = File.ReadAllText("C:/Development/External/Vulkan-Web-Registry/specs/1.3-extensions/html/vkspec.html").ReplaceLineEndings(" ");
//    }

//#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.


//    /*********
//    ** Public Methods
//    *********/
//    /// <summary>Generates the documentation for a specification.</summary>
//    /// <param name="specification">The specification to generate documentation for.</param>
//    public static void Generate(VulkanSpecification specification)
//    {
//        // in the spec html, the layout for each element for documentation is:

//        // <div id="[name, e.g. VkOffset2D]" class="listingblock">
//        //     <div class="content">
//        //         // definition
//        //     </div>
//        // </div>
//        // <div class="ulist">
//        //     // documentation
//        // </div>
//        // <div class="paragraph">
//        //     // remarks
//        // </div>

//        // not every listingblock will have an accompanying ulist, in the case for delegates without parameters, for example

//        Specification = specification;

//        // calculate listing blocks and organise them for documentation extraction
//        var namedListingBlocks = GetNamedListingBlocks();

//        var delegateNamedListingBlocks = namedListingBlocks
//            .Where(namedListingBlock => specification.Delegates.Any(delegateInfo => delegateInfo.Name == namedListingBlock.Key))
//            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

//        SetDelegateDocumentation(delegateNamedListingBlocks);
//    }


//    /*********
//    ** Private Methods
//    *********/
//    /// <summary>Retrieves the div.listingblock and name pairs from <see cref="DocumentationHtml"/>.</summary>
//    /// <returns>The name and div.listingblock html of each element present in the html.</returns>
//    /// <remarks>Each element that is documented is wrapped is a div.listingblock.</remarks>
//    private static Dictionary<string, Match> GetNamedListingBlocks()
//    {
//        var listingBlocks = ListingBlockRegex.Matches(DocumentationHtml);

//        var namedListingBlocks = new Dictionary<string, Match>();
//        foreach (var listingBlock in listingBlocks.Cast<Match>())
//        {
//            var name = listingBlock.ValueSpan.Slice("\"", "\"");
//            namedListingBlocks[new(name)] = listingBlock;
//        }

//        return namedListingBlocks;
//    }

//    /// <summary>Retrieves and sets the delegate documentation in <see cref="Specification"/>.</summary>
//    /// <param name="delegateNamedListingBlocks">The delegate listing blocks containing the documentation.</param>
//    private static void SetDelegateDocumentation(Dictionary<string, Match> delegateNamedListingBlocks)
//    {
//        // get adjacent div.ulist, containing the parameter documentation
//        var ulistMatches = GetAdjacentUlistMatches(delegateNamedListingBlocks.Values);

//        for (int i = 0; i < delegateNamedListingBlocks.Count(); i++)
//        {
//            var namedListingBlock = delegateNamedListingBlocks.ElementAt(i);
//            var ulistMatch = ulistMatches.ElementAt(i);

//            var delegateInfo = Specification.Delegates.Single(delegateInfo => delegateInfo.Name == namedListingBlock.Key);

//            // get delegate remarks documentation, from div.paragraph that's adjacent to div.ulist
//            var paragraphMatch = GetAdjacentParagraphMatch(ulistMatch);
//            if (paragraphMatch != null)
//                delegateInfo.RemarksDocumentation = paragraphMatch.ValueSpan.Slice("<p>", "</p>").ToString();

//            // get delegate parameter documentation, from div.ulist that's adjacent to div.listingblock
//            var parameterDocumentations = GetDocumentationFromUlistMatch(ulistMatch);
//            foreach (var parameterDocumentation in parameterDocumentations)
//            {
//                var delegateParameterInfo = delegateInfo.Parameters.Single(delegateParameterInfo => delegateParameterInfo.Name == parameterDocumentation.Key);
//                delegateParameterInfo.SummaryDocumentation = parameterDocumentation.Value;
//            }

//            PrettifyDelegateDocumentation(delegateInfo);
//        }
//    }

//    /// <summary>Retrieves the div.ulist s for the corresponding div.listingblock s.</summary>
//    /// <param name="listingBlocks">The div.listingblock s to use to get the corresponding div.ulist s (if there is one).</param>
//    /// <returns>The div.ulist s for <paramref name="listingBlocks"/>.</returns>
//    private static List<Match?> GetAdjacentUlistMatches(IEnumerable<Match> listingBlocks)
//    {
//        var ulistMatches = new List<Match?>();
//        foreach (var listingBlock in listingBlocks)
//        {
//            // ensure the ulist is ajacent to the listingblock (as not all listingblocks have ulists)
//            var nextUlist = UlistRegex.Match(DocumentationHtml, listingBlock.Index);
//            ulistMatches.Add(nextUlist.Index == listingBlock.Index + listingBlock.Length ? nextUlist : null);
//        }

//        return ulistMatches;
//    }

//    /// <summary>Retrieves the div.paragraph for the corresponding div.ulist.</summary>
//    /// <param name="ulist">The div.ulist to use to get the corresponding div.paragraph (if there is one).</param>
//    /// <returns>The div.paragraph for <paramref name="ulist"/>.</returns>
//    private static Match? GetAdjacentParagraphMatch(Match? ulist)
//    {
//        if (ulist == null)
//            return null;

//        // ensure the paragraph is ajacent to the ulist (as not all ulists have paragraphs)
//        var nextParagraph = ParagraphRegex.Match(DocumentationHtml, ulist.Index + ulist.Length);
//        return nextParagraph.Index == ulist.Index + ulist.Length ? nextParagraph : null;
//    }

//    /// <summary>Retrieves the parameter/field documentation from a div.ulist.</summary>
//    /// <param name="ulistMatch">The div.ulist to get the documentation from.</param>
//    /// <returns>The documentation keyed on the parameter.field names.</returns>
//    private static Dictionary<string, string> GetDocumentationFromUlistMatch(Match? ulistMatch)
//    {
//        if (ulistMatch == null)
//            return new();

//        // in the spec html, the layout for each ulist element is:

//        // <div class="ulist">
//        //     <ul>
//        //         <li>
//        //             <p>
//        //                 <code>[name]</code> documentation
//        //             </p>
//        //         </li>
//        //         [..]
//        //     </ul>
//        // </div>

//        var documentationStrings = new Dictionary<string, string>();

//        var documentationMatch = UlistElementRegex.Matches(ulistMatch.Value);
//        foreach (var element in documentationMatch.Cast<Match>())
//        {
//            var nameMatch = UlistElementNameRegex.Match(element.Value);
//            var name = nameMatch.ValueSpan.Slice("<code>", "</code>").ToString();
//            var value = element.ValueSpan.Slice("</code>", "</p>").ToString();

//            documentationStrings[name] = value;
//        }

//        return documentationStrings;
//    }

//    /// <summary>Prettifies a delegate's documentation.</summary>
//    /// <param name="delegateInfo">The delegate whose documentation to prettify.</param>
//    private static void PrettifyDelegateDocumentation(DelegateInfo delegateInfo)
//    {
//        foreach (var parameter in delegateInfo.Parameters)
//        {
//            if (parameter.SummaryDocumentation == null)
//                continue;

//            var summaryDocumentation = parameter.SummaryDocumentation;

//            summaryDocumentation = ReplaceParameterReferences(summaryDocumentation);
//            summaryDocumentation = ReplaceEdgecaseReferences(summaryDocumentation);
//            summaryDocumentation = PrettifyDocumentation(summaryDocumentation);

//            parameter.SummaryDocumentation = summaryDocumentation;
//        }

//        if (delegateInfo.RemarksDocumentation != null)
//        {
//            var remarksDocumentation = delegateInfo.RemarksDocumentation;

//            remarksDocumentation = ReplaceParameterReferences(remarksDocumentation);
//            remarksDocumentation = ReplaceEdgecaseReferences(remarksDocumentation);
//            remarksDocumentation = PrettifyDocumentation(remarksDocumentation);

//            delegateInfo.RemarksDocumentation = remarksDocumentation;
//        }

//        // Replaces all edge case parameter references which refer to VkAllocationCallbacks fields
//        string ReplaceEdgecaseReferences(string documentation) =>
//            documentation
//                .Replace("<code>pfnReallocation</code>", "<see cref=\"VkAllocationCallbacks.Reallocation\"/>")
//                .Replace("<code>pfnAllocation</code>", "<see cref=\"VkAllocationCallbacks.Allocation\"/>");

//        // Replaces all <code>paramName</code> references with <paramref name="paramName"/>
//        string ReplaceParameterReferences(string documentation)
//        {
//            var matches = Regex.Matches(documentation, "(?<!::)<code>.*?</code>").ToList(); // look behind is to not convert parameters of a non parameter reference (name::secondName)
//            for (int i = matches.Count - 1; i >= 0; i--)
//            {
//                var match = matches[i];

//                var parameterName = match.Value[6..^7];
//                var parameter = delegateInfo.Parameters.FirstOrDefault(parameterInfo => parameterInfo.Name == parameterName);
//                if (parameter == null)
//                    continue;

//                // paramrefs can't include the '@' if a parameter starts with it
//                parameterName = parameter.DisplayName;
//                if (parameterName.StartsWith('@'))
//                    parameterName = parameterName[1..];

//                documentation = documentation.Replace(match.Index, match.Value.Length, $"<paramref name=\"{parameterName}\"/>");
//            }

//            return documentation;
//        }
//    }

//    /// <summary>Performs generic documentation prettifying.</summary>
//    /// <param name="documentation">The documentation string to prettify.</param>
//    /// <returns>A pretty version of <paramref name="documentation"/>.</returns>
//    /// <remarks>This won't affect context specific documentation such as paramrefs etc.</remarks>
//    private static string PrettifyDocumentation(string documentation)
//    {
//        documentation = documentation.Trim();

//        if (documentation.StartsWith("is "))
//            documentation = documentation[3..];

//        // remove "as describer here"
//        var asDescribedHereMatch = Regex.Match(documentation, ", as described <a href=\".*?\">here</a>.");
//        if (asDescribedHereMatch.Success)
//            documentation = documentation.Replace(asDescribedHereMatch.Value, ".");

//        // convert references to crefs, the documentation layouts for references are:
//        // <a href="[..]">name</a>
//        // <a href="[..]">name</a>::<code>secondaryName</code>
//        // <code>name</code>
//        var referenceMatches = Regex.Matches(documentation, "<a href=\".*?\">.*?</a>(?:::<code>.*?</code>)?").ToList();
//        for (int i = referenceMatches.Count - 1; i >= 0; i--)
//        {
//            var referenceMatch = referenceMatches[i];

//            var name = referenceMatch.ValueSpan.Slice("\">", "</a>").ToString();
//            var secondaryName = referenceMatch.Value.Contains("::") ? referenceMatch.ValueSpan.Slice("<code>", "</code>").ToString() : null;

//            TryCalculateReferenceDisplayName(name, secondaryName, out var displayName);

//            documentation = documentation.Replace(referenceMatch.Index, referenceMatch.Length, $"<see cref=\"{displayName}\"/>");
//        }

//        var codeReferenceMatches = Regex.Matches(documentation, "<code>.*?</code>");
//        for (int i = codeReferenceMatches.Count - 1; i >= 0; i--)
//        {
//            var codeReferenceMatch = codeReferenceMatches[i];

//            var name = codeReferenceMatch.ValueSpan.Slice("<code>", "</code>").ToString();
//            if (!TryCalculateReferenceDisplayName(name, null, out var displayName))
//                continue;

//            documentation = documentation.Replace(codeReferenceMatch.Index, codeReferenceMatch.Length, $"<see cref=\"{displayName}\"/>");
//        }

//        // convert <span class="eq">[..]</span> to <c>[..]</c>
//        var inlineCodeMatches = Regex.Matches(documentation, "<span class=\"eq\">.*?</span>");
//        for (int i = inlineCodeMatches.Count - 1; i >= 0; i--)
//        {
//            var inlineCodeMatch = inlineCodeMatches[i];

//            var name = inlineCodeMatch.ValueSpan.Slice("\">", "</span>").ToString();
//            documentation = documentation.Replace(inlineCodeMatch.Index, inlineCodeMatch.Length, $"<c>{name}</c>");
//        }

//        // capitalise first character, if the first character is a '<' (meaning a tag is at the beginning) then the content should be capitalised
//        if (documentation[0] != '<')
//            documentation = documentation.FirstToUpper();
//        else
//            documentation = documentation.CharToUpper(documentation.IndexOf('>') + 1);

//        return documentation
//            .Replace("<strong class=\"purple\">", "<strong>")
//            .Replace("null", "<see langword=\"null\"/>")
//            .Replace("<code>NULL</code>", "<see langword=\"null\"/>");
//    }

//    /// <summary>Calculates the display name for a reference.</summary>
//    /// <param name="name">The name of the reference (e.g. struct name).</param>
//    /// <param name="secondaryName">The secondary name of the reference (e.g. field name).</param>
//    /// <returns><see langword="true"/>, if a reference could be determined; otherwise, <see langword="false"/>.</returns>
//    /// <remarks>If <see langword="false"/> is returned, <paramref name="displayName"/> will be "TODO: error(<paramref name="name"/>.<paramref name="secondaryName"/>)".</remarks>
//    private static bool TryCalculateReferenceDisplayName(string name, string? secondaryName, out string displayName)
//    {
//        displayName = "";

//        name = Specification.TypeConverter.GetConvertedType(name);

//        // constants
//        var constantInfo = Specification.Constants.FirstOrDefault(constantInfo => constantInfo.Name == name);
//        if (constantInfo != null)
//            displayName = $"VK.{constantInfo.DisplayName}";

//        // commands
//        var commandInfo = Specification.Commands.FirstOrDefault(commandInfo => commandInfo.Name == name);
//        if (commandInfo != null)
//            displayName = $"VK.{commandInfo.DisplayName}";

//        // structures
//        var structureInfo = Specification.Structures.FirstOrDefault(structureInfo => structureInfo.Name == name);
//        if (structureInfo != null)
//        {
//            displayName = structureInfo.DisplayName;

//            if (secondaryName != null)
//            {
//                var fieldInfo = structureInfo.Fields.Single(fieldInfo => fieldInfo.Name == secondaryName);
//                displayName += $".{fieldInfo.DisplayName}";
//            }
//        }

//        // enums
//        var enumInfo = Specification.Enums.FirstOrDefault(enumInfo => enumInfo.Name == name);
//        if (enumInfo != null)
//        {
//            displayName = enumInfo.DisplayName;

//            if (secondaryName != null)
//            {
//                var enumFieldInfo = enumInfo.Values.Single(enumFieldInfo => enumFieldInfo.Name == secondaryName);
//                displayName += $".{enumFieldInfo.DisplayName}";
//            }
//        }

//        // enum values
//        enumInfo = Specification.Enums.FirstOrDefault(enumInfo => enumInfo.Values.Any(enumFieldInfo => enumFieldInfo.Name == name));
//        if (enumInfo != null)
//        {
//            var enumFieldInfo = enumInfo.Values.Single(enumFieldInfo => enumFieldInfo.Name == name);
//            displayName = $"{enumInfo.DisplayName}.{enumFieldInfo.DisplayName}";
//        }

//        // handles
//        var handleInfo = Specification.Handles.FirstOrDefault(handleInfo => handleInfo.Name == name);
//        if (handleInfo != null)
//            displayName = handleInfo.Name;

//        // predefined base types (VkBool, etc)
//        if (Specification.TypeConverter.DefinedBaseTypes.Contains(name))
//            displayName = name;

//        var referenceFound = displayName != "";
//        if (!referenceFound)
//            displayName = "TODO: error({name}.{secondaryName})";

//        return referenceFound;
//    }
//}
