#pragma checksum "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8eda8489e98a7339ac8f20532d7cfda6ded4b73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Book), @"mvc.1.0.view", @"/Views/Home/Book.cshtml")]
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
#line 1 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\_ViewImports.cshtml"
using ASPTask1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\_ViewImports.cshtml"
using ASPTask1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8eda8489e98a7339ac8f20532d7cfda6ded4b73", @"/Views/Home/Book.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6726fb0ce2242a27d2c0b4edd784a9b89d2dac64", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Book : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Borrow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger m-b-xs float-end"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml"
  
    ViewData["Title"] = "Book Info";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <img");
            BeginWriteAttribute("src", " src=", 119, "", 139, 1);
#nullable restore
#line 7 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml"
WriteAttributeValue("", 124, Model.ImageUrl, 124, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Image Text\" />\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <h3>Book Information</h3>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8eda8489e98a7339ac8f20532d7cfda6ded4b735750", async() => {
                WriteLiteral(@"
            <div class=""form-group row"">
                <label for=""Isbn"" class=""col-sm-2 col-form-label font-weight-bold"">ISBN:</label>
                <div class=""col-sm-10"">
                    <input type=""text"" readonly class=""form-control"" id=""Isbn""");
                BeginWriteAttribute("value", " value=\"", 511, "\"", 530, 1);
#nullable restore
#line 15 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml"
WriteAttributeValue("", 519, Model.Isbn, 519, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n\r\n                <label for=\"Title\" class=\"col-sm-2 col-form-label font-weight-bold\">Title:</label>\r\n                <div class=\"col-sm-10\">\r\n                    <input type=\"text\" readonly class=\"form-control\" id=\"Title\"");
                BeginWriteAttribute("value", " value=\"", 780, "\"", 800, 1);
#nullable restore
#line 20 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml"
WriteAttributeValue("", 788, Model.Title, 788, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n\r\n                <label for=\"Author\" class=\"col-sm-2 col-form-label font-weight-bold\">Author:</label>\r\n                <div class=\"col-sm-10\">\r\n                    <input type=\"text\" readonly class=\"form-control\" id=\"Author\"");
                BeginWriteAttribute("value", " value=\"", 1053, "\"", 1074, 1);
#nullable restore
#line 25 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml"
WriteAttributeValue("", 1061, Model.Author, 1061, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <label for=""Edition"" class=""col-sm-2 col-form-label font-weight-bold"">Edition:</label>
                <div class=""col-sm-10 input-group-lg"">
                    <input type=""text"" readonly class=""form-control"" id=""Edition""");
                BeginWriteAttribute("value", " value=\"", 1343, "\"", 1365, 1);
#nullable restore
#line 29 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml"
WriteAttributeValue("", 1351, Model.Edition, 1351, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
                <label for=""Publication"" class=""col-sm-2 col-form-label font-weight-bold"">Publication:</label>
                <div class=""col-sm-10 input-group-lg"">
                    <input type=""text"" readonly class=""form-control"" id=""Publication""");
                BeginWriteAttribute("value", " value=\"", 1646, "\"", 1672, 1);
#nullable restore
#line 33 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml"
WriteAttributeValue("", 1654, Model.Publication, 1654, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 36 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml"
             if (Model.Borrow == false)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8eda8489e98a7339ac8f20532d7cfda6ded4b739659", async() => {
                    WriteLiteral("Borrow Book");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml"
                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1930, "location.href=\'", 1930, 15, true);
#nullable restore
#line 38 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml"
AddHtmlAttributeValue("", 1945, Url.Action("Borrow", "home", @Model), 1945, 37, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 1982, "\'", 1982, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>This book has been borrowed, checkout other books!</p>\r\n");
#nullable restore
#line 43 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8eda8489e98a7339ac8f20532d7cfda6ded4b7313609", async() => {
                    WriteLiteral("Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2273, "location.href=\'", 2273, 15, true);
#nullable restore
#line 46 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\ASPTask1\Views\Home\Book.cshtml"
AddHtmlAttributeValue("", 2288, Url.Action("Books", "home"), 2288, 28, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 2316, "\'", 2316, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-md-3\"></div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
