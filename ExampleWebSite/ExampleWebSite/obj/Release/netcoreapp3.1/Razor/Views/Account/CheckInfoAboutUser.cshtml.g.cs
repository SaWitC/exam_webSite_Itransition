#pragma checksum "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d7c8b231819850a17b8d94be5a93aa01902e4bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CheckInfoAboutUser), @"mvc.1.0.view", @"/Views/Account/CheckInfoAboutUser.cshtml")]
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
#line 6 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.ViewModels.Items;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.ViewModels.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.ViewModels.Comments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using ExampleWebSite.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d7c8b231819850a17b8d94be5a93aa01902e4bc", @"/Views/Account/CheckInfoAboutUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6122fc4dd63fd57d875fd09fc5da9841c6eccd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_CheckInfoAboutUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InformationAboutUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-md-4\">\r\n    ");
#nullable restore
#line 3 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
Write(await Html.PartialAsync("Partials/_NavigationByUserForAdminPartial.cshtml",Model.user));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<div class=\"col-md-8 UserInfo \">\r\n    <p><b>");
#nullable restore
#line 6 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
     Write(ViewResourcesModel["UserName"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\":</b>  ");
#nullable restore
#line 6 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
                                            Write(Model.user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <hr class=\"hr_custom\" />\r\n    <p><b>");
#nullable restore
#line 8 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
     Write(ViewResourcesModel["Email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\":</b>  ");
#nullable restore
#line 8 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
                                         Write(Model.user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <hr class=\"hr_custom\" />\r\n    <p><b>");
#nullable restore
#line 10 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
     Write(ViewResourcesModel["PhoneNumber"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\":</b>  ");
#nullable restore
#line 10 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
                                               Write(Model.user.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <hr class=\"hr_custom\" />\r\n");
#nullable restore
#line 12 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
     if (Model.user.IsBaned)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p><b>");
#nullable restore
#line 14 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
         Write(ViewResourcesModel["Blocking_status"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\":</b>");
#nullable restore
#line 14 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
                                                     Write(ViewResourcesModel["Baned"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 15 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p><b>");
#nullable restore
#line 18 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
         Write(ViewResourcesModel["Blocking_status"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\":</b>");
#nullable restore
#line 18 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
                                                     Write(ViewResourcesModel["NotBaned"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 19 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr class=\"hr_custom\" />\r\n    <h4>");
#nullable restore
#line 21 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
   Write(ViewResourcesModel["Roles"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 23 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
     if (Model.roles != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ol>\r\n");
#nullable restore
#line 26 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
             foreach (var item in Model.roles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 28 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 29 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ol>\r\n");
#nullable restore
#line 31 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
    }
    else if (Model.roles == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <P>");
#nullable restore
#line 34 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
      Write(ViewResourcesModel["UserHasNoRoles"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</P>\r\n");
#nullable restore
#line 35 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Account\CheckInfoAboutUser.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InformationAboutUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
