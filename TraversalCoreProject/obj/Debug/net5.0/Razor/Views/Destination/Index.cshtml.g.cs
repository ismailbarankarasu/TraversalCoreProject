#pragma checksum "C:\cSharpDersleri\TraversalCoreProject\TraversalCoreProject\Views\Destination\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5a03d2c044b040d0bcba3df02b22ee4c7b7f263e9f41f891ce1267d277a2710b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Destination_Index), @"mvc.1.0.view", @"/Views/Destination/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\cSharpDersleri\TraversalCoreProject\TraversalCoreProject\Views\_ViewImports.cshtml"
using TraversalCoreProject

#nullable disable
    ;
#nullable restore
#line 2 "C:\cSharpDersleri\TraversalCoreProject\TraversalCoreProject\Views\_ViewImports.cshtml"
using TraversalCoreProject.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\cSharpDersleri\TraversalCoreProject\TraversalCoreProject\Views\_ViewImports.cshtml"
using EntityLayer.Concrete

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"5a03d2c044b040d0bcba3df02b22ee4c7b7f263e9f41f891ce1267d277a2710b", @"/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e77bafe3a4377eea3e7f6d84ea81aafed67ebd71d67c29056991fcdc84caa02a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\cSharpDersleri\TraversalCoreProject\TraversalCoreProject\Views\Destination\Index.cshtml"
       List<Destination>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Starter/assets/css/style-liberty.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Traversal-Starter/assets/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Default/Index/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\cSharpDersleri\TraversalCoreProject\TraversalCoreProject\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UILayout.cshtml";

#line default
#line hidden
#nullable disable

            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5a03d2c044b040d0bcba3df02b22ee4c7b7f263e9f41f891ce1267d277a2710b5440", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a03d2c044b040d0bcba3df02b22ee4c7b7f263e9f41f891ce1267d277a2710b6579", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <!-- about breadcrumb -->
    <section class=""w3l-about-breadcrumb text-left"">
        <div class=""breadcrumb-bg breadcrumb-bg-about py-sm-5 py-4"">
            <div class=""container"">
                <h2 class=""title"">Rotalar </h2>
                <ul class=""breadcrumbs-custom-path mt-2"">
                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a03d2c044b040d0bcba3df02b22ee4c7b7f263e9f41f891ce1267d277a2710b7975", async() => {
                WriteLiteral("Ana Sayfa");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    <li class=""active""><span class=""fa fa-arrow-right mx-2"" aria-hidden=""true""></span> Rotalar </li>
                </ul>
            </div>
        </div>
    </section>
    <!-- //about breadcrumb -->
    <!--  Work gallery section -->
    <section class=""grids-1 py-5"">
        <div class=""grids py-lg-5 py-md-4"">
            <div class=""container"">
                <h3 class=""hny-title mb-5"">Tur Rotaları</h3>
                <div class=""row"">
");
#nullable restore
#line 27 "C:\cSharpDersleri\TraversalCoreProject\TraversalCoreProject\Views\Destination\Index.cshtml"
                     foreach(var item in Model){

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <div class=\"col-lg-4 col-md-4 col-6\">\r\n                        <div class=\"column\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a03d2c044b040d0bcba3df02b22ee4c7b7f263e9f41f891ce1267d277a2710b9970", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 1368, "\"", 1385, 1);
                WriteAttributeValue("", 1374, 
#nullable restore
#line 30 "C:\cSharpDersleri\TraversalCoreProject\TraversalCoreProject\Views\Destination\Index.cshtml"
                                                                                                       item.Image

#line default
#line hidden
#nullable disable
                , 1374, 11, false);
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1386, "\"", 1392, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid\">");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1309, "~/Destination/DestinationDetails/", 1309, 33, true);
            AddHtmlAttributeValue("", 1342, 
#nullable restore
#line 30 "C:\cSharpDersleri\TraversalCoreProject\TraversalCoreProject\Views\Destination\Index.cshtml"
                                                                       item.DesctinationId

#line default
#line hidden
#nullable disable
            , 1342, 20, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <div class=\"info\">\r\n                                <h4><a href=\"blog-single.html\">");
            Write(
#nullable restore
#line 32 "C:\cSharpDersleri\TraversalCoreProject\TraversalCoreProject\Views\Destination\Index.cshtml"
                                                                item.City

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</a></h4>\r\n                                <p>");
            Write(
#nullable restore
#line 33 "C:\cSharpDersleri\TraversalCoreProject\TraversalCoreProject\Views\Destination\Index.cshtml"
                                    item.DayNight

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</p>\r\n                                <div class=\"dst-btm\">\r\n                                    <h6");
            BeginWriteAttribute("class", " class=\"", 1699, "\"", 1707, 0);
            EndWriteAttribute();
            WriteLiteral(">Başlayan Fiyatlarla </h6>\r\n                                    <span>");
            Write(
#nullable restore
#line 36 "C:\cSharpDersleri\TraversalCoreProject\TraversalCoreProject\Views\Destination\Index.cshtml"
                                           item.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" ₺</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 41 "C:\cSharpDersleri\TraversalCoreProject\TraversalCoreProject\Views\Destination\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
