#pragma checksum "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\SomeFeature\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73c9a2e8e6b81a19f15f312562d6038ef0e534b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_SomeFeature_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/SomeFeature/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/SomeFeature/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_SomeFeature_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73c9a2e8e6b81a19f15f312562d6038ef0e534b3", @"/Areas/Admin/Views/SomeFeature/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebced34e0df12d02d35f4e9383856ca51ee68d0b", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_SomeFeature_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SomeFeature>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\SomeFeature\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(67, 568, true);
            WriteLiteral(@"
<div class=""page-wrapper"" style=""min-height:304px"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <table class=""table-bordered table table-striped"">
                    <thead>
                        <tr>
                            <th>Title</th>
                            <th>Paragraph</th>
                            <th>Icon</th>                       
                            <th></th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 20 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\SomeFeature\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(716, 91, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"align-middle\">");
            EndContext();
            BeginContext(808, 10, false);
#line 23 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\SomeFeature\Index.cshtml"
                                                    Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(818, 64, true);
            WriteLiteral("</td>\r\n                                <td class=\"align-middle\">");
            EndContext();
            BeginContext(883, 14, false);
#line 24 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\SomeFeature\Index.cshtml"
                                                    Write(item.Paragraph);

#line default
#line hidden
            EndContext();
            BeginContext(897, 64, true);
            WriteLiteral("</td>\r\n                                <td class=\"align-middle\">");
            EndContext();
            BeginContext(962, 9, false);
#line 25 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\SomeFeature\Index.cshtml"
                                                    Write(item.Icon);

#line default
#line hidden
            EndContext();
            BeginContext(971, 125, true);
            WriteLiteral("</td>                       \r\n                                <td class=\"align-middle\">\r\n                                    ");
            EndContext();
            BeginContext(1096, 193, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "182ca36c94f94c33bfcefd7173c48009", async() => {
                BeginContext(1172, 113, true);
                WriteLiteral("\r\n                                        <i class=\"fas fa-pencil-alt\"></i>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\SomeFeature\Index.cshtml"
                                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1289, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 32 "C:\Users\User\source\repos\SmartWatchShopFP\SmartWatchShopFP\Areas\Admin\Views\SomeFeature\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1392, 114, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1524, 73, true);
                WriteLiteral("\r\n    <script src=\"https://kit.fontawesome.com/f28891363d.js\"></script>\r\n");
                EndContext();
            }
            );
            BeginContext(1600, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SomeFeature>> Html { get; private set; }
    }
}
#pragma warning restore 1591
