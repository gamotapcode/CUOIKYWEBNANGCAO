#pragma checksum "D:\TAILIEU\WebProjects\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9af6b75012639528642e94b92b1ce76c5432ad4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SanPhamTheoDanhMuc), @"mvc.1.0.view", @"/Views/Home/SanPhamTheoDanhMuc.cshtml")]
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
#line 1 "D:\TAILIEU\WebProjects\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\_ViewImports.cshtml"
using CUOIKYLTWEBNANGCAO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TAILIEU\WebProjects\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\_ViewImports.cshtml"
using CUOIKYLTWEBNANGCAO.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\TAILIEU\WebProjects\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9af6b75012639528642e94b92b1ce76c5432ad4b", @"/Views/Home/SanPhamTheoDanhMuc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67419b20895bd731eed0cb383560db772ef484ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SanPhamTheoDanhMuc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<TbSanpham>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\TAILIEU\WebProjects\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
  
    ViewData["Title"] =ViewBag.tendm;
    Layout = "~/Views/Shared/_LayoutHome.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "D:\TAILIEU\WebProjects\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-3 col-md-4 col-sm-6 mix vegetables fastfood\">\r\n        <div class=\"featured__item\">\r\n            <div class=\"featured__item__pic set-bg\" data-setbg=\"../ImageProducts/");
#nullable restore
#line 13 "D:\TAILIEU\WebProjects\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
                                                                            Write(item.Hinhanh);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                <ul class=""featured__item__pic__hover"">
                    <li><a href=""#""><i class=""fa fa-heart""></i></a></li>
                    <li><a href=""#""><i class=""fa fa-retweet""></i></a></li>
                    <li><a href=""#""><i class=""fa fa-shopping-cart""></i></a></li>
                </ul>
            </div>
            <div class=""featured__item__text"">
                <h6><a href=""#"">");
#nullable restore
#line 21 "D:\TAILIEU\WebProjects\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
                           Write(item.Tensanpham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                <h5>$");
#nullable restore
#line 22 "D:\TAILIEU\WebProjects\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
                Write(item.Dongia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 26 "D:\TAILIEU\WebProjects\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"product__pagination\" style=\"flex: 0 0 100%;\">\r\n    ");
#nullable restore
#line 29 "D:\TAILIEU\WebProjects\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("sanphamtheodanhmuc", new { madm=ViewBag.madm ,page = page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<style>\r\n    .pagination {\r\n        justify-content: center;\r\n    }\r\n</style>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<TbSanpham>> Html { get; private set; }
    }
}
#pragma warning restore 1591