#pragma checksum "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c47bdc19736d2043fa4fe7a8c923d260f28a3a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c47bdc19736d2043fa4fe7a8c923d260f28a3a5", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335146926919375588e7d5296f3999d915c88bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectSem3_merged.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>List of Students</h2>\r\n<br />\r\n");
#nullable restore
#line 9 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"font-size:medium\" class=\"font-weight-bold border-dark\">\r\n        <div class=\"border\"><img");
            BeginWriteAttribute("src", " src=\"", 273, "\"", 297, 1);
#nullable restore
#line 12 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml"
WriteAttributeValue("", 279, item.ProfileImage, 279, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\" /></div>\r\n        <div class=\"border\">");
#nullable restore
#line 13 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml"
                       Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;");
#nullable restore
#line 13 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml"
                                            Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"border\">Student Id: ");
#nullable restore
#line 14 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml"
                                   Write(item.StudentId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"border\">");
#nullable restore
#line 15 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml"
                       Write(item.DateOfBirth.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"border\">");
#nullable restore
#line 16 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml"
                       Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"border\">");
#nullable restore
#line 17 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml"
                       Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"border\">");
#nullable restore
#line 18 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"border\">");
#nullable restore
#line 19 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml"
                       Write(item.JoinDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"border\">");
#nullable restore
#line 20 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml"
                       Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n");
#nullable restore
#line 24 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Students\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectSem3_merged.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
