#pragma checksum "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\ListCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db5097a2cd4b30a39a4ef92a2074c4b616343384"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListCustomers), @"mvc.1.0.view", @"/Views/Admin/ListCustomers.cshtml")]
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
#line 1 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\_ViewImports.cshtml"
using TheaterAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\_ViewImports.cshtml"
using TheaterAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db5097a2cd4b30a39a4ef92a2074c4b616343384", @"/Views/Admin/ListCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec19c43930534d87db4d90d8976258354e178c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListCustomers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ServiceReference1.CustomerData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\ListCustomers.cshtml"
  
    ViewData["Title"] = "List Customers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\ListCustomers.cshtml"
Write(Html.Partial("_Menu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n\r\n    <h1>All Customers</h1>\r\n\r\n    <table>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Email</th>\r\n            <th>Name</th>\r\n            <th>Action</th>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\ListCustomers.cshtml"
         foreach (var customer in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\ListCustomers.cshtml"
           Write(customer.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\ListCustomers.cshtml"
           Write(customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\ListCustomers.cshtml"
           Write(customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\ListCustomers.cshtml"
           Write(Html.ActionLink("Edit", "ListCustomers"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\"", 570, "\"", 614, 2);
            WriteAttributeValue("", 577, "/Admin/RemoveCustomer?id=", 577, 25, true);
#nullable restore
#line 26 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\ListCustomers.cshtml"
WriteAttributeValue("", 602, customer.Id, 602, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Remove</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 28 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\ListCustomers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ServiceReference1.CustomerData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
