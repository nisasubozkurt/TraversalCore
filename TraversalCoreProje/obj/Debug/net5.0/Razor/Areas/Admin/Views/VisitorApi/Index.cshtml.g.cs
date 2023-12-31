#pragma checksum "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cb670f76c62c41ae95832203854b4751b980ca3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_VisitorApi_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/VisitorApi/Index.cshtml")]
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
#line 3 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cb670f76c62c41ae95832203854b4751b980ca3", @"/Areas/Admin/Views/VisitorApi/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9254f762a46c8e7a077cae37a3e3e85f722e714", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_VisitorApi_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VisitorViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <h5 class=""card-header"">Api Ziyaretçi Listesi  </h5>
    <div class=""table-responsive text-nowrap"">
        <table class=""table table-hover text-center"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>İSİM</th>
                    <th>SOYİSİM</th>
                    <th>ŞEHİR</th>
                    <th>ÜLKE</th>
                    <th>E-POSTA</th>
                    <th>İŞLEM SEÇİNİZ</th>
                </tr>
            </thead>

            <tbody class=""table-border-bottom-0 text-center"">
");
#nullable restore
#line 25 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 28 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
                       Write(item.VisitorID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><i class=\"fab fa-angular fa-lg text-danger me-3\"></i> <strong>");
#nullable restore
#line 29 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
                                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                        <td><i class=\"fab fa-angular fa-lg text-danger me-3\"></i> <strong>");
#nullable restore
#line 30 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
                                                                                     Write(item.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
                       Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
                       Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 33 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
                       Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                        <td>
                            <div class=""dropdown"">
                                <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">
                                    <i class=""bx bx-plus""></i>
                                </button>
                                <div class=""dropdown-menu"">
                                    <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 1671, "\"", 1725, 2);
            WriteAttributeValue("", 1678, "/Admin/VisitorApi/UpdateVisitor/", 1678, 32, true);
#nullable restore
#line 41 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
WriteAttributeValue("", 1710, item.VisitorID, 1710, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-edit-alt me-1\"></i> Güncelle</a>\r\n                                    <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1837, "\"", 1891, 2);
            WriteAttributeValue("", 1844, "/Admin/VisitorApi/DeleteVisitor/", 1844, 32, true);
#nullable restore
#line 42 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
WriteAttributeValue("", 1876, item.VisitorID, 1876, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-trash me-1\"></i> Sil</a>\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 47 "C:\Users\LaraA\source\repos\TraversalCore\TraversalCoreProje\Areas\Admin\Views\VisitorApi\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <a href=\"/Admin/VisitorApi/AddVisitor/\" class=\"btn btn-outline-primary\">Yeni Ziyaretçi Oluştur!</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VisitorViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
