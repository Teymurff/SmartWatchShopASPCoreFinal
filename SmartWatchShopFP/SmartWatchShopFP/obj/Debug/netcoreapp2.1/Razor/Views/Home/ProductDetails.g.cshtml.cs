#pragma checksum "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c28b454ee137411389b50ac1fe0726d720d305fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProductDetails), @"mvc.1.0.view", @"/Views/Home/ProductDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ProductDetails.cshtml", typeof(AspNetCore.Views_Home_ProductDetails))]
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
#line 1 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\_ViewImports.cshtml"
using SmartWatchShopFP;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\_ViewImports.cshtml"
using SmartWatchShopFP.Models;

#line default
#line hidden
#line 3 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\_ViewImports.cshtml"
using SmartWatchShopFP.DAL;

#line default
#line hidden
#line 4 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\_ViewImports.cshtml"
using SmartWatchShopFP.ViewModels;

#line default
#line hidden
#line 6 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c28b454ee137411389b50ac1fe0726d720d305fd", @"/Views/Home/ProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9cc65404b0686b726f44cd18d0b364945dc41b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomePageVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Pages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
  
    ViewData["Title"] = "ProductDetails";

#line default
#line hidden
            BeginContext(69, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(71, 25, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "22cba6804fbe4624a518b9e8502757c8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(96, 269, true);
            WriteLiteral(@"
<main id=""productdetails"">
    <div class=""container"">
        <div class=""col-md-12"">
            <div class=""product-details"">
                <div class=""row"">
                    <div class=""col-md-5"">
                        <div class=""product-content"">
");
            EndContext();
#line 14 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                             for (int i = 0; i < Model.Images.Count; i++)
                            {
                                if (i == 0)
                                {
                                    

#line default
#line hidden
#line 18 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                     if (Model.Product.HasDiscount)
                                    {

#line default
#line hidden
            BeginContext(659, 64, true);
            WriteLiteral("                                        <div class=\"product-img\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 723, "\"", 802, 4);
            WriteAttributeValue("", 731, "background-image:", 731, 17, true);
            WriteAttributeValue(" ", 748, "url(/images/", 749, 13, true);
#line 20 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
WriteAttributeValue("", 761, Model.Images.ElementAt(i).ProductImage, 761, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 800, ");", 800, 2, true);
            EndWriteAttribute();
            BeginContext(803, 220, true);
            WriteLiteral("></div>\r\n                                        <span class=\"ml-3 align-middle\" style=\"font-size:20px;background:#2566E8;color:#fff;padding:.3em.5em;border-radius:2px;position:absolute;top:10px;left:10px;\">Sale</span>\r\n");
            EndContext();
#line 22 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(1143, 64, true);
            WriteLiteral("                                        <div class=\"product-img\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1207, "\"", 1286, 4);
            WriteAttributeValue("", 1215, "background-image:", 1215, 17, true);
            WriteAttributeValue(" ", 1232, "url(/images/", 1233, 13, true);
#line 25 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
WriteAttributeValue("", 1245, Model.Images.ElementAt(i).ProductImage, 1245, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 1284, ");", 1284, 2, true);
            EndWriteAttribute();
            BeginContext(1287, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 26 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                    }

#line default
#line hidden
#line 26 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                     
                                }
                                else

                                {

#line default
#line hidden
            BeginContext(1445, 53, true);
            WriteLiteral("                                    <img class=\"ml-1\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1498, "\"", 1551, 2);
            WriteAttributeValue("", 1504, "/images/", 1504, 8, true);
#line 31 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
WriteAttributeValue("", 1512, Model.Images.ElementAt(i).ProductImage, 1512, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1552, 33, true);
            WriteLiteral(" style=\"height:30%;width:30%;\">\r\n");
            EndContext();
#line 32 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(1651, 188, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"col-md-7\">\r\n                        <div class=\"product-desc\">\r\n                            <h3>");
            EndContext();
            BeginContext(1840, 18, false);
#line 38 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                           Write(Model.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1858, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 39 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                             if (Model.Product.HasDiscount)
                            {

#line default
#line hidden
            BeginContext(1957, 52, true);
            WriteLiteral("                                <span class=\"price\">");
            EndContext();
            BeginContext(2010, 29, false);
#line 41 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                               Write(Model.Product.DiscountedPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2039, 13, true);
            WriteLiteral(" AZN</span>\r\n");
            EndContext();
#line 42 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2148, 52, true);
            WriteLiteral("                                <span class=\"price\">");
            EndContext();
            BeginContext(2201, 19, false);
#line 45 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                               Write(Model.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2220, 13, true);
            WriteLiteral(" AZN</span>\r\n");
            EndContext();
#line 46 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                            }

#line default
#line hidden
            BeginContext(2264, 507, true);
            WriteLiteral(@"                            <p class=""paragraph"">
                                Even the all-powerful Pointing has no control about
                                the blind texts it is an almost unorthographic life One day however
                                a small line of blind text by the name of Lorem Ipsum
                                decided to leave for the far World of Grammar.
                            </p>
                            <p class=""info"">Brand:<span class=""ml-3"">");
            EndContext();
            BeginContext(2772, 24, false);
#line 53 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                                                Write(Model.Product.Brand.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2796, 82, true);
            WriteLiteral("</span></p>\r\n                            <p class=\"info\">Color:<span class=\"ml-3\">");
            EndContext();
            BeginContext(2879, 19, false);
#line 54 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                                                Write(Model.Product.Color);

#line default
#line hidden
            EndContext();
            BeginContext(2898, 94, true);
            WriteLiteral("</span></p>\r\n                            <p class=\"info mb-5\">Availability:<span class=\"ml-3\">");
            EndContext();
            BeginContext(2993, 26, false);
#line 55 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                                                            Write(Model.Product.Availability);

#line default
#line hidden
            EndContext();
            BeginContext(3019, 13, true);
            WriteLiteral("</span></p>\r\n");
            EndContext();
            BeginContext(3169, 42, true);
            WriteLiteral("                            <div data-id=\"");
            EndContext();
            BeginContext(3212, 16, false);
#line 57 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                     Write(Model.Product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3228, 4, true);
            WriteLiteral("\">\r\n");
            EndContext();
#line 58 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                 if (Model.Product.InStock)
                                {

#line default
#line hidden
            BeginContext(3328, 223, true);
            WriteLiteral("                                    <a href=\"#\" class=\"additemtocart\">\r\n                                        <i class=\"fad fa-shopping-cart mr-2\"></i><span> Add to Cart </span>\r\n                                    </a>\r\n");
            EndContext();
#line 63 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3659, 208, true);
            WriteLiteral("                                    <a href=\"#\" hidden>\r\n                                        <i class=\"fad fa-shopping-cart mr-2\"></i><span> Add to Cart </span>\r\n                                    </a>\r\n");
            EndContext();
#line 69 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Views\Home\ProductDetails.cshtml"
                                }

#line default
#line hidden
            BeginContext(3902, 183, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomePageVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
