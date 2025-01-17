#pragma checksum "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "42e7e41a3c9501a85a4e69a380c1eeb18de9d65ab1c084c5eb400688686e43ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_CustomerLogo_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/CustomerLogo/Index.cshtml")]
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
#nullable restore
#line 2 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
using Resume.Domain.ViewModels.CustomerLogo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
using Resume.Application.StaticTools;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"42e7e41a3c9501a85a4e69a380c1eeb18de9d65ab1c084c5eb400688686e43ce", @"/Areas/Admin/Views/CustomerLogo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"251cda655028140a25a54ed9dfb1b44a3a504f62ff01ae88291f8797bc34e2b5", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_CustomerLogo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CustomerLogoListViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
  
    ViewData["Title"] = "لیست موسسه ها";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Content Header (Page header) -->\r\n<div class=\"content-header\">\r\n    <div class=\"d-flex align-items-center\">\r\n        <div class=\"mr-auto\">\r\n            <h3 class=\"page-title\">");
#nullable restore
#line 14 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
        </div>
        <div class=""right-title"">
            <!-- Button trigger modal -->
            <button type=""button"" onclick=""LoadCustomerLogoFormModal(0)"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
                افزودن به لیست
            </button>
        </div>

    </div>
</div>

<!-- Main content -->
<section class=""content"">

    <div class=""row"">
        <div class=""col-12"">
            <div class=""box"">
                <div class=""box-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover no-wrap data_table"" id=""data-table-box"">
                            <thead>
                                <tr class=""bg-secondary"">
                                    <th>لوگو</th>
                                    <th>alt</th>
                                    <th>لینک</th>
                                    <th>الویت</th>
                                    <th></th>
  ");
            WriteLiteral("                              </tr>\r\n                            </thead>\r\n                            <tbody>\r\n\r\n");
#nullable restore
#line 46 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
                                 if (Model != null && Model.Any())
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
                                     foreach (CustomerLogoListViewModel item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr");
            BeginWriteAttribute("id", " id=\"", 1789, "\"", 1813, 2);
            WriteAttributeValue("", 1794, "list-thing-", 1794, 11, true);
#nullable restore
#line 50 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
WriteAttributeValue("", 1805, item.Id, 1805, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <td><img");
            BeginWriteAttribute("src", " src=\"", 1869, "\"", 1979, 1);
#nullable restore
#line 51 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
WriteAttributeValue("", 1875, string.IsNullOrEmpty(item.Logo) ? FilePaths.DefaultAvatar : $"{FilePaths.CustomerLogoImg}{item.Logo}", 1875, 104, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"70\" height=\"70\" /></td>\r\n                                            <td>");
#nullable restore
#line 52 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
                                           Write(item.LogoAlt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 53 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
                                           Write(item.Link);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 54 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
                                           Write(item.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>\r\n\r\n                                                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2319, "\"", 2364, 3);
            WriteAttributeValue("", 2329, "LoadCustomerLogoFormModal(", 2329, 26, true);
#nullable restore
#line 57 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
WriteAttributeValue("", 2355, item.Id, 2355, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2363, ")", 2363, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-warning\">ویرایش</button>\r\n                                                <button");
            BeginWriteAttribute("onclick", " onclick=\"", 2476, "\"", 2514, 3);
            WriteAttributeValue("", 2486, "DeleteCustomerLogo(", 2486, 19, true);
#nullable restore
#line 58 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
WriteAttributeValue("", 2505, item.Id, 2505, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2513, ")", 2513, 1, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-danger\">حذف</button>\r\n\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 62 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\mahdi\Documents\Resume-hadi-fakhimi\Resume.Presentation\Areas\Admin\Views\CustomerLogo\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n<!-- /.content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CustomerLogoListViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
