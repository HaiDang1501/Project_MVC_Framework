#pragma checksum "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19d08da65328c6bd95d8c8a474e90340ee1e7b4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exercises_Details), @"mvc.1.0.view", @"/Views/Exercises/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19d08da65328c6bd95d8c8a474e90340ee1e7b4f", @"/Views/Exercises/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a09356b26a7a236d388297b43c76deb5641d45", @"/Views/_ViewImports.cshtml")]
    public class Views_Exercises_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Courses_MVC.Models.Exercise>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavBar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AlertMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListExerciseAdmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateExercise", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<main class=\"main\">\r\n    <div class=\"sidebar-admin\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19d08da65328c6bd95d8c8a474e90340ee1e7b4f4960", async() => {
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
            WriteLiteral("\r\n    </div>\r\n    <section class=\"section-add_course\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19d08da65328c6bd95d8c8a474e90340ee1e7b4f6144", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <h1 class=""text-center mt-3"">Chi tiết bài luyện tập</h1>
        <div class=""ml-5"">
            <div class=""content-option"">
                <h4>Bài luyện tập</h4>
                <hr />
                <dl class=""row"">
                    <dt class=""col-sm-2"">
                        ");
#nullable restore
#line 20 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.exerciseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 23 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayFor(model => model.exerciseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 26 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.exerciseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 29 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayFor(model => model.exerciseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 32 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 35 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayFor(model => model.content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 38 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.input));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        <p>");
#nullable restore
#line 41 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                      Write(Html.DisplayFor(model => model.input));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        \r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 45 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.output));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 48 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayFor(model => model.output));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 51 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.deadline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 54 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayFor(model => model.deadline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        ");
#nullable restore
#line 57 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayNameFor(model => model.Lesson));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 60 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Lesson.title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        Tác giả\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 66 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                   Write(Html.DisplayFor(model => model.AppUser.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n            </div>\r\n            <div class=\"option-detail\">\r\n                <div class=\"back-admin\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19d08da65328c6bd95d8c8a474e90340ee1e7b4f13914", async() => {
                WriteLiteral("Trở về");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"main-option\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19d08da65328c6bd95d8c8a474e90340ee1e7b4f15163", async() => {
                WriteLiteral("Chỉnh sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
                                                     WriteLiteral(Model.exerciseId);

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
            WriteLiteral(@" |
                </div>

            </div>
        </div>
    </section>
</main>
<script>
    const active_lienhe = document.querySelector('#active--baitap')
    active_lienhe.classList.add('active--css')
    /*document.querySelector('#active--khoahoc').classList.remove('active--css')*/
</script>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 88 "D:\Xây dựng HTTT trên các framework\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Exercises\Details.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Courses_MVC.Models.Exercise> Html { get; private set; }
    }
}
#pragma warning restore 1591
