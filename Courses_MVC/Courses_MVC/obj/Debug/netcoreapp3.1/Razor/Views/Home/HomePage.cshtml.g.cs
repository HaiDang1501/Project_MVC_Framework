#pragma checksum "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Home\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3442601f32ac53f280ea44c414bd9722f9f8dd9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HomePage), @"mvc.1.0.view", @"/Views/Home/HomePage.cshtml")]
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
#line 1 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
using Courses_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
using Courses_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Home\HomePage.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3442601f32ac53f280ea44c414bd9722f9f8dd9a", @"/Views/Home/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a09356b26a7a236d388297b43c76deb5641d45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("Banner-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DanhSachHienThi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Home\HomePage.cshtml"
  

    ViewData["Title"] = "Quản lý khóa học";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3442601f32ac53f280ea44c414bd9722f9f8dd9a5345", async() => {
                WriteLiteral(@"
    <div class=""intro-web"">
        <h2 class=""title-section"">Giới thiệu web DDG</h2>
        <div class=""intro"">
            <div class=""intro-left col-6"">
                <img src=""https://codelearn.io/Themes/TheCodeCampPro/Resources/Images/landing-v2/chia-khoa-lap-trinh.png"" class=""future-img"" alt=""Giới thiệu sơ lược về DDG"" />
            </div>

            <div class=""intro-right "">
                <ul class=""list-key-futures"">
                    <li>
                        <div class=""heading-key"">

                            <h3><i class=""fas fa-graduation-cap intro-icon""></i>   Nơi tỏa sức đam mê học tập</h3>
                        </div>

                        <p class=""key-des"">
                            Trang web này là nơi chúng tôi tạo ra các bài học bổ ích .
                            Tại đây, bạn thỏa sức sáng tạo các sản phẩm dựa trên các bài học.
                        </p>
                    </li>

                    <li>
                        <div clas");
                WriteLiteral(@"s=""heading-key"">

                            <h3><i class=""fas fa-laptop-code intro-icon""></i>   Định hướng nghề nghiệp</h3>
                        </div>

                        <p class=""key-des"">
                            Học lập trình giúp bạn có được những kiến thức tốt nhất để làm quen với thế giới công nghệ,
                            thích nghi với cuộc sống thời đại 4.0.
                        </p>
                    </li>

                    <li>
                        <div class=""heading-key"">

                            <h3><i class=""far fa-handshake intro-icon""></i>   Sẻ chia kinh nghiệm lập trình</h3>
                        </div>

                        <p class=""key-des"">
                            Kỹ năng lập trình có xu hướng đa dạng hơn phục vụ cho nhu cầu phát triển của mọi ngành nghề.
                            DDG đồng hành cùng bạn để chia sẻ, làm giàu thêm kinh nghiệm lập trình.
                        </p>
                    </li>

              ");
                WriteLiteral(@"  </ul>
            </div>
        </div>
    </div>
    <div class=""our-statistic"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-4"">
                <div class=""wrap-statistic-content"">
                    <div class=""statistic-number"">
                        <span class=""counter"">5</span> +
                    </div>

                    <h3 class=""statistic-title"">Thành viên đăng ký</h3>
                </div>
            </div>
            <div class=""col-xs-12 col-sm-4"">
                <div class=""wrap-statistic-content"">
                    <div class=""statistic-number"">
                        <span class=""counter"">15</span> +
                    </div>

                    <h3 class=""statistic-title"">Bài học luyện tập</h3>
                </div>
            </div>


            <div class=""col-xs-12 col-sm-4"">
                <div class=""wrap-statistic-content"">
                    <div class=""statistic-number"">
                        <span class=""");
                WriteLiteral("counter\">3</span> +\r\n                    </div>\r\n\r\n                    <h3 class=\"statistic-title\">Nhân viên hỗ trợ</h3>\r\n                </div>\r\n            </div>\r\n\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
                WriteLiteral(@"    <div class='roadmap-container'>
        <h2 class='roadmap-title'>Lộ trình để trở thành<br />Lập Trình Viên</h2>
        <div class='roadmap-row'>
            <div to='/' class='roadmap-step'>
                <div class='roadmap-step-img'>
                    <span class='roadmap-label-step'>1</span>
                    <img src='https://codelearn.io/Themes/TheCodeCampPro/Resources/Images/landing-v2/hoc-lap-trinh.png' alt='Learn to code' />
                </div>
                <h3 class='roadmap-step-title'>Học lập trình</h3>
                <p class='roadmap-step-des'>Học lập trình từ cơ bản đến nâng cao qua các khóa học.</p>
            </div>

            <div to='/' class='roadmap-step'>
                <div class='roadmap-step-img'>
                    <span class='roadmap-label-step'>2</span>
                    <img src='https://codelearn.io/Themes/TheCodeCampPro/Resources/Images/landing-v2/luyen-lap-trinh.png' alt='Practice coding' />
                </div>
                <h3 c");
                WriteLiteral(@"lass='roadmap-step-title'>Luyện kỹ năng</h3>
                <p class='roadmap-step-des'>Luyện tập lập trình hàng ngày cùng với chuyên mục luyện tập.</p>
            </div>

            <div to='/blogs' class='roadmap-step'>
                <div class='roadmap-step-img'>
                    <span class='roadmap-label-step'>3</span>
                    <img src='https://codelearn.io/Themes/TheCodeCampPro/Resources/Images/landing-v2/thi-lap-trinh.png' alt='Share' />
                </div>
                <h3 class='roadmap-step-title'>Tìm hiểu thêm</h3>
                <p class='roadmap-step-des'>Tìm hiểu kỹ năng lập trình thông qua chia sẻ từ mọi người.</p>
            </div>
        </div>
    </div>
");
                WriteLiteral(@"    <div id=""Slider"">
        <div class=""Slider-title"">
            <h2>Học viên nói gì về DDG?</h2>
        </div>
        <div class=""Slider-main"">
            <div class=""Slide"">
                <div class=""Slider-item-avt"">
                </div>
                <p class=""Slider-item-name"">Khánh Duy</p>
                <p class=""Slider-item-job"">Sinh viên</p>
                <p class=""Slider-item-think"">""Thật tuyệt vời""</p>
            </div>
            <div class=""Slide"">
                <div class=""Slider-item-avt"">
                </div>
                <p class=""Slider-item-name"">Hải Đăng</p>
                <p class=""Slider-item-job"">Sinh viên</p>
                <p class=""Slider-item-think"">""Trên cả mong đợi""</p>
            </div>
            <div class=""Slide"">
                <div class=""Slider-item-avt"">
                </div>
                <p class=""Slider-item-name"">Hoàng Giang</p>
                <p class=""Slider-item-job"">Sinh viên</p>
                <p class=""");
                WriteLiteral("Slider-item-think\">\"Xuất sắc\"</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                WriteLiteral("<div class=\"Banner\">\r\n    <div class=\"Banner-content\">\r\n        <p class=\"title\">HIỆN THỰC ĐAM MÊ <span>LẬP TRÌNH</span>!</p>\r\n        <p class=\"content\">Đăng ký tài khoản và tham gia ngay hôm nay</p>\r\n    </div>\r\n");
#nullable restore
#line 161 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Home\HomePage.cshtml"
     if (!SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"Banner-button\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3442601f32ac53f280ea44c414bd9722f9f8dd9a12723", async() => {
                    WriteLiteral("Bắt đầu ngay!");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 166 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Home\HomePage.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"Banner-button\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3442601f32ac53f280ea44c414bd9722f9f8dd9a14570", async() => {
                    WriteLiteral("Bắt đầu ngay!");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 172 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Home\HomePage.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n    const active_lienhe = document.querySelector(\'#navbar-trangchu\')\r\n\r\n    active_lienhe.classList.add(\'nav--active\')\r\n    /*document.querySelector(\'#active--khoahoc\').classList.remove(\'active--css\')*/\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; }
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
