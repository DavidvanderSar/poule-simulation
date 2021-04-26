#pragma checksum "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4a169fda448f261a987ea3da7c2e5c51dbeb1f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PouleSetUp_TestPoule), @"mvc.1.0.view", @"/Views/PouleSetUp/TestPoule.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\_ViewImports.cshtml"
using PouleSim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\_ViewImports.cshtml"
using PouleSim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4a169fda448f261a987ea3da7c2e5c51dbeb1f5", @"/Views/PouleSetUp/TestPoule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ae7a493f68b7cbbaff96f10cf608a136ab4633c", @"/Views/_ViewImports.cshtml")]
    public class Views_PouleSetUp_TestPoule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
  
    ViewData["Title"] = "Simulated Poule result";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Poule Result</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>Club name (level)</th>
            <th>Matches Played</th>
            <th>Games won</th>
            <th>Games Drawn</th>
            <th>Games Lost</th>
            <th>Goals For</th>
            <th>Goals Against </th>
            <th>Goals Aggregate </th>
            <th>Points</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
         for (int i = 0; i < (int)@ViewData["ClubCount"]; i++)
        {
            var pouleScoreRow = ViewData[$"PouleScoreRow{i}"] as PouleSim.Models.PouleScoreRow;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 27 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
                Write(pouleScoreRow.Club.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 27 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
                                          Write(pouleScoreRow.Club.Powerlevel);

#line default
#line hidden
#nullable disable
            WriteLiteral(") </td>\r\n                <td> ");
#nullable restore
#line 28 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
                Write(pouleScoreRow.MatchesPlayed);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 29 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
                Write(pouleScoreRow.GamesWon);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 30 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
                Write(pouleScoreRow.GamesDrawn);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 31 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
                Write(pouleScoreRow.GamesLost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 32 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
                Write(pouleScoreRow.GoalsFor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 33 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
                Write(pouleScoreRow.GoalsAgainst);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 34 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
                Write(pouleScoreRow.GoalsAggregate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td><b>");
#nullable restore
#line 35 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
                  Write(pouleScoreRow.Points);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<h2>Matches Played</h2>\r\n\r\n<ul>\r\n");
#nullable restore
#line 44 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
     for (int i = 0; i < (int)ViewData["MatchCount"]; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 46 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
       Write(ViewData[$"Match{i}"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 47 "C:\Users\david\Documents\Code\private\sollicitatieopdrachten\poule-simulatie-solution\Poulesim\Views\PouleSetUp\TestPoule.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
