#pragma checksum "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e6f9f88af8421c5cd664e52af08feb1a2abfa16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Deleted_Subject), @"mvc.1.0.view", @"/Areas/Admin/Views/Deleted/Subject.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Deleted/Subject.cshtml", typeof(AspNetCore.Areas_Admin_Views_Deleted_Subject))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e6f9f88af8421c5cd664e52af08feb1a2abfa16", @"/Areas/Admin/Views/Deleted/Subject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a023bc38249f464093c9bb251a195d5e384ae0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Deleted_Subject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Subject>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Deleted", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success waves-effect waves-light m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditSubject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-round waves-effect waves-light m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActivateSubject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-round waves-effect waves-light m-1 activate_subject"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 255, true);
            WriteLiteral("<div class=\"container-fluid\">\n    <div class=\"row pt-2 pb-2\">\n        <div class=\"col-sm-6\">\n            <h4 class=\"page-title\">Mövzular</h4>\n        </div>\n        <div class=\"col-sm-6\">\n            <div class=\"btn-group float-sm-right\">\n                ");
            EndContext();
            BeginContext(283, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61f3bd64ef4840e8a9e5016710f6e31f", async() => {
                BeginContext(400, 12, true);
                WriteLiteral("Geriyə qayıt");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(416, 46, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 13 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
     if (TempData.ContainsKey("Error"))
    {
        if (TempData["Error"].ToString() == "course") 
        {

#line default
#line hidden
            BeginContext(573, 65, true);
            WriteLiteral("            <div class=\"text-danger\">Bu mövzu silinmiş bir kursa(");
            EndContext();
            BeginContext(639, 18, false);
#line 17 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
                                                            Write(TempData["Course"]);

#line default
#line hidden
            EndContext();
            BeginContext(657, 82, true);
            WriteLiteral(") aiddir.Ya kursu geri qaytarmalı ya da aid olduğu kursu dəyiştirməlisiniz.</div>\n");
            EndContext();
#line 18 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
        }
        else if(TempData["Error"].ToString() == "category") 
        {

#line default
#line hidden
            BeginContext(820, 72, true);
            WriteLiteral("            <div class=\"text-danger\">Bu mövzu silinmiş bir kateqoriyaya(");
            EndContext();
            BeginContext(893, 20, false);
#line 21 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
                                                                   Write(TempData["Category"]);

#line default
#line hidden
            EndContext();
            BeginContext(913, 96, true);
            WriteLiteral(") aiddir.Ya kateqoriyanı geri qaytarmalı ya da aid olduğu kateqoriyanı dəyiştirməlisiniz.</div>\n");
            EndContext();
#line 22 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
        }
        else if(TempData["Error"].ToString() == "both") 
        {

#line default
#line hidden
            BeginContext(1086, 72, true);
            WriteLiteral("            <div class=\"text-danger\">Bu mövzu həm silinmiş kateqoriyaya(");
            EndContext();
            BeginContext(1159, 20, false);
#line 25 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
                                                                   Write(TempData["Category"]);

#line default
#line hidden
            EndContext();
            BeginContext(1179, 24, true);
            WriteLiteral(") həm də silinmiş kursa(");
            EndContext();
            BeginContext(1204, 18, false);
#line 25 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
                                                                                                                Write(TempData["Course"]);

#line default
#line hidden
            EndContext();
            BeginContext(1222, 102, true);
            WriteLiteral(") aiddir.Ya hər ikisini geri qaytarmalı ya da aid olduğu kateqoriya və kursu dəyiştirməlisiniz.</div>\n");
            EndContext();
#line 26 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1340, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 28 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
     if(Model.Count() == 0) 
    {

#line default
#line hidden
            BeginContext(1375, 45, true);
            WriteLiteral("        <h2>Heç bir kurs silinməmişdir.</h2>\n");
            EndContext();
#line 31 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1441, 468, true);
            WriteLiteral(@"        <div class=""table-responsive"">
            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th style=""font-size:20px"" scope=""col"">Mövzular</th>
                        <th style=""font-size:20px"" scope=""col"">Silən/Silindiyi tarix</th>
                        <th style=""font-size:20px"" scope=""col"">Ətraflı oxu/Geri Qaytar</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 44 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
         foreach (Subject subject in Model)
        {

#line default
#line hidden
            BeginContext(1963, 60, true);
            WriteLiteral("            <tr>\n                <td style=\"font-size:20px\">");
            EndContext();
            BeginContext(2024, 12, false);
#line 47 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
                                      Write(subject.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2036, 49, true);
            WriteLiteral("</td>\n                <td style=\"font-size:20px\">");
            EndContext();
            BeginContext(2086, 21, false);
#line 48 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
                                      Write(subject.User.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(2107, 3, true);
            WriteLiteral(" / ");
            EndContext();
            BeginContext(2111, 19, false);
#line 48 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
                                                               Write(subject.DeletedTime);

#line default
#line hidden
            EndContext();
            BeginContext(2130, 47, true);
            WriteLiteral("</td>\n                <td>\n                    ");
            EndContext();
            BeginContext(2177, 194, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f525e233aba84e1986eacefbdf8e9ce6", async() => {
                BeginContext(2337, 30, true);
                WriteLiteral("<i class=\"zmdi zmdi-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
                                                                           WriteLiteral(subject.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2371, 21, true);
            WriteLiteral("\n                    ");
            EndContext();
            BeginContext(2392, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce076dd586e94fb7a14254823eb04d68", async() => {
                BeginContext(2573, 31, true);
                WriteLiteral("<i class=\"zmdi zmdi-check\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
                                                                                                WriteLiteral(subject.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2608, 42, true);
            WriteLiteral("\n\n                </td>\n            </tr>\n");
            EndContext();
#line 55 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
        }

#line default
#line hidden
            BeginContext(2660, 98, true);
            WriteLiteral("                                    \n                </tbody>\n            </table>\n        </div>\n");
            EndContext();
#line 60 "C:\Users\Kanan\Desktop\final_project\final_poject\Areas\Admin\Views\Deleted\Subject.cshtml"
    }

#line default
#line hidden
            BeginContext(2764, 23, true);
            WriteLiteral("            \n\n</div>\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2804, 758, true);
                WriteLiteral(@"
    <script>
        $("".activate_subject"").click(function (e) {
            e.preventDefault();
            swal({
                title: ""Əminsiniz?"",
                text: ""Aktiv etmək istədiyinizə əminsinizmi?"",
                icon: ""warning"",
                buttons: true,
                dangerMode: true,
            })
                .then((willDelete) => {
                    if (willDelete && $(this).val() != ""1"") {
                        swal(""Aktiv olundu"", {
                            icon: ""success"",
                        });
                        location.href = $(this).attr('href')
                    } else {
                        swal(""Aktiv olunmadı"");
                    }
                });
        })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Subject>> Html { get; private set; }
    }
}
#pragma warning restore 1591
