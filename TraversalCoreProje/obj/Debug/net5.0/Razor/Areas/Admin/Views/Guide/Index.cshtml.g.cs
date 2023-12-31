#pragma checksum "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f181691e1a4a5e2fc190a380f600482cf3b0419"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Guide_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Guide/Index.cshtml")]
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
#line 1 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.DestinationResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Results.GuideResults;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.CQRS.Commands.GuideCommands;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f181691e1a4a5e2fc190a380f600482cf3b0419", @"/Areas/Admin/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9254f762a46c8e7a077cae37a3e3e85f722e714", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Rehber Listesi</h1>

<table class=""table table-bordered"">
        <tr>
            <th>#</th>
            <th>GÖRSEL</th>
            <th>İSİM SOYİSİM</th>
            <th>AÇIKLAMA</th>
            <th>DURUM</th>
            <th>DÜZENLE</th>
        </tr>
");
#nullable restore
#line 20 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
          foreach (var item in Model)
                {
                     count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <tr>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><img");
            BeginWriteAttribute("src", " src=\"", 620, "\"", 637, 1);
#nullable restore
#line 25 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 626, item.Image, 626, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Avatar\" class=\"rounded-circle avatar avatar-s pull-up\" /></td>\r\n                        <td><i class=\"fab fa-angular fa-lg text-danger me-3\"></i> <strong>");
#nullable restore
#line 26 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 28 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
             if (item.Status == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 974, "\"", 1021, 2);
            WriteAttributeValue("", 981, "/Admin/Guide/ChangeToFalse/", 981, 27, true);
#nullable restore
#line 31 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1008, item.GuideID, 1008, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Pasif Yap!</a>\r\n                </td>\r\n");
#nullable restore
#line 33 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1185, "\"", 1231, 2);
            WriteAttributeValue("", 1192, "/Admin/Guide/ChangeToTrue/", 1192, 26, true);
#nullable restore
#line 37 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1218, item.GuideID, 1218, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Aktif Yap!</a>\r\n                </td>\r\n");
#nullable restore
#line 39 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td><a href=\"/Admin/Guide/EditGuide/\" class=\"btn btn-outline-success\">Düzenle</a></td>\r\n                        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("                   </table>\r\n                    <a href=\"/Admin/Guide/AddGuide/\" class=\"btn btn-outline-primary\">Yeni Rehber Oluştur!</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
