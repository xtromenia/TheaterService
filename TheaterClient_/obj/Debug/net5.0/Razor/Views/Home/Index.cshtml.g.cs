#pragma checksum "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7acba9df7a5874bdf49312b23d2c6a7df5e11f85"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7acba9df7a5874bdf49312b23d2c6a7df5e11f85", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ServiceReference1.MovieData>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<section id=\"jumbo\"");
            BeginWriteAttribute("style", " style=\"", 173, "\"", 254, 4);
            WriteAttributeValue("", 181, "background-image:", 181, 17, true);
            WriteAttributeValue(" ", 198, "url(\'", 199, 6, true);
#nullable restore
#line 7 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 204, Html.DisplayFor(m => m.LastOrDefault().ImgPath), 204, 48, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 252, "\')", 252, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 264, "\"", 330, 2);
            WriteAttributeValue("", 271, "/Movie/Index?id=", 271, 16, true);
#nullable restore
#line 8 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 287, Html.DisplayFor(m => m.LastOrDefault().Id), 287, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></a>\r\n</section>\r\n<section id=\"movielist\">\r\n    <nav>\r\n");
#nullable restore
#line 12 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
         using (Html.BeginForm(FormMethod.Get))
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <select name=\"genre\" id=\"genre-list\" onchange=\"this.form.submit()\">\r\n                <option value=\"All\">All Genres</option>\r\n");
#nullable restore
#line 18 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
                 foreach (var genre in Model.Select(x => x.Genre).Distinct())
                {
                    if (ViewBag.Genre != null)
                    {
                        if (genre.Equals(ViewBag.Genre))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1075, "\"", 1089, 1);
#nullable restore
#line 24 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 1083, genre, 1083, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 24 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
                                                       Write(genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 25 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <option");
            BeginWriteAttribute("value", " value=\"", 1236, "\"", 1250, 1);
#nullable restore
#line 28 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 1244, genre, 1244, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
                                              Write(genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 29 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 1399, "\"", 1413, 1);
#nullable restore
#line 33 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 1407, genre, 1407, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
                                          Write(genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 34 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n");
#nullable restore
#line 37 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </nav>\r\n\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 43 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
     foreach (var movie in Model)
    {
        if (ViewBag.Genre != null)
        {
            if (movie.Genre.Equals(ViewBag.Genre))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <article class=\"movie\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1800, "\"", 1832, 2);
            WriteAttributeValue("", 1807, "/Movie/Index?id=", 1807, 16, true);
#nullable restore
#line 50 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 1823, movie.Id, 1823, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <section class=\"bannercontainer\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1927, "\"", 1947, 1);
#nullable restore
#line 52 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 1933, movie.ImgPath, 1933, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1948, "\"", 1973, 2);
#nullable restore
#line 52 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 1954, movie.Title, 1954, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1966, "banner", 1967, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"movie-banner\" />\r\n                        </section>\r\n                        <section class=\"titlecontainer\">\r\n                            <h3>");
#nullable restore
#line 55 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
                           Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        </section>\r\n                    </a>\r\n                </article>\r\n");
#nullable restore
#line 59 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
            }
        }

        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <article class=\"movie\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2343, "\"", 2375, 2);
            WriteAttributeValue("", 2350, "/Movie/Index?id=", 2350, 16, true);
#nullable restore
#line 65 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 2366, movie.Id, 2366, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <section class=\"bannercontainer\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 2462, "\"", 2482, 1);
#nullable restore
#line 67 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 2468, movie.ImgPath, 2468, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2483, "\"", 2508, 2);
#nullable restore
#line 67 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
WriteAttributeValue("", 2489, movie.Title, 2489, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2501, "banner", 2502, 7, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"movie-banner\" />\r\n                    </section>\r\n                    <section class=\"titlecontainer\">\r\n                        <h3>");
#nullable restore
#line 70 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
                       Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </section>\r\n                </a>\r\n            </article>\r\n");
#nullable restore
#line 74 "C:\Users\xtrom\Source\Repos\TheaterService3\TheaterClient_\Views\Home\Index.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n");
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
