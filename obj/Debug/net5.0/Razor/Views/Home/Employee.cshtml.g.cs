#pragma checksum "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\Session3\Views\Home\Employee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe9088e42902ca3ff59782e70c22fe08b0b5ce65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employee), @"mvc.1.0.view", @"/Views/Home/Employee.cshtml")]
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
#line 1 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\Session3\Views\_ViewImports.cshtml"
using Session3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\Session3\Views\_ViewImports.cshtml"
using Session3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe9088e42902ca3ff59782e70c22fe08b0b5ce65", @"/Views/Home/Employee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c54af2485caa308b1d39b74eb695695868130e20", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Employee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Confirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control btn btn-block btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Click to Confirm Employee"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\Session3\Views\Home\Employee.cshtml"
  

    ViewData["Title"] = "Employee Info";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe9088e42902ca3ff59782e70c22fe08b0b5ce655316", async() => {
                WriteLiteral(@"
    <div class=""form-group row"">
        <label for=""FirstName"" class=""col-sm-2 col-form-label bg-secondary font-weight-bold"">First Name:</label>
        <div class=""col-sm-10"">
            <input type=""text"" readonly class=""form-control"" id=""firstName""");
                BeginWriteAttribute("value", " value=\"", 664, "\"", 688, 1);
#nullable restore
#line 16 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\Session3\Views\Home\Employee.cshtml"
WriteAttributeValue("", 672, Model.FirstName, 672, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n\r\n        <label for=\"LastName\" class=\"col-sm-2 col-form-label bg-secondary font-weight-bold\">Second Name:</label>\r\n        <div class=\"col-sm-10\">\r\n            <input type=\"text\" readonly class=\"form-control\" id=\"LastName\"");
                BeginWriteAttribute("value", " value=\"", 931, "\"", 954, 1);
#nullable restore
#line 21 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\Session3\Views\Home\Employee.cshtml"
WriteAttributeValue("", 939, Model.LastName, 939, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n\r\n        <label for=\"Department\" class=\"col-sm-2 col-form-label bg-secondary font-weight-bold\">Department:</label>\r\n        <div class=\"col-sm-10\">\r\n            <input type=\"text\" readonly class=\"form-control\" id=\"Department\"");
                BeginWriteAttribute("value", " value=\"", 1200, "\"", 1225, 1);
#nullable restore
#line 26 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\Session3\Views\Home\Employee.cshtml"
WriteAttributeValue("", 1208, Model.Department, 1208, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <label for=\"Salary\" class=\"col-sm-2 col-form-label bg-secondary font-weight-bold\">Salary:</label>\r\n        <div class=\"col-sm-10 input-group-lg\">\r\n            <input type=\"text\" readonly class=\"form-control\" id=\"Salary\"");
                BeginWriteAttribute("value", " value=\"", 1472, "\"", 1494, 2);
                WriteAttributeValue("", 1480, "$", 1480, 1, true);
#nullable restore
#line 30 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\Session3\Views\Home\Employee.cshtml"
WriteAttributeValue("", 1481, Model.Salary, 1481, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n\r\n");
#nullable restore
#line 33 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\Session3\Views\Home\Employee.cshtml"
         if (Model.Confirmed == true)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("             <h1>Employee has been confirmed!</h1>\r\n");
#nullable restore
#line 36 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\Session3\Views\Home\Employee.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-group\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe9088e42902ca3ff59782e70c22fe08b0b5ce658916", async() => {
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
#line 40 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\Session3\Views\Home\Employee.cshtml"
                                                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 42 "C:\CodebitsAcademy\ClassSessions\CSharp\ASP.Net Core MVC\Session3\Views\Home\Employee.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    </div>\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
