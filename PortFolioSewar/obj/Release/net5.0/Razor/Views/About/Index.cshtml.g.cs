#pragma checksum "C:\Users\hp\source\repos\PortFolioSewar\PortFolioSewar\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89031cc9ea1d6cdf36f7b883886c8b37b9fb26fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
#line 1 "C:\Users\hp\source\repos\PortFolioSewar\PortFolioSewar\Views\_ViewImports.cshtml"
using PortFolioSewar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\PortFolioSewar\PortFolioSewar\Views\_ViewImports.cshtml"
using PortFolioSewar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89031cc9ea1d6cdf36f7b883886c8b37b9fb26fc", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"356b97422f2e828774f17cdd6af3a4feedd15028", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PortFolioSewar.Models.Owner>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hp\source\repos\PortFolioSewar\PortFolioSewar\Views\About\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<main id=\"main\">\r\n");
#nullable restore
#line 9 "C:\Users\hp\source\repos\PortFolioSewar\PortFolioSewar\Views\About\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <section id=""about"" class=""about"">
            <div class=""container"">

                <div class=""section-title"">
                    <h2>About</h2>
                    <p></p>
                </div>

                <div class=""row"">
                    <div class=""col-lg-4"" data-aos=""fade-right"">
                        <img");
            BeginWriteAttribute("src", "  src=\"", 503, "\"", 537, 1);
#nullable restore
#line 21 "C:\Users\hp\source\repos\PortFolioSewar\PortFolioSewar\Views\About\Index.cshtml"
WriteAttributeValue("", 510, Url.Content("~/"+item.Pic), 510, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 556, "\"", 562, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""col-lg-8 pt-4 pt-lg-0 content"" data-aos=""fade-left"">
                        <h3> Web Developer</h3>
                        <p class=""fst-italic"">

                        </p>
                        <div class=""row"">
                            <div class=""col-lg-6"">
                                <ul>
                                    <li><i class=""bi bi-chevron-right""></i> <strong>Birthday:</strong> <span>");
#nullable restore
#line 31 "C:\Users\hp\source\repos\PortFolioSewar\PortFolioSewar\Views\About\Index.cshtml"
                                                                                                        Write(item.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n");
            WriteLiteral("                                    <li><i class=\"bi bi-chevron-right\"></i> <strong>Degree:</strong> <span>");
#nullable restore
#line 34 "C:\Users\hp\source\repos\PortFolioSewar\PortFolioSewar\Views\About\Index.cshtml"
                                                                                                      Write(item.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                    <li><i class=\"bi bi-chevron-right\"></i> <strong>City:</strong> <span>");
#nullable restore
#line 35 "C:\Users\hp\source\repos\PortFolioSewar\PortFolioSewar\Views\About\Index.cshtml"
                                                                                                    Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
                                </ul>
                            </div>
                            <div class=""col-lg-6"">
                                <ul>
                                    <li><i class=""bi bi-chevron-right""></i> <strong>Age:</strong> <span>");
#nullable restore
#line 40 "C:\Users\hp\source\repos\PortFolioSewar\PortFolioSewar\Views\About\Index.cshtml"
                                                                                                   Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                  \r\n                                    <li><i class=\"bi bi-chevron-right\"></i> <strong>Email:</strong> <span>");
#nullable restore
#line 42 "C:\Users\hp\source\repos\PortFolioSewar\PortFolioSewar\Views\About\Index.cshtml"
                                                                                                     Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                    <li><i class=\"bi bi-chevron-right\"></i> <strong>Freelance:</strong> <span>");
#nullable restore
#line 43 "C:\Users\hp\source\repos\PortFolioSewar\PortFolioSewar\Views\About\Index.cshtml"
                                                                                                         Write(item.Freelance);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></li>
                                </ul>
                            </div>
                        </div>
                        <p>

                        </p>
                    </div>
                </div>

            </div>
        </section><!-- End About Section -->
        <!-- ======= Skills Section ======= -->
");
#nullable restore
#line 56 "C:\Users\hp\source\repos\PortFolioSewar\PortFolioSewar\Views\About\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <section id=""skills"" class=""skills section-bg"">
        <div class=""container"">

            <div class=""section-title"">
                <h2>Skills</h2>
                <p></p>
            </div>

            <div class=""row skills-content"">

                <div class=""col-lg-6"" data-aos=""fade-up"">

                    <div class=""progress"">
                        <span class=""skill"">HTML <i class=""val"">100%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>

                    <div class=""progress"">
                        <span class=""skill"">CSS <i class=""val"">90%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""></div>
     ");
            WriteLiteral(@"                   </div>
                    </div>

                    <div class=""progress"">
                        <span class=""skill"">Python <i class=""val"">75%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>
                    <div class=""progress"">
                        <span class=""skill"">C# <i class=""val"">80%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>
                    <div class=""progress"">
                        <span class=""skill"">Power BI <i class=""val"">75%</i></span>
                        <div class=""progress-bar-wrap"">
                        ");
            WriteLiteral(@"    <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""75"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>

                </div>

                <div class=""col-lg-6"" data-aos=""fade-up"" data-aos-delay=""100"">

                    <div class=""progress"">
                        <span class=""skill"">PHP <i class=""val"">70%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""70"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>

                    <div class=""progress"">
                        <span class=""skill"">Bootstrap<i class=""val"">90%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
     ");
            WriteLiteral(@"               </div>

                    <div class=""progress"">
                        <span class=""skill"">Photoshop <i class=""val"">55%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""55"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>
                    <div class=""progress"">
                        <span class=""skill"">SSO <i class=""val"">70%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""70"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>
                    <div class=""progress"">
                        <span class=""skill"">Excel <i class=""val"">80%</i></span>
                        <div class=""progress-bar-wrap"">
                            <div class=""progress-bar"" r");
            WriteLiteral(@"ole=""progressbar"" aria-valuenow=""80"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>
                </div>

            </div>

        </div>
    </section><!-- End Skills Section -->

</main>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PortFolioSewar.Models.Owner>> Html { get; private set; }
    }
}
#pragma warning restore 1591
