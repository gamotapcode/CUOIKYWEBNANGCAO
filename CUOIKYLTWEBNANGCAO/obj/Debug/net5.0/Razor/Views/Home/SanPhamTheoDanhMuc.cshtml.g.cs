#pragma checksum "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ff297e87cbdb8483e235da3fece5f97e79ee711c4100a8bf24436c6570e4ef22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SanPhamTheoDanhMuc), @"mvc.1.0.view", @"/Views/Home/SanPhamTheoDanhMuc.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\_ViewImports.cshtml"
using CUOIKYLTWEBNANGCAO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\_ViewImports.cshtml"
using CUOIKYLTWEBNANGCAO.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ff297e87cbdb8483e235da3fece5f97e79ee711c4100a8bf24436c6570e4ef22", @"/Views/Home/SanPhamTheoDanhMuc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"859147c92b50923758b8f48d650a393f32e044a5741f33d94c24ccbf4cd439f3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_SanPhamTheoDanhMuc : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<TbSanpham>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
  
    ViewData["Title"] =ViewBag.tendm;
    Layout = "~/Views/Shared/_LayoutHome.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-lg-3 col-md-4 col-sm-6 mix vegetables fastfood\">\r\n        <div class=\"featured__item\">\r\n            <div class=\"featured__item__pic set-bg\" data-setbg=\"../ImageProducts/");
#nullable restore
#line 13 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
                                                                            Write(item.Hinhanh);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                <ul class=\"featured__item__pic__hover\">\r\n                    <li><a href=\"#\"><i class=\"fa fa-heart\"></i></a></li>\r\n                    <li><a href=\"#\"><i class=\"fa fa-retweet\"></i></a></li>\r\n                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff297e87cbdb8483e235da3fece5f97e79ee711c4100a8bf24436c6570e4ef225485", async() => {
                WriteLiteral("<i class=\"fa fa-shopping-cart\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
                                                                          WriteLiteral(item.Masanpham);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"featured__item__text\">\r\n                <h6><a href=\"#\">");
#nullable restore
#line 21 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
                           Write(item.Tensanpham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                <h5>$");
#nullable restore
#line 22 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
                Write(item.Dongia);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"product__pagination\" style=\"flex: 0 0 100%;\">\r\n    ");
#nullable restore
#line 29 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Home\SanPhamTheoDanhMuc.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("sanphamtheodanhmuc", new { madm=ViewBag.madm ,page = page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<style>\r\n    .pagination {\r\n        justify-content: center;\r\n    }\r\n</style>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<TbSanpham>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
