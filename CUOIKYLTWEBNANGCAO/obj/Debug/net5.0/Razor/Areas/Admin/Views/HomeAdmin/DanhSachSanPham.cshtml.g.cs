#pragma checksum "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51b2abcf25506110a0610215f0bf35d70273a332"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HomeAdmin_DanhSachSanPham), @"mvc.1.0.view", @"/Areas/Admin/Views/HomeAdmin/DanhSachSanPham.cshtml")]
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
#line 1 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
using CUOIKYLTWEBNANGCAO.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51b2abcf25506110a0610215f0bf35d70273a332", @"/Areas/Admin/Views/HomeAdmin/DanhSachSanPham.cshtml")]
    public class Areas_Admin_Views_HomeAdmin_DanhSachSanPham : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<TbSanpham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThemSanPham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SuaSanPham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "XoaSanPham", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
  
    ViewData["Title"] = "Quản lý sản phẩm";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Quản lý sản phẩm</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51b2abcf25506110a0610215f0bf35d70273a3324399", async() => {
                WriteLiteral("Thêm mới sản phẩm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<p>");
#nullable restore
#line 16 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
Write(TempData["Messages"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Tên sản phẩm
            </th>
            <th>
                Đơn giá
            </th>
            <th>
                Số lượng
            </th>
            <th>
                Hình ảnh
            </th>
            <th>
                Mô tả
            </th>
            <th>
                Tên danh mục
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 42 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tensanpham));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
               Write(Html.DisplayFor(modelItem => item.Dongia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 52 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
               Write(Html.DisplayFor(modelItem => item.Soluong));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td  style=\"text-align: center;\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1376, "\"", 1429, 1);
#nullable restore
#line 55 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
WriteAttributeValue("", 1382, Url.Content("~/ImageProducts/" + item.Hinhanh), 1382, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1430, "\"", 1449, 1);
#nullable restore
#line 55 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
WriteAttributeValue("", 1436, item.Hinhanh, 1436, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1450, "\"", 1471, 1);
#nullable restore
#line 55 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
WriteAttributeValue("", 1458, item.Hinhanh, 1458, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"50\" height=\"50\" />\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 58 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 61 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
               Write(Html.DisplayFor(modelItem => item.MadanhmucNavigation.Tendanhmuc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51b2abcf25506110a0610215f0bf35d70273a3329691", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-masanpham", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
                                                        WriteLiteral(item.Masanpham);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["masanpham"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-masanpham", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["masanpham"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51b2abcf25506110a0610215f0bf35d70273a33211931", async() => {
                WriteLiteral("Xoá");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-masanpham", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
                                                        WriteLiteral(item.Masanpham);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["masanpham"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-masanpham", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["masanpham"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 68 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div class=\"product__pagination\" style=\"flex: 0 0 100%;\">\r\n    ");
#nullable restore
#line 72 "D:\TAILIEU\CUOIKYLTWEBNANGCAO\CUOIKYLTWEBNANGCAO\Areas\Admin\Views\HomeAdmin\DanhSachSanPham.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("DanhSachSanPham", new { page = page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<style>\r\n    .pagination {\r\n        justify-content: center;\r\n    }\r\n</style>\r\n");
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
