#pragma checksum "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\Houses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1619ad94dfda4017136a84baac52a8ce81505352"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Houses_Index), @"mvc.1.0.view", @"/Views/Houses/Index.cshtml")]
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
#line 1 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\_ViewImports.cshtml"
using CasaOrtApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\_ViewImports.cshtml"
using CasaOrtApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1619ad94dfda4017136a84baac52a8ce81505352", @"/Views/Houses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1970ba2db26e84d6a1a30aacbd56af0529cb96", @"/Views/_ViewImports.cshtml")]
    public class Views_Houses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CasaOrtApp.Models.House>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\Houses\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de casas</h1>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-12\" style=\"text-align:center;\">\r\n            <h1>Nuestras casas</h1>\r\n        </div>\r\n\r\n    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 19 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\Houses\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-sm-4\">\r\n                <div class=\"card\" style=\"width: 18rem;\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 521, "\"", 567, 1);
#nullable restore
#line 23 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\Houses\Index.cshtml"
WriteAttributeValue("", 527, Html.DisplayFor(modelItem => item.Path), 527, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 568, "\"", 612, 1);
#nullable restore
#line 23 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\Houses\Index.cshtml"
WriteAttributeValue("", 574, Html.DisplayFor(modelItem => item.Id), 574, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 25 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\Houses\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\Houses\Index.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">Mts ");
#nullable restore
#line 26 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\Houses\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">U$s ");
#nullable restore
#line 27 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\Houses\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 28 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\Houses\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1619ad94dfda4017136a84baac52a8ce815053527432", async() => {
                WriteLiteral(@"
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-eye"" viewBox=""0 0 16 16"">
                                <path d=""M16 8s-3-5.5-8-5.5S0 8 0 8s3 5.5 8 5.5S16 8 16 8zM1.173 8a13.133 13.133 0 0 1 1.66-2.043C4.12 4.668 5.88 3.5 8 3.5c2.12 0 3.879 1.168 5.168 2.457A13.133 13.133 0 0 1 14.828 8c-.058.087-.122.183-.195.288-.335.48-.83 1.12-1.465 1.755C11.879 11.332 10.119 12.5 8 12.5c-2.12 0-3.879-1.168-5.168-2.457A13.134 13.134 0 0 1 1.172 8z"" />
                                <path d=""M8 5.5a2.5 2.5 0 1 0 0 5 2.5 2.5 0 0 0 0-5zM4.5 8a3.5 3.5 0 1 1 7 0 3.5 3.5 0 0 1-7 0z"" />
                            </svg>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\Houses\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 38 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\TodoApp\Views\Houses\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CasaOrtApp.Models.House>> Html { get; private set; }
    }
}
#pragma warning restore 1591
