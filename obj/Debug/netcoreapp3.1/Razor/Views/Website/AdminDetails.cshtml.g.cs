#pragma checksum "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e8cf1c0413d227e327a6c3417dfd87601966eed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Website_AdminDetails), @"mvc.1.0.view", @"/Views/Website/AdminDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e8cf1c0413d227e327a6c3417dfd87601966eed", @"/Views/Website/AdminDetails.cshtml")]
    public class Views_Website_AdminDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MovieWebSite.Models.Website>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
  
    ViewData["Title"] = "AdminDetails";
    Layout = "~/Views/Shared/OperationLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
 foreach (var x in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-white container\" style=\"background-color:black\">\r\n        <br />\r\n        <center><h1 style=\"color:white; text-transform:uppercase\">");
#nullable restore
#line 11 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
                                                             Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1></center>\r\n        <hr />\r\n        <div>\r\n");
#nullable restore
#line 14 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
              
                var link = "https://www.youtube.com/embed/";
                var model = x.Link;
                var movielink = link + model;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <iframe width=\"100%\" height=\"500\"");
            BeginWriteAttribute("src", " src=\"", 606, "\"", 622, 1);
#nullable restore
#line 19 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
WriteAttributeValue("", 612, movielink, 612, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" frameborder=""0"" allow=""accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture"" allowfullscreen></iframe>
        </div>
        <br />
        <br />

        <div class=""detailbox row"">
            <div class=""col-md-3 col-sm-10"">

                <img");
            BeginWriteAttribute("src", " src=\"", 902, "\"", 919, 1);
#nullable restore
#line 27 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
WriteAttributeValue("", 908, x.ImageUrl, 908, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200px\" height=\"350px\"");
            BeginWriteAttribute("title", " title=", 949, "", 963, 1);
#nullable restore
#line 27 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
WriteAttributeValue("", 956, x.Name, 956, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <br />\r\n            <div class=\"col-md-9 col-sm-10\">\r\n                <div class=\"row pr-3\">\r\n                    <div class=\"col-md-7\">\r\n                        <h4 style=\"color: white; text-transform: uppercase\"><b>");
#nullable restore
#line 33 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
                                                                          Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\r\n                        <br />\r\n                        <br />\r\n                        <p class=\"lead\" style=\"color:white\">");
#nullable restore
#line 36 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
                                                       Write(x.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-md-5\">\r\n                        <h6 style=\"color:white;\"><span class=\"text-danger\">Kategorisi</span> : ");
#nullable restore
#line 39 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
                                                                                          Write(x.Filter.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <br />\r\n                        <h6 style=\"color:white;\"><span class=\"text-danger\">Direktör</span> : ");
#nullable restore
#line 41 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
                                                                                        Write(x.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <br />\r\n                        <h6 style=\"color:white\"><span class=\"text-danger\">Çıkış Yılı</span> : ");
#nullable restore
#line 43 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
                                                                                         Write(x.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <br />\r\n                        <h6 style=\"color:white\"><span class=\"text-danger\">Imdb Puanı</span> : ");
#nullable restore
#line 45 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
                                                                                         Write(x.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <br />\r\n                        <h6 style=\"color:white\"><span class=\"text-danger\">Türü</span> : ");
#nullable restore
#line 47 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
                                                                                   Write(x.Genres.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <br />\r\n                        <h6 style=\"color:white\"><span class=\"text-danger\">İzleme Seçeneği</span> : ");
#nullable restore
#line 49 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
                                                                                              Write(x.Choose.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <br />\r\n                        <h6 style=\"color:white\"><span class=\"text-danger\">Ülke</span> : ");
#nullable restore
#line 51 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
                                                                                   Write(x.Country.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <br />\r\n                        <h6 style=\"color:white\"><span class=\"text-danger\">Aktörler</span> : ");
#nullable restore
#line 53 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
                                                                                       Write(x.Actors);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <br />\r\n                        <h6 style=\"color:white\"><span class=\"text-danger\">Süresi</span> : ");
#nullable restore
#line 55 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"
                                                                                     Write(x.WatchTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n");
#nullable restore
#line 65 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\AdminDetails.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MovieWebSite.Models.Website>> Html { get; private set; }
    }
}
#pragma warning restore 1591
