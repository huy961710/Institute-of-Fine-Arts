#pragma checksum "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50ccd6e3f296aed5c51e703b50589d2fbeefc7a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staffs_Login), @"mvc.1.0.view", @"/Views/Staffs/Login.cshtml")]
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
#line 1 "D:\FPT\ProjectSem_3\Manage_staff\Views\_ViewImports.cshtml"
using Manage_staff;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FPT\ProjectSem_3\Manage_staff\Views\_ViewImports.cshtml"
using Manage_staff.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ccd6e3f296aed5c51e703b50589d2fbeefc7a7", @"/Views/Staffs/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b535566b4a6bf6478a37d5999e67c3ceb1b13e66", @"/Views/_ViewImports.cshtml")]
    public class Views_Staffs_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manage_staff.Models.Staff>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Login Page</h2>\r\n\r\n");
#nullable restore
#line 8 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Login.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <div>\r\n            <input type=\"text\" name=\"accName\" placeholder=\"Enter Username\" />\r\n            ");
#nullable restore
#line 13 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Login.cshtml"
       Write(Html.ValidationMessageFor(model => model.StaffId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            <input type=\"password\" name=\"accPass\" placeholder=\"Enter Pasword\" />\r\n            ");
#nullable restore
#line 18 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Login.cshtml"
       Write(Html.ValidationMessageFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <div>\r\n            <input type=\"submit\" value=\"Sign In\" class=\"btn-success\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 25 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Login.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3 style=\"color:red\">");
#nullable restore
#line 28 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Login.cshtml"
                     Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manage_staff.Models.Staff> Html { get; private set; }
    }
}
#pragma warning restore 1591
