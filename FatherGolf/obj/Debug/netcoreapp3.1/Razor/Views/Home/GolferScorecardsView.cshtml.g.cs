#pragma checksum "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6672b5a30df07cab3dbad86c4117849931413753"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GolferScorecardsView), @"mvc.1.0.view", @"/Views/Home/GolferScorecardsView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6672b5a30df07cab3dbad86c4117849931413753", @"/Views/Home/GolferScorecardsView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d26deb39372f39ec8deba74109f7111d7b0ffc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GolferScorecardsView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FatherGolf.ViewModels.GolfRounds>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddScorecard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateScorecard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
  
    ViewData["Title"] = "GolferScorecardsView";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
Write(ViewBag.PlayerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6672b5a30df07cab3dbad86c41178499314137534579", async() => {
                WriteLiteral("Create New");
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
#line 15 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 54 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole10));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 57 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole11));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole12));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole13));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 66 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole14));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 69 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole15));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 72 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole16));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 75 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole17));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 78 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Hole18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 81 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 84 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 90 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 93 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.CourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 105 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 108 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 111 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 114 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 117 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole5));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 120 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole6));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 123 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole7));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 126 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 129 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole9));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 132 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole10));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 135 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole11));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 138 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole12));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 141 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole13));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 144 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole14));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 147 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole15));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 150 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole16));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 153 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole17));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 156 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hole18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 159 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 162 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6672b5a30df07cab3dbad86c411784993141375319729", async() => {
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
#line 165 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6672b5a30df07cab3dbad86c411784993141375321944", async() => {
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
#line 167 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
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
#line 170 "C:\Users\denob\Documents\FatherGolf\FatherGolf\Views\Home\GolferScorecardsView.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FatherGolf.ViewModels.GolfRounds>> Html { get; private set; }
    }
}
#pragma warning restore 1591
