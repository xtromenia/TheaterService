#pragma checksum "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Admin\ListMovies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b1134f480c31a212675ad68dfdc5a490a9851f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ListMovies), @"mvc.1.0.view", @"/Views/Admin/ListMovies.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b1134f480c31a212675ad68dfdc5a490a9851f0", @"/Views/Admin/ListMovies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec19c43930534d87db4d90d8976258354e178c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ListMovies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ServiceReference1.MovieData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Admin\ListMovies.cshtml"
  
    ViewData["Title"] = "List Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Admin\ListMovies.cshtml"
Write(Html.Partial("_Menu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <h1>All Movies</h1>\r\n    <table>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Name</th>\r\n            <th>Action</th>\r\n        </tr>\r\n");
#nullable restore
#line 16 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Admin\ListMovies.cshtml"
         foreach (var movie in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Admin\ListMovies.cshtml"
               Write(movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Admin\ListMovies.cshtml"
               Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 473, "\"", 509, 2);
            WriteAttributeValue("", 480, "/Admin/EditMovie?id=", 480, 20, true);
#nullable restore
#line 22 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Admin\ListMovies.cshtml"
WriteAttributeValue("", 500, movie.Id, 500, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"movie-button\">Edit</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 560, "\"", 598, 2);
            WriteAttributeValue("", 567, "/Admin/RemoveMovie?id=", 567, 22, true);
#nullable restore
#line 23 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Admin\ListMovies.cshtml"
WriteAttributeValue("", 589, movie.Id, 589, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"movie-button\">Remove</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "C:\Users\super\source\repos\projekt\TheaterService\TheaterAdmin\Views\Admin\ListMovies.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ServiceReference1.MovieData>> Html { get; private set; }
    }
}
#pragma warning restore 1591
