#pragma checksum "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\Partials\_NavigationPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "193090895c4cf9896fe1c673872fa557ba282fbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Partials__NavigationPartial), @"mvc.1.0.view", @"/Views/Account/Partials/_NavigationPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"193090895c4cf9896fe1c673872fa557ba282fbe", @"/Views/Account/Partials/_NavigationPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9248e8ff246fac01db07a5b2b578a39cf5348a4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Partials__NavigationPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"btn-group-vertical\">\r\n    <input class=\"btn h-auto m-1 bg_Green btn-lg btn-block\"");
            BeginWriteAttribute("value", " value=\"", 95, "\"", 133, 1);
#nullable restore
#line 3 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\Partials\_NavigationPartial.cshtml"
WriteAttributeValue("", 103, ViewResourcesModel["General"], 103, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" asp-action=\"Index\" asp-controller=\"Account\" />\r\n    <input class=\"btn m-1 bg_Green btn-lg btn-block\"");
            BeginWriteAttribute("value", " value=\"", 235, "\"", 278, 1);
#nullable restore
#line 4 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\Partials\_NavigationPartial.cshtml"
WriteAttributeValue("", 243, ViewResourcesModel["PersonalData"], 243, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" asp-action=\"PersonalData\" asp-controller=\"Account\" />\r\n    <input class=\"btn m-1 bg_Green btn-lg btn-block\"");
            BeginWriteAttribute("value", " value=\"", 387, "\"", 424, 1);
#nullable restore
#line 5 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\Partials\_NavigationPartial.cshtml"
WriteAttributeValue("", 395, ViewResourcesModel["Logout"], 395, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" asp-action=\"Logout\" asp-controller=\"Account\" />\r\n    <input class=\"btn m-1 bg_Green btn-lg btn-block\"");
            BeginWriteAttribute("value", " value=\"", 527, "\"", 562, 1);
#nullable restore
#line 6 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\Partials\_NavigationPartial.cshtml"
WriteAttributeValue("", 535, ViewResourcesModel["Help"], 535, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" asp-action=\"Help\" asp-controller=\"Account\" />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591