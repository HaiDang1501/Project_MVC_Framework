#pragma checksum "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Shared\_Summernote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3f82900c458d6bad283c175991f916cfd92491b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Summernote), @"mvc.1.0.view", @"/Views/Shared/_Summernote.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f82900c458d6bad283c175991f916cfd92491b", @"/Views/Shared/_Summernote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46a09356b26a7a236d388297b43c76deb5641d45", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Summernote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Courses_MVC.Models.Summernote>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Shared\_Summernote.cshtml"
 if (Model.loadLibary)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <script src=""https://cdnjs.cloudflare.com/ajax/libs/summernote/0.8.20/summernote-bs4.min.js"" integrity=""sha512-ZESy0bnJYbtgTNGlAD+C2hIZCt4jKGF41T5jZnIXy4oP8CQqcrBGWyxNP16z70z/5Xy6TS/nUZ026WmvOcjNIQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer""></script>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/summernote/0.8.20/summernote-bs4.min.css"" integrity=""sha512-ngQ4IGzHQ3s/Hh8kMyG4FC74wzitukRMIcTOoKT3EyzFZCILOPF0twiXOQn75eDINUfKBYmzYn2AA8DkAk8veQ=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
");
#nullable restore
#line 7 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Shared\_Summernote.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    $(\'");
#nullable restore
#line 11 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Shared\_Summernote.cshtml"
  Write(Model.idEditor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\').summernote({\r\n        height: ");
#nullable restore
#line 12 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Shared\_Summernote.cshtml"
           Write(Model.height);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n        toolbar: ");
#nullable restore
#line 13 "C:\Users\Admin\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Project_MVC_Framework.git\Courses_MVC\Courses_MVC\Views\Shared\_Summernote.cshtml"
            Write(Html.Raw(Model.toolBar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Courses_MVC.Models.Summernote> Html { get; private set; }
    }
}
#pragma warning restore 1591
