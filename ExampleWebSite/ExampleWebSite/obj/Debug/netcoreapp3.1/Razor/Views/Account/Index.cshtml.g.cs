#pragma checksum "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b8a809a3487a3a7ece3223c46b92c65e8a24a75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.ResourcesModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b8a809a3487a3a7ece3223c46b92c65e8a24a75", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9248e8ff246fac01db07a5b2b578a39cf5348a4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
#nullable restore
#line 6 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\Index.cshtml"
       Write(await Html.PartialAsync("Partials/_NavigationPartial.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9 UserInfo \">\r\n            <p><b>");
#nullable restore
#line 9 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\Index.cshtml"
             Write(ViewResourcesModel["UserName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\":</b>  ");
#nullable restore
#line 9 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\Index.cshtml"
                                                    Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <hr class=\"hr_custom\" />\r\n            <p><b>");
#nullable restore
#line 11 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\Index.cshtml"
             Write(ViewResourcesModel["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\":</b>  ");
#nullable restore
#line 11 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\Index.cshtml"
                                                 Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <hr class=\"hr_custom\" />\r\n            <p><b>");
#nullable restore
#line 13 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\Index.cshtml"
             Write(ViewResourcesModel["PhoneNumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\":</b>  ");
#nullable restore
#line 13 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\Index.cshtml"
                                                       Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <hr class=\"hr_custom\" />\r\n        </div>\r\n    </div>\r\n</div> ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<ViewResourcesModel> ViewResourcesModel { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591