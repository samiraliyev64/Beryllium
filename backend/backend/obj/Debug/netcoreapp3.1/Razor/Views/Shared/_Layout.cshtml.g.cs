#pragma checksum "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef7d52ff7c1080b7129ac741258aab58b5ee3179"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\_ViewImports.cshtml"
using backend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\_ViewImports.cshtml"
using backend.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef7d52ff7c1080b7129ac741258aab58b5ee3179", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e404b651db9ec25e911d8077b5597c2cec1e3e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/main.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/script.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef7d52ff7c1080b7129ac741258aab58b5ee31794486", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <!-- CSS CDN -->\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ef7d52ff7c1080b7129ac741258aab58b5ee31794951", async() => {
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
                WriteLiteral(@"
    <!-- Bootstrap CDN start -->
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/css/bootstrap.min.css""
          integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""
            integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.14.7/dist/umd/popper.min.js""
            integrity=""sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.3.1/dist/js/bootstrap.min.js""
            integrity=""sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM""
            crossorigin=""anonymous""></script>
    <!-- Font Awesome CDN -->
    <link rel=""stylesheet"" href=""https://cdnjs.cloudf");
                WriteLiteral(@"lare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
          integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
          crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />
    <!-- JavaScript CDN -->
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef7d52ff7c1080b7129ac741258aab58b5ee31797494", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("defer", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>Beryllium — Free Website Template, Free HTML5 Template by FreeHTML5.co</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef7d52ff7c1080b7129ac741258aab58b5ee31799714", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <!-- header start -->
        <div class=""row"">
            <header>
                <nav id=""navbar"">
                    <a href=""#"" id=""beryllium-text"">
                        <h4>BERYLLIUM</h4>
                    </a>
                    <div id=""navbar-main-part"">
                        <ul>
                            <li><a href=""#"" id=""home"">HOME</a></li>
                            <li><a href=""#"">ABOUT</a></li>
                            <li id=""services-dropdown"">
                                <a href=""#"" id=""services"">SERVICES <i class=""fa-solid fa-caret-down""></i></a>
                                <div id=""services-dropdown-content"">
                                    <ul>
                                        <li><a");
                BeginWriteAttribute("href", " href=\"", 2536, "\"", 2543, 0);
                EndWriteAttribute();
                WriteLiteral(">Web Design</a></li>\r\n                                        <li><a");
                BeginWriteAttribute("href", " href=\"", 2612, "\"", 2619, 0);
                EndWriteAttribute();
                WriteLiteral(">eCommerce</a></li>\r\n                                        <li><a");
                BeginWriteAttribute("href", " href=\"", 2687, "\"", 2694, 0);
                EndWriteAttribute();
                WriteLiteral(">Branding</a></li>\r\n                                        <li><a");
                BeginWriteAttribute("href", " href=\"", 2761, "\"", 2768, 0);
                EndWriteAttribute();
                WriteLiteral(@">API</a></li>
                                    </ul>
                                </div>
                            </li>
                            <li id=""dropdown-dropdown"">
                                <a href=""#"" id=""dropdown"">DROPDOWN <i class=""fa-solid fa-caret-down""></i></a>
                                <div id=""dropdown-dropdown-content"">
                                    <ul>
                                        <li><a");
                BeginWriteAttribute("href", " href=\"", 3228, "\"", 3235, 0);
                EndWriteAttribute();
                WriteLiteral(">HTML5</a></li>\r\n                                        <li><a");
                BeginWriteAttribute("href", " href=\"", 3299, "\"", 3306, 0);
                EndWriteAttribute();
                WriteLiteral(">CSS3</a></li>\r\n                                        <li><a");
                BeginWriteAttribute("href", " href=\"", 3369, "\"", 3376, 0);
                EndWriteAttribute();
                WriteLiteral(">Sass</a></li>\r\n                                        <li><a");
                BeginWriteAttribute("href", " href=\"", 3439, "\"", 3446, 0);
                EndWriteAttribute();
                WriteLiteral(@">jQuery</a></li>
                                    </ul>
                                </div>
                            </li>
                            <li><a href=""#"">PORTFOLIO</a></li>
                            <li><a href=""#"">CONTACT</a></li>
                        </ul>
                    </div>
                </nav>
            </header>
        </div>
        <!-- header end -->
        ");
#nullable restore
#line 74 "C:\Users\HP\Desktop\asp.net\Beryllium\backend\backend\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        <!-- footer start -->
        <footer>
            <section id=""contact"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""contact-container"">
                            <div class=""contact-container-item"" id=""beryllium-info"">
                                <h3>Beryllium</h3>
                                <p>
                                    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus placerat enim et
                                    urna
                                    sagittis, rhoncus euismod.
                                </p>
                            </div>
                            <div class=""contact-container-item"" id=""links"">
                                <h3>Links</h3>
                                <ul>
                                    <li>HOME</li>
                                    <li>FEATURES</li>
                                    <li>PRODUCTS</li>
");
                WriteLiteral(@"                                    <li>TESTIMONIAL</li>
                                    <li>CONTACT</li>
                                </ul>
                            </div>
                            <div class=""contact-container-item"" id=""work"">
                                <h3>Work</h3>
                                <ul>
                                    <li>NEW YORK ARENA</li>
                                    <li>EAGLE PARK</li>
                                    <li>NATIONALS PARK</li>
                                    <li>MANILA PARK</li>
                                </ul>
                            </div>
                            <div class=""contact-container-item"" id=""email"">
                                <input type=""text"" placeholder=""Email"">
                                <button type=""submit"">SEND</button>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
 ");
                WriteLiteral(@"           <section id=""copyrights"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""copyrights-container"">
                            <div class=""rights"">© 2016 Free HTML5. All Rights Reserved.</div>
                            <div class=""designed-by"">
                                Designed by <a href=""#"">FreeHTML5.co</a> Demo Images: <a href=""#"">Pixeden</a> & <a href=""#"">Unsplash</a>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </footer>
        <!-- footer end -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
