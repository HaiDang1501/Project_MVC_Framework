#pragma checksum "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9b2c89cd518618e1c3958ee9ad3d5fa7c330acf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exercises_DetailsInUI), @"mvc.1.0.view", @"/Views/Exercises/DetailsInUI.cshtml")]
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
#line 1 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
using Courses_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9b2c89cd518618e1c3958ee9ad3d5fa7c330acf", @"/Views/Exercises/DetailsInUI.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a09356b26a7a236d388297b43c76deb5641d45", @"/Views/_ViewImports.cshtml")]
    public class Views_Exercises_DetailsInUI : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exercise>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/LessonDetail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AlertMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/ExerciseInUsers/SubmitExercise"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
  
    var listId = ViewBag.listIdExercise;
    var idcurrent = Model.exerciseId;
    var length = listId.Length;
    var idMin = listId[0].exerciseId;
    var idMax = listId[length - 1].exerciseId;
    var idPre = idcurrent - 1;
    var idNext = idcurrent + 1;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9b2c89cd518618e1c3958ee9ad3d5fa7c330acf8561", async() => {
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
            WriteLiteral("\r\n<div class=\"container col-9 container-custom mb-5\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9b2c89cd518618e1c3958ee9ad3d5fa7c330acf9736", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"lesson-title mt-4 p-4 pb-2 text-center \">");
#nullable restore
#line 20 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
                                                    Write(Model.exerciseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"lesson-info pb-2 pt-3 p-4\">\r\n        <div class=\"lesson-info-teacher\"><i class=\"fas fa-chalkboard-teacher\"></i><b>Tác giả:</b> ");
#nullable restore
#line 22 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
                                                                                             Write(Model.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"lesson-info-deadline\"><i class=\"fas fa-hourglass-start\">Deadline:</i> ");
#nullable restore
#line 23 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
                                                                                     Write(Model.deadline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n    <div class=\"lesson-content mb-3 pl-4 pr-4\">\r\n        <b>Nội dung:</b>\r\n        <p>\r\n            ");
#nullable restore
#line 28 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
       Write(Model.content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 29 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
       Write(UserManager.GetUserName(User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n        </p>\r\n    </div>\r\n    <div class=\"exercise-input mb-1 pl-4 pr-4\">\r\n        <b>Input:</b>\r\n        <p>");
#nullable restore
#line 36 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
      Write(Model.input);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"exercise-output mb-1 pl-4 pr-4\">\r\n        <b>Output:</b>\r\n        <p>");
#nullable restore
#line 40 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
      Write(Model.output);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 42 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"do-exercise mb-3 pl-4 pr-4\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9b2c89cd518618e1c3958ee9ad3d5fa7c330acf14438", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"exerciseId\"");
                BeginWriteAttribute("value", " value=\"", 1666, "\"", 1691, 1);
#nullable restore
#line 46 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 1674, Model.exerciseId, 1674, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />


                <label for=""place-do-exercise""><b>Làm bài tập:</b></label>
                <textarea name=""content""
                          id=""place-do-exercise""
                          cols=""30"" rows=""10"" placeholder=""Nhập bài làm của bạn""
                          class=""form-control""
                          required>

            </textarea>
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9b2c89cd518618e1c3958ee9ad3d5fa7c330acf15633", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 57 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <button class=\"btn btn-primary\" type=\"submit\">Nộp bài</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        </div>\r\n");
#nullable restore
#line 62 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9b2c89cd518618e1c3958ee9ad3d5fa7c330acf19071", async() => {
                WriteLiteral("Bạn cần phải đăng nhập mới có thể làm bài tập được");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 66 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"move-lesson p-4 pt-0\">\r\n\r\n");
#nullable restore
#line 70 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
         if (idPre == idMin - 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"next-lesson\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2601, "\"", 2647, 2);
            WriteAttributeValue("", 2608, "/lesson/LessonDetail?Id=", 2608, 24, true);
#nullable restore
#line 73 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 2632, Model.lessonId, 2632, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pre-lesson-btn\">Quay lại bài học</a>\r\n            </div>\r\n            <div class=\"pre-lesson\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2770, "\"", 2810, 2);
            WriteAttributeValue("", 2777, "/Exercises/DetailsInUI?Id=", 2777, 26, true);
#nullable restore
#line 76 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 2803, idNext, 2803, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pre-lesson-btn\">Kế tiếp</a>\r\n            </div>\r\n");
#nullable restore
#line 78 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
        }
        else if (idNext == idMax + 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"next-lesson\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2986, "\"", 3025, 2);
            WriteAttributeValue("", 2993, "/Exercises/DetailsInUI?Id=", 2993, 26, true);
#nullable restore
#line 82 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 3019, idPre, 3019, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pre-lesson-btn\">Quay lại</a>\r\n            </div>\r\n            <div class=\"next-lesson\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3141, "\"", 3187, 2);
            WriteAttributeValue("", 3148, "/lesson/LessonDetail?Id=", 3148, 24, true);
#nullable restore
#line 85 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 3172, Model.lessonId, 3172, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pre-lesson-btn\">Quay lại bài học</a>\r\n            </div>\r\n");
#nullable restore
#line 87 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"next-lesson\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3347, "\"", 3386, 2);
            WriteAttributeValue("", 3354, "/Exercises/DetailsInUI?Id=", 3354, 26, true);
#nullable restore
#line 91 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 3380, idPre, 3380, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pre-lesson-btn\">Quay lại</a>\r\n            </div>\r\n            <div class=\"pre-lesson\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 3501, "\"", 3541, 2);
            WriteAttributeValue("", 3508, "/Exercises/DetailsInUI?Id=", 3508, 26, true);
#nullable restore
#line 94 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
WriteAttributeValue("", 3534, idNext, 3534, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"pre-lesson-btn\">Kế tiếp</a>\r\n            </div>\r\n");
#nullable restore
#line 96 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\DetailsInUI.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exercise> Html { get; private set; }
    }
}
#pragma warning restore 1591
