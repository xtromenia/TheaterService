#pragma checksum "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "689a0006a6e70a5bdca7699642291b1811529df6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"689a0006a6e70a5bdca7699642291b1811529df6", @"/Views/Admin/RegisterMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec19c43930534d87db4d90d8976258354e178c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RegisterMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ServiceReference1.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
  
    ViewData["Title"] = "Register Movie";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
Write(Html.Partial("_Menu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\r\n    <h1>Register New Movie</h1>\r\n\r\n    <div class=\"container-form\">\r\n\r\n");
#nullable restore
#line 14 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
         using (Html.BeginForm(FormMethod.Post, new { @id = "viewing-form" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label for=\"title\">Title</label>\r\n");
#nullable restore
#line 17 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
       Write(Html.EditorFor(m => m.Title, new { htmlAttributes = new { @class = "form-control", @data_val = "true", @required = "required" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
                                                                                                                                               ;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label for=\"img-path\">Image Path</label>\r\n");
#nullable restore
#line 19 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
       Write(Html.EditorFor(m => m.ImgPath, new { htmlAttributes = new { @class = "form-control", @data_val = "true", @required = "required" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
                                                                                                                                                 ;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label for=\"description\">Description</label>\r\n");
#nullable restore
#line 21 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
       Write(Html.EditorFor(m => m.Description, new { htmlAttributes = new { @class = "form-control", @data_val = "true", @required = "required" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
                                                                                                                                                     ;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label for=\"description\">Runtime (Minutes)</label>\r\n");
#nullable restore
#line 23 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
       Write(Html.EditorFor(m => m.Runtime, new { htmlAttributes = new { @class = "form-control", @data_val = "true", @required = "required" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
                                                                                                                                                 ;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label for=\"description\">Genre</label>\r\n");
#nullable restore
#line 25 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
       Write(Html.EditorFor(m => m.Genre, new { htmlAttributes = new { @class = "form-control", @data_val = "true", @required = "required" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
                                                                                                                                               ;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"submit\" value=\"Register Movie\" />\r\n");
#nullable restore
#line 27 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 29 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterAdmin\Views\Admin\RegisterMovie.cshtml"
   Write(ViewBag.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n</div>\r\n");
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
