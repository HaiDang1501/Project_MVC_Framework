<<<<<<< HEAD
#pragma checksum "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0723a602e84d5a261d35f2702dcc54883c69cad5"
=======
#pragma checksum "D:\Project_MVC_Framework\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_StatusMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0723a602e84d5a261d35f2702dcc54883c69cad5"
>>>>>>> e180fcc9ad6fcbaced5b7e91b9931304f2eb93d9
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Pages_User__StatusMessage), @"mvc.1.0.view", @"/Areas/Admin/Pages/User/_StatusMessage.cshtml")]
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
<<<<<<< HEAD
#line 1 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_ViewImports.cshtml"
=======
#line 1 "D:\Project_MVC_Framework\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_ViewImports.cshtml"
>>>>>>> e180fcc9ad6fcbaced5b7e91b9931304f2eb93d9
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_ViewImports.cshtml"
=======
#line 2 "D:\Project_MVC_Framework\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_ViewImports.cshtml"
>>>>>>> e180fcc9ad6fcbaced5b7e91b9931304f2eb93d9
using Courses_MVC.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 3 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_ViewImports.cshtml"
=======
#line 3 "D:\Project_MVC_Framework\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_ViewImports.cshtml"
>>>>>>> e180fcc9ad6fcbaced5b7e91b9931304f2eb93d9
using Courses_MVC.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 5 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_ViewImports.cshtml"
=======
#line 5 "D:\Project_MVC_Framework\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_ViewImports.cshtml"
>>>>>>> e180fcc9ad6fcbaced5b7e91b9931304f2eb93d9
using Courses_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 6 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_ViewImports.cshtml"
=======
#line 6 "D:\Project_MVC_Framework\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_ViewImports.cshtml"
>>>>>>> e180fcc9ad6fcbaced5b7e91b9931304f2eb93d9
using Courses_MVC.Areas.Admin.Pages.User;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0723a602e84d5a261d35f2702dcc54883c69cad5", @"/Areas/Admin/Pages/User/_StatusMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"202bb2fed95aad1a4ca619901127dcb5ebfd13bc", @"/Areas/Admin/Pages/User/_ViewImports.cshtml")]
    public class Areas_Admin_Pages_User__StatusMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
<<<<<<< HEAD
#line 3 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_StatusMessage.cshtml"
=======
#line 3 "D:\Project_MVC_Framework\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_StatusMessage.cshtml"
>>>>>>> e180fcc9ad6fcbaced5b7e91b9931304f2eb93d9
 if (!String.IsNullOrEmpty(Model))
{
    var statusMessageClass = Model.StartsWith("Error") ? "danger" : "success";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 144, "\"", 201, 4);
            WriteAttributeValue("", 152, "alert", 152, 5, true);
            WriteAttributeValue(" ", 157, "alert-", 158, 7, true);
#nullable restore
<<<<<<< HEAD
#line 6 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_StatusMessage.cshtml"
=======
#line 6 "D:\Project_MVC_Framework\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_StatusMessage.cshtml"
>>>>>>> e180fcc9ad6fcbaced5b7e91b9931304f2eb93d9
WriteAttributeValue("", 164, statusMessageClass, 164, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 183, "alert-dismissible", 184, 18, true);
            EndWriteAttribute();
            WriteLiteral(" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\r\n        ");
#nullable restore
<<<<<<< HEAD
#line 8 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_StatusMessage.cshtml"
=======
#line 8 "D:\Project_MVC_Framework\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_StatusMessage.cshtml"
>>>>>>> e180fcc9ad6fcbaced5b7e91b9931304f2eb93d9
   Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
<<<<<<< HEAD
#line 10 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_StatusMessage.cshtml"
=======
#line 10 "D:\Project_MVC_Framework\Courses_MVC\Courses_MVC\Areas\Admin\Pages\User\_StatusMessage.cshtml"
>>>>>>> e180fcc9ad6fcbaced5b7e91b9931304f2eb93d9
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
