#pragma checksum "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4ae209cb10f899c894ed37dbb295054bc938acaf8ec7b5d49a7d92788673fff2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4ae209cb10f899c894ed37dbb295054bc938acaf8ec7b5d49a7d92788673fff2", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"859147c92b50923758b8f48d650a393f32e044a5741f33d94c24ccbf4cd439f3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CartItem>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutHome.cshtml";
    decimal TongTien = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""shoping-cart spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""shoping__cart__table"">
                    <table>
                        <thead>
                            <tr>
                                <th class=""shoping__product"">Products</th>
                                <th>Price</th>
                                <th>Quantity</th>
                                <th>Total</th>
                                <th></th>
                            </tr>
                        </thead>

                        <tbody>
");
#nullable restore
#line 25 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml"
                             foreach(var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td class=\"shoping__cart__item\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4ae209cb10f899c894ed37dbb295054bc938acaf8ec7b5d49a7d92788673fff26058", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1045, "~/ImageProducts/", 1045, 16, true);
#nullable restore
#line 29 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 1061, item.Hinhanh, 1061, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 1081, item.TenSanPham, 1081, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        <h5>");
#nullable restore
#line 30 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml"
                                       Write(item.TenSanPham);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    </td>\r\n                                    <td class=\"shoping__cart__price\">\r\n                                        $");
#nullable restore
#line 33 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml"
                                    Write(item.DonGia);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </td>
                                    <td class=""shoping__cart__quantity"">
                                        <div class=""quantity"">
                                            <div class=""pro-qty"">
                                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 1651, "\"", 1672, 1);
#nullable restore
#line 38 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1659, item.SoLuong, 1659, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            </div>
                                        </div>
                                    </td>
                                    <td class=""shoping__cart__total"">
                                        $");
#nullable restore
#line 43 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml"
                                    Write(item.ThanhTien);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td class=\"shoping__cart__item__close\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ae209cb10f899c894ed37dbb295054bc938acaf8ec7b5d49a7d92788673fff210152", async() => {
                WriteLiteral("\r\n                                            <span class=\"icon_close\"></span>\r\n                                        ");
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
#line 46 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml"
                                                                                               WriteLiteral(item.IdSanPham);

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
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 51 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>

                    </table>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""shoping__cart__btns"">
                    <a");
            BeginWriteAttribute("href", " href=\"", 2694, "\"", 2729, 1);
#nullable restore
#line 61 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2701, Url.Action("Index", "Home"), 2701, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""primary-btn cart-btn"">CONTINUE SHOPPING</a>
                    <a href=""#"" class=""primary-btn cart-btn cart-btn-right"">
                        <span class=""icon_loading""></span>
                        Update Cart
                    </a>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""shoping__continue"">
                    <div class=""shoping__discount"">
                        <h5>Discount Codes</h5>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ae209cb10f899c894ed37dbb295054bc938acaf8ec7b5d49a7d92788673fff214209", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Enter your coupon code\">\r\n                            <button type=\"submit\" class=\"site-btn\">APPLY COUPON</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6\">\r\n                <div class=\"shoping__checkout\">\r\n                    <h5>Cart Total</h5>\r\n                    <ul>\r\n");
#nullable restore
#line 83 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml"
                         foreach(var item in Model)
                        {
                            TongTien += item.ThanhTien;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>Total <span>$");
#nullable restore
#line 87 "C:\Users\PhucDo\Desktop\CUOIKYWEBNANGCAO\CUOIKYLTWEBNANGCAO\Views\Cart\Index.cshtml"
                                    Write(TongTien);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    </ul>\r\n                    <a href=\"#\" class=\"primary-btn\">PROCEED TO CHECKOUT</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CartItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
