#pragma checksum "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f98c475060f61489ad1e1e23bf6d1543ffffb9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f98c475060f61489ad1e1e23bf6d1543ffffb9", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abcd3afe9ad0bfae389dc3eabf6b8c00fc6234e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<main>\r\n\r\n    <!-- SLIDER START -->\r\n\r\n    <section id=\"slider\">\r\n        <div class=\"owl-carousel slider\">\r\n            <div> <img src=\"img/h3-slider-background.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 188, "\"", 194, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n            <div> <img src=\"img/h3-slider-background-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 264, "\"", 270, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n            <div> <img src=\"img/h3-slider-background-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 340, "\"", 346, 0);
            EndWriteAttribute();
            WriteLiteral("> </div>\r\n        </div>\r\n        <div class=\"container context pl-lg-5 ml-lg-3\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-5\">\r\n                    <div class=\"text\">\r\n                        ");
#nullable restore
#line 16 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.slider.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                       \r\n                        <h1>you mean it</h1>\r\n                        <p class=\"text-black-50 d-none d-sm-block\">\r\n                          ");
#nullable restore
#line 20 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                     Write(Model.slider.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"img\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 914, "\"", 947, 2);
            WriteAttributeValue("", 920, "img/", 920, 4, true);
#nullable restore
#line 24 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 924, Model.slider.Signature, 924, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 948, "\"", 954, 0);
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
            BeginWriteAttribute("href", " href=\"", 1421, "\"", 1428, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"categories mr-2\">Categories</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                            <ul class=\"category list-unstyled\" style=\"display: none;\">\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1659, "\"", 1666, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1734, "\"", 1741, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"popular\">Popular</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1817, "\"", 1824, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"winter\">Winter</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1898, "\"", 1905, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"various\">Various</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1981, "\"", 1988, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"exotic\">Exotic</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2062, "\"", 2069, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"green\">Greens</a></li>\r\n                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2142, "\"", 2149, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"cactuse\">Cactuses</a></li>\r\n                            </ul>\r\n                        </li>\r\n                    </ul>\r\n                    <ul class=\"category d-none d-md-flex list-unstyled\">\r\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2385, "\"", 2392, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"all\">All</a></li>\r\n\r\n");
#nullable restore
#line 56 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                         foreach (var category in Model.category)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a");
            BeginWriteAttribute("href", " href=\"", 2552, "\"", 2559, 0);
            EndWriteAttribute();
            WriteLiteral(" data-id=\"");
