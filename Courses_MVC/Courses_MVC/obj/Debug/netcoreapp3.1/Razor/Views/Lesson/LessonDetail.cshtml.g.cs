<<<<<<< HEAD
#pragma checksum "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4280082d96309e2e288f8b03397471d3c9ef11ff"
=======
#pragma checksum "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "329e34b703d1c30c3f6624bf5bbb218f679dc4d7"
>>>>>>> 7b98e23d37dd55a288a001340feb0a9554a90a4c
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lesson_LessonDetail), @"mvc.1.0.view", @"/Views/Lesson/LessonDetail.cshtml")]
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
#line 1 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
>>>>>>> 7b98e23d37dd55a288a001340feb0a9554a90a4c
using Courses_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\_ViewImports.cshtml"
>>>>>>> 7b98e23d37dd55a288a001340feb0a9554a90a4c
using Courses_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"329e34b703d1c30c3f6624bf5bbb218f679dc4d7", @"/Views/Lesson/LessonDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a09356b26a7a236d388297b43c76deb5641d45", @"/Views/_ViewImports.cshtml")]
    public class Views_Lesson_LessonDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lesson>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/LessonDetail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
   

    var id = Model.lessonId;
    int idLastlesson = Convert.ToInt32(ViewBag.listExercise);
    int idmax = idLastlesson + 1;
    var idNext = id + 1;
    var idPre = id - 1;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "329e34b703d1c30c3f6624bf5bbb218f679dc4d74659", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "329e34b703d1c30c3f6624bf5bbb218f679dc4d75773", async() => {
                WriteLiteral("\r\n    <p>");
#nullable restore
#line 13 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
  Write(idmax);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <div class=\"container col-9 container-custom mb-5\">\r\n        <div class=\"lesson-title mt-4 p-4 pb-2 text-center\">");
#nullable restore
#line 15 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
                                                       Write(Model.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <div class=\"lesson-des pb-1 pt-3 p-4\">\r\n            <b>Mô tả:</b>\r\n            <p>");
#nullable restore
#line 18 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
          Write(Model.description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"lesson-content mb-3 p-4 pb-2\">\r\n            <b>Nội dung:</b>\r\n            <p>\r\n                ");
#nullable restore
#line 23 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
           Write(Model.content);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"lesson-exercise p-4 pt-0 pb-3\">\r\n            <b> <i class=\"fas fa-chalkboard\"></i> Bài tập</b>\r\n");
#nullable restore
#line 28 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
             foreach (var item in ViewBag.listExercise)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <ol>\r\n                        <i class=\"fas fa-pencil-alt\"></i>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1021, "\"", 1028, 0);
                EndWriteAttribute();
                WriteLiteral(">Bài tâp ");
#nullable restore
#line 32 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
                                      Write(item.exerciseId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                    </ol>\r\n");
#nullable restore
#line 34 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n        <div class=\"move-lesson p-4 pt-0\">\r\n");
#nullable restore
#line 38 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
              
                if (idPre == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"pre-lesson\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1304, "\"", 1342, 2);
                WriteAttributeValue("", 1311, "/lesson/LessonDetail?Id=", 1311, 24, true);
#nullable restore
#line 42 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
WriteAttributeValue("", 1335, idNext, 1335, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"pre-lesson-btn\">Tiếp theo</a>\r\n                    </div>\r\n");
#nullable restore
#line 44 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
                }
                else if (idNext == idmax)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"next-lesson\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1564, "\"", 1601, 2);
                WriteAttributeValue("", 1571, "/lesson/LessonDetail?Id=", 1571, 24, true);
#nullable restore
#line 48 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
WriteAttributeValue("", 1595, idPre, 1595, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"pre-lesson-btn\">Quay lại</a>\r\n                    </div>\r\n");
#nullable restore
#line 50 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                     <div class=\"pre-lesson\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1801, "\"", 1839, 2);
                WriteAttributeValue("", 1808, "/lesson/LessonDetail?Id=", 1808, 24, true);
#nullable restore
#line 54 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
WriteAttributeValue("", 1832, idNext, 1832, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"pre-lesson-btn\">Tiếp theo</a>\r\n                    </div>\r\n                    <div class=\"next-lesson\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1980, "\"", 2017, 2);
                WriteAttributeValue("", 1987, "/lesson/LessonDetail?Id=", 1987, 24, true);
#nullable restore
<<<<<<< HEAD
#line 8 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
Write(Model.title);
=======
#line 57 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
WriteAttributeValue("", 2011, idPre, 2011, 6, false);
>>>>>>> 7b98e23d37dd55a288a001340feb0a9554a90a4c

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"pre-lesson-btn\">Quay lại</a>\r\n                    </div>\r\n");
#nullable restore
<<<<<<< HEAD
#line 9 "D:\Xây dựng HTTT trên các framework\Báo cáo đồ án\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
Write(Model.content);
=======
#line 59 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework\Courses_MVC\Courses_MVC\Views\Lesson\LessonDetail.cshtml"
                }
            
>>>>>>> 7b98e23d37dd55a288a001340feb0a9554a90a4c

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lesson> Html { get; private set; }
    }
}
#pragma warning restore 1591
