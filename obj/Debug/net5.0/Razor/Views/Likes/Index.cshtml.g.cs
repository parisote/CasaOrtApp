#pragma checksum "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe4b31fec3bf14edab0a15cb6df769fc454a9646"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Likes_Index), @"mvc.1.0.view", @"/Views/Likes/Index.cshtml")]
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
#line 1 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\_ViewImports.cshtml"
using CasaOrtApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
using CasaOrtApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe4b31fec3bf14edab0a15cb6df769fc454a9646", @"/Views/Likes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1970ba2db26e84d6a1a30aacbd56af0529cb96", @"/Views/_ViewImports.cshtml")]
    public class Views_Likes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 2 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var emprendimientos = ViewData["E_Likes"];
    var houses = ViewData["H_Likes"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-12\" style=\"text-align:center;\">\r\n            <h1>Mis preferidos</h1>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 17 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
         foreach (var hou in (IEnumerable<House>)houses)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-sm-4\">\r\n                <div class=\"card\" style=\"width: 18rem;\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 568, "\"", 613, 1);
#nullable restore
#line 21 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
WriteAttributeValue("", 574, Html.DisplayFor(modelItem => hou.Path), 574, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 614, "\"", 657, 1);
#nullable restore
#line 21 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
WriteAttributeValue("", 620, Html.DisplayFor(modelItem => hou.Id), 620, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 23 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => hou.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
                                                                                    Write(Html.DisplayFor(modelItem => hou.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">Mts ");
#nullable restore
#line 24 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => hou.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">U$s ");
#nullable restore
#line 25 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => hou.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 26 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => hou.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe4b31fec3bf14edab0a15cb6df769fc454a96467443", async() => {
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
#line 27 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
                                                  WriteLiteral(hou.Id);

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
#line 36 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
         foreach (var emp in (IEnumerable<Emprendimiento>)emprendimientos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-sm-4\">\r\n                <div class=\"card\" style=\"width: 18rem;\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2266, "\"", 2311, 1);
#nullable restore
#line 41 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
WriteAttributeValue("", 2272, Html.DisplayFor(modelItem => emp.Path), 2272, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2312, "\"", 2355, 1);
#nullable restore
#line 41 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
WriteAttributeValue("", 2318, Html.DisplayFor(modelItem => emp.Id), 2318, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 43 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => emp.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 43 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
                                                                                    Write(Html.DisplayFor(modelItem => emp.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">Mts ");
#nullable restore
#line 44 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => emp.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">U$s ");
#nullable restore
#line 45 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => emp.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 46 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => emp.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe4b31fec3bf14edab0a15cb6df769fc454a964613852", async() => {
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
#line 47 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
                                                  WriteLiteral(emp.Id);

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
#line 56 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Likes\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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