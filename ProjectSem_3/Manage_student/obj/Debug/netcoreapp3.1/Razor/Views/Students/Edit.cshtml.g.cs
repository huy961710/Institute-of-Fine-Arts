#pragma checksum "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6e50281431ec261362e3e70ec82c95404975216"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Edit), @"mvc.1.0.view", @"/Views/Students/Edit.cshtml")]
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
#line 1 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\_ViewImports.cshtml"
using Manage_student;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\_ViewImports.cshtml"
using Manage_student.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e50281431ec261362e3e70ec82c95404975216", @"/Views/Students/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a76fe71309ad2fddb0e7316ebd32beb9cff2b40", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manage_student.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit Student</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
 using (Html.BeginForm("Edit", "Students", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <tr>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.LabelFor(s => s.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td colspan=\"1\">");
#nullable restore
#line 14 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
                       Write(Html.HiddenFor(s => s.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.LabelFor(s => s.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(s => s.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.ValidationMessageFor(s => s.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.LabelFor(s => s.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(s => s.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.ValidationMessageFor(s => s.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.LabelFor(s => s.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(s => s.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.ValidationMessageFor(s => s.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.LabelFor(s => s.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(s => s.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.ValidationMessageFor(s => s.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.LabelFor(s => s.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(s => s.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.ValidationMessageFor(s => s.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 42 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.LabelFor(s => s.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(s => s.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.ValidationMessageFor(s => s.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 47 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.LabelFor(s => s.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 48 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(s => s.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 49 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.ValidationMessageFor(s => s.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.LabelFor(s => s.JoinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(s=>s.JoinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>");
#nullable restore
#line 56 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.ValidationMessageFor(s=>s.JoinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 59 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.LabelFor(s => s.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 60 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.EditorFor(s => s.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 61 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.ValidationMessageFor(s => s.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>");
#nullable restore
#line 64 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
           Write(Html.LabelFor(s => s.ProfileImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td colspan=\"1\">\r\n                <input type=\"file\" name=\"file\" />\r\n            </td>\r\n        </tr>\r\n");
            WriteLiteral("        <tr>\r\n            <td><input type=\"submit\" value=\"Save\" class=\"btn-primary\" /></td>\r\n            <td colspan=\"1\">");
#nullable restore
#line 76 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
                       Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 79 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\ProjectSem_3\Manage_student\Views\Students\Edit.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manage_student.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
