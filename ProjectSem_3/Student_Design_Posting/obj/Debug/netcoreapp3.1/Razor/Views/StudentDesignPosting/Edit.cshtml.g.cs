#pragma checksum "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a05740d2ad11bf7bd8408838f1067374ce354727"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentDesignPosting_Edit), @"mvc.1.0.view", @"/Views/StudentDesignPosting/Edit.cshtml")]
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
#line 1 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\_ViewImports.cshtml"
using Student_Design_Posting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\_ViewImports.cshtml"
using Student_Design_Posting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05740d2ad11bf7bd8408838f1067374ce354727", @"/Views/StudentDesignPosting/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"946c30a321388572f5cf6f62c8ad4dddf301db58", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentDesignPosting_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Student_Design_Posting.Models.Design>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit Design</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
 using (Html.BeginForm("Edit", "StudentDesignPosting", FormMethod.Post, new { enctype = "multipart/form-data" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        <div>\r\n            ");
#nullable restore
#line 13 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
       Write(Html.HiddenFor(d => d.DesignId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 16 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
       Write(Html.LabelFor(d => d.DesignName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 17 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
       Write(Html.EditorFor(d => d.DesignName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 18 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
       Write(Html.ValidationMessageFor(d => d.DesignName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 21 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
       Write(Html.LabelFor(d => d.Painting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 22 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
       Write(Html.HiddenFor(d => d.Painting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 23 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
       Write(Html.ValidationMessageFor(d => d.Painting));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 763, "\"", 803, 2);
            WriteAttributeValue("", 769, "../", 769, 3, true);
#nullable restore
#line 24 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
WriteAttributeValue("", 772, Html.DisplayFor(d=>d.Painting), 772, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\"");
            BeginWriteAttribute("alt", " alt=\"", 829, "\"", 866, 1);
#nullable restore
#line 24 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
WriteAttributeValue("", 835, Html.DisplayFor(d=>d.DesignId), 835, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <div>\r\n                <input type=\"file\" name=\"file\" />\r\n            </div>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 30 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
       Write(Html.LabelFor(d => d.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 31 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
       Write(Html.EditorFor(d => d.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 32 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
       Write(Html.ValidationMessageFor(d => d.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 35 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
       Write(Html.HiddenFor(d=>d.SubmitDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 38 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
       Write(Html.HiddenFor(d => d.StudentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <input type=\"submit\" value=\"Update\" class=\"btn-primary\" onclick=\"return confirm(\'Are you sure?\')\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 44 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h3>");
#nullable restore
#line 46 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
   Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 49 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Student_Design_Posting\Views\StudentDesignPosting\Edit.cshtml"
Write(Html.ActionLink("Back to list ", "Index", "StudentDesignPosting"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Student_Design_Posting.Models.Design> Html { get; private set; }
    }
}
#pragma warning restore 1591
