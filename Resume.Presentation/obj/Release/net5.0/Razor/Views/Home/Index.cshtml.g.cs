#pragma checksum "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0d946d5a6d9efdaefd1d2f9dd7e556de3f80b3cddc57ed0eb1952c99e69cfc9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\_ViewImports.cshtml"
using Resume.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\_ViewImports.cshtml"
using Resume.Presentation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
using Resume.Application.StaticTools;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0d946d5a6d9efdaefd1d2f9dd7e556de3f80b3cddc57ed0eb1952c99e69cfc9b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4398592170a4f119fd098f8a00f028ace45647730761366b0cf07c90f8e0d2b0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Resume.Domain.ViewModels.Page.HomePageViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none; color:white;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_SocialMediaPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- ============== start hero area ================= -->\r\n\r\n<section class=\"banner\" id=\"profile\">\r\n    <div class=\"container\">\r\n        <div class=\"row section\">\r\n            <div class=\"col-lg-6 col-md-12\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 325, "\"", 467, 1);
#nullable restore
#line 9 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 331, string.IsNullOrEmpty(Model.informationView.Avatar) ? FilePaths.DefaultAvatar : $"{FilePaths.AvatarImg}{Model.informationView.Avatar}", 331, 136, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                     class=\"img-fluid banner-img\"\r\n                     alt=\"banner\" />\r\n            </div>\r\n            <div class=\"col-lg-6 col-md-12 site-title align-content-center\">\r\n\r\n");
#nullable restore
#line 15 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                 if (!string.IsNullOrEmpty(Model.informationView.Name))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h3 class=\"title-text\">سلام من</h3>\r\n                    <h1 class=\"title-text\">");
#nullable restore
#line 18 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                                      Write(Model.informationView.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" هستم</h1>\r\n");
#nullable restore
#line 19 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"text-animate\">\r\n                    <h3 class=\"head-3\">Full Stack Developer</h3>\r\n                </div>\r\n");
#nullable restore
#line 23 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                 if (!string.IsNullOrEmpty(Model.informationView.Job))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"info-title\">\r\n                        ");
#nullable restore
#line 26 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                   Write(Model.informationView.Job);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 28 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div class=\"info-para\">\r\n");
#nullable restore
#line 31 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                     if (!string.IsNullOrEmpty(Model.informationView.DateOfBirth))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div><i class=\"fa-regular fa-calendar social-icon\"></i>");
#nullable restore
#line 33 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                                                                          Write(Model.informationView.DateOfBirth);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 34 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                     if (!string.IsNullOrEmpty(Model.informationView.Address))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div><i class=\"fa-solid fa-location-dot social-icon\"></i>");
#nullable restore
#line 38 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                                                                            Write(Model.informationView.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 39 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                     if (!string.IsNullOrEmpty(Model.informationView.Email))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div><i class=\"fa-regular fa-envelope social-icon\"></i>");
#nullable restore
#line 43 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                                                                          Write(Model.informationView.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 44 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 46 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                     if (!string.IsNullOrEmpty(Model.informationView.Phone))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div><i class=\"fa-solid fa-mobile social-icon\"></i>");
#nullable restore
#line 48 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                                                                      Write(Model.informationView.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 49 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"d-flex flex-row flex-wrap\">\r\n                    \r\n                    <button  type=\"button\" class=\"btn button btn-dark mr-4\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d946d5a6d9efdaefd1d2f9dd7e556de3f80b3cddc57ed0eb1952c99e69cfc9b11848", async() => {
                WriteLiteral("تماس با من");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </button>\r\n");
#nullable restore
#line 58 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                     if (!string.IsNullOrEmpty(Model.informationView.ResumeFile))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <button type=\"button\" class=\"btn button btn-outline-secondary\">\r\n                            <a download");
            BeginWriteAttribute("href", " href=\"", 2878, "\"", 2944, 1);
#nullable restore
#line 61 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
WriteAttributeValue("", 2885, $" {FilePaths.Resume}{Model.informationView.ResumeFile}", 2885, 59, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"fa-solid fa-download\"></i>\r\n                                رزومه را بارگیری کنید\r\n                            </a>\r\n                        </button>\r\n");
#nullable restore
#line 66 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"social-media mt-3\">\r\n\r\n\r\n");
#nullable restore
#line 71 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                     if (Model.SocialMediaList != null && Model.SocialMediaList.Any())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0d946d5a6d9efdaefd1d2f9dd7e556de3f80b3cddc57ed0eb1952c99e69cfc9b15068", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 73 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.SocialMediaList;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 74 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<!-- ============== end hero area ================= -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Resume.Domain.ViewModels.Page.HomePageViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
