#pragma checksum "C:\Users\LaraA\source\repos\TraversalCoreProje\TraversalCoreProje\Views\Admin\PartialNavbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f5d74311f9388f2f23682f29314f63c2be1b970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_PartialNavbar), @"mvc.1.0.view", @"/Views/Admin/PartialNavbar.cshtml")]
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
#line 1 "C:\Users\LaraA\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LaraA\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LaraA\source\repos\TraversalCoreProje\TraversalCoreProje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f5d74311f9388f2f23682f29314f63c2be1b970", @"/Views/Admin/PartialNavbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_PartialNavbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/sneat-1.0.0/assets/img/avatars/1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("w-px-40 h-auto rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""layout-navbar container-xxl navbar navbar-expand-xl navbar-detached align-items-center bg-navbar-theme""
     id=""layout-navbar"">
    <div class=""layout-menu-toggle navbar-nav align-items-xl-center me-3 me-xl-0 d-xl-none"">
        <a class=""nav-item nav-link px-0 me-xl-4"" href=""javascript:void(0)"">
            <i class=""bx bx-menu bx-sm""></i>
        </a>
    </div>

    <div class=""navbar-nav-right d-flex align-items-center"" id=""navbar-collapse"">
        <!-- Search -->
        <div class=""navbar-nav align-items-center"">
            <div class=""nav-item d-flex align-items-center"">
                <i class=""bx bx-search fs-4 lh-0""></i>
                <input type=""text""
                       class=""form-control border-0 shadow-none""
                       placeholder=""Aranacak Kelimeyi Giriniz""
                       aria-label=""Search..."" />
            </div>
        </div>
        <!-- /Search -->

        <ul class=""navbar-nav flex-row align-items-center ms-auto"">
       ");
            WriteLiteral(@"     <!-- Place this tag where you want the button to render. -->
            <li class=""nav-item lh-1 me-3"">
                <a class=""github-button""
                   href=""https://github.com/themeselection/sneat-html-admin-template-free""
                   data-icon=""octicon-star""
                   data-size=""large""
                   data-show-count=""true""
                   aria-label=""Star themeselection/sneat-html-admin-template-free on GitHub"">Star</a>
            </li>

            <!-- User -->
            <li class=""nav-item navbar-dropdown dropdown-user dropdown"">
                <a class=""nav-link dropdown-toggle hide-arrow"" href=""javascript:void(0);"" data-bs-toggle=""dropdown"">
                    <div class=""avatar avatar-online"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f5d74311f9388f2f23682f29314f63c2be1b9706080", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("alt", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </a>
                <ul class=""dropdown-menu dropdown-menu-end"">
                    <li>
                        <a class=""dropdown-item"" href=""#"">
                            <div class=""d-flex"">
                                <div class=""flex-shrink-0 me-3"">
                                    <div class=""avatar avatar-online"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f5d74311f9388f2f23682f29314f63c2be1b9707936", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("alt", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""flex-grow-1"">
                                    <span class=""fw-semibold d-block"">John Doe</span>
                                    <small class=""text-muted"">Admin</small>
                                </div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <div class=""dropdown-divider""></div>
                    </li>
                    <li>
                        <a class=""dropdown-item"" href=""#"">
                            <i class=""bx bx-user me-2""></i>
                            <span class=""align-middle"">My Profile</span>
                        </a>
                    </li>
                    <li>
                        <a class=""dropdown-item"" href=""#"">
                            <i class=""bx bx-cog me-2""></i>
                            <span class=""al");
            WriteLiteral(@"ign-middle"">Settings</span>
                        </a>
                    </li>
                    <li>
                        <a class=""dropdown-item"" href=""#"">
                            <span class=""d-flex align-items-center align-middle"">
                                <i class=""flex-shrink-0 bx bx-credit-card me-2""></i>
                                <span class=""flex-grow-1 align-middle"">Billing</span>
                                <span class=""flex-shrink-0 badge badge-center rounded-pill bg-danger w-px-20 h-px-20"">4</span>
                            </span>
                        </a>
                    </li>
                    <li>
                        <div class=""dropdown-divider""></div>
                    </li>
                    <li>
                        <a class=""dropdown-item"" href=""auth-login-basic.html"">
                            <i class=""bx bx-power-off me-2""></i>
                            <span class=""align-middle"">Log Out</span>
                ");
            WriteLiteral("        </a>\r\n                    </li>\r\n                </ul>\r\n            </li>\r\n            <!--/ User -->\r\n        </ul>\r\n    </div>\r\n</nav>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591