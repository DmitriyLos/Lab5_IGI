#pragma checksum "F:\Education\3 курс\2 сем\ИГИ\lab5\lab5\Views\Owner\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8319cfbc1cea3a30878381a42628876dcf55fad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owner_Index), @"mvc.1.0.view", @"/Views/Owner/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Owner/Index.cshtml", typeof(AspNetCore.Views_Owner_Index))]
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
#line 1 "F:\Education\3 курс\2 сем\ИГИ\lab5\lab5\Views\_ViewImports.cshtml"
using lab5;

#line default
#line hidden
#line 2 "F:\Education\3 курс\2 сем\ИГИ\lab5\lab5\Views\_ViewImports.cshtml"
using lab5.Models;

#line default
#line hidden
#line 1 "F:\Education\3 курс\2 сем\ИГИ\lab5\lab5\Views\Owner\Index.cshtml"
using lab5.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8319cfbc1cea3a30878381a42628876dcf55fad", @"/Views/Owner/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03e3f5c0494a08bb020928239a815887d5c419a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Owner_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OwnersViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Owner", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\Education\3 курс\2 сем\ИГИ\lab5\lab5\Views\Owner\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(89, 40, true);
            WriteLiteral("\r\n<div>\r\n    <div class=\"data-search\">\r\n");
            EndContext();
#line 9 "F:\Education\3 курс\2 сем\ИГИ\lab5\lab5\Views\Owner\Index.cshtml"
         using (Html.BeginForm("Index", "Owner", FormMethod.Post))
        {

#line default
#line hidden
            BeginContext(208, 37, true);
            WriteLiteral("        <fieldset>\r\n            ФИО: ");
            EndContext();
            BeginContext(246, 55, false);
#line 12 "F:\Education\3 курс\2 сем\ИГИ\lab5\lab5\Views\Owner\Index.cshtml"
            Write(Html.TextBox("FioOwner", Model.OwnerViewModel.FioOwner));

#line default
#line hidden
            EndContext();
            BeginContext(301, 74, true);
            WriteLiteral("\r\n            <input type=\"submit\" value=\"Найти\" />\r\n        </fieldset>\r\n");
            EndContext();
#line 15 "F:\Education\3 курс\2 сем\ИГИ\lab5\lab5\Views\Owner\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(386, 111, true);
            WriteLiteral("    </div>\r\n    <div>\r\n        Информация о владельцах\r\n        <table>\r\n            <tr>\r\n                <td>");
            EndContext();
            BeginContext(497, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18de7ac673ad4079995890c82da10ed6", async() => {
                BeginContext(586, 43, true);
                WriteLiteral("\r\n                    ФИО\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "F:\Education\3 курс\2 сем\ИГИ\lab5\lab5\Views\Owner\Index.cshtml"
                                                                          WriteLiteral(ViewBag.FioOwnerSort);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(633, 78, true);
            WriteLiteral("\r\n                </td>\r\n                <td>Телефон</td>\r\n            </tr>\r\n");
            EndContext();
#line 27 "F:\Education\3 курс\2 сем\ИГИ\lab5\lab5\Views\Owner\Index.cshtml"
             foreach (Owner p in Model.PageViewModel)
            {

#line default
#line hidden
            BeginContext(781, 48, true);
            WriteLiteral("                <tr>\r\n\r\n                    <td>");
            EndContext();
            BeginContext(830, 10, false);
#line 31 "F:\Education\3 курс\2 сем\ИГИ\lab5\lab5\Views\Owner\Index.cshtml"
                   Write(p.FioOwner);

#line default
#line hidden
            EndContext();
            BeginContext(840, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(872, 7, false);
#line 32 "F:\Education\3 курс\2 сем\ИГИ\lab5\lab5\Views\Owner\Index.cshtml"
                   Write(p.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(879, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 34 "F:\Education\3 курс\2 сем\ИГИ\lab5\lab5\Views\Owner\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(924, 40, true);
            WriteLiteral("        </table>\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OwnersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
