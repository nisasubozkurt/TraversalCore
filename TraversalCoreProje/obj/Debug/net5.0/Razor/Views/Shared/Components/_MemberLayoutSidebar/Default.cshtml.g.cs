#pragma checksum "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Views\Shared\Components\_MemberLayoutSidebar\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67099c9dc77d657926f93dc1549ae41fff045d37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__MemberLayoutSidebar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_MemberLayoutSidebar/Default.cshtml")]
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
#line 1 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Views\_ViewImports.cshtml"
using TraversalCoreProje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67099c9dc77d657926f93dc1549ae41fff045d37", @"/Views/Shared/Components/_MemberLayoutSidebar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a51958c9bf37a05153a1f850f6d853d08112d134", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components__MemberLayoutSidebar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("brand-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Chameleon admin logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/member/theme-assets/images/logo/logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""main-menu menu-fixed menu-light menu-accordion    menu-shadow "" data-scroll-to-active=""true"" data-img=""~/member/theme-assets/images/backgrounds/02.jpg"">
    <div class=""navbar-header"">
        <ul class=""nav navbar-nav flex-row"">
            <li class=""nav-item mr-auto"">
                <a class=""navbar-brand"" href=""index.html"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "67099c9dc77d657926f93dc1549ae41fff045d375010", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <h3 class=""brand-text""> Traversal</h3>
                </a>
            </li>
            <li class=""nav-item d-md-none""><a class=""nav-link close-navbar""><i class=""ft-x""></i></a></li>
        </ul>
    </div>
    <div class=""main-menu-content"">
        <ul class=""navigation navigation-main"" id=""main-menu-navigation"" data-menu=""menu-navigation"">
            <li class="" nav-item"">
                <a href=""/Member/Dashboard/MemberDashboard/""><i class=""ft-home""></i><span class=""menu-title"" data-i18n="""">Dashboard</span></a>
            </li>
            <li class="" nav-item"">
                <a href=""/Member/Profile/Index""><i class=""ficon ft-user""></i><span class=""menu-title"" data-i18n="""">Profilim</span></a>
            </li>
            <li class="" nav-item"">
                <a href=""/Member/Reservation/MyCurrentReservation""><i class=""la la-calendar-plus-o""></i><span class=""menu-title"" data-i18n="""">Aktif Rotalar</span></a>
            </li>
            <li class="" nav-item"">
                <");
            WriteLiteral(@"a href=""/Member/Reservation/MyApprovalReservation""><i class=""la la-calendar-o""></i><span class=""menu-title"" data-i18n="""">Bekleyen Rotalar</span></a>
            </li>
            <li class=""active"">
                <a href=""/Member/Reservation/MyOldReservation""><i class=""la la-calendar-times-o""></i><span class=""menu-title"" data-i18n="""">Geçmiş Rotalar</span></a>
            </li>
            <li class="" nav-item"">
                <a href=""/Member/Reservation/NewReservation""><i class=""la la-paper-plane""></i><span class=""menu-title"" data-i18n="""">Yeni Rezervasyon</span></a>
            </li>
            <li class="" nav-item"">
                <a href=""/Member/Comment/Index""><i class=""la la-comment""></i><span class=""menu-title"" data-i18n="""">Yorumlarım</span></a>
            </li>
            <li class="" nav-item"">
                <a href=""/Member/LastDestinations/Index""><i class=""la la-bookmark""></i><span class=""menu-title"" data-i18n="""">Son Rotalar</span></a>
            </li>
            <li class="" nav-item"">
   ");
            WriteLiteral(@"             <a href=""/Member/Destination/Index""><i class=""la la-bullseye""></i><span class=""menu-title"" data-i18n="""">Tur Rotaları</span></a>
            </li>
        </ul>
    </div>
    <a class=""btn btn-danger btn-block btn-glow btn-upgrade-pro mx-1"" href=""/Default/Index"" target=""_blank"">Siteye Git!</a>
    <div class=""navigation-background""></div>
</div>");
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