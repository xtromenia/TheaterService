#pragma checksum "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ff835839782993eb85b777a1f5ae8d66ba1fe65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\_ViewImports.cshtml"
using TheaterAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\_ViewImports.cshtml"
using TheaterAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ff835839782993eb85b777a1f5ae8d66ba1fe65", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec19c43930534d87db4d90d8976258354e178c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Admin>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"container-login\">\r\n    <h1>Admin Login</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Home\Index.cshtml"
     using  (Html.BeginForm(FormMethod.Post, new { @id = "login-form" })) 
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label for=\"username\">Username</label>\r\n");
#nullable restore
#line 12 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Home\Index.cshtml"
Write(Html.EditorFor(m => m.Username, new { htmlAttributes = new { @class = "form-control", @data_val = "true", @required = "required" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Home\Index.cshtml"
                                                                                                                                          ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label for=\"password\">Password</label>\r\n");
#nullable restore
#line 14 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Home\Index.cshtml"
Write(Html.PasswordFor(m => m.Password, new { @required = "required" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Home\Index.cshtml"
                                                                      ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <input type=\"submit\" value=\"Login\" />\r\n    <p id = \"login-error\" > ");
#nullable restore
#line 17 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Home\Index.cshtml"
                       Write(ViewBag.LoginError);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 18 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
