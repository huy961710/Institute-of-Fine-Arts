#pragma checksum "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Exhibitions\ExhibitionPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef005920ebcfcd0591cfcd91d403ffd886887680"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exhibitions_ExhibitionPage), @"mvc.1.0.view", @"/Views/Exhibitions/ExhibitionPage.cshtml")]
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
#line 1 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\_ViewImports.cshtml"
using ProjectSem3_merged;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\_ViewImports.cshtml"
using ProjectSem3_merged.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef005920ebcfcd0591cfcd91d403ffd886887680", @"/Views/Exhibitions/ExhibitionPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335146926919375588e7d5296f3999d915c88bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Exhibitions_ExhibitionPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectSem3_merged.Models.CombineModels>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Exhibitions\ExhibitionPage.cshtml"
  
    ViewData["Title"] = "ExhibitionPage";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Exhibition Page</h2>\r\n<br />\r\n");
#nullable restore
#line 9 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Exhibitions\ExhibitionPage.cshtml"
 using (Html.BeginForm("ExhibitionPage", "Exhibitions", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>Select an Exhibition: </label>\r\n");
#nullable restore
#line 12 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Exhibitions\ExhibitionPage.cshtml"
Write(Html.DropDownList("ename", ViewBag.data as SelectList, "All"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Search\">\r\n");
#nullable restore
#line 14 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Exhibitions\ExhibitionPage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 16 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Exhibitions\ExhibitionPage.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"font-size:medium\" class=\"font-weight-bold border-dark\">\r\n        <div class=\"border\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 543, "\"", 573, 2);
            WriteAttributeValue("", 549, "../", 549, 3, true);
#nullable restore
#line 20 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Exhibitions\ExhibitionPage.cshtml"
WriteAttributeValue("", 552, item.Design.Painting, 552, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" height=\"200\" />\r\n        </div>\r\n        <div class=\"border\">");
#nullable restore
#line 22 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Exhibitions\ExhibitionPage.cshtml"
                       Write(item.Design.DesignName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"border\">Exhibition: ");
#nullable restore
#line 23 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Exhibitions\ExhibitionPage.cshtml"
                                   Write(item.Exhibition.ExhibitionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"border\">Painted by: ");
#nullable restore
#line 24 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Exhibitions\ExhibitionPage.cshtml"
                                   Write(item.Student.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;");
#nullable restore
#line 24 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Exhibitions\ExhibitionPage.cshtml"
                                                                Write(item.Student.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <br />\r\n");
#nullable restore
#line 27 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Exhibitions\ExhibitionPage.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectSem3_merged.Models.CombineModels>> Html { get; private set; }
    }
}
#pragma warning restore 1591
