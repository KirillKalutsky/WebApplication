#pragma checksum "C:\Users\Asus\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aba16ccfc0bcdef589301ddeb21897b3989ee5e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Asus\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\source\repos\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aba16ccfc0bcdef589301ddeb21897b3989ee5e7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Asus\source\repos\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Crime Analysis";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""header"" class=""sidenav"">
    <a href=""javascript:void(0)"" class=""closebtn"" onclick=""closeNav()"">&times;</a>
    <div class=""top"">
        <div id=""content_item"">
            <h1 class=""header1 districtName""></h1>
        </div>

        <div id=""content_entry"">

            <div id=""show_btn"">
                <h4 onclick=""openNav()"">Развернуть →</h4>
            </div>
            <h3 class=""header1"">Список происшествий</h3>

            <table class=""districtEvents"">
            </table>


        </div>
    </div>
</div>

<!-- Main -->
<div id=""main"">

    <div class=""map-image"">
        <img src=""/RedZone/images/Ekb_all_districts_2-01.jpg"" style=""display: block; width: 100%;""");
            BeginWriteAttribute("alt", " alt=\"", 774, "\"", 780, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
        <!--					Железнодорожный-->
        <a onclick=""openDistrict('железнодорожный')"" style=""top: 22%; left: 35%; ""><div class=""circle""></div></a>
        <!--					Орджоникидзевский-->
        <a onclick=""openDistrict('орджоникидзевский')"" style=""top: 17.5%; left: 60.1%; ""><div class=""circle""></div></a>
        <!--					Кировский-->
        <a onclick=""openDistrict('кировский')"" style=""top: 36%; left: 69%; ""><div class=""circle""></div></a>
        <!--					Октябрьский-->
        <a onclick=""openDistrict('октябрьский')"" style=""top: 55%; left: 69%; ""><div class=""circle""></div></a>
        <!--					Чкаловский-->
        <a onclick=""openDistrict('чкаловский')"" style=""top: 74%; left: 52%; ""><div class=""circle""></div></a>
        <!--					Ленинский-->
        <a onclick=""openDistrict('ленинский')"" style=""top: 54%; left: 49%; ""><div class=""circle""></div></a>
        <!--					Верх-Исетский-->
        <a onclick=""openDistrict('верх-исетский')"" style=""top: 46%; left: 37%; ""><div class=""circle""></div");
            WriteLiteral("></a>\r\n        <!--\t\t\t\t\tАкадемический-->\r\n        <a onclick=\"openDistrict(\'академический\')\" style=\"top: 65%; left: 24%; \"><div class=\"circle\"></div></a>\r\n\r\n\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591