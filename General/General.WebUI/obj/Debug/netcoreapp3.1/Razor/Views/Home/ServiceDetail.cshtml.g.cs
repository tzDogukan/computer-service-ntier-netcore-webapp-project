#pragma checksum "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\Home\ServiceDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "709a8f3117317b848575cd29b9f62f0e9452f3f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ServiceDetail), @"mvc.1.0.view", @"/Views/Home/ServiceDetail.cshtml")]
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
#line 1 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\_ViewImports.cshtml"
using General.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\_ViewImports.cshtml"
using General.Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\_ViewImports.cshtml"
using General.DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\_ViewImports.cshtml"
using General.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"709a8f3117317b848575cd29b9f62f0e9452f3f3", @"/Views/Home/ServiceDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d7741ab8cbfed6e95ba16672735feaad812994", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ServiceDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyServiceModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\Home\ServiceDetail.cshtml"
  
    ViewData["Title"] = "ServiceDetail";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"banner-area\">\r\n    <img src=\"../../images/banner/banner2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 196, "\"", 202, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <div class=\"parallax-overlay\"></div>\r\n    <!-- Subpage title start -->\r\n    <div class=\"banner-title-content\">\r\n        <div class=\"text-center\">\r\n            <h2>");
#nullable restore
#line 13 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\Home\ServiceDetail.cshtml"
           Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <ul class=\"breadcrumb\">\r\n                <li>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "709a8f3117317b848575cd29b9f62f0e9452f3f36247", async() => {
                WriteLiteral("Hizmetlerimiz <i class=\"fa fa-angle-down\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 526, "dropdown-toggle", 526, 15, true);
            AddHtmlAttributeValue(" ", 541, "navbar-link", 542, 12, true);
#nullable restore
#line 16 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\Home\ServiceDetail.cshtml"
AddHtmlAttributeValue(" ", 553, ViewBag.menuactive=="Services"?"active":"", 554, 45, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n                <li><a href=\"#\"> ");
#nullable restore
#line 18 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\Home\ServiceDetail.cshtml"
                            Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
            </ul>
        </div>
    </div><!-- Subpage title end -->
</div><!-- Banner area end -->
<!-- Main container start -->
<section class=""call-to-action"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <h3>Hemen bizimle iletişime geçin!</h3>
                <a href=""index.html#contact"" class=""pull-right btn btn-primary white"">İletişim</a>
            </div>
        </div>
    </div>
</section>

<!-- Main container start -->

<section id=""main-container"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                <div class=""post-content"">
                    <div class=""post-image-wrapper"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "709a8f3117317b848575cd29b9f62f0e9452f3f39525", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1532, "~/images/services/", 1532, 18, true);
#nullable restore
#line 43 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\Home\ServiceDetail.cshtml"
AddHtmlAttributeValue("", 1550, Model.image, 1550, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    ");
#nullable restore
#line 45 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\Home\ServiceDetail.cshtml"
               Write(Html.Raw(Model.longexplanation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div><!--/ post content end -->\r\n\r\n            </div><!--/ Content col end -->\r\n\r\n\r\n        </div><!--/ row end -->\r\n    </div><!--/ container end -->\r\n</section><!--/ Main container end -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyServiceModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
