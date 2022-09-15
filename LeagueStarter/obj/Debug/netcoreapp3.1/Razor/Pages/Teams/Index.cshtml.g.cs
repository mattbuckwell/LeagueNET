#pragma checksum "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2790cd268fe95483406af1e9ef37530b56f83f74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(League.Pages.Teams.Pages_Teams_Index), @"mvc.1.0.razor-page", @"/Pages/Teams/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/teams")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2790cd268fe95483406af1e9ef37530b56f83f74", @"/Pages/Teams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5e3ff45e0845b767ce2e91c14cb4035fde88f59", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Teams_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Team", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
  
    ViewData["Title"] = "NRL Teams";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"jumbotron p-2 d-flex justify-content-between\">\r\n    <h2 class=\"display-3\"><img src=\"/image/nfl/nfl.png\"> Teams 2019-2020</h2>\r\n</div>\r\n\r\n<section class=\"grid\">\r\n");
#nullable restore
#line 12 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
     foreach (Conference Conference in Model.Conferences)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4 class=\"p-2\">");
#nullable restore
#line 14 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
                   Write(Conference.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 16 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
         foreach (Division Division in Model.GetConferenceDivisions(Conference.ConferenceId))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h5 class=\"bg-primary p-1 text-white\">");
#nullable restore
#line 18 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
                                             Write(Division.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
#nullable restore
#line 20 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
             foreach (Team Team in Model.GetDivisonTeams(Division.DivisionId))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2790cd268fe95483406af1e9ef37530b56f83f745266", async() => {
                WriteLiteral("\r\n                    <div style=\"flex:0 0 25%\">");
#nullable restore
#line 23 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
                                         Write(Team.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    <div style=\"flex:0 0 25%\">");
#nullable restore
#line 24 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
                                         Write(Team.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    <div style=\"flex:0 0 5%\">");
#nullable restore
#line 25 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
                                        Write(Team.Win);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    <div style=\"flex:0 0 5%\">");
#nullable restore
#line 26 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
                                        Write(Team.Loss);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    <div style=\"flex:0 0 5%\">");
#nullable restore
#line 27 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
                                        Write(Team.Tie);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 22 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
AddHtmlAttributeValue("", 670, Team.TeamId == Model.FavouriteTeam ? "d-flex favorite p1" : "d-flex p1", 670, 74, false);

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
#line 22 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
                                                                                                                          WriteLiteral(Team.TeamId);

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
#line 29 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\mattb\projects\LeagueNET\LeagueStarter\Pages\Teams\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
