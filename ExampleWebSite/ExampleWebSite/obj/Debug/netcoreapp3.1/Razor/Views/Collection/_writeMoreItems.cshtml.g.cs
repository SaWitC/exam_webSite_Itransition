#pragma checksum "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "474cd1912200078ff89e8f42f231b4c605764b9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Collection__writeMoreItems), @"mvc.1.0.view", @"/Views/Collection/_writeMoreItems.cshtml")]
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
#nullable restore
#line 8 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"474cd1912200078ff89e8f42f231b4c605764b9a", @"/Views/Collection/_writeMoreItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac91f125f01ec1be8c8df689801b46ac4bcf2d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Collection__writeMoreItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExampleWebSite.ViewModels.CollectionDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn text_color bg-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
 foreach (var item in Model.items)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-4\">\r\n        <div class=\"card\">\r\n            <div class=\"table table-info\">\r\n                <h5 class=\"category-social\">\r\n");
            WriteLiteral("                </h5>\r\n                <h4 class=\"card-caption\">\r\n                    <a href=\"#\">");
#nullable restore
#line 13 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </h4>\r\n                <div class=\"ftr\">\r\n                    <div class=\"author\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "474cd1912200078ff89e8f42f231b4c605764b9a5778", async() => {
#nullable restore
#line 17 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
                                                                                                                        Write(ViewResourcesModel["Details"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
                                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 19 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
                     if (item.IsLiked==true)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"stats\">  <a");
            BeginWriteAttribute("id", " id=\"", 830, "\"", 848, 2);
            WriteAttributeValue("", 835, "like+", 835, 5, true);
#nullable restore
#line 21 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
WriteAttributeValue("", 840, item.Id, 840, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 849, "\"", 899, 5);
            WriteAttributeValue("", 859, "LikeBtnOnclick(", 859, 15, true);
#nullable restore
#line 21 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
WriteAttributeValue("", 874, item.Id, 874, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 882, ",`like+", 882, 7, true);
#nullable restore
#line 21 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
WriteAttributeValue("", 889, item.Id, 889, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 897, "`)", 897, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa text-danger fa-heart\"></i> ");
#nullable restore
#line 21 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
                                                                                                                                                         Write(item.likesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
#nullable restore
#line 22 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"stats\">  <a");
            BeginWriteAttribute("id", " id=\"", 1088, "\"", 1106, 2);
            WriteAttributeValue("", 1093, "like+", 1093, 5, true);
#nullable restore
#line 25 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
WriteAttributeValue("", 1098, item.Id, 1098, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1107, "\"", 1157, 5);
            WriteAttributeValue("", 1117, "LikeBtnOnclick(", 1117, 15, true);
#nullable restore
#line 25 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
WriteAttributeValue("", 1132, item.Id, 1132, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1140, ",`like+", 1140, 7, true);
#nullable restore
#line 25 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
WriteAttributeValue("", 1147, item.Id, 1147, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1155, "`)", 1155, 2, true);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-heart\"></i> ");
#nullable restore
#line 25 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
                                                                                                                                             Write(item.likesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></div>\r\n");
#nullable restore
#line 26 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 46 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
                
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<script>\r\n    //like\r\n    function LikeBtnOnclick(itemId, htmlElemId) {\r\n        var Element = document.getElementById(htmlElemId)\r\n        $.ajax({\r\n            type: \'Get\',\r\n            url: \"");
#nullable restore
#line 57 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Collection\_writeMoreItems.cshtml"
             Write(Url.Action("Like","Like"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { ItemId: itemId },
            success: function (data) {
                console.log(data);
                //var response = JSON.parse(data)
                //console.log(response);
                if (data.status) {
                    Element.innerHTML = `<i class=""fa text-danger fa-heart""></i> ${data.count}`;
                }
                else {
                    Element.innerHTML = `<i class=""fa fa-heart""></i> ${data.count}`;
                }
            },
            error: function (data) {
                alert(""2"");
            }
        })
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExampleWebSite.ViewModels.CollectionDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
