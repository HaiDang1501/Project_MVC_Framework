#pragma checksum "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce3b04b3a754b9c76de57e1d856ab99e6fb3ece6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lesson_LessonCourse), @"mvc.1.0.view", @"/Views/Lesson/LessonCourse.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce3b04b3a754b9c76de57e1d856ab99e6fb3ece6", @"/Views/Lesson/LessonCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a09356b26a7a236d388297b43c76deb5641d45", @"/Views/_ViewImports.cshtml")]
    public class Views_Lesson_LessonCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Courses_MVC.Models.Lesson>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AlertMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/CourseDetail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThemBinhLuan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-10 mt-4 offset-1 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
  
    ViewData["Title"] = "Khóa học";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
  


    var listLesson = Model.ToArray();

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce3b04b3a754b9c76de57e1d856ab99e6fb3ece66849", async() => {
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
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"

    var courseNama = listLesson[0].Course.courseName;
    var courseDes = listLesson[0].Course.discription;
    var coursePrice = listLesson[0].Course.price;
    var courseTime = listLesson[0].Course.totalTime;
    var courseCount = listLesson.Length;
    var courseId = listLesson[0].courseId;
    var coureValue = listLesson[0].Course.rating;
    var totalStuden = 20;



#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce3b04b3a754b9c76de57e1d856ab99e6fb3ece68638", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce3b04b3a754b9c76de57e1d856ab99e6fb3ece69756", async() => {
                WriteLiteral("\r\n\r\n        <div class=\"container col-9 container-custom\">\r\n            <div class=\"course-header mt-5 \">\r\n                <div class=\"course-header-left col-7\">\r\n                    <h2>");
#nullable restore
#line 30 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
                   Write(courseNama);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                    <div class=\"course-student-values\">\r\n                        <p>");
#nullable restore
#line 32 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
                      Write(totalStuden);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p class=\"value\">");
#nullable restore
#line 33 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
                                    Write(coureValue);

#line default
#line hidden
#nullable disable
                WriteLiteral("/10</p>\r\n                    </div>\r\n                    <div class=\"course-des\">\r\n                        <p>\r\n                            ");
#nullable restore
#line 37 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
                       Write(courseDes);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </p>
                    </div>
                </div>
                <div class=""course-header-right col-3"">
                    <div class=""course-time"">
                        <p class=""course-time-title"">
                            <i class=""far fa-clock""></i>Thời gian:
                        </p>
                        <p>");
