#pragma checksum "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c518fe8d09b7a5d3c52b84fc2acde4a9afe24be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staffs_Create), @"mvc.1.0.view", @"/Views/Staffs/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c518fe8d09b7a5d3c52b84fc2acde4a9afe24be", @"/Views/Staffs/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335146926919375588e7d5296f3999d915c88bd0", @"/Views/_ViewImports.cshtml")]
    public class Views_Staffs_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectSem3_merged.Models.Staff>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create new Staff</h2>\r\n");
#nullable restore
#line 7 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
 using (Html.BeginForm("Create", "Staffs", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <div>\r\n            ");
#nullable restore
#line 11 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.LabelFor(model => model.StaffId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 12 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.EditorFor(model => model.StaffId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 13 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.StaffId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 17 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.LabelFor(model => model.StaffName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.EditorFor(model => model.StaffName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.StaffName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 23 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.LabelFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 24 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.EditorFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 29 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.LabelFor(model => model.JoinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 30 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.EditorFor(model => model.JoinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 31 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.JoinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 35 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.LabelFor(model => model.ProfileImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"file\" name=\"file\" />\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 40 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.LabelFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 41 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.EditorFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 42 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 46 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.LabelFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 47 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.EditorFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 48 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 52 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.LabelFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 53 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.EditorFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 54 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            ");
#nullable restore
#line 58 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.LabelFor(model => model.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"number\" min=\"0\" max=\"2\" />\r\n            ");
#nullable restore
#line 60 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
       Write(Html.ValidationMessageFor(model => model.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div>\r\n            <input type=\"submit\" value=\"Create\" class=\"btn-primary\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 67 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3>");
#nullable restore
#line 70 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
   Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n\r\n<div>\r\n    ");
#nullable restore
#line 74 "D:\FPT\Sem3_merged_DucHuy\ProjectSem3_merged\ProjectSem3_merged\Views\Staffs\Create.cshtml"
Write(Html.ActionLink("Back to list ", "Index", "Staffs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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