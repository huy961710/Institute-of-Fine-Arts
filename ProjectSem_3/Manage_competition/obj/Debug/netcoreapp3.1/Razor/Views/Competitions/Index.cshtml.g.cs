#pragma checksum "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_competition\Views\Competitions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8e8d84a9d16bc7f500975b49563973e29282d42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Competitions_Index), @"mvc.1.0.view", @"/Views/Competitions/Index.cshtml")]
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
#line 1 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_competition\Views\_ViewImports.cshtml"
using Manage_competition;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_competition\Views\_ViewImports.cshtml"
using Manage_competition.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8e8d84a9d16bc7f500975b49563973e29282d42", @"/Views/Competitions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b932e2f12448fba9fcdc5b30bc4f52f1cf7a0e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Competitions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Manage_competition.Models.StaffCompetition>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_competition\Views\Competitions\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>List of Competitions</h2>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8e8d84a9d16bc7f500975b49563973e29282d423997", async() => {
                WriteLiteral("Create New Competition");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>CompetitionName</th>
            <th>StartDate</th>
            <th>EndDate</th>
            <th>StaffName</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_competition\Views\Competitions\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_competition\Views\Competitions\Index.cshtml"
               Write(item.Competition.CompetitionId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_competition\Views\Competitions\Index.cshtml"
               Write(item.Competition.CompetitionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_competition\Views\Competitions\Index.cshtml"
               Write(item.Competition.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_competition\Views\Competitions\Index.cshtml"
               Write(item.Competition.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_competition\Views\Competitions\Index.cshtml"
               Write(item.Staff.StaffName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_competition\Views\Competitions\Index.cshtml"
               Write(Html.ActionLink("Update", "Edit", new { id = item.Competition.CompetitionId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 34 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_competition\Views\Competitions\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Competition.CompetitionId }, new { onClick = "return confirm('Are you sure?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 37 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_competition\Views\Competitions\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Manage_competition.Models.StaffCompetition>> Html { get; private set; }
    }
}
#pragma warning restore 1591
