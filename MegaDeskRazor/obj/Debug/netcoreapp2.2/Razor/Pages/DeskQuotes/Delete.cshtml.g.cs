#pragma checksum "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2f126ddcf46174d060e668aeccbf2f9a6ac0095"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MegaDeskRazor.Pages.DeskQuotes.Pages_DeskQuotes_Delete), @"mvc.1.0.razor-page", @"/Pages/DeskQuotes/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/DeskQuotes/Delete.cshtml", typeof(MegaDeskRazor.Pages.DeskQuotes.Pages_DeskQuotes_Delete), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2f126ddcf46174d060e668aeccbf2f9a6ac0095", @"/Pages/DeskQuotes/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1d5c672dc8599e40ae0f7a6633e355ee67ec26", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DeskQuotes_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(102, 177, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>DeskQuote</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(280, 55, false);
#line 16 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.QuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(335, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(397, 51, false);
#line 19 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.QuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(448, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(509, 55, false);
#line 22 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(564, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(626, 51, false);
#line 25 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(677, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(738, 54, false);
#line 28 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(792, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(854, 50, false);
#line 31 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(904, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(965, 51, false);
#line 34 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Width));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1078, 47, false);
#line 37 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Width));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1186, 51, false);
#line 40 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Depth));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1299, 47, false);
#line 43 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Depth));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1407, 57, false);
#line 46 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.SurfaceArea));

#line default
#line hidden
            EndContext();
            BeginContext(1464, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1526, 53, false);
#line 49 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.SurfaceArea));

#line default
#line hidden
            EndContext();
            BeginContext(1579, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1640, 58, false);
#line 52 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.SurfacePrice));

#line default
#line hidden
            EndContext();
            BeginContext(1698, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1760, 54, false);
#line 55 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.SurfacePrice));

#line default
#line hidden
            EndContext();
            BeginContext(1814, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1875, 61, false);
#line 58 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.SurfaceMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(1936, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1998, 57, false);
#line 61 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.SurfaceMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(2055, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2116, 56, false);
#line 64 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.NumDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(2172, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2234, 52, false);
#line 67 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.NumDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(2286, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2347, 57, false);
#line 70 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.IsRushOrder));

#line default
#line hidden
            EndContext();
            BeginContext(2404, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2466, 53, false);
#line 73 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.IsRushOrder));

#line default
#line hidden
            EndContext();
            BeginContext(2519, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2580, 58, false);
#line 76 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DeliveryTime));

#line default
#line hidden
            EndContext();
            BeginContext(2638, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2700, 54, false);
#line 79 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DeliveryTime));

#line default
#line hidden
            EndContext();
            BeginContext(2754, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2815, 60, false);
#line 82 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.RushOrderPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2875, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2937, 56, false);
#line 85 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.RushOrderPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2993, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3054, 56, false);
#line 88 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3110, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3172, 52, false);
#line 91 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3224, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(3262, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2f126ddcf46174d060e668aeccbf2f9a6ac009516364", async() => {
                BeginContext(3282, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3292, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d2f126ddcf46174d060e668aeccbf2f9a6ac009516757", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 96 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DeskQuote.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3338, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(3421, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2f126ddcf46174d060e668aeccbf2f9a6ac009518680", async() => {
                    BeginContext(3443, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3459, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3472, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MegaDeskRazor.Pages.DeskQuotes.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDeskRazor.Pages.DeskQuotes.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDeskRazor.Pages.DeskQuotes.DeleteModel>)PageContext?.ViewData;
        public MegaDeskRazor.Pages.DeskQuotes.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