#nullable restore
#line 58 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                               Write(category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 58 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                                                         Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 59 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </ul>\r\n                    <ul class=\"list-unstyled\">\r\n                        <li>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2789, "\"", 2796, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"mr-2\">Filter</a>\r\n                            <i class=\"fas fa-caret-down\"></i>\r\n                        </li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 73 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                 foreach (var item in Model.product)
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-sm-6 col-md-4 col-lg-3 mt-3\">\r\n                        <div class=\"product-item text-center\" data-id=\"");
#nullable restore
#line 77 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                                                  Write(item.category.Name.ToLower());

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <div class=\"img\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3346, "\"", 3353, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 80 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                               Write(Html.Raw(item.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </div>\r\n                            <div class=\"title mt-3\">\r\n                                <h6>");
#nullable restore
#line 84 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                            </div>\r\n                            <div class=\"price\">\r\n                                <span class=\"text-black-50\">Add to cart</span>\r\n                                <span class=\"text-black-50\">");
#nullable restore
#line 88 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 92 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>
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
#line 106 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
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
#line 114 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.valentine.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 115 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                   Write(Html.Raw(Model.valentine.Desc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <ul class=\"list-unstyled\">\r\n");
#nullable restore
#line 117 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                           foreach (var item in Model.listItem)
                          {
                              

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                         Write(Html.Raw(item.Text));

#line default
#line hidden
#nullable disable
#nullable restore
#line 119 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                                  
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
#line 137 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                       Write(Model.title.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <p class=\"text-black-50\">\r\n                           ");
#nullable restore
#line 139 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                      Write(Model.title.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row pb-5\">\r\n");
#nullable restore
#line 145 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                 foreach (var item in Model.experts)

                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-md-6 col-lg-3\">\r\n                        <div class=\"item text-center\">\r\n                            <div class=\"img\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 5979, "\"", 6000, 2);
            WriteAttributeValue("", 5985, "img/", 5985, 4, true);
#nullable restore
#line 152 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 5989, item.Image, 5989, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid rounded-circle\"");
            BeginWriteAttribute("alt", " alt=\"", 6034, "\"", 6040, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <div class=\"text mt-3\">\r\n                                <h6>");
#nullable restore
#line 155 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                                <p class=\"text-black-50\">");
#nullable restore
#line 156 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
                                                    Write(item.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 160 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
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
            BeginWriteAttribute("style", " style=\"", 6679, "\"", 6732, 4);
            WriteAttributeValue("", 6687, "background:", 6687, 11, true);
            WriteAttributeValue(" ", 6698, "url(", 6699, 5, true);
#nullable restore
#line 174 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
WriteAttributeValue("", 6703, Model.subscribeTable.Image, 6703, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6730, ");", 6730, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <div class=\"container py-5\">\r\n            <div class=\"row py-5\">\r\n                <div class=\"col-12\">\r\n                    <div class=\"content text-center py-5\">\r\n                        <h3>");
#nullable restore
#line 179 "C:\Users\asus\OneDrive\Рабочий стол\BACKEND\ASP.NET Core Tasks\FlowerStore\FlowerStore\Views\Home\Index.cshtml"
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
                        <h1>From our Blog</h1>
                        <p class=""text-black-50"">
                            A perfect blend of creativity, energy, communication, happiness and
                            love. Let us arrange
                            a smile for you.
                ");
            WriteLiteral(@"        </p>
                    </div>
                </div>
            </div>
            <div class=""row pb-5"">
                <div class=""col-md-6 col-lg-4"">
                    <div class=""item"">
                        <div class=""img position-relative"">
                            <img src=""img/blog-feature-img-1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 8341, "\"", 8347, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                <span>29.12.2019</span>
                            </div>
                        </div>
                        <div class=""text mt-3 text-center px-5"">
                            <h5>Flower Power</h5>
                            <p class=""text-black-50"">
                                Class aptent taciti sociosqu ad litora torquent per conubia
                                nostra, per
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-4"">
                    <div class=""item"">
                        <div class=""img position-relative"">
                            <img src=""img/blog-feature-img-3.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 9230, "\"", 9236, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                <span>29.12.2019</span>
                            </div>
                        </div>
                        <div class=""text mt-3 text-center px-5"">
                            <h5>Local Florists</h5>
                            <p class=""text-black-50"">
                                Class aptent taciti sociosqu ad litora torquent per conubia
                                nostra, per
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6 col-lg-4"">
                    <div class=""item"">
                        <div class=""img position-relative"">
                            <img src=""img/blog-feature-img-4.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 10121, "\"", 10127, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <div class=""date rounded bg-light position-absolute py-1 px-2"">
                                <span>29.12.2019</span>
                            </div>
                        </div>
                        <div class=""text mt-3 text-center px-5"">
                            <h5>Flower Beauty</h5>
                            <p class=""text-black-50"">
                                Class aptent taciti sociosqu ad litora torquent per conubia
                                nostra, per
                            </p>
                        </div>
                    </div>
                </div>
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
                       ");
            WriteLiteral("     <div class=\"item text-center\">\r\n                                <div class=\"img d-flex justify-content-center\">\r\n                                    <img src=\"img/testimonial-img-1.png\"");
            BeginWriteAttribute("alt", " alt=\"", 11342, "\"", 11348, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""text text-muted pt-3 pb-5"">
                                    <i>
                                        Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus
                                        lingua.
                                    </i>
                                </div>
                                <div class=""author"">
                                    <h6>Anna Barnes</h6>
                                    <p class=""text-black-50"">Florist</p>
                                </div>
                            </div>
                        </div>
                        <div>
                            <div class=""item text-center"">
                                <div class=""img d-flex justify-content-center"">
                                    <img src=""img/testimonial-img-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 12292, "\"", 12298, 0);
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
            <div><img src=""img/instagram1.jpg"" class=""img-fluid""");
            BeginWriteAttribute("alt", " alt=\"", 13302, "\"", 13308, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram2.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 13382, "\"", 13388, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram3.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 13462, "\"", 13468, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram4.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 13542, "\"", 13548, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram5.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 13622, "\"", 13628, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram6.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 13702, "\"", 13708, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram7.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 13782, "\"", 13788, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            <div><img src=\"img/instagram8.jpg\" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 13862, "\"", 13868, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n        </div>\r\n        <div class=\"hastag bg-light text-muted py-2 px-3\">\r\n            #FIORELLO\r\n        </div>\r\n    </section>\r\n\r\n    <!-- INSTAGRAM END -->\r\n\r\n</main>");
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
