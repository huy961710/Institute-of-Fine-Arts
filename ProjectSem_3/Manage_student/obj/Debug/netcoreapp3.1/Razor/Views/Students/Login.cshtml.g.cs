#pragma checksum "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f202f9da2fea139615d8ca603e96296f3d0935"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Login), @"mvc.1.0.view", @"/Views/Students/Login.cshtml")]
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
#line 1 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\_ViewImports.cshtml"
using Manage_student;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\_ViewImports.cshtml"
using Manage_student.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8f202f9da2fea139615d8ca603e96296f3d0935", @"/Views/Students/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a76fe71309ad2fddb0e7316ebd32beb9cff2b40", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manage_student.Models.StaffLogin>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Staff Login</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Login.cshtml"
 using (Html.BeginForm("Login", "Students", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Login.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Login.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Login.cshtml"
           Write(Html.LabelFor(s => s.StaffId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Login.cshtml"
           Write(Html.EditorFor(s => s.StaffId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 15 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Login.cshtml"
           Write(Html.ValidationMessageFor(s => s.StaffId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Login.cshtml"
           Write(Html.LabelFor(s => s.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Login.cshtml"
           Write(Html.EditorFor(s => s.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Login.cshtml"
           Write(Html.ValidationMessageFor(s => s.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><input type=\"submit\" value=\"Login\" class=\"btn-success\" /></td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Login.cshtml"
           Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td></td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 28 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Login.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manage_student.Models.StaffLogin> Html { get; private set; }
    }
}
#pragma warning restore 1591