#pragma checksum "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be2ca7b4782933107613264a0985115d974cad07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MegaDeskRazor.Pages.DeskQuotes.Pages_DeskQuotes_Index), @"mvc.1.0.razor-page", @"/Pages/DeskQuotes/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/DeskQuotes/Index.cshtml", typeof(MegaDeskRazor.Pages.DeskQuotes.Pages_DeskQuotes_Index), null)]
namespace MegaDeskRazor.Pages.DeskQuotes
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\_ViewImports.cshtml"
using MegaDeskRazor;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be2ca7b4782933107613264a0985115d974cad07", @"/Pages/DeskQuotes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1d5c672dc8599e40ae0f7a6633e355ee67ec26", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DeskQuotes_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 18, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n");
            EndContext();
            BeginContext(118, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be2ca7b4782933107613264a0985115d974cad075973", async() => {
                BeginContext(124, 107, true);
                WriteLiteral("\r\n    <label for=\"nameSearchField\">Search by Name:</label>\r\n    <input type=\"text\" id=\"nameSearchField\"/>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(238, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(249, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be2ca7b4782933107613264a0985115d974cad077547", async() => {
                BeginContext(270, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(284, 149, true);
            WriteLiteral("\r\n</p>\r\n<div class=\"container table-conta\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(434, 58, false);
#line 21 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeskQuote[0].QuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(492, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(560, 58, false);
#line 24 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeskQuote[0].FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(618, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(686, 57, false);
#line 27 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeskQuote[0].LastName));

#line default
#line hidden
            EndContext();
            BeginContext(743, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(811, 54, false);
#line 30 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeskQuote[0].Width));

#line default
#line hidden
            EndContext();
            BeginContext(865, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(933, 54, false);
#line 33 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeskQuote[0].Depth));

#line default
#line hidden
            EndContext();
            BeginContext(987, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1055, 60, false);
#line 36 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeskQuote[0].SurfaceArea));

#line default
#line hidden
            EndContext();
            BeginContext(1115, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1183, 61, false);
#line 39 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeskQuote[0].SurfacePrice));

#line default
#line hidden
            EndContext();
            BeginContext(1244, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1312, 64, false);
#line 42 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeskQuote[0].SurfaceMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(1376, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1444, 59, false);
#line 45 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeskQuote[0].NumDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(1503, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1571, 61, false);
#line 48 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeskQuote[0].DeliveryTime));

#line default
#line hidden
            EndContext();
            BeginContext(1632, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1700, 63, false);
#line 51 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeskQuote[0].RushOrderPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1763, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1831, 59, false);
#line 54 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DeskQuote[0].TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 60 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
             foreach (var item in Model.DeskQuote)
            {

#line default
#line hidden
            BeginContext(2063, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2136, 44, false);
#line 64 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.QuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(2180, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2260, 44, false);
#line 67 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2304, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2384, 43, false);
#line 70 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2427, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2507, 40, false);
#line 73 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Width));

#line default
#line hidden
            EndContext();
            BeginContext(2547, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2627, 40, false);
#line 76 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Depth));

#line default
#line hidden
            EndContext();
            BeginContext(2667, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2747, 46, false);
#line 79 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SurfaceArea));

#line default
#line hidden
            EndContext();
            BeginContext(2793, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2873, 47, false);
#line 82 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SurfacePrice));

#line default
#line hidden
            EndContext();
            BeginContext(2920, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3000, 50, false);
#line 85 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.SurfaceMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(3050, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3130, 45, false);
#line 88 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.NumDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(3175, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3255, 47, false);
#line 91 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.DeliveryTime));

#line default
#line hidden
            EndContext();
            BeginContext(3302, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3382, 49, false);
#line 94 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RushOrderPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3431, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3511, 45, false);
#line 97 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3556, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3635, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be2ca7b4782933107613264a0985115d974cad0720510", async() => {
                BeginContext(3704, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 100 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                                               WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3712, 27, true);
            WriteLiteral(" \r\n                        ");
            EndContext();
            BeginContext(3739, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be2ca7b4782933107613264a0985115d974cad0722959", async() => {
                BeginContext(3808, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 101 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                                                  WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3819, 27, true);
            WriteLiteral(" \r\n                        ");
            EndContext();
            BeginContext(3846, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be2ca7b4782933107613264a0985115d974cad0725414", async() => {
                BeginContext(3917, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 102 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
                                                 WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3927, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 105 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3994, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MegaDeskRazor.Pages.DeskQuotes.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDeskRazor.Pages.DeskQuotes.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDeskRazor.Pages.DeskQuotes.IndexModel>)PageContext?.ViewData;
        public MegaDeskRazor.Pages.DeskQuotes.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
