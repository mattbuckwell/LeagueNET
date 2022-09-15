#pragma checksum "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f4a7ac6174f53ba322d93f061cf99b89071df53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(League.Pages.Teams.Pages_Teams_Team), @"mvc.1.0.razor-page", @"/Pages/Teams/Team.cshtml")]
namespace League.Pages.Teams
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
#line 1 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\_ViewImports.cshtml"
using League;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\_ViewImports.cshtml"
using League.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/team/{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f4a7ac6174f53ba322d93f061cf99b89071df53", @"/Pages/Teams/Team.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e3ff45e0845b767ce2e91c14cb4035fde88f59", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Teams_Team : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Players/Player", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
  
    ViewData["Title"] = "NFL Team - " + Model.Team.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron p-2\">\r\n    <h1 class=\"display-4\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 174, "\"", 220, 3);
            WriteAttributeValue("", 180, "/image/nfl/logo/", 180, 16, true);
#nullable restore
#line 9 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
WriteAttributeValue("", 196, Model.Team.TeamId, 196, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 216, ".png", 216, 4, true);
            EndWriteAttribute();
            WriteLiteral("/>\r\n        ");
#nullable restore
#line 10 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
   Write(Model.Team.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 11 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
   Write(Model.Team.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n</div>\r\n\r\n<div class=\"d-flex justify-content-between pb-2\">\r\n    <div>\r\n        <div>\r\n            ");
#nullable restore
#line 18 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
       Write(Model.Team.Division.ConferenceId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                                           Write(Model.Team.DivisionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            Records: ");
#nullable restore
#line 21 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                Write(Model.Team.Win);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 21 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                                  Write(Model.Team.Loss);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 21 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                                                     Write(Model.Team.Tie);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <hr />\r\n        <div>\r\n            ");
#nullable restore
#line 25 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
       Write(Model.Team.Stadium);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Stadium\r\n        </div>\r\n        <div>\r\n            Capacity: ");
#nullable restore
#line 28 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                 Write(Model.Team.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <hr />\r\n        <div>\r\n            ");
#nullable restore
#line 32 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
       Write(Model.Team.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"pb-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
       Write(Model.Team.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                         Write(Model.Team.State);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 35 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                                            Write(Model.Team.Zip);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 938, "\"", 987, 3);
            WriteAttributeValue("", 944, "/image/nfl/stadium/", 944, 19, true);
#nullable restore
#line 37 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
WriteAttributeValue("", 963, Model.Team.TeamId, 963, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 983, ".jpg", 983, 4, true);
            EndWriteAttribute();
            WriteLiteral("/>\r\n    </div>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 1012, "\"", 1061, 3);
            WriteAttributeValue("", 1018, "/image/nfl/seating/", 1018, 19, true);
#nullable restore
#line 39 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
WriteAttributeValue("", 1037, Model.Team.TeamId, 1037, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1057, ".png", 1057, 4, true);
            EndWriteAttribute();
            WriteLiteral(@"/>
</div>

<section class=""grid container"">
    <div class=""d-flex bg-primary text-white"">
        <div class=""p-1"" style=""flex: 0 0 10%"">Number</div>
        <div class=""p-1"" style=""flex: 0 0 25%"">Name</div>
        <div class=""p-1"" style=""flex: 0 0 10%"">Position</div>
        <div class=""p-1"" style=""flex: 0 0 20%"">Experience</div>
        <div class=""p-1"" style=""flex: 0 0 25%"">College</div>
        <div class=""p-1"" style=""flex: 0 0 10%"">Depth</div>
    </div>

");
#nullable restore
#line 52 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
     foreach (Player Player in Model.Team.Players) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f4a7ac6174f53ba322d93f061cf99b89071df539605", async() => {
                WriteLiteral("\r\n            <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 54 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                                             Write(Player.Number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 25%\">");
#nullable restore
#line 55 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                                             Write(Player.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 56 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                                             Write(Player.Position);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 20%\">");
#nullable restore
#line 57 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                                             Write(Player.Experience);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 25%\">");
#nullable restore
#line 58 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                                             Write(Player.College);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n            <div class=\"p-1\" style=\"flex:0 0 10%\">");
#nullable restore
#line 59 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                                             Write(Player.Depth);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
AddHtmlAttributeValue("", 1614, Player.Depth == 1 ? "d-flex starter" : "d-flex", 1614, 50, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
                                                                                                   WriteLiteral(Player.PlayerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Team.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TeamModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TeamModel>)PageContext?.ViewData;
        public TeamModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
