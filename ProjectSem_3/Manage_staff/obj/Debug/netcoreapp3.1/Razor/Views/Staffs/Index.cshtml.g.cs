#pragma checksum "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "925bdbe89195f567cc7b5c75d648aac752d44a39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staffs_Index), @"mvc.1.0.view", @"/Views/Staffs/Index.cshtml")]
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
#nullable restore
#line 2 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"925bdbe89195f567cc7b5c75d648aac752d44a39", @"/Views/Staffs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b535566b4a6bf6478a37d5999e67c3ceb1b13e66", @"/Views/_ViewImports.cshtml")]
    public class Views_Staffs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Manage_staff.Models.Staff>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3>Welcome, ");
#nullable restore
#line 9 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
            Write(Context.Session.GetString("ename"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n<br />\r\n");
#nullable restore
#line 12 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
Write(Html.ActionLink("Logout", "Logout", "Staffs"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h2>List of Staffs</h2>\r\n<br />\r\n<p>\r\n    ");
#nullable restore
#line 17 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
Write(Html.ActionLink("Create New Staff", "Create", "Staffs"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</p>
<br />
<table class=""table"">
    <tr>
        <th>StaffId</th>
        <th>StaffName</th>
        <th>JoinDate</th>
        <th>ProfileImage</th>
        <th>Email</th>
        <th>Phone</th>
        <th>Address</th>
        <th>Role</th>
        <th></th>
    </tr>
");
#nullable restore
#line 32 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 35 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
           Write(item.StaffId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
           Write(item.StaffName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
           Write(item.JoinDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 874, "\"", 898, 1);
#nullable restore
#line 39 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
WriteAttributeValue("", 880, item.ProfileImage, 880, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" />\r\n            </td>\r\n            <td>");
#nullable restore
#line 41 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
           Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 42 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
           Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 43 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 44 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
           Write(item.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
           Write(Html.ActionLink("Update", "Edit", new { id = item.StaffId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 47 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.StaffId }, new { onClick = "return confirm('Are you sure?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 50 "D:\FPT\ProjectSem_3\Manage_staff\Views\Staffs\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Manage_staff.Models.Staff>> Html { get; private set; }
    }
}
#pragma warning restore 1591
