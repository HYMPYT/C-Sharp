#pragma checksum "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b93fc8b75b3d9d9ba998193939e8b51a2fcedae8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manufacturer_Index), @"mvc.1.0.view", @"/Views/Manufacturer/Index.cshtml")]
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
#line 1 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\_ViewImports.cshtml"
using CoreShop.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\_ViewImports.cshtml"
using CoreShop.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b93fc8b75b3d9d9ba998193939e8b51a2fcedae8", @"/Views/Manufacturer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a61e6210ebf0d646d0609daf96e2897714fea589", @"/Views/_ViewImports.cshtml")]
    public class Views_Manufacturer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreShop.Domain.Entities.Manufacturer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Index.cshtml"
  
    ViewData["Title"] = "Manufacturer";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center Message alert-info rounded\">");
#nullable restore
#line 7 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Index.cshtml"
                                               Write(TempData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
#nullable restore
#line 9 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Index.cshtml"
Write(Html.ActionLink("Create new","CreateNew","Manufacturer",new {},new {@class="btn btn-large btn-info m-2"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"table-responsive\">\n<table class=\"table\">\n    <thead class=\"thead-dark\">\n        <tr>\n            <th>Id</th>\n            <th>Title</th>\n            <th>Action</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 21 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 24 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Index.cshtml"
               Write(item.ManufacturerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 25 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Index.cshtml"
               Write(item.ManufacturerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    ");
#nullable restore
#line 27 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Index.cshtml"
               Write(Html.ActionLink("Edit","Edit","Manufacturer",new {id=item.ManufacturerId},new {@class="btn btn-large btn-warning"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 28 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Index.cshtml"
                     using (Html.BeginForm("Remove","Manufacturer",new {id=item.ManufacturerId},FormMethod.Post,false,new { @class="d-inline"})){

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <input type=\"submit\" value=\"Remove\" class=\"btn btn-large btn-danger d-inline\">\n");
#nullable restore
#line 30 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\n            </tr>\n");
#nullable restore
#line 33 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n</div>     ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreShop.Domain.Entities.Manufacturer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
