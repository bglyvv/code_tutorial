#pragma checksum "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cba8983c65a612db70e3d19fc3332b3b0004301"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Chat_Message), @"mvc.1.0.view", @"/Areas/Admin/Views/Chat/Message.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Chat/Message.cshtml", typeof(AspNetCore.Areas_Admin_Views_Chat_Message))]
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
#line 1 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\_ViewImports.cshtml"
using final_poject.Models;

#line default
#line hidden
#line 2 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\_ViewImports.cshtml"
using final_poject.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cba8983c65a612db70e3d19fc3332b3b0004301", @"/Areas/Admin/Views/Chat/Message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a023bc38249f464093c9bb251a195d5e384ae0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Chat_Message : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChatVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/asset/chat.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Profile Picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Chat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("sendMessage(event)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 100%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/microsoft/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
   CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

#line default
#line hidden
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Styles", async() => {
                BeginContext(104, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(110, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6e41490992be4f19b17822d3f908d53e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(165, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            BeginContext(172, 848, true);
            WriteLiteral(@"
<div id=""chat"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""view-wrapper"">
                    <div class=""left-side-wrapper"">
                        <div class=""box-heading"">
                            <div class=""chat_wrapper"">
                                <h2>Mesaj</h2>
                                <div class=""icon-wrapper"" data-toggle=""modal"" data-target=""#chat-modal"">
                                    <i class=""zmdi zmdi-plus-circle-o""></i>
                                </div>
                            </div>
                        </div>
                        <div class=""box-content"">
                            <div class=""chat_wrapper"">
                                <ul style=""padding-left:0!important"" class=""chat-list"">
");
            EndContext();
#line 26 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                     foreach (ChatUser item in Model.CurrentChats)
                                    {

#line default
#line hidden
            BeginContext(1143, 113, true);
            WriteLiteral("                                        <li class=\"chat-list-item\">\r\n                                            ");
            EndContext();
            BeginContext(1256, 847, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08b868be06a94ab49e0ef1a1145a27be", async() => {
                BeginContext(1325, 221, true);
                WriteLiteral("\r\n                                                <div class=\"chat-card-wrapper\">\r\n                                                    <div class=\"avatar-wrapper\">\r\n                                                        ");
                EndContext();
                BeginContext(1546, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "137c55d2119d475681eb5826d362c5c9", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1556, "~/img/teacher/", 1556, 14, true);
#line 32 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
AddHtmlAttributeValue("", 1570, item.User.Image, 1570, 16, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1610, 219, true);
                WriteLiteral("\r\n                                                    </div>\r\n                                                    <div class=\"profile-meta\">\r\n                                                        <h4 class=\"username\">");
                EndContext();
                BeginContext(1830, 18, false);
#line 35 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                                                        Write(item.User.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(1848, 66, true);
                WriteLiteral("</h4>\r\n                                                        <p>");
                EndContext();
                BeginContext(1915, 18, false);
#line 36 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                                      Write(item.User.Fullname);

#line default
#line hidden
                EndContext();
                BeginContext(1933, 166, true);
                WriteLiteral("</p>\r\n                                                    </div>\r\n                                                </div>\r\n                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                                                                       WriteLiteral(item.ChatId);

#line default
#line hidden
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
            EndContext();
            BeginContext(2103, 49, true);
            WriteLiteral("\r\n                                        </li>\r\n");
            EndContext();
#line 41 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2191, 394, true);
            WriteLiteral(@"                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""right-side-wrapper"">

                        <div class=""box-heading"">
                            <div class=""chat_wrapper"">
                                <a class=""avatar-wrapper"">
                                    ");
            EndContext();
            BeginContext(2585, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09a5de53876e49c4b8344b928ce338f8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2595, "~/img/teacher/", 2595, 14, true);
#line 51 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
AddHtmlAttributeValue("", 2609, Model.CurrentChatUser.Image, 2609, 28, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2661, 161, true);
            WriteLiteral("\r\n                                </a>\r\n                                <div class=\"current-chat-info\">\r\n                                    <a class=\"username\">");
            EndContext();
            BeginContext(2823, 30, false);
#line 54 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                                   Write(Model.CurrentChatUser.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2853, 287, true);
            WriteLiteral(@"</a>
                                </div>
                            </div>
                        </div>

                        <div class=""box-content"">
                            <div class=""messages-wrapper"">
                                <ul class=""messages-list"">
");
            EndContext();
#line 62 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                     foreach (Message message in Model.Messages)
                                    {
                                        

#line default
#line hidden
#line 64 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                         if (message.User.UserName == User.Identity.Name)
                                        {

#line default
#line hidden
            BeginContext(3395, 230, true);
            WriteLiteral("                                            <li class=\"message-item is-sent\">\r\n                                                <div class=\"message-sender\">\r\n                                                    <h4 class=\"username\">");
            EndContext();
            BeginContext(3626, 21, false);
#line 68 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                                                    Write(message.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(3647, 218, true);
            WriteLiteral("</h4>\r\n                                                </div>\r\n                                                <div class=\"message-body\">\r\n                                                    <span class=\"message-time\">");
            EndContext();
            BeginContext(3866, 42, false);
#line 71 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                                                          Write(message.SendingDate.ToString("g", culture));

#line default
#line hidden
            EndContext();
            BeginContext(3908, 145, true);
            WriteLiteral("</span>\r\n                                                    <div class=\"message-text\">\r\n                                                        ");
            EndContext();
            BeginContext(4054, 12, false);
#line 73 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                                   Write(message.Text);

#line default
#line hidden
            EndContext();
            BeginContext(4066, 169, true);
            WriteLiteral("\r\n                                                    </div>\r\n                                                </div>\r\n                                            </li>\r\n");
            EndContext();
#line 77 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
            BeginContext(4367, 222, true);
            WriteLiteral("                                            <li class=\"message-item\">\r\n                                                <div class=\"message-sender\">\r\n                                                    <h4 class=\"username\">");
            EndContext();
            BeginContext(4590, 21, false);
#line 82 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                                                    Write(message.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(4611, 218, true);
            WriteLiteral("</h4>\r\n                                                </div>\r\n                                                <div class=\"message-body\">\r\n                                                    <span class=\"message-time\">");
            EndContext();
            BeginContext(4830, 42, false);
#line 85 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                                                          Write(message.SendingDate.ToString("g", culture));

#line default
#line hidden
            EndContext();
            BeginContext(4872, 145, true);
            WriteLiteral("</span>\r\n                                                    <div class=\"message-text\">\r\n                                                        ");
            EndContext();
            BeginContext(5018, 12, false);
#line 87 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                                   Write(message.Text);

#line default
#line hidden
            EndContext();
            BeginContext(5030, 169, true);
            WriteLiteral("\r\n                                                    </div>\r\n                                                </div>\r\n                                            </li>\r\n");
            EndContext();
#line 91 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                        }

#line default
#line hidden
#line 91 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                         
                                    }

#line default
#line hidden
            BeginContext(5281, 163, true);
            WriteLiteral("\r\n                                </ul>\r\n                            </div>\r\n                            <div class=\"box-footer\">\r\n                                ");
            EndContext();
            BeginContext(5444, 765, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "742ccd14b2f04135a68a00a06e255a4d", async() => {
                BeginContext(5500, 469, true);
                WriteLiteral(@"
                                    <div class=""chat-action"">
                                        <div class=""control"">
                                            <textarea name=""message"" id=""chat-input"" rows=""1"" placeholder=""Message...""></textarea>
                                        </div>
                                        <div class=""message-send-button-wrapper"">
                                            <input type=""hidden"" name=""roomId""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 5969, "\"", 5991, 1);
#line 103 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
WriteAttributeValue("", 5977, Model.Chat.Id, 5977, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5992, 210, true);
                WriteLiteral(" />\r\n                                            <button type=\"submit\">Send</button>\r\n                                        </div>\r\n                                    </div>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6209, 68, true);
            WriteLiteral("\r\n                                <input type=\"hidden\" id=\"crntUser\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 6277, "\"", 6304, 1);
#line 108 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
WriteAttributeValue("", 6285, User.Identity.Name, 6285, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6305, 672, true);
            WriteLiteral(@" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id=""chat-modal"" class=""modal fade"" role=""dialog"">
        <div class=""modal-dialog modal-dialog-centered"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Yeni söhbət</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                ");
            EndContext();
            BeginContext(6977, 1081, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6739a387e3944eab8a770030d65af10", async() => {
                BeginContext(6997, 328, true);
                WriteLiteral(@"
                    <div class=""modal-body text-center"">
                        <div class=""container-fluid"">
                            <div class=""row"">
                                <div class=""col-12"">
                                    <select class=""js-example-basic-single"" name=""friend"" style=""width: 100%"">
");
                EndContext();
#line 131 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                         foreach (User user in Model.Users)
                                        {

#line default
#line hidden
                BeginContext(7445, 44, true);
                WriteLiteral("                                            ");
                EndContext();
                BeginContext(7489, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af0c3e7a4ee64afb8b033c76a3dd86a2", async() => {
                    BeginContext(7515, 13, false);
#line 133 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                                                Write(user.UserName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 133 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                               WriteLiteral(user.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7537, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 134 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                        }

#line default
#line hidden
                BeginContext(7582, 469, true);
                WriteLiteral(@"                                    </select>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-warning"" data-dismiss=""modal"">Close</button>
                        <button type=""submit"" class=""btn btn-primary"">Create</button>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8058, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(8135, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(8141, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2fe891bdc3644c0ab1e3dd584c78afe", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8212, 1964, true);
                WriteLiteral(@"
    <script src=""https://unpkg.com/axios/dist/axios.min.js""></script>
    <script>
        var messageBody = document.querySelector('.messages-list');
        messageBody.scrollTop = messageBody.scrollHeight - messageBody.clientHeight;
        $('.js-example-basic-single').select2();
        $('#chat-input').keyup(function () {
            if ($(this).val() == """") {
                $('.message-send-button-wrapper').hide();
            }
            else {
                $('.message-send-button-wrapper').show();
            }
        });

        var connection = new signalR.HubConnectionBuilder().withUrl(""/ChatHub"").build();
            connection.on(""ReceiveMessage"", function (data) {
                console.log(data);
                var msgItem = $(""<li>"").addClass('message-item');
                if (data.name==$('#crntUser').val()) {
                    msgItem.addClass('is-sent');
                }
                var msgSender = $(""<div>"").addClass('message-sender');
          ");
                WriteLiteral(@"      var msgBody = $(""<div>"").addClass('message-body');
                var msgUsername = $(""<h4>"").addClass('username');
                var msgDate = $(""<span>"").addClass('message-time');
                var msgText = $(""<div>"").addClass('message-text');
                msgUsername.text(data.name);
                msgSender.append(msgUsername);
                msgDate.text(data.date);
                msgText.text(data.text);
                msgBody.append(msgDate, msgText)
                msgItem.append(msgSender, msgBody);
                $('.messages-list').append(msgItem);
                var messageBody = document.querySelector('.messages-list');
                messageBody.scrollTop = messageBody.scrollHeight - messageBody.clientHeight;
            });

            var _connectionId = '';


            var joinRoom = function () {
                var url = '/HubHandler/JoinRoom/' + _connectionId + '/");
                EndContext();
                BeginContext(10177, 13, false);
#line 193 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Chat\Message.cshtml"
                                                                 Write(Model.Chat.Id);

#line default
#line hidden
                EndContext();
                BeginContext(10190, 1412, true);
                WriteLiteral(@"';
                axios.post(url, null)
                    .then(res => {
                        console.log(""Joined Room!"", res);
                    })
                    .catch(err => {
                        console.log(""Failed"", err);
                    })
            }


            connection.start()
                .then(function () {
                    connection.invoke('getConnectionId')
                        .then(function (connectionId) {
                            _connectionId = connectionId;
                            joinRoom();
                        })
                })
                .catch(function (err) {
                    console.log(err);
                })


            var sendMessage = function (event) {
                event.preventDefault();
                var data = new FormData(event.target);
                if ($('#chat-input').val()=='') {
                    return;
                }
                $('#chat-input').val('');
    ");
                WriteLiteral(@"            $('.message-send-button-wrapper').hide();
                axios.post('/HubHandler/SendMessage', data)
                    .then(res => {
                        console.log(""Message Sent!"");
                    })
                    .catch(err => {
                        console.log(""Failed to send message"");
                    })
            }
    </script>

");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChatVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
