#pragma checksum "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "823ef2000b3d5e3b04587f80f432448f2feea6b2"
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
#nullable restore
#line 1 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\_ViewImports.cshtml"
using FlowerStore.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\_ViewImports.cshtml"
using FlowerStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823ef2000b3d5e3b04587f80f432448f2feea6b2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe9dc3f933a48cef12520dd54ffebe326d2c3eef", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<main>\r\n\r\n    <!-- SLIDER START -->\r\n\r\n    <section id=\"slider\">\r\n        <div class=\"owl-carousel slider\">\r\n");
#nullable restore
#line 8 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
             foreach (var item in Model.sliderImages) 
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "823ef2000b3d5e3b04587f80f432448f2feea6b23978", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 235, "~/img/", 235, 6, true);
#nullable restore
#line 10 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 241, item.Image, 241, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 11 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           \r\n        </div>\r\n        <div class=\"container context pl-lg-5 ml-lg-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-5\">\r\n                    <div class=\"text\">\r\n                        ");
#nullable restore
#line 19 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.slider.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                       \r\n                        <h1>you mean it</h1>\r\n                        <p class=\"text-black-50 d-none d-sm-block\">\r\n                          ");
#nullable restore
#line 23 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                     Write(Model.slider.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"img\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 857, "\"", 890, 2);
            WriteAttributeValue("", 863, "img/", 863, 4, true);
