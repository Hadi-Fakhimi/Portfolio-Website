#pragma checksum "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\Shared\_Notification.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6ebcdbd6c3fda597e6ebddde67788062a204adcdc88019b8c211712cb6bc0c43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Notification), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Notification.cshtml")]
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
#line 1 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\_ViewImports.cshtml"
using Resume.Presentation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6ebcdbd6c3fda597e6ebddde67788062a204adcdc88019b8c211712cb6bc0c43", @"/Areas/Admin/Views/Shared/_Notification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"251cda655028140a25a54ed9dfb1b44a3a504f62ff01ae88291f8797bc34e2b5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Shared__Notification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\Shared\_Notification.cshtml"
 if (TempData["SuccessMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        swal({\r\n            title: \"اعلان\",\r\n            text: \"");
#nullable restore
#line 6 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\Shared\_Notification.cshtml"
              Write(TempData["SuccessMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            icon: \"success\",\r\n            button: \"باشه\"\r\n        });\r\n    </script>\r\n");
#nullable restore
#line 11 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\Shared\_Notification.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\Shared\_Notification.cshtml"
 if (TempData["WarningMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        swal({\r\n            title: \"اعلان\",\r\n            text: \"");
#nullable restore
#line 18 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\Shared\_Notification.cshtml"
              Write(TempData["WarningMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            icon: \"warning\",\r\n            button: \"باشه\"\r\n        });\r\n    </script>\r\n");
#nullable restore
#line 23 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\Shared\_Notification.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\Shared\_Notification.cshtml"
 if (TempData["InfoMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        swal({\r\n            title: \"اعلان\",\r\n            text: \"");
#nullable restore
#line 30 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\Shared\_Notification.cshtml"
              Write(TempData["InfoMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            icon: \"info\",\r\n            button: \"باشه\"\r\n        });\r\n    </script>\r\n");
#nullable restore
#line 35 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\Shared\_Notification.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\Shared\_Notification.cshtml"
 if (TempData["ErrorMessage"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        swal({\r\n            title: \"خطا\",\r\n            text: \"");
#nullable restore
#line 42 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\Shared\_Notification.cshtml"
              Write(TempData["ErrorMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            icon: \"error\",\r\n            button: \"باشه\"\r\n        });\r\n    </script>\r\n");
#nullable restore
#line 47 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\Shared\_Notification.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
