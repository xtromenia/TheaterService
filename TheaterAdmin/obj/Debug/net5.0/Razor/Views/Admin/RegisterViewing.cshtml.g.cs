#pragma checksum "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\Admin\RegisterViewing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ea9f20b89716cdb5f63900ba3ad33836c40b06b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RegisterViewing), @"mvc.1.0.view", @"/Views/Admin/RegisterViewing.cshtml")]
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
#line 1 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\_ViewImports.cshtml"
using TheaterAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\_ViewImports.cshtml"
using TheaterAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ea9f20b89716cdb5f63900ba3ad33836c40b06b", @"/Views/Admin/RegisterViewing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ec19c43930534d87db4d90d8976258354e178c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RegisterViewing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegisterViewingModel>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\Admin\RegisterViewing.cshtml"
  
    ViewData["Title"] = "Register Viewing";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\Admin\RegisterViewing.cshtml"
Write(Html.Partial("_Menu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <h1>Register New Movie Viewing</h1>\r\n    <div class=\"container-form\">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\Admin\RegisterViewing.cshtml"
         using (Html.BeginForm(FormMethod.Post, new { @id = "viewing-form" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label for=\"movieId\">Movie</label>\r\n            <select name=\"movieId\" required>\r\n\r\n");
#nullable restore
#line 17 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\Admin\RegisterViewing.cshtml"
                 foreach (var movie in Model.Movies)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ea9f20b89716cdb5f63900ba3ad33836c40b06b4585", async() => {
#nullable restore
#line 19 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\Admin\RegisterViewing.cshtml"
                                         Write(movie.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\Admin\RegisterViewing.cshtml"
                       WriteLiteral(movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\Admin\RegisterViewing.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </select>\r\n            <label for=\"theaterId\">Theater</label>\r\n            <select name=\"theaterId\" required>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\Admin\RegisterViewing.cshtml"
                 foreach (var theater in Model.Theaters)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ea9f20b89716cdb5f63900ba3ad33836c40b06b7161", async() => {
#nullable restore
#line 28 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\Admin\RegisterViewing.cshtml"
                                           Write(theater.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\Admin\RegisterViewing.cshtml"
                       WriteLiteral(theater.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\Admin\RegisterViewing.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </select>
            <label for=""date"">Date</label>
            <input type=""date"" name=""date"" required/>
            <label for=""time"">Time(HH:MM)</label>
            <input name=""time"" type=""time"" required/>
            <input type=""submit"" value=""Register Viewing"" />
");
#nullable restore
#line 37 "C:\Users\josef\Documents\HV\År 2\[4] E-tjänster och XML\Grupparbete\TheaterAdmin\Views\Admin\RegisterViewing.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegisterViewingModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
