#pragma checksum "C:\Users\USER\OneDrive\Desktop\Asp.Net folder\EduhomeTask\EduhomeTask\Views\Shared\_LoadCoursesPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a092b84a47fb0a46c8bba66a33676caeb94f24d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoadCoursesPartial), @"mvc.1.0.view", @"/Views/Shared/_LoadCoursesPartial.cshtml")]
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
#line 1 "C:\Users\USER\OneDrive\Desktop\Asp.Net folder\EduhomeTask\EduhomeTask\Views\_ViewImports.cshtml"
using EduhomeTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\OneDrive\Desktop\Asp.Net folder\EduhomeTask\EduhomeTask\Views\_ViewImports.cshtml"
using EduhomeTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\OneDrive\Desktop\Asp.Net folder\EduhomeTask\EduhomeTask\Views\_ViewImports.cshtml"
using EduhomeTask.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a092b84a47fb0a46c8bba66a33676caeb94f24d0", @"/Views/Shared/_LoadCoursesPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0612f5da587f2c22a1b41364bbab7bb4b2939258", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__LoadCoursesPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USER\OneDrive\Desktop\Asp.Net folder\EduhomeTask\EduhomeTask\Views\Shared\_LoadCoursesPartial.cshtml"
 foreach (Course course in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n        <div class=\"single-course mb-70\">\r\n            <div class=\"course-img\">\r\n                <a href=\"course-details.html\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a092b84a47fb0a46c8bba66a33676caeb94f24d04290", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 267, "~/img/course/", 267, 13, true);
#nullable restore
#line 9 "C:\Users\USER\OneDrive\Desktop\Asp.Net folder\EduhomeTask\EduhomeTask\Views\Shared\_LoadCoursesPartial.cshtml"
AddHtmlAttributeValue("", 280, course.Image, 280, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""course-hover"">
                        <i class=""fa fa-link""></i>
                    </div>
                </a>
            </div>
            <div class=""course-content"">
                <h3><a href=""course-details.html"">");
#nullable restore
#line 16 "C:\Users\USER\OneDrive\Desktop\Asp.Net folder\EduhomeTask\EduhomeTask\Views\Shared\_LoadCoursesPartial.cshtml"
                                             Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                <p>");
#nullable restore
#line 17 "C:\Users\USER\OneDrive\Desktop\Asp.Net folder\EduhomeTask\EduhomeTask\Views\Shared\_LoadCoursesPartial.cshtml"
              Write(course.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a class=\"default-btn\" href=\"course-details.html\">read more</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 22 "C:\Users\USER\OneDrive\Desktop\Asp.Net folder\EduhomeTask\EduhomeTask\Views\Shared\_LoadCoursesPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
