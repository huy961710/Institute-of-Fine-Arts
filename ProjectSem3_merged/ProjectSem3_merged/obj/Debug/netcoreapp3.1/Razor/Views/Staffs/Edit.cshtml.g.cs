#pragma checksum "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d23da20e027a6e18dbea3a8b14849ad40a1a1ef8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staffs_Edit), @"mvc.1.0.view", @"/Views/Staffs/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d23da20e027a6e18dbea3a8b14849ad40a1a1ef8", @"/Views/Staffs/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335146926919375588e7d5296f3999d915c88bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Staffs_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectSem3_merged.Models.Staff>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit Staff</h2>\r\n<br />\r\n");
#nullable restore
#line 9 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
 using (Html.BeginForm("Edit", "Staffs", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 12 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.HiddenFor(model => model.StaffId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 16 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.HiddenFor(model => model.StaffName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 20 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 24 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.HiddenFor(model => model.JoinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 28 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.LabelFor(model => model.ProfileImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <input type=\"file\" name=\"file\" />\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 33 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 34 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.EditorFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 35 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 39 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.LabelFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 40 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.EditorFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 41 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 45 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.LabelFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 46 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.EditorFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 47 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.ValidationMessageFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
#nullable restore
#line 51 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(Html.HiddenFor(model => model.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <div>\r\n        <input type=\"submit\" value=\"Update\" class=\"btn-warning\" />\r\n    </div>\r\n");
#nullable restore
#line 57 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3>");
#nullable restore
#line 60 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
   Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 64 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Edit.cshtml"
Write(Html.ActionLink("Back to list ", "Index", "Staffs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectSem3_merged.Models.Staff> Html { get; private set; }
    }
}
#pragma warning restore 1591