#pragma checksum "C:\Users\super\source\repos\projekt\TheaterService\TheaterClient_\Views\Shared\_Menu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6212a383bc992da927c1128daac4d4cd165b5c79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Menu), @"mvc.1.0.view", @"/Views/Shared/_Menu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6212a383bc992da927c1128daac4d4cd165b5c79", @"/Views/Shared/_Menu.cshtml")]
    public class Views_Shared__Menu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"menu-container\">\r\n\r\n    <nav id=\"menu\">\r\n\r\n        ");
#nullable restore
#line 10 "C:\Users\super\source\repos\projekt\TheaterService\TheaterClient_\Views\Shared\_Menu.cshtml"
   Write(Html.ActionLink("My Info", "Index", "User", null, new { @class = "menu-button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 12 "C:\Users\super\source\repos\projekt\TheaterService\TheaterClient_\Views\Shared\_Menu.cshtml"
   Write(Html.ActionLink("Active Bookings", "ActiveBookings", "User", null, new { @class = "menu-button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 14 "C:\Users\super\source\repos\projekt\TheaterService\TheaterClient_\Views\Shared\_Menu.cshtml"
   Write(Html.ActionLink("Booking History", "BookingHistory", "User", null, new { @class = "menu-button" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </nav>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
