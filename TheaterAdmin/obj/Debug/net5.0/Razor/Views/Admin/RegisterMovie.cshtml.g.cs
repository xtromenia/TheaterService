#pragma checksum "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb935b298f41c73ab090837f9b18fa9bb71afa9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RegisterMovie), @"mvc.1.0.view", @"/Views/Admin/RegisterMovie.cshtml")]
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
#line 1 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\_ViewImports.cshtml"
using TheaterAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\_ViewImports.cshtml"
using TheaterAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb935b298f41c73ab090837f9b18fa9bb71afa9a", @"/Views/Admin/RegisterMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec19c43930534d87db4d90d8976258354e178c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RegisterMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceReference1.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
  
    ViewData["Title"] = "RegisterMovie";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Register New Movie</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label for=\"title\">Title</label>\r\n");
#nullable restore
#line 11 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
Write(Html.EditorFor(m => m.Title));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
                                 ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label for=\"img-path\">Image Path</label>\r\n");
#nullable restore
#line 14 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
Write(Html.EditorFor(m => m.ImgPath));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
                                   ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label for=\"description\">Description</label>\r\n");
#nullable restore
#line 17 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
Write(Html.EditorFor(m => m.Description));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
                                       ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label for=\"description\">Runtime (Minutes)</label>\r\n");
#nullable restore
#line 20 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
Write(Html.EditorFor(m => m.Runtime));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
                                   ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label for=\"description\">Genre</label>\r\n");
#nullable restore
#line 23 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
Write(Html.EditorFor(m => m.Genre));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
                                 ;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n    <input type=\"submit\" value=\"Register Movie\" />\r\n");
#nullable restore
#line 27 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
Write(ViewBag.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 31 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
Write(Html.ActionLink("Back", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ServiceReference1.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
