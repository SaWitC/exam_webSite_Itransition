#pragma checksum "D:\FileCopy\ExampleWebSite\ExampleWebSite\Views\Shared\Partials\_sidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32fe067c94f57fb0af5653b6421946cb046dbb9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__sidebarPartial), @"mvc.1.0.view", @"/Views/Shared/Partials/_sidebarPartial.cshtml")]
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
#line 1 "D:\FileCopy\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FileCopy\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\FileCopy\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.ResourcesModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FileCopy\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\FileCopy\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.ViewModels.Items;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\FileCopy\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.ViewModels.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\FileCopy\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.ViewModels.Comments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\FileCopy\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\FileCopy\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.Models.ModelsForProcessing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\FileCopy\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32fe067c94f57fb0af5653b6421946cb046dbb9f", @"/Views/Shared/Partials/_sidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2da3635d363bc5c0e224c38a791ff7976999301", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__sidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n<h4>");
#nullable restore
#line 2 "D:\FileCopy\ExampleWebSite\ExampleWebSite\Views\Shared\Partials\_sidebarPartial.cshtml"
Write(ViewResourcesModel["TagCloud"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<div id=\"TagCloud\">\r\n\r\n</div>\r\n</div>\r\n\r\n\r\n<script>\r\n    function Tagc() {\r\n        $.ajax({\r\n            type: \'GET\',\r\n            url: \"");
#nullable restore
#line 13 "D:\FileCopy\ExampleWebSite\ExampleWebSite\Views\Shared\Partials\_sidebarPartial.cshtml"
             Write(Url.Action("GetBestPopylarTags", "tag"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            success: function (data, textstatus) {
                if (data != '') {
                    //$(""#RenderUsers"").append(data);
                    div = document.getElementById(""TagCloud"");
                    var value = 30;
                    data.forEach(el => {
                        value = value - 2;
                        div.innerHTML += `<a class=""m-0"" style=""font-size:${value}px;"" href=""../../Item/FindItemByTag/?TagString=${el.title}"">${el.title}</a><hr class=""m-0""/>`;
                    });
                }
                _inCallback = false;
                $(""div#loading"").hide();
            }
        });
    }
    Tagc();
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
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
