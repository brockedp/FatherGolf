#pragma checksum "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a4ff400d8fcb9e9640ff1af32845c3353f75fe2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayAllRounds), @"mvc.1.0.view", @"/Views/Home/DisplayAllRounds.cshtml")]
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
#line 1 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\_ViewImports.cshtml"
using FatherGolf;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\_ViewImports.cshtml"
using FatherGolf.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a4ff400d8fcb9e9640ff1af32845c3353f75fe2", @"/Views/Home/DisplayAllRounds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d26deb39372f39ec8deba74109f7111d7b0ffc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayAllRounds : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FatherGolf.Models.GolfScoreCard>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddScorecard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteScorecard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
  
    ViewData["Title"] = "DisplayAllRounds";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Display All Rounds</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a4ff400d8fcb9e9640ff1af32845c3353f75fe24340", async() => {
                WriteLiteral("Create New Scorecard");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.PlayerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole10));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole11));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole12));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole13));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole14));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole15));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole16));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole17));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 76 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 79 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 85 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.CourseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.PlayerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 97 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 100 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 103 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 106 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 109 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 115 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 118 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 121 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole10));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 124 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole11));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 127 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole12));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 130 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole13));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 133 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole14));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 136 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole15));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 139 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole16));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 142 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole17));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 145 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 148 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 151 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a4ff400d8fcb9e9640ff1af32845c3353f75fe219898", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 154 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n");
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a4ff400d8fcb9e9640ff1af32845c3353f75fe222098", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 156 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 159 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\DisplayAllRounds.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FatherGolf.Models.GolfScoreCard>> Html { get; private set; }
    }
}
#pragma warning restore 1591
