#pragma checksum "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\BrandNewApp\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd3c384ca997621d30054f33668cda2d243e0890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BrandNewApp_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/BrandNewApp/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/BrandNewApp/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_BrandNewApp_Index))]
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
#line 1 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\_ViewImports.cshtml"
using SmartWatchShopFP;

#line default
#line hidden
#line 2 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\_ViewImports.cshtml"
using SmartWatchShopFP.Models;

#line default
#line hidden
#line 3 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\_ViewImports.cshtml"
using SmartWatchShopFP.DAL;

#line default
#line hidden
#line 4 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\_ViewImports.cshtml"
using SmartWatchShopFP.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd3c384ca997621d30054f33668cda2d243e0890", @"/Areas/Admin/Views/BrandNewApp/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebced34e0df12d02d35f4e9383856ca51ee68d0b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BrandNewApp_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BrandNewApp>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\BrandNewApp\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(61, 841, true);
            WriteLiteral(@"
<div class=""page-wrapper"" style=""min-height:304px"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <table class=""table-bordered table table-striped"">
                    <thead>
                        <tr>
                            <th>Image</th>
                            <th>Image Icon</th>
                            <th>Subtitle Top</th>
                            <th>Title</th>
                            <th>Subtitle Bottom</th>
                            <th>Paragraph</th>
                            <th>Button</th>
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                ");
            EndContext();
            BeginContext(902, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "42a27fd2fbff483ea7a7ffdbcd04682a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 912, "~/images/", 912, 9, true);
#line 26 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\BrandNewApp\Index.cshtml"
AddHtmlAttributeValue("", 921, Model.Image, 921, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(949, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1052, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "660585a626884eb1a2d566cf04d5a796", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1062, "~/images/", 1062, 9, true);
#line 29 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\BrandNewApp\Index.cshtml"
AddHtmlAttributeValue("", 1071, Model.IconImage, 1071, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1103, 90, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(1194, 17, false);
#line 31 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\BrandNewApp\Index.cshtml"
                                                Write(Model.SubtitleTop);

#line default
#line hidden
            EndContext();
            BeginContext(1211, 60, true);
            WriteLiteral("</td>\r\n                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(1272, 11, false);
#line 32 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\BrandNewApp\Index.cshtml"
                                                Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1283, 60, true);
            WriteLiteral("</td>\r\n                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(1344, 20, false);
#line 33 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\BrandNewApp\Index.cshtml"
                                                Write(Model.SubtitleBottom);

#line default
#line hidden
            EndContext();
            BeginContext(1364, 60, true);
            WriteLiteral("</td>\r\n                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(1425, 15, false);
#line 34 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\BrandNewApp\Index.cshtml"
                                                Write(Model.Paragraph);

#line default
#line hidden
            EndContext();
            BeginContext(1440, 60, true);
            WriteLiteral("</td>\r\n                            <td class=\"align-middle\">");
            EndContext();
            BeginContext(1501, 12, false);
#line 35 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\BrandNewApp\Index.cshtml"
                                                Write(Model.Button);

#line default
#line hidden
            EndContext();
            BeginContext(1513, 94, true);
            WriteLiteral("</td>\r\n                            <td class=\"align-middle\">\r\n                                ");
            EndContext();
            BeginContext(1607, 186, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f61611e57cd2410b92e04ea01fb314fb", async() => {
                BeginContext(1684, 105, true);
                WriteLiteral("\r\n                                    <i class=\"fas fa-pencil-alt\"></i>\r\n                                ");
                EndContext();
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
#line 37 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\BrandNewApp\Index.cshtml"
                                                       WriteLiteral(Model.Id);

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
            BeginContext(1793, 182, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1993, 73, true);
                WriteLiteral("\r\n    <script src=\"https://kit.fontawesome.com/f28891363d.js\"></script>\r\n");
                EndContext();
            }
            );
            BeginContext(2069, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BrandNewApp> Html { get; private set; }
    }
}
#pragma warning restore 1591