#nullable restore
#line 27 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 867, Model.slider.Signature, 867, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 891, "\"", 897, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SLIDER END -->
    <!-- PRODUCTS START -->

    <section id=""products"">
        <div class=""container"">
            <div class=""row pt-5"">
                <div class=""col-12 d-flex justify-content-between"">
                    <ul class=""category-mobile d-md-none list-unstyled"">
                        <li>
                            <a");
            BeginWriteAttribute("href", " href=\"", 1364, "\"", 1371, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                            <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1602, "\"", 1609, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1677, "\"", 1684, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"popular\">Popular</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1760, "\"", 1767, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"winter\">Winter</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1841, "\"", 1848, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"various\">Various</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1924, "\"", 1931, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"exotic\">Exotic</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2005, "\"", 2012, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"green\">Greens</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2085, "\"", 2092, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"cactuse\">Cactuses</a></li>\r\n                            </ul>\r\n                        </li>\r\n                    </ul>\r\n                    <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2328, "\"", 2335, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n\r\n");
#nullable restore
#line 59 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                         foreach (var category in Model.category)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2495, "\"", 2502, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 61 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                               Write(category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 61 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                                                         Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 62 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </ul>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2732, "\"", 2739, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\" id=\"products-count\">\r\n");
            WriteLiteral("                ");
#nullable restore
#line 77 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
           Write(await Component.InvokeAsync("Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n\r\n            </div>\r\n            <button id=\"load\" data-count=\"");
#nullable restore
#line 80 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                     Write(ViewBag.SkipCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""btn btn-primary"">Load more</button>
        </div>
    </section>

    <!-- PRODUCTS END -->
    <!-- ABOUT START -->

    <section id=""about"">
        <div class=""container py-5"">
            <div class=""row py-5"">
                <div class=""col-lg-6"">
                    <div class=""img"">
                        ");
#nullable restore
#line 92 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.valentine.PhotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        <div class=""player position-absolute rounded-circle d-flex align-items-center justify-content-center"">
                            <i class=""fas fa-play fa-lg""></i>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""about-text mt-5 mt-lg-0 px-lg-5"">
                        ");
#nullable restore
#line 100 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.valentine.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 101 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.valentine.Desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 103 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                           foreach (var item in Model.listItem)
                          {
                              

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                         Write(Html.Raw(item.Text));

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                                  
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- ABOUT END -->
    <!-- EXPERTS START -->

    <section id=""experts"">
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""offset-lg-3 col-lg-6"">
                    <div class=""section-title"">
                        <h1>");
#nullable restore
#line 123 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                       Write(Model.title.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"text-black-50\">\r\n                           ");
#nullable restore
#line 125 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                      Write(Model.title.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row pb-5\">\r\n");
#nullable restore
#line 131 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                 foreach (var item in Model.experts)

                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-3\">\r\n                        <div class=\"item text-center\">\r\n                            <div class=\"img\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 5244, "\"", 5265, 2);
            WriteAttributeValue("", 5250, "img/", 5250, 4, true);
#nullable restore
#line 138 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 5254, item.Image, 5254, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 5299, "\"", 5305, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"text mt-3\">\r\n                                <h6>");
#nullable restore
#line 141 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <p class=\"text-black-50\">");
#nullable restore
#line 142 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                                    Write(item.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 146 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"              

                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
                <div class=""col-lg-3""></div>
            </div>
        </div>
    </section>

    <!-- EXPERTS END -->
    <!-- SUBSCRIBE START -->

  
    <section id=""subscribe""");
            BeginWriteAttribute("style", " style=\"", 5944, "\"", 5997, 4);
            WriteAttributeValue("", 5952, "background:", 5952, 11, true);
            WriteAttributeValue(" ", 5963, "url(", 5964, 5, true);
#nullable restore
#line 160 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 5968, Model.subscribeTable.Image, 5968, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5995, ");", 5995, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"container py-5\">\r\n            <div class=\"row py-5\">\r\n                <div class=\"col-12\">\r\n                    <div class=\"content text-center py-5\">\r\n                        <h3>");
#nullable restore
#line 165 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                       Write(Model.subscribeTable.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                        <div class=""form-group d-flex justify-content-center flex-wrap mt-5"">
                            <input type=""email"" placeholder=""Email Address"" class=""form-control-lg rounded-0"">
                            <button class=""btn btn-danger btn-lg rounded-0 px-5 mt-3 mt-sm-0"">Subscribe</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SUBSCRIBE END -->
    <!-- BLOG START -->

    <section id=""blog"">
        <div class=""container"">
            <div class=""row py-5"">
                <div class=""offset-lg-3 col-lg-6"">
                    <div class=""section-title"">
                        <h1>");
#nullable restore
#line 184 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                       Write(Model.blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"text-black-50\">\r\n                            ");
#nullable restore
#line 186 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                       Write(Model.blog.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row pb-5\">\r\n");
#nullable restore
#line 192 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                 foreach (var item in Model.BlogItems)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-4\">\r\n                        <div class=\"item\">\r\n                            <div class=\"img position-relative\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 7505, "\"", 7522, 1);
#nullable restore
#line 198 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 7511, item.Image, 7511, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 7541, "\"", 7547, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <div class=\"date rounded bg-light position-absolute py-1 px-2\">\r\n                                    <span>");
#nullable restore
#line 200 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                     Write(item.Date.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"text mt-3 text-center px-5\">\r\n                                <h5>");
#nullable restore
#line 204 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"text-black-50\">\r\n                                   ");
#nullable restore
#line 206 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                              Write(item.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 211 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>
    </section>

    <!-- BLOG END -->
    <!-- SAY START -->

    <section id=""say"">
        <div class=""container"">
            <div class=""row py-5 justify-content-center"">
                <div class=""col-md-8 col-xl-6"">
                    <div class=""owl-carousel say"">
                        <div>
                            <div class=""item text-center"">
                                <div class=""img d-flex justify-content-center"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 8722, "\"", 8747, 1);
#nullable restore
#line 229 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 8728, Model.worker.Image, 8728, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 8748, "\"", 8754, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                </div>\r\n                                <div class=\"text text-muted pt-3 pb-5\">\r\n                                    <i>\r\n                                       ");
#nullable restore
#line 233 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                  Write(Model.worker.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </i>\r\n                                </div>\r\n                                <div class=\"author\">\r\n                                    <h6>");
#nullable restore
#line 237 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                   Write(Model.worker.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                    <p class=\"text-black-50\">");
#nullable restore
#line 238 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                                        Write(Model.worker.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                            </div>
                        </div>
                        <div>
                            <div class=""item text-center"">
                                <div class=""img d-flex justify-content-center"">
                                    <img src=""img/testimonial-img-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 9615, "\"", 9621, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""text text-muted pt-3 pb-5"">
                                    <i>
                                        Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Aenean commodo
                                        ligula eget.
                                    </i>
                                </div>
                                <div class=""author"">
                                    <h6>Jasmine White</h6>
                                    <p class=""text-black-50"">Florist</p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- SAY END -->
    <!-- INSTAGRAM START -->

    <section id=""instagram"">
        <div class=""owl-carousel instagram"">
");
#nullable restore
#line 270 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
             foreach (var item in Model.Images)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div><img");
            BeginWriteAttribute("src", " src=\"", 10650, "\"", 10670, 1);
#nullable restore
#line 272 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 10656, item.ImageUrl, 10656, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 10689, "\"", 10695, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n");
#nullable restore
#line 273 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n           ");
#nullable restore
#line 278 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
      Write(Model.Hashtag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </section>\r\n\r\n    <!-- INSTAGRAM END -->\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
