#pragma checksum "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Forward.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a8e3e6c3ab3ca082d7ad1bf3002265a1dd48f74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Designs_Forward), @"mvc.1.0.view", @"/Views/Designs/Forward.cshtml")]
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
#line 1 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\_ViewImports.cshtml"
using Manage_design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\_ViewImports.cshtml"
using Manage_design.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a8e3e6c3ab3ca082d7ad1bf3002265a1dd48f74", @"/Views/Designs/Forward.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a950e7de1e9e65745a95abf21fbc8438b3f4ab78", @"/Views/_ViewImports.cshtml")]
    public class Views_Designs_Forward : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Manage_design.Models.Display>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Forward.cshtml"
  
    ViewData["Title"] = "Forward";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Forward</h1>\r\n");
#nullable restore
#line 7 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Forward.cshtml"
 using (Html.BeginForm("Forward", "Designs", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <div>\r\n        ");
#nullable restore
#line 11 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Forward.cshtml"
   Write(Html.LabelFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 12 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Forward.cshtml"
   Write(Html.EditorFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Forward.cshtml"
   Write(Html.ValidationMessageFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        ");
#nullable restore
#line 16 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Forward.cshtml"
   Write(Html.LabelFor(model => model.ExhibitionID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Forward.cshtml"
   Write(Html.EditorFor(model => model.ExhibitionID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 18 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Forward.cshtml"
   Write(Html.ValidationMessageFor(model => model.ExhibitionID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <input type=\"submit\" value=\"Create\" class=\"btn-primary\" />\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 24 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Forward.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 26 "C:\Users\Phat Developer King\Desktop\clone\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Forward.cshtml"
Write(ViewBag.Msg);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Manage_design.Models.Display> Html { get; private set; }
    }
}
#pragma warning restore 1591