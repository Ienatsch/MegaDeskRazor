#pragma checksum "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a46a3456e43cd6175d9026b7c78f79dbcb538960"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MegaDeskRazor.Pages.DeskQuotes.Pages_DeskQuotes_Details), @"mvc.1.0.razor-page", @"/Pages/DeskQuotes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/DeskQuotes/Details.cshtml", typeof(MegaDeskRazor.Pages.DeskQuotes.Pages_DeskQuotes_Details), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a46a3456e43cd6175d9026b7c78f79dbcb538960", @"/Pages/DeskQuotes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b1d5c672dc8599e40ae0f7a6633e355ee67ec26", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DeskQuotes_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(104, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>DeskQuote</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(235, 55, false);
#line 15 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.QuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(290, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(352, 51, false);
#line 18 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.QuoteDate));

#line default
#line hidden
            EndContext();
            BeginContext(403, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(464, 55, false);
#line 21 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(519, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(581, 51, false);
#line 24 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(632, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(693, 54, false);
#line 27 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(747, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(809, 50, false);
#line 30 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(859, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(920, 51, false);
#line 33 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Width));

#line default
#line hidden
            EndContext();
            BeginContext(971, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1033, 47, false);
#line 36 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Width));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1141, 51, false);
#line 39 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.Depth));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1254, 47, false);
#line 42 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.Depth));

#line default
#line hidden
            EndContext();
            BeginContext(1301, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1362, 57, false);
#line 45 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.SurfaceArea));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1481, 53, false);
#line 48 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.SurfaceArea));

#line default
#line hidden
            EndContext();
            BeginContext(1534, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1595, 58, false);
#line 51 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.SurfacePrice));

#line default
#line hidden
            EndContext();
            BeginContext(1653, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1715, 54, false);
#line 54 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.SurfacePrice));

#line default
#line hidden
            EndContext();
            BeginContext(1769, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1830, 61, false);
#line 57 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.SurfaceMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(1891, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1953, 57, false);
#line 60 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.SurfaceMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(2010, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2071, 56, false);
#line 63 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.NumDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2189, 52, false);
#line 66 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.NumDrawers));

#line default
#line hidden
            EndContext();
            BeginContext(2241, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2302, 57, false);
#line 69 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.IsRushOrder));

#line default
#line hidden
            EndContext();
            BeginContext(2359, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2421, 53, false);
#line 72 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.IsRushOrder));

#line default
#line hidden
            EndContext();
            BeginContext(2474, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2535, 58, false);
#line 75 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.DeliveryTime));

#line default
#line hidden
            EndContext();
            BeginContext(2593, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2655, 54, false);
#line 78 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.DeliveryTime));

#line default
#line hidden
            EndContext();
            BeginContext(2709, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2770, 60, false);
#line 81 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.RushOrderPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2830, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2892, 56, false);
#line 84 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.RushOrderPrice));

#line default
#line hidden
            EndContext();
            BeginContext(2948, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(3009, 56, false);
#line 87 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DeskQuote.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3065, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(3127, 52, false);
#line 90 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
       Write(Html.DisplayFor(model => model.DeskQuote.TotalPrice));

#line default
#line hidden
            EndContext();
            BeginContext(3179, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3226, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a46a3456e43cd6175d9026b7c78f79dbcb53896015656", async() => {
                BeginContext(3282, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "C:\Users\Owner\Source\Repos\MegaDeskRazor\MegaDeskRazor\Pages\DeskQuotes\Details.cshtml"
                           WriteLiteral(Model.DeskQuote.ID);

#line default
#line hidden
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
            EndContext();
            BeginContext(3290, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3298, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a46a3456e43cd6175d9026b7c78f79dbcb53896017994", async() => {
                BeginContext(3320, 12, true);
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
            BeginContext(3336, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MegaDeskRazor.Pages.DeskQuotes.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDeskRazor.Pages.DeskQuotes.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MegaDeskRazor.Pages.DeskQuotes.DetailsModel>)PageContext?.ViewData;
        public MegaDeskRazor.Pages.DeskQuotes.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
