#pragma checksum "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2900bc1d44eb35dabcde0b790d90e3e2fd3184c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Details), @"mvc.1.0.view", @"/Views/Item/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2900bc1d44eb35dabcde0b790d90e3e2fd3184c0", @"/Views/Item/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9248e8ff246fac01db07a5b2b578a39cf5348a4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
Write(Model.Item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
 if (User.Identity.IsAuthenticated)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
Write(await Html.PartialAsync("Partials/_WriteCommentPartial.cshtml"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                                                    ;
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>you are is not autentiacted</h3>\r\n");
#nullable restore
#line 14 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"renderScope\">\r\n    ");
#nullable restore
#line 16 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
Write(await Html.PartialAsync("_WriteMoreComments.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<button onclick=""LoadComments()"">load Mode</button>

<script>
    var page = 0;
    var _inCallback = false;
    window.addEventListener('scroll', function () {
      
        if (page > -1 && !_inCallback) {
            _inCallback = true;
            page++;
            $('div#loading').show();
            console.log(page);
            $.ajax({
                type: 'GET',
                url: """);
#nullable restore
#line 33 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                 Write(Url.Action("Details","Item"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                data: { id: ");
#nullable restore
#line 34 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                       Write(Model.Item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@", p: page },
                success: function (data, textstatus) {
                    if (data != '') {
                        $(""#renderScope"").append(data);
                    }
                    else {
                        page = -1;
                    }
                    _inCallback = false;
                    $(""div#loading"").hide();
                }
            });
        }
    });

    var page = 0;
    var _inCallback = false;
    function LoadComments() {
        if (page > -1 && !_inCallback) {
            _inCallback = true;
            page++;
            $('div#loading').show();
            console.log(page);
            $.ajax({
                type: 'GET',
                url: """);
#nullable restore
#line 59 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                 Write(Url.Action("Details","Item"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                data: { id: ");
#nullable restore
#line 60 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                       Write(Model.Item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",p:page },
                success: function (data, textstatus) {
                    if (data != '') {
                        $(""#renderScope"").append(data);
                    }
                    else {
                        page = -1;
                    }
                    _inCallback = false;
                    $(""div#loading"").hide();
                }
            });
        }
    }

</script>

<script>
   function SentComment() {
        $.ajax({
            type: ""POST"",
            url: """);
#nullable restore
#line 81 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
             Write(Url.Action("CreateComent", "Comment"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            data: { message: $(\"#message\").val(), itemId:");
#nullable restore
#line 82 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                                    Write(Model.Item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" },
            dataType: ""text"",
            success: function () {
                location.reload();
            },
            error: function () {
                 alert(""error"");
                // document.getElementById(""status_w"").innerHTML = ""error"";
            }
        })
    }
</script>

<div>
    <input id=""id""");
            BeginWriteAttribute("value", " value=\"", 2634, "\"", 2656, 1);
#nullable restore
#line 96 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
WriteAttributeValue("", 2642, Model.Item.Id, 2642, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <textarea type=\"text\" id=\"message\" maxlength=\"500\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2716, "\"", 2772, 1);
#nullable restore
#line 97 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
WriteAttributeValue("", 2730, ViewResourcesModel["MaxCommentLenght500"], 2730, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></textarea>\r\n    <button onclick=\"SentComment()\" class=\"btn\">");
#nullable restore
#line 98 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                           Write(ViewResourcesModel["Enter"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591