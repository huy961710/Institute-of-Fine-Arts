#pragma checksum "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Postings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16f9b5047d2f2a0c942ca3f84b4150bafb51805f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Postings_Index), @"mvc.1.0.view", @"/Views/Postings/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16f9b5047d2f2a0c942ca3f84b4150bafb51805f", @"/Views/Postings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335146926919375588e7d5296f3999d915c88bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Postings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectSem3_merged.Models.CombineModels>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Postings\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>List of Postings</h2>

<table class=""table"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Post Date</th>
            <th>Post Description</th>
            <th>Mark</th>
            <th>Remark</th>
            <th>Design Name</th>
            <th>Competition Name</th>
            <th>Staff Name</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Postings\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Postings\Index.cshtml"
               Write(item.Posting.PostingId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Postings\Index.cshtml"
               Write(item.Posting.PostDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Postings\Index.cshtml"
               Write(item.Posting.PostDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Postings\Index.cshtml"
               Write(item.Posting.Mark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Postings\Index.cshtml"
               Write(item.Posting.Remark);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Postings\Index.cshtml"
               Write(item.Design.DesignName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Postings\Index.cshtml"
               Write(item.Competition.CompetitionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Postings\Index.cshtml"
               Write(item.Staff.StaffName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Postings\Index.cshtml"
               Write(Html.ActionLink("Update", "Edit", new { id = item.Posting.PostingId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 39 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Postings\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
