#pragma checksum "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\Shared\_homeservices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75d37872db19b51900edef4f730ab4e69fc3e0a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__homeservices), @"mvc.1.0.view", @"/Views/Shared/_homeservices.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d37872db19b51900edef4f730ab4e69fc3e0a5", @"/Views/Shared/_homeservices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d7741ab8cbfed6e95ba16672735feaad812994", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__homeservices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyService>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n            <div class=\"card col-md-3 col-sm-3  fadeInDown\">\r\n                <div class=\"service-content text-center\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 294, "\"", 329, 2);
            WriteAttributeValue("", 301, "Home/ServiceDetail/", 301, 19, true);
#nullable restore
#line 10 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\Shared\_homeservices.cshtml"
WriteAttributeValue("", 320, Model.Id, 320, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"service-icon icon-pentagon\"><i");
            BeginWriteAttribute("class", " class=\"", 374, "\"", 393, 1);
#nullable restore
#line 10 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\Shared\_homeservices.cshtml"
WriteAttributeValue("", 382, Model.icon, 382, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></span></a>\r\n                    <h3>");
#nullable restore
#line 11 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\Shared\_homeservices.cshtml"
                   Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p>");
#nullable restore
#line 12 "C:\Users\scary\OneDrive\Masaüstü\GENERAL(identitysizson)\GENERALALFA\General\General\General.WebUI\Views\Shared\_homeservices.cshtml"
                  Write(Model.shortexplanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyService> Html { get; private set; }
    }
}
#pragma warning restore 1591
