#pragma checksum "C:\Users\letrj\Source\Repos\TheaterService\TheaterClient_\Views\Authentication\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f03ce499e6182e85132856e4182b4b6cd980c01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authentication_Login), @"mvc.1.0.view", @"/Views/Authentication/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f03ce499e6182e85132856e4182b4b6cd980c01", @"/Views/Authentication/Login.cshtml")]
    public class Views_Authentication_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceReference1.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\letrj\Source\Repos\TheaterService\TheaterClient_\Views\Authentication\Login.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\letrj\Source\Repos\TheaterService\TheaterClient_\Views\Authentication\Login.cshtml"
Write(Html.ViewBag.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\letrj\Source\Repos\TheaterService\TheaterClient_\Views\Authentication\Login.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label>Email:</label>\r\n");
#nullable restore
#line 11 "C:\Users\letrj\Source\Repos\TheaterService\TheaterClient_\Views\Authentication\Login.cshtml"
Write(Html.EditorFor(m => m.Email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\letrj\Source\Repos\TheaterService\TheaterClient_\Views\Authentication\Login.cshtml"
                                 ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br>\r\n    <label>Password:</label>\r\n");
#nullable restore
#line 14 "C:\Users\letrj\Source\Repos\TheaterService\TheaterClient_\Views\Authentication\Login.cshtml"
Write(Html.PasswordFor(m => m.Password));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\letrj\Source\Repos\TheaterService\TheaterClient_\Views\Authentication\Login.cshtml"
                                      ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Login\"/>\r\n");
#nullable restore
#line 16 "C:\Users\letrj\Source\Repos\TheaterService\TheaterClient_\Views\Authentication\Login.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceReference1.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
