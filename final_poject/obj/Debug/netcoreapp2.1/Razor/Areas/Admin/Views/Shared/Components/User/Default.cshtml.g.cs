#pragma checksum "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4537cbce5eae1bf9cf48d95da603d4b44163f009"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_User_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/User/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/Components/User/Default.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_Components_User_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4537cbce5eae1bf9cf48d95da603d4b44163f009", @"/Areas/Admin/Views/Shared/Components/User/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a023bc38249f464093c9bb251a195d5e384ae0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_User_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AdminHeaderVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Read", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Mail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Calendar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("align-self-start mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Chat", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ChangePicture", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 170, true);
            WriteLiteral("<header class=\"topbar-nav\">\n    <nav class=\"navbar navbar-expand fixed-top\">\n\n        <div class=\"toggle-menu\">\n            <i class=\"zmdi zmdi-menu\"></i>\n        </div>\n");
            EndContext();
#line 8 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
          string controller = @ViewContext.RouteData.Values["controller"].ToString();

#line default
#line hidden
            BeginContext(278, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 9 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
          string action = @ViewContext.RouteData.Values["action"].ToString();

#line default
#line hidden
            BeginContext(357, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 10 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
         if ( controller == "Users" && action == "Index" || controller == "Subscribers" && action == "Index" || controller == "Users" && action == "DeletedUsers" )
        {

#line default
#line hidden
            BeginContext(531, 463, true);
            WriteLiteral(@"            <div class=""search-bar flex-grow-1"">
                <div class=""input-group"">
                    <div class=""input-group-prepend search-arrow-back"">
                        <button class=""btn btn-search-back"" type=""button""><i class=""zmdi zmdi-long-arrow-left""></i></button>
                    </div>
                    <input id=""searchEverything"" type=""text"" class=""form-control"" placeholder=""Axtar..."">
                </div>
            </div>
");
            EndContext();
#line 20 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(1004, 322, true);
            WriteLiteral(@"
        <ul class=""navbar-nav align-items-center right-nav-link ml-auto"">
            <li class=""nav-item dropdown search-btn-mobile"">
                <a class=""nav-link position-relative"" href=""javascript:void();"">
                    <i class=""zmdi zmdi-search align-middle""></i>
                </a>
            </li>
");
            EndContext();
#line 28 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
             if (User.IsInRole("Admin") || User.IsInRole("Moderator")) 
            {

#line default
#line hidden
            BeginContext(1412, 286, true);
            WriteLiteral(@"                <li class=""nav-item dropdown dropdown-lg"">
                    <a class=""nav-link dropdown-toggle dropdown-toggle-nocaret position-relative"" data-toggle=""dropdown"" href=""javascript:void();"">
                        <i class=""zmdi zmdi-comment-outline align-middle""></i>
");
            EndContext();
#line 33 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                         if (@Model.Messages.Where(m => m.isDeleted == false && m.isRead == false).Count() != 0) 
                        {

#line default
#line hidden
            BeginContext(1838, 72, true);
            WriteLiteral("                            <span class=\"bg-danger text-white badge-up\">");
            EndContext();
            BeginContext(1911, 74, false);
#line 35 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                                                   Write(Model.Messages.Where(m=>m.isDeleted == false && m.isRead == false).Count());

#line default
#line hidden
            EndContext();
            BeginContext(1985, 8, true);
            WriteLiteral("</span>\n");
            EndContext();
#line 36 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(2019, 372, true);
            WriteLiteral(@"                        
                    </a>
                    <div class=""dropdown-menu dropdown-menu-right"">
                        <ul class=""list-group list-group-flush"">
                            <li class=""list-group-item d-flex justify-content-between align-items-center"">
                                Yeni Məktublar 
                            </li>
");
            EndContext();
#line 44 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                             if (Model.Messages.Count() == 0) 
                            {

#line default
#line hidden
            BeginContext(2484, 74, true);
            WriteLiteral("                                <p class=\"ml-3\">Məktub qutunuz boşdur</p>\n");
            EndContext();
#line 47 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(2588, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 48 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                             foreach (Contact contact in Model.Messages.Take(3).OrderByDescending(m => m.Id)) 
                            {

#line default
#line hidden
            BeginContext(2729, 97, true);
            WriteLiteral("                                <li class=\"list-group-item\">\n                                    ");
            EndContext();
            BeginContext(2826, 1236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c797ecff67c405a84cc157685c7bf0f", async() => {
                BeginContext(2913, 61, true);
                WriteLiteral("\n                                        <div class=\"media\">\n");
                EndContext();
#line 53 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                             if (contact.isRead == false)
                                            {

#line default
#line hidden
                BeginContext(3095, 130, true);
                WriteLiteral("                                                <div class=\"avatar\"><i class=\"zmdi zmdi-email fa-2x mr-3 text-warning\"></i></div>\n");
                EndContext();
#line 56 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                            }
                                            else 
                                            {

#line default
#line hidden
                BeginContext(3367, 117, true);
                WriteLiteral("                                                <div class=\"avatar\"><i class=\"zmdi zmdi-email fa-2x mr-3\"></i></div>\n");
                EndContext();
#line 60 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                            }

#line default
#line hidden
                BeginContext(3530, 144, true);
                WriteLiteral("                                            <div class=\"media-body\">\n                                                <h6 class=\"mt-0 msg-title\">");
                EndContext();
                BeginContext(3675, 12, false);
#line 62 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                                                      Write(contact.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3687, 74, true);
                WriteLiteral("</h6>\n                                                <p class=\"msg-info\">");
                EndContext();
                BeginContext(3762, 15, false);
#line 63 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                                               Write(contact.Subject);

#line default
#line hidden
                EndContext();
                BeginContext(3777, 60, true);
                WriteLiteral("</p>\n                                                <small>");
                EndContext();
                BeginContext(3838, 77, false);
#line 64 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                                  Write(contact.SendingDate.ToString("g", CultureInfo.CreateSpecificCulture("es-ES")));

#line default
#line hidden
                EndContext();
                BeginContext(3915, 143, true);
                WriteLiteral("</small>\n                                            </div>\n                                        </div>\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                                                                                  WriteLiteral(contact.Id);

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
            BeginContext(4062, 39, true);
            WriteLiteral("\n                                </li>\n");
            EndContext();
#line 69 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                            }

#line default
#line hidden
            BeginContext(4131, 68, true);
            WriteLiteral("                            <li class=\"list-group-item text-center\">");
            EndContext();
            BeginContext(4199, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "906b113565594207a2f2003e3f837030", async() => {
                BeginContext(4260, 20, true);
                WriteLiteral("Bütün məktubları gör");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4284, 85, true);
            WriteLiteral("</li>\n                        </ul>\n                    </div>\n                </li>\n");
            EndContext();
#line 74 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
            }

#line default
#line hidden
            BeginContext(4383, 292, true);
            WriteLiteral(@"            
            <li class=""nav-item dropdown dropdown-lg"">
                <a class=""nav-link dropdown-toggle dropdown-toggle-nocaret position-relative"" data-toggle=""dropdown"" href=""javascript:void();"">
                    <i class=""zmdi zmdi-notifications-active align-middle""></i>
");
            EndContext();
#line 79 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                     if (Model.Events.Count() != 0) 
                    {

#line default
#line hidden
            BeginContext(4750, 66, true);
            WriteLiteral("                        <span class=\"bg-info text-white badge-up\">");
            EndContext();
            BeginContext(4817, 20, false);
#line 81 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                                             Write(Model.Events.Count());

#line default
#line hidden
            EndContext();
            BeginContext(4837, 8, true);
            WriteLiteral("</span>\n");
            EndContext();
#line 82 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(4867, 355, true);
            WriteLiteral(@"                    
                </a>
                <div class=""dropdown-menu dropdown-menu-right"">
                    <ul class=""list-group list-group-flush"">
                        <li class=""list-group-item d-flex justify-content-between align-items-center"">
                            Bu günə olan tədbirləriniz
                        </li>
");
            EndContext();
#line 90 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                         if (Model.Events.Count() == 0) 
                        {

#line default
#line hidden
            BeginContext(5305, 81, true);
            WriteLiteral("                            <p class=\"ml-3\">Bu gün heç bir tədbiriniz yoxdur</p>\n");
            EndContext();
#line 93 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(5412, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 94 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                         foreach (Event e in Model.Events) 
                        {

#line default
#line hidden
            BeginContext(5498, 421, true);
            WriteLiteral(@"                            <li class=""list-group-item"">
                                <a href=""javaScript:void();"">
                                    <div class=""media"">
                                        <i class=""zmdi zmdi-notifications-active fa-2x mr-3 text-danger""></i>
                                        <div class=""media-body"">
                                            <h6 class=""mt-0 msg-title"">");
            EndContext();
            BeginContext(5920, 9, false);
#line 101 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                                                  Write(e.Subject);

#line default
#line hidden
            EndContext();
            BeginContext(5929, 70, true);
            WriteLiteral("</h6>\n                                            <p class=\"msg-info\">");
            EndContext();
            BeginContext(6000, 13, false);
#line 102 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                                           Write(e.Description);

#line default
#line hidden
            EndContext();
            BeginContext(6013, 166, true);
            WriteLiteral("</p>\n                                        </div>\n                                    </div>\n                                </a>\n                            </li>\n");
            EndContext();
#line 107 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(6205, 89, true);
            WriteLiteral("                        \n                        <li class=\"list-group-item text-center\">");
            EndContext();
            BeginContext(6294, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64503dfcf0c84289b9657cc2d717c1fa", async() => {
                BeginContext(6359, 19, true);
                WriteLiteral("Bütün kalendarı gör");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6382, 577, true);
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </li>
            <li class=""nav-item dropdown language"">
                <a class=""nav-link dropdown-toggle dropdown-toggle-nocaret position-relative"" data-toggle=""dropdown"" href=""javascript:void();""><i class=""flag-icon flag-icon-az align-middle""></i></a>

            </li>
            <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle dropdown-toggle-nocaret position-relative"" data-toggle=""dropdown"" href=""javascript:void();"">
                    <span class=""user-profile"">");
            EndContext();
            BeginContext(6959, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2afb61209f9244fa9218b2909de278f5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6969, "~/img/teacher/", 6969, 14, true);
#line 119 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
AddHtmlAttributeValue("", 6983, Model.User.Image, 6983, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(7039, 306, true);
            WriteLiteral(@"</span>
                </a>
                <ul class=""dropdown-menu dropdown-menu-right"">
                    <li class=""dropdown-item user-details"">
                        <a href=""/Account/MyAccount"">
                            <div class=""media"">
                                <div class=""avatar"">");
            EndContext();
            BeginContext(7345, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f886fc63b80442078526ba19694dc9d2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 7385, "~/img/teacher/", 7385, 14, true);
#line 125 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
AddHtmlAttributeValue("", 7399, Model.User.Image, 7399, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7436, 128, true);
            WriteLiteral("</div>\n                                <div class=\"media-body\">\n                                    <h6 class=\"mt-2 user-title\">");
            EndContext();
            BeginContext(7565, 19, false);
#line 127 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                                           Write(Model.User.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(7584, 67, true);
            WriteLiteral("</h6>\n                                    <p class=\"user-subtitle\">");
            EndContext();
            BeginContext(7652, 19, false);
#line 128 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                                        Write(Model.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(7671, 235, true);
            WriteLiteral("</p>\n                                </div>\n                            </div>\n                        </a>\n                    </li>\n                    <li class=\"dropdown-divider\"></li>\n                    <li class=\"dropdown-item\">");
            EndContext();
            BeginContext(7906, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "569771a1504e4b40bd0c6e78f7e88eeb", async() => {
                BeginContext(7950, 47, true);
                WriteLiteral("<i class=\"zmdi zmdi-comments mr-3\"></i>Mesajlar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8001, 107, true);
            WriteLiteral("</li>\n                    <li class=\"dropdown-divider\"></li>\n                    <li class=\"dropdown-item\">");
            EndContext();
            BeginContext(8108, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4156ba6a80d4e2c9715c69cdb5d0ad1", async() => {
                BeginContext(8178, 56, true);
                WriteLiteral("<i class=\"zmdi zmdi-balance-wallet mr-3\"></i>Şəkil dəyiş");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(8238, 261, true);
            WriteLiteral(@"</li>
                    <li class=""dropdown-divider""></li>
                    <li class=""dropdown-item""><a href=""/Account/Logout""><i class=""zmdi zmdi-power mr-3""></i>Çıxış et</a></li>
                </ul>
            </li>
        </ul>
    </nav>
</header>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminHeaderVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
