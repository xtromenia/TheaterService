#pragma checksum "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3cf28053448bbdd007c0b0786ad09c324263787e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cf28053448bbdd007c0b0786ad09c324263787e", @"/Views/Movie/Index.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceReference1.MovieData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\Movie\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\Movie\Index.cshtml"
Write(Html.DisplayFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 116, "\"", 154, 1);
#nullable restore
#line 7 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\Movie\Index.cshtml"
WriteAttributeValue("", 122, Html.DisplayFor(m => m.ImgPath), 122, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/>\r\n<h3>");
#nullable restore
#line 8 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\Movie\Index.cshtml"
Write(Html.DisplayFor(m => m.Runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>");
#nullable restore
#line 9 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\Movie\Index.cshtml"
Write(Html.DisplayFor(m => m.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<p>");
#nullable restore
#line 10 "C:\Users\xtrom\source\repos\xtromenia\TheaterService\TheaterClient_\Views\Movie\Index.cshtml"
Write(Html.DisplayFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceReference1.MovieData> Html { get; private set; }
    }
}
#pragma warning restore 1591