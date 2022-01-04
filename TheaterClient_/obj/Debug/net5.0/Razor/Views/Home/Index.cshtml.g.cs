#pragma checksum "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5a7d0745f5e4bdf9a689eeabf56357e4da5c981"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5a7d0745f5e4bdf9a689eeabf56357e4da5c981", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ServiceReference1.MovieData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<section id=\"jumbo\"");
            BeginWriteAttribute("style", " style=\"", 173, "\"", 253, 4);
            WriteAttributeValue("", 181, "background-image:", 181, 17, true);
            WriteAttributeValue(" ", 198, "url(\'", 199, 6, true);
#nullable restore
#line 7 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 204, Html.DisplayFor(m => m.LastOrDefault().ImgPath), 204, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 252, "\'", 252, 1, true);
            EndWriteAttribute();
            WriteLiteral(" )>\r\n</section>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <label for=\"genre\">Genre:</label>\r\n");
            WriteLiteral("    <select name=\"genre\" id=\"genre-list\">\r\n");
#nullable restore
#line 16 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
         foreach (var genre in Model.Select(x => x.Genre).Distinct())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <option");
            BeginWriteAttribute("value", " value=\"", 671, "\"", 685, 1);
#nullable restore
#line 18 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 679, genre, 679, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
                              Write(genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 19 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </select>\r\n    <input type=\"submit\" value=\"Append\"/>\r\n    <h1>");
#nullable restore
#line 22 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
   Write(ViewBag.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 23 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("<section id=\"movielist\">\r\n");
#nullable restore
#line 28 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
     foreach (var movie in Model)
    {
        if (ViewBag.Genre != null)
        {
            if (movie.Genre.Equals(ViewBag.Genre))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"movie\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1101, "\"", 1133, 2);
            WriteAttributeValue("", 1108, "/Movie/Index?id=", 1108, 16, true);
#nullable restore
#line 35 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 1124, movie.Id, 1124, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1165, "\"", 1185, 1);
#nullable restore
#line 36 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 1171, movie.ImgPath, 1171, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1186, "\"", 1211, 2);
#nullable restore
#line 36 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 1192, movie.Title, 1192, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1204, "banner", 1205, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"movie-banner\" />\r\n                    </a>\r\n                    <h3>");
#nullable restore
#line 38 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
                   Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n");
#nullable restore
#line 40 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
            }
        }

        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"movie\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1435, "\"", 1467, 2);
            WriteAttributeValue("", 1442, "/Movie/Index?id=", 1442, 16, true);
#nullable restore
#line 46 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 1458, movie.Id, 1458, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1495, "\"", 1515, 1);
#nullable restore
#line 47 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 1501, movie.ImgPath, 1501, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1516, "\"", 1541, 2);
#nullable restore
#line 47 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 1522, movie.Title, 1522, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1534, "banner", 1535, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"movie-banner\" />\r\n                </a>\r\n                <h3>");
#nullable restore
#line 49 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
               Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n");
#nullable restore
#line 51 "C:\Users\xtrom\Source\Repos\TheaterService\TheaterClient_\Views\Home\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>");
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
