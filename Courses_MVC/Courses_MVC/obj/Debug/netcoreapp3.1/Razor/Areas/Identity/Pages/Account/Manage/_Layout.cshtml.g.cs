#pragma checksum "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\DoAn_CK_Framework.git\Courses_MVC\Courses_MVC\Areas\Identity\Pages\Account\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edb4e1e0a0b787540bd351e00dcf9ba8c6f82a01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage__Layout), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
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
#line 1 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\DoAn_CK_Framework.git\Courses_MVC\Courses_MVC\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\DoAn_CK_Framework.git\Courses_MVC\Courses_MVC\Areas\Identity\Pages\_ViewImports.cshtml"
using Courses_MVC.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\DoAn_CK_Framework.git\Courses_MVC\Courses_MVC\Areas\Identity\Pages\_ViewImports.cshtml"
using Courses_MVC.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\DoAn_CK_Framework.git\Courses_MVC\Courses_MVC\Areas\Identity\Pages\_ViewImports.cshtml"
using Courses_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\DoAn_CK_Framework.git\Courses_MVC\Courses_MVC\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Courses_MVC.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\DoAn_CK_Framework.git\Courses_MVC\Courses_MVC\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using Courses_MVC.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edb4e1e0a0b787540bd351e00dcf9ba8c6f82a01", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93b5197276cb7eb3d67015b9dc44784d93921a82", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"930cfff73a51cdb7a5f6574e88869a6017f557ce", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39f7aebf3e0fdc6f3f7a9063e9c2eb1306367a47", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ManageNav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\DoAn_CK_Framework.git\Courses_MVC\Courses_MVC\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
  
    if (ViewData.TryGetValue("ParentLayout", out var parentLayout))
    {
        Layout = (string)parentLayout;
    }
    else
    {
        Layout = "/Views/Shared/_Layout.cshtml";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-center mt-4\">Quản lý tài khoản</h2>\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 269, "\"", 277, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <h4 class=\"mb-2 text-center\">Thay đổi các thiết lập của tài khoản</h4>\r\n    <hr />\r\n    <div class=\"row offset-3 mb-5 mt-3\">\r\n        <div class=\"col-md-3\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "edb4e1e0a0b787540bd351e00dcf9ba8c6f82a016026", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            ");
#nullable restore
#line 22 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\DoAn_CK_Framework.git\Courses_MVC\Courses_MVC\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</divclass=\"offset-4\">\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 28 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\DoAn_CK_Framework.git\Courses_MVC\Courses_MVC\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
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
