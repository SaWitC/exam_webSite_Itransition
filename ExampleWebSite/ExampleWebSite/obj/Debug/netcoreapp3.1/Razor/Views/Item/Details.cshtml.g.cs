#pragma checksum "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d413c876f51b38052e283cdad8edc43a7042463"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d413c876f51b38052e283cdad8edc43a7042463", @"/Views/Item/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6122fc4dd63fd57d875fd09fc5da9841c6eccd7", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/microsoft-signalr/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text_color btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("ml-auto mr-auto btn bg_Green"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FindItemByTag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("yes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Check-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icons/yes_check.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("no"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icons/no_check.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d413c876f51b38052e283cdad8edc43a70424638590", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<hr size=\"3\" class=\"hr_custom\" />\r\n<h3>");
#nullable restore
#line 6 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
Write(Model.Item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<hr size=\"3\" class=\"hr_custom\" />\r\n<div></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d413c876f51b38052e283cdad8edc43a70424639947", async() => {
#nullable restore
#line 9 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                                                                             Write(ViewResourcesModel["Delete"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 9 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                                                      WriteLiteral(Model.Item.Id);

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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d413c876f51b38052e283cdad8edc43a704246312645", async() => {
#nullable restore
#line 10 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                                                                               Write(ViewResourcesModel["Edit"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ItemId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 10 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                                                        WriteLiteral(Model.Item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ItemId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ItemId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ItemId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div>\r\n    <p>\r\n        <b>");
#nullable restore
#line 13 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
      Write(ViewResourcesModel["Tags"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</b>\r\n");
#nullable restore
#line 14 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
         if (Model.Tags != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
             foreach (var item in Model.Tags)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d413c876f51b38052e283cdad8edc43a704246316090", async() => {
#nullable restore
#line 18 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                                                                                                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-TagString", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 18 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                                                                                                  WriteLiteral(item.Title);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TagString"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-TagString", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TagString"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 19 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
             
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
       Write(ViewResourcesModel["NoHasTags"]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </p>\r\n</div>\r\n\r\n\r\n\r\n");
#nullable restore
#line 30 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
 if (Model.Properties != null)
{
    foreach (var item in Model.Properties)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row justify-content-md-start\">\r\n");
#nullable restore
#line 35 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
             if (item.Type == "number" || item.Type == "date")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"div_border_custom col-6\"><b>");
#nullable restore
#line 37 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n                <div class=\"div_border_custom col-6\">");
#nullable restore
#line 38 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                                Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 39 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
            }
            else if (item.Type == "bool")
            {
                if (item.Value == "on")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"div_border_custom col-6\"><b>");
#nullable restore
#line 44 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n                    <div class=\"div_border_custom col-6\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d413c876f51b38052e283cdad8edc43a704246321639", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 46 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"div_border_custom col-6\"><b>");
#nullable restore
#line 49 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                                       Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n                    <div class=\"div_border_custom col-6\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d413c876f51b38052e283cdad8edc43a704246323470", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n                    <input type=\"checkbox\" disabled />\r\n");
#nullable restore
#line 52 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12\">\r\n                    <h3>");
#nullable restore
#line 57 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    ");
#nullable restore
#line 58 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
               Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 60 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 62 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 65 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
 if (User.Identity.IsAuthenticated)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
Write(await Html.PartialAsync("Partials/_WriteCommentPartial.cshtml"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                                                    ;
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>you are is not autentiacted</h3>\r\n");
#nullable restore
#line 72 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"renderScope\">\r\n    ");
#nullable restore
#line 74 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
Write(await Html.PartialAsync("_WriteMoreComments.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>

<button onclick=""LoadComments()"">load Mode</button>

<div id=""notify""></div>

<script>
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
#line 92 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                 Write(Url.Action("Details","Item"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                data: { id: ");
#nullable restore
#line 93 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
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
#line 113 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
             Write(Url.Action("CreateComent", "Comment"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            data: { message: $(\"#message\").val(), itemId:");
#nullable restore
#line 114 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
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
            }
        })
    }
</script>

<div>
    <input id=""id"" hidden");
            BeginWriteAttribute("value", " value=\"", 3876, "\"", 3898, 1);
#nullable restore
#line 127 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
WriteAttributeValue("", 3884, Model.Item.Id, 3884, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <textarea type=\"text\" id=\"message\" maxlength=\"500\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 3958, "\"", 4014, 1);
#nullable restore
#line 128 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
WriteAttributeValue("", 3972, ViewResourcesModel["MaxCommentLenght500"], 3972, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></textarea>\r\n    <button onclick=\"SentComment()\" class=\"btn\">");
#nullable restore
#line 129 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                                           Write(ViewResourcesModel["Enter"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n</div>\r\n\r\n<script>\r\n    const hubConnection = new signalR.HubConnectionBuilder()\r\n        .withUrl(\"/chat\")\r\n        .build();\r\n\r\n    // получение сообщения от сервера\r\n    hubConnection.on(\'comment\'+\'");
#nullable restore
#line 138 "D:\проекты\ExampleWebSite\ExampleWebSite\Views\Item\Details.cshtml"
                           Write(Model.Item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', function (message) {

        //$(""#renderData"").append(data);
        // создает элемент <p> для сообщения пользователя
        let elem = document.createElement(""p"");
        var elem2 = `<div class=""card"" style=""width:auto;"">
    <div class=""form-group"">

        <div class=""card-body bg-info btn-lg active w-100 h-auto"" role=""button"" aria-pressed=""true"">
            <button type=""button"" class=""btn btn-secondary btn-lg active"" data-bs-toggle=""tooltip"" data-bs-placement=""right"" title=""From:"">
                ?
            </button>
            <h5 class=""card-text text-wrap"">user</h5>
            <p class=""card-text text-wrap"">${message}</p>
        </div>
    </div>
</div>`
        elem.appendChild(document.createTextNode(message));

        document.getElementById(""notify"").appendChild(elem);
        $(""#notify"").html(elem2);


    });
    hubConnection.start();


    hubConnection.on(""UserConnected"", function (connectionId) {
        //$(""#users"").html();
        console.l");
            WriteLiteral("og(\"connected \" + connectionId)\r\n    });\r\n\r\n    hubConnection.on(\"UserConnected\", function (connectionId) {\r\n        //$(\"#users\").html();\r\n        console.log(\"Disconnected \" + connectionId)\r\n    });\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
