#pragma checksum "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Comment\CreateComent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d4a8b327eeb0329742e6630e2a975c2059bd16d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_CreateComent), @"mvc.1.0.view", @"/Views/Comment/CreateComent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d4a8b327eeb0329742e6630e2a975c2059bd16d", @"/Views/Comment/CreateComent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6122fc4dd63fd57d875fd09fc5da9841c6eccd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_CreateComent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommentModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\nconst { url } = require(\"inspector\");\r\n\r\n    function SentComment() {\r\n        $.ajax({\r\n            type: \"Post\",\r\n            url: \"");
#nullable restore
#line 9 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Comment\CreateComent.cshtml"
             Write(Url.Action("CreateComent", "Comment"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            dataType: ""text"",
            success: function () {
                location.reload();
            },
            error: function () {
                alert(""Exception"");
            }
        })
    }
</script>

<div>
    <textarea type=""text"" maxlength=""500""");
            BeginWriteAttribute("placeholder", " placeholder=\"", 517, "\"", 573, 1);
#nullable restore
#line 22 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Comment\CreateComent.cshtml"
WriteAttributeValue("", 531, ViewResourcesModel["MaxCommentLenght500"], 531, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></textarea>\r\n    <input type=\"submit\" onclick=\"SentComment()\" class=\"btn\"");
            BeginWriteAttribute("value", " value=\"", 648, "\"", 684, 1);
#nullable restore
#line 23 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Comment\CreateComent.cshtml"
WriteAttributeValue("", 656, ViewResourcesModel["Enter"], 656, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommentModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
