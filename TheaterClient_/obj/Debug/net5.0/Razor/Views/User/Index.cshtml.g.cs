#pragma checksum "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "561bb477af77b7047f1e94c8e165f4372ae47bb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"561bb477af77b7047f1e94c8e165f4372ae47bb3", @"/Views/User/Index.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceReference1.CustomerData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Welcome ");
#nullable restore
#line 7 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\User\Index.cshtml"
       Write(Html.DisplayFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\User\Index.cshtml"
 using (Html.BeginForm("UpdateMail", "User"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Current mail: ");
#nullable restore
#line 11 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\User\Index.cshtml"
                Write(Html.DisplayFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <label>New mail: </label>\r\n");
#nullable restore
#line 13 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\User\Index.cshtml"
Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\User\Index.cshtml"
                                 ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input value=\"Update Email\" type=\"submit\" />\r\n");
#nullable restore
#line 15 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\User\Index.cshtml"
 using (Html.BeginForm("UpdatePassword", "User"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>New Password: </label>\r\n");
#nullable restore
#line 20 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\User\Index.cshtml"
Write(Html.TextBoxFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input value=\"Update Password\" type=\"submit\"/>\r\n");
#nullable restore
#line 22 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceReference1.CustomerData> Html { get; private set; }
    }
}
#pragma warning restore 1591
