#pragma checksum "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93aec2ee4b82486f0446a9939fca429ed7f7eeb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_CartDisplay), @"mvc.1.0.view", @"/Views/Courses/CartDisplay.cshtml")]
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
#line 1 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
using Courses_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
using Courses_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
using System.Collections;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93aec2ee4b82486f0446a9939fca429ed7f7eeb9", @"/Views/Courses/CartDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a09356b26a7a236d388297b43c76deb5641d45", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_CartDisplay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Courses_MVC.Models.CarItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/CartDisplay.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#exampleModalCenter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Register/ConfirmCart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
  
    ViewData["Title"] = "Giỏ hàng";


#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "93aec2ee4b82486f0446a9939fca429ed7f7eeb97097", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h2 class=\"cart-header\">GIỎ HÀNG</h2>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
 if (Model.Count > 0)
{
    decimal total = 0;
    int stt = 1;
    int sttmodel = 1;
    List<int> list = new List<int>();
    foreach (var i in Model)
    {
        list.Add(i.Course.courseId);
    }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""cart-container container-fluid "">

        <div class=""table-course p-4 m-2"">
            <div class=""clear mb-2 "">
                <a href=""/Courses/ClearCartAll""
                   class=""btn btn-danger "">Xóa tất cả </a>
            </div>
            <table class=""table table-main"">
                <tr>
                    <th>STT</th>
                    <th>Sản phẩm</th>
                    <th>Giá</th>
                    <th>Số lượng</th>
                    <th>Thành tiền</th>
                    <th></th>
                </tr>
");
#nullable restore
#line 38 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                 foreach (var cartitem in Model)
                {
                    var thanhtien = cartitem.Quantity * cartitem.Course.originalPrice;
                    total += thanhtien;



#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 45 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                        Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 46 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                       Write(cartitem.Course.courseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 47 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                        Write(cartitem.Course.originalPrice.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 48 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                       Write(cartitem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 49 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                        Write(thanhtien.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1592, "\"", 1653, 2);
            WriteAttributeValue("", 1599, "/Courses/DeleteCart?courseId=", 1599, 29, true);
#nullable restore
#line 51 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
WriteAttributeValue("", 1628, cartitem.Course.courseId, 1628, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                               class=\"remove-cart-item\"><i class=\"far fa-trash-alt\"></i></a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td colspan=\"4\" class=\"text-right total\"><i class=\"fas fa-dollar-sign\"></i>Tổng tiền</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                    Write(total.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                    <td></td>
                </tr>
                <tr>
                    <td colspan=""6 "" class=""cart-option"">

                        <a href=""/Courses/DanhSachHienThi""
                           class=""btn btn-secondary"">Tiếp tục xem</a>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93aec2ee4b82486f0446a9939fca429ed7f7eeb913651", async() => {
                WriteLiteral("Thanh toán");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header modal-header-custom"">
                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Thanh toán</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <table class=""table table-main"">
                        <tr>
                            <th>STT</th>
                            <th>Sản phẩm</th>
                            <th>Giá</th>
                            <th>Số lượng</th>
                            <th>Thành tiền</th>
                       ");
            WriteLiteral("     <th></th>\r\n                        </tr>\r\n");
#nullable restore
#line 96 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                         foreach (var cartitem in Model)
                        {
                            var thanhtien = cartitem.Quantity * cartitem.Course.originalPrice;
                            total += thanhtien;



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 103 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                                Write(sttmodel++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 104 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                               Write(cartitem.Course.courseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 105 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                                Write(cartitem.Course.originalPrice.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 106 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                               Write(cartitem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 107 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                                Write(thanhtien.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 110 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"4\" class=\"text-right total\"><i class=\"fas fa-dollar-sign\"></i>Tổng tiền</td>\r\n                            <td>");
#nullable restore
#line 113 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                            Write(total.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                            <td></td>
                        </tr>
                    </table>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Trở về</button>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93aec2ee4b82486f0446a9939fca429ed7f7eeb920081", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 121 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                         foreach (var item in list)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <input type=\"hidden\" name=\"courseId\"");
                BeginWriteAttribute("value", " value=\"", 5030, "\"", 5043, 1);
#nullable restore
#line 123 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
WriteAttributeValue("", 5038, item, 5038, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 124 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-primary\">Xác nhận</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    \r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 132 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-body cart"">
                        <div class=""col-sm-12 empty-cart-cls text-center"">
                            <img src=""https://i.imgur.com/dCdflKN.png"" width=""130"" height=""130"" class=""img-fluid mb-4 mr-3"">
                            <h3><strong>Giỏ hàng trống</strong></h3>
                            <a href=""/Courses/DanhSachHienThi"" class=""btn btn-primary cart-btn-transform m-3"" data-abc=""true"">Trờ về</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 150 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Courses\CartDisplay.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Courses_MVC.Models.CarItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
