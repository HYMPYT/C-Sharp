#pragma checksum "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9533dfdca3bb10b236f04b9bec1a433de10056f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manufacturer_Edit), @"mvc.1.0.view", @"/Views/Manufacturer/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9533dfdca3bb10b236f04b9bec1a433de10056f5", @"/Views/Manufacturer/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a61e6210ebf0d646d0609daf96e2897714fea589", @"/Views/_ViewImports.cshtml")]
    public class Views_Manufacturer_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreShop.Domain.Entities.Manufacturer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Edit.cshtml"
 using (Html.BeginForm("Edit","Manufacturer",Model,FormMethod.Post,true,new {@class = "form justify-content-center"}))
{
    
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Edit.cshtml"
                            ;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group row\"  >\n        ");
#nullable restore
#line 9 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Edit.cshtml"
   Write(Html.LabelFor(Model=>Model.ManufacturerId, new {@class = "control-label col-md-4"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div>\n            ");
#nullable restore
#line 11 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Edit.cshtml"
       Write(Html.DisplayFor(Model=>Model.ManufacturerId, new {@class ="form-control col"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n");
            WriteLiteral("    <div class=\"form-group row\" >\n        ");
#nullable restore
#line 16 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Edit.cshtml"
   Write(Html.LabelFor(Model=>Model.ManufacturerName, new {@class = "control-label col-md-4"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n        <div>\n            ");
#nullable restore
#line 18 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Edit.cshtml"
       Write(Html.EditorFor(Model=>Model.ManufacturerName, new {@class ="form-control col"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 19 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Edit.cshtml"
       Write(Html.ValidationMessageFor(Model=>Model.ManufacturerName,"", new {@class = "text-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n");
            WriteLiteral("    <div class=\"form-actions\">\n        <input type=\"submit\" value=\"Save\" class=\"btn btn-large btn-primary\">\n        ");
#nullable restore
#line 25 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Edit.cshtml"
   Write(Html.ActionLink("Cancel","Index","Manufacturer",new{}, new{@class="btn btn-large btn-secondary"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 27 "C:\Users\Evgeniy\Desktop\ASP.NET\Домашня робота №9\CoreShop\CoreShop.WebUI\Views\Manufacturer\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreShop.Domain.Entities.Manufacturer> Html { get; private set; }
    }
}
#pragma warning restore 1591