#nullable restore
#line 46 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
                      Write(courseTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                    </div>
                    <div class=""count-lesson"">
                        <p class=""count-lesson-title"">
                            <i class=""fab fa-leanpub""></i>Số bài học
                        </p>
                        <p>");
#nullable restore
#line 52 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
                      Write(courseCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"course-price\">\r\n                        <p><i class=\"fas fa-donate\"></i>");
#nullable restore
#line 55 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
                                                   Write(coursePrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"course-header-right-add-button col-2\">\r\n                    <div class=\"add-car-btn btn-success\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 2285, "\"", 2337, 2);
                WriteAttributeValue("", 2292, "/Courses/AddtoCartInLesson?courseId=", 2292, 36, true);
#nullable restore
#line 60 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
WriteAttributeValue("", 2328, courseId, 2328, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Đăng kí ngay</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"course-lesson mt-5 mb-5 pb-5\">\r\n\r\n");
#nullable restore
#line 66 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"one-lesson\">\r\n                        <div class=\"one-lesson-name\">\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 2683, "\"", 2728, 2);
                WriteAttributeValue("", 2690, "/lesson/LessonDetail?Id=", 2690, 24, true);
#nullable restore
#line 70 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
WriteAttributeValue("", 2714, item.lessonId, 2714, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 70 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
                                                                        Write(item.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                        </div>\r\n                        <div class=\"one-lesson-des\">\r\n                            <p><b>Mô tả:</b> ");
#nullable restore
#line 73 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
                                        Write(item.description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 77 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </div>
        </div>

        <div class=""container col-9 container-custom"">
            <div class=""danhgiachung"">
                <div class=""danhgia__title"">
                    <p>Đánh giá của khách hàng về khóa học</p>
                </div>
                <div class=""row padding--css"">
                    <div class=""mumber-evaluate col-md-4"">
                        <h2 class=""number-block"">4.5</h2>
                        <div class=""star-evaluate"">
                            <i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""far fa-star""></i>
                        </div>
                        <p>163 đánh giá</p>
                    </div>
                    <!-- <img id=""dalat_danhgia"" src=""DuLichTrongNuoc__ChiTiet/dalat_danhgia.jpg"" alt=""Hình ảnh Đà Lạt""> -->
                    <div class=""col-md-8"">
                        <div");
                BeginWriteAttribute("class", " class=\"", 3942, "\"", 3950, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            <div class=""voting-block"">
                                <div class=""voting-element "">
                                    <div class=""five-star""></div>
                                </div>
                                <div class=""voting-star"">
                                    <i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i>
                                </div>
                                <p class=""voting-number"">80%</p>
                            </div>
                            <div class=""voting-block"">
                                <div class=""voting-element "">
                                    <div class=""four-star""></div>
                                </div>
                                <div class=""voting-star"">
                                    <i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-st");
                WriteLiteral(@"ar""></i><i class=""far fa-star""></i>
                                </div>
                                <p class=""voting-number"">20%</p>
                            </div>
                            <div class=""voting-block"">
                                <div class=""voting-element "">
                                    <div class=""three-star""></div>
                                </div>
                                <div class=""voting-star"">
                                    <i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""far fa-star""></i><i class=""far fa-star""></i>
                                </div>
                                <p class=""voting-number"">0%</p>
                            </div>
                            <div class=""voting-block"">
                                <div class=""voting-element "">
                                    <div class=""tow-star""></div>
                                </div>
                    ");
                WriteLiteral(@"            <div class=""voting-star"">
                                    <i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""far fa-star""></i><i class=""far fa-star""></i><i class=""far fa-star""></i>
                                </div>
                                <p class=""voting-number"">0%</p>
                            </div>
                            <div class=""voting-block"">
                                <div class=""voting-element "">
                                    <div class=""one-star""></div>
                                </div>
                                <div class=""voting-star"">
                                    <i class=""fas fa-star""></i><i class=""far fa-star""></i><i class=""far fa-star""></i><i class=""far fa-star""></i><i class=""far fa-star""></i>
                                </div>
                                <p class=""voting-number"">0%</p>
                            </div>
                        </div>
                    </div>
             ");
                WriteLiteral("   </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"container col-9 container-custom mt-3\">\r\n            <h3 class=\"title-h3\">Nhận xét của học viên</h3>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce3b04b3a754b9c76de57e1d856ab99e6fb3ece621562", async() => {
                    WriteLiteral("\r\n                <input type=\"hidden\" name=\"courseId\"");
                    BeginWriteAttribute("value", " value=\"", 7364, "\"", 7381, 1);
#nullable restore
#line 150 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Lesson\LessonCourse.cshtml"
WriteAttributeValue("", 7372, courseId, 7372, 9, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(@" class=""form-control mb-2 "" />
                <div class=""form-group "">
                    <input name=""content"" class=""form-control mb-2"" required placeholder=""Bạn có thắc mắc về điều gì?"" />
                </div>
                <div class=""form-group mt-4"">
                    <label class=""control-label"">Điểm đánh giá</label>
                    <input type=""number"" name=""evaluate"" class=""form-control mb-2 "" required />
                </div>
                <div class=""form-group submit-form-css"">
                    <input type=""submit"" name=""submit"" value=""Viết đánh giá"" class=""button--design "" />
                    <input type=""button"" name=""more"" value=""Xem thêm đánh giá"" class=""button--design "" />
                </div>

            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

            <hr>

            <div class=""content-comment col-11"">
                <div class=""content-comment__icon"">
                    <i class=""fas fa-user-circle""></i>
                </div>
                <div class=""content-comment-block"">
                    <p class=""content-comment__Title"">Trần Phan Hải Đăng</p>
                    <div class=""content-comment__star"">
                        <i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i> ( 9/10 )
                    </div>
                    <p class=""content-comment__content"">Thầy giáo dạy đơn giản dễ hiểu phù hợp cho người bắt đầu. Very good</p>
                </div>
            </div>
        </div>
    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Courses_MVC.Models.Lesson>> Html { get; private set; }
    }
}
#pragma warning restore 1591
