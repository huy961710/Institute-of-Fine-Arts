#pragma checksum "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acf8a281370399a9fa5b3d4d5ae248598e79c506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Designs_Index), @"mvc.1.0.view", @"/Views/Designs/Index.cshtml")]
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
#line 1 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\_ViewImports.cshtml"
using Manage_design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\_ViewImports.cshtml"
using Manage_design.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acf8a281370399a9fa5b3d4d5ae248598e79c506", @"/Views/Designs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a950e7de1e9e65745a95abf21fbc8438b3f4ab78", @"/Views/_ViewImports.cshtml")]
    public class Views_Designs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Manage_design.Models.DesignStudent>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Best", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "better", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "good", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "moderate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "normal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "disqualified", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h3>Welcome, ");
#nullable restore
#line 8 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
            Write(Context.Session.GetString("staffname"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n</div>\r\n<br />\r\n");
#nullable restore
#line 11 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
Write(Html.ActionLink("Logout", "Logout", "Students"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h1>List of Design</h1>\r\n<br />\r\n");
#nullable restore
#line 15 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <div><input type=\"text\" name=\"dname\" placeholder=\"Enter a Design Name\" /></div>\r\n        <input type=\"submit\" name=\"Search\" class=\"btn-primary\" />\r\n        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf8a281370399a9fa5b3d4d5ae248598e79c5067459", async() => {
                WriteLiteral("\r\n                <label for=\"Marks\">Fillter by Mark:</label>\r\n                <select name=\"Marks\" id=\"Marks\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf8a281370399a9fa5b3d4d5ae248598e79c5067858", async() => {
                    WriteLiteral("best");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf8a281370399a9fa5b3d4d5ae248598e79c5069099", async() => {
                    WriteLiteral("better");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf8a281370399a9fa5b3d4d5ae248598e79c50610342", async() => {
                    WriteLiteral("good");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf8a281370399a9fa5b3d4d5ae248598e79c50611584", async() => {
                    WriteLiteral("moderate");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf8a281370399a9fa5b3d4d5ae248598e79c50612830", async() => {
                    WriteLiteral("normal");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acf8a281370399a9fa5b3d4d5ae248598e79c50614074", async() => {
                    WriteLiteral("disqualified");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n                <br><br>\r\n                <input type=\"submit\" value=\"Submit\">\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n<div style=\"overflow-x:auto\">\r\n    <table class=\"table table-striped\">\r\n        <tr>\r\n            <th>");
#nullable restore
#line 41 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Design.DesignId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 42 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Design.DesignName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 43 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Design.Painting));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 44 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Design.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 45 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Design.SubmitDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>Fullname</th>\r\n            <th>Mark</th>\r\n            <th></th>\r\n        </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
               Write(Html.DisplayFor(m => item.Design.DesignId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
               Write(Html.DisplayFor(m => item.Design.DesignName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><img");
            BeginWriteAttribute("src", " src=\"", 2011, "\"", 2038, 1);
#nullable restore
#line 55 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
WriteAttributeValue("", 2017, item.Design.Painting, 2017, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\"");
            BeginWriteAttribute("alt", " alt=\"", 2064, "\"", 2091, 1);
#nullable restore
#line 55 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
WriteAttributeValue("", 2070, item.Design.DesignId, 2070, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
               Write(Html.DisplayFor(m => item.Design.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 57 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
               Write(Html.DisplayFor(m => item.Design.SubmitDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 59 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
                      
                        var FullName = item.Student.FirstName + " " + item.Student.LastName;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
                   Write(Html.DisplayFor(m => FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>Best</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
               Write(Html.ActionLink("Forward to Exhibition", "Forward", new { id = item.Design.DesignId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 69 "C:\Users\Phat Developer King\Desktop\Institute-of-Fine-Arts\Institute-of-Fine-Arts\ProjectSem_3\Manage_design\Views\Designs\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Manage_design.Models.DesignStudent>> Html { get; private set; }
    }
}
#pragma warning restore 1591