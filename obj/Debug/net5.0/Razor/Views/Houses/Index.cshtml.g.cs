#pragma checksum "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25a9358d0666d3932373db776cc88abb7f09c308"
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
#line 1 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\_ViewImports.cshtml"
using CasaOrtApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\_ViewImports.cshtml"
using CasaOrtApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25a9358d0666d3932373db776cc88abb7f09c308", @"/Views/Houses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1970ba2db26e84d6a1a30aacbd56af0529cb96", @"/Views/_ViewImports.cshtml")]
    public class Views_Houses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CasaOrtApp.Models.TipoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("this.form.submit()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Houses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n\r\n        <div class=\"col-12\" style=\"text-align:center;\">\r\n            <h1>Nuestras casas</h1>\r\n        </div>\r\n\r\n    </div>\r\n    <br />\r\n    <div class=\"form-group\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a9358d0666d3932373db776cc88abb7f09c3087134", async() => {
                WriteLiteral("\r\n            <p>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a9358d0666d3932373db776cc88abb7f09c3087427", async() => {
                    WriteLiteral("\r\n                    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a9358d0666d3932373db776cc88abb7f09c3087715", async() => {
                        WriteLiteral("Seleccionar");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 19 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TipoOperacion);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 19 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Tipo;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </p>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 27 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
         foreach (var item in Model.Houses)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-sm-4\">\r\n                <div class=\"card\" style=\"width: 18rem;\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 904, "\"", 950, 1);
#nullable restore
#line 31 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
WriteAttributeValue("", 910, Html.DisplayFor(modelItem => item.Path), 910, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 951, "\"", 995, 1);
#nullable restore
#line 31 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
WriteAttributeValue("", 957, Html.DisplayFor(modelItem => item.Id), 957, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 33 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">Mts ");
#nullable restore
#line 34 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">U$s ");
#nullable restore
#line 35 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 36 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25a9358d0666d3932373db776cc88abb7f09c30815856", async() => {
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <a");
            BeginWriteAttribute("onclick", " onclick=\"", 2320, "\"", 2460, 19);
            WriteAttributeValue("", 2330, "like(", 2330, 5, true);
#nullable restore
#line 43 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
WriteAttributeValue("", 2335, item.Id, 2335, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2343, ",", 2343, 1, true);
            WriteAttributeValue(" ", 2344, "\'", 2345, 2, true);
#nullable restore
#line 43 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
WriteAttributeValue("", 2346, item.Street, 2346, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2358, "\',", 2358, 2, true);
#nullable restore
#line 43 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
WriteAttributeValue(" ", 2360, item.Number, 2361, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2373, ",", 2373, 1, true);
#nullable restore
#line 43 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
WriteAttributeValue(" ", 2374, item.Size, 2375, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2385, ",", 2385, 1, true);
            WriteAttributeValue(" ", 2386, "\'", 2387, 2, true);
#nullable restore
#line 43 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
WriteAttributeValue("", 2388, item.Path, 2388, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2398, "\',", 2398, 2, true);
            WriteAttributeValue(" ", 2400, "\'", 2401, 2, true);
#nullable restore
#line 43 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
WriteAttributeValue("", 2402, item.Price, 2402, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2413, "\',", 2413, 2, true);
            WriteAttributeValue(" ", 2415, "\'", 2416, 2, true);
#nullable restore
#line 43 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
WriteAttributeValue("", 2417, item.ReleaseDate.ToString("dd/MM/yyyy"), 2417, 40, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2457, "\');", 2457, 3, true);
            EndWriteAttribute();
            WriteLiteral(@" id='likeButton' class=""btn btn-primary"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-eye"" viewBox=""0 0 16 16"">
                                <path d=""M16 8s-3-5.5-8-5.5S0 8 0 8s3 5.5 8 5.5S16 8 16 8zM1.173 8a13.133 13.133 0 0 1 1.66-2.043C4.12 4.668 5.88 3.5 8 3.5c2.12 0 3.879 1.168 5.168 2.457A13.133 13.133 0 0 1 14.828 8c-.058.087-.122.183-.195.288-.335.48-.83 1.12-1.465 1.755C11.879 11.332 10.119 12.5 8 12.5c-2.12 0-3.879-1.168-5.168-2.457A13.134 13.134 0 0 1 1.172 8z"" />
                                <path d=""M8 5.5a2.5 2.5 0 1 0 0 5 2.5 2.5 0 0 0 0-5zM4.5 8a3.5 3.5 0 1 1 7 0 3.5 3.5 0 0 1-7 0z"" />
                            </svg>
                        </a>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 52 "C:\Users\Tomi\Desktop\Escritorio\FACULTAD\1er_2do_año\NUEVAS_TECNO\CasaOrtApp\Views\Houses\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
<script type=""text/jscript"">
    function like(_id, _street, _number, _size, _path, _price, _date) {
        var url = ""/Houses/AddLike"";
        $.get(url, { id: _id, street: _street, number: _number, size: _size, path: _path, price: _price, date: _date });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CasaOrtApp.Models.TipoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
