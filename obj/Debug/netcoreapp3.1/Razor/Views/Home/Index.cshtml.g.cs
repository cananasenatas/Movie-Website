#pragma checksum "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bf1cadb651644252690c7e0fd1e92145a1060d9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bf1cadb651644252690c7e0fd1e92145a1060d9", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MovieWebSite.Models.Website>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/js/jquery.slidey.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/js/jquery.dotdotdot.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/css/owl.carousel.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("all"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/js/owl.carousel.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap-grid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"slidey\" style=\"display: none;\">\r\n    <ul>\r\n");
#nullable restore
#line 8 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
         foreach (var item in Model.Where(x=>x.FilterId==1).Take(5))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li><img");
            BeginWriteAttribute("src", " src=\"", 282, "\"", 302, 1);
#nullable restore
#line 10 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 288, item.ImageUrl, 288, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" \"><p class=\'title\'>");
#nullable restore
#line 10 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><p class=\'description\'>");
#nullable restore
#line 10 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                                                                                                   Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></li>\r\n");
#nullable restore
#line 11 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bf1cadb651644252690c7e0fd1e92145a1060d97193", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bf1cadb651644252690c7e0fd1e92145a1060d98232", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    $(\"#slidey\").slidey({\r\n        interval: 8000,\r\n        listCount: 5,\r\n        autoplay: false,\r\n        showList: true\r\n    });\r\n    $(\".slidey-list-description\").dotdotdot();\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6bf1cadb651644252690c7e0fd1e92145a1060d99521", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bf1cadb651644252690c7e0fd1e92145a1060d910802", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $(""#owl-demo"").owlCarousel({

            autoPlay: 3000, //Set AutoPlay to 3 seconds

            items: 5,
            itemsDesktop: [640, 4],
            itemsDesktopSmall: [414, 3]
        });
    });
</script>





<div class=""banner-bottom"">
    <div class=""container"">
        <div class=""w3_agile_banner_bottom_grid"">
            <div id=""owl-demo"" class=""owl-carousel owl-theme"">
");
#nullable restore
#line 48 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                 foreach (var item in Model.Where(x=>x.FilterId==1).Skip(5).Take(6))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"item\">\r\n                        <div class=\"w3l-movie-gride-agile w3l-movie-gride-agile1\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1618, "\"", 1650, 2);
            WriteAttributeValue("", 1625, "/Website/Details/", 1625, 17, true);
#nullable restore
#line 52 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 1642, item.Id, 1642, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"hvr-shutter-out-horizontal\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1725, "\"", 1745, 1);
#nullable restore
#line 53 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 1731, item.ImageUrl, 1731, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" title=""album-name"" class=""img-responsive"" alt="" "" />
                                <div class=""w3l-action-icon""><i class=""fa fa-play-circle"" aria-hidden=""true""></i></div>
                            </a>
                            <div class=""mid-1 agileits_w3layouts_mid_1_home"">
                                <div class=""w3l-movie-text"">
                                    <h6><a");
            BeginWriteAttribute("href", " href=\"", 2139, "\"", 2171, 2);
            WriteAttributeValue("", 2146, "/Website/Details/", 2146, 17, true);
#nullable restore
#line 58 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 2163, item.Id, 2163, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 58 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                                                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                </div>\r\n                                <div class=\"mid-2 agile_mid_2_home\">\r\n                                    <p>");
#nullable restore
#line 61 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                                  Write(item.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    <div class=""block-stars"">
                                        <ul class=""w3l-ratings"">
                                            <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                            <li><a href=""#""><i class=""fa fa-star-half-o"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                        </ul>
                                    </div>
                                    <div class=""clearfix""></div>
                                </d");
            WriteLiteral(@"iv>
                            </div>
                            <div class=""ribben"" style=""background-color:#6F1E51"">
                                <p>NEW</p>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 79 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>




<div class=""general"">
    <h4 class=""latest-text w3_latest_text"" >Öne Çıkanlar</h4>
    <div class=""container"">
        <div class=""bs-example bs-example-tabs"" role=""tabpanel"" data-example-id=""togglable-tabs"">
            <ul id=""myTab"" class=""nav nav-tabs"" role=""tablist"" style="" color: #6F1E51"" >
                <li role=""presentation"" class=""active""><a href=""#home"" id=""home-tab"" role=""tab"" data-toggle=""tab"" aria-controls=""home"" aria-expanded=""true"">Popüler</a></li>
                <li role=""presentation""><a href=""#profile"" role=""tab"" id=""profile-tab"" data-toggle=""tab"" aria-controls=""profile"" aria-expanded=""false"">Vizyondakiler</a></li>
                <li role=""presentation""><a href=""#rating"" id=""rating-tab"" role=""tab"" data-toggle=""tab"" aria-controls=""rating"" aria-expanded=""true"">Imdb puanı Yüksek</a></li>
                <li role=""presentation""><a href=""#imdb"" role=""tab"" id=""imdb-tab"" data-toggle=""tab"" aria-controls=""imdb"" aria-expande");
            WriteLiteral(@"d=""false"">Son Eklenenler</a></li>
            </ul>
            <div id=""myTabContent"" class=""tab-content"">
                <div role=""tabpanel"" class=""tab-pane fade active in"" id=""home"" aria-labelledby=""home-tab"">
                    <div class=""w3_agile_featured_movies"">
                        <div class=""row"">
");
#nullable restore
#line 102 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                             foreach (var item in Model.Where(x => x.FilterId == 1).Skip(11).Take(7))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-md-4 w3l-movie-gride-agile\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5263, "\"", 5295, 2);
            WriteAttributeValue("", 5270, "/Website/Details/", 5270, 17, true);
#nullable restore
#line 105 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 5287, item.Id, 5287, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"hvr-shutter-out-horizontal\">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 5378, "\"", 5398, 1);
#nullable restore
#line 106 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 5384, item.ImageUrl, 5384, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" title=""album-name"" class=""img-responsive"" alt="" "" />
                                        <div class=""w3l-action-icon""><i class=""fa fa-play-circle"" aria-hidden=""true""></i></div>
                                    </a>
                                    <div class=""mid-1 agileits_w3layouts_mid_1_home"">
                                        <div class=""w3l-movie-text"">
                                            <h6><a");
            BeginWriteAttribute("href", " href=\"", 5832, "\"", 5864, 2);
            WriteAttributeValue("", 5839, "/Website/Details/", 5839, 17, true);
#nullable restore
#line 111 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 5856, item.Id, 5856, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 111 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                        </div>\r\n                                        <div class=\"mid-2 agile_mid_2_home\">\r\n                                            <p>");
#nullable restore
#line 114 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                                          Write(item.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            <div class=""block-stars"">
                                                <ul class=""w3l-ratings"">
                                                    <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                    <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                    <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                    <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                    <li><a href=""#""><i class=""fa fa-star-half-o"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                </ul>
                                            </div>
                             ");
            WriteLiteral("               <div class=\"clearfix\"></div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 128 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>

                        <div class=""clearfix""> </div>

                    </div>
                </div>
                <div role=""tabpanel"" class=""tab-pane fade"" id=""profile"" aria-labelledby=""profile-tab"">
                    <div class=""row"">
");
#nullable restore
#line 137 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                         foreach (var item in Model.Where(x => x.FilterId == 1).Skip(18).Take(5))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-4 w3l-movie-gride-agile\">\r\n\r\n\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 7833, "\"", 7865, 2);
            WriteAttributeValue("", 7840, "/Website/Details/", 7840, 17, true);
#nullable restore
#line 142 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 7857, item.Id, 7857, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"hvr-shutter-out-horizontal\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 7944, "\"", 7964, 1);
#nullable restore
#line 143 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 7950, item.ImageUrl, 7950, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" title=""album-name"" class=""img-responsive"" alt="" "" />
                                    <div class=""w3l-action-icon""><i class=""fa fa-play-circle"" aria-hidden=""true""></i></div>
                                </a>
                                <div class=""mid-1 agileits_w3layouts_mid_1_home"">
                                    <div class=""w3l-movie-text"">
                                        <h6><a");
            BeginWriteAttribute("href", " href=\"", 8378, "\"", 8410, 2);
            WriteAttributeValue("", 8385, "/Website/Details/", 8385, 17, true);
#nullable restore
#line 148 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 8402, item.Id, 8402, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 148 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                    </div>\r\n                                    <div class=\"mid-2 agile_mid_2_home\">\r\n                                        <p>");
#nullable restore
#line 151 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                                      Write(item.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        <div class=""block-stars"">
                                            <ul class=""w3l-ratings"">
                                                <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-star-half-o"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-star-o"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-star-o"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-star-o"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                            </ul>
                                        </div>
                                        <div class=""clearfi");
            WriteLiteral("x\"></div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 165 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n                    <div class=\"clearfix\"> </div>\r\n                </div>\r\n                <div role=\"tabpanel\" class=\"tab-pane fade\" id=\"rating\" aria-labelledby=\"rating-tab\">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 172 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                         foreach (var item in Model.Where(x => x.FilterId == 1).Skip(23).Take(4))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-4 w3l-movie-gride-agile\">\r\n\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 10275, "\"", 10307, 2);
            WriteAttributeValue("", 10282, "/Website/Details/", 10282, 17, true);
#nullable restore
#line 176 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 10299, item.Id, 10299, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"hvr-shutter-out-horizontal\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 10386, "\"", 10406, 1);
#nullable restore
#line 177 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 10392, item.ImageUrl, 10392, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" title=""album-name"" class=""img-responsive"" alt="" "" />
                                    <div class=""w3l-action-icon""><i class=""fa fa-play-circle"" aria-hidden=""true""></i></div>
                                </a>
                                <div class=""mid-1 agileits_w3layouts_mid_1_home"">
                                    <div class=""w3l-movie-text"">
                                        <h6><a");
            BeginWriteAttribute("href", " href=\"", 10820, "\"", 10852, 2);
            WriteAttributeValue("", 10827, "/Website/Details/", 10827, 17, true);
#nullable restore
#line 182 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 10844, item.Id, 10844, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 182 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                    </div>\r\n                                    <div class=\"mid-2 agile_mid_2_home\">\r\n                                        <p>");
#nullable restore
#line 185 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                                      Write(item.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        <div class=""block-stars"">
                                            <ul class=""w3l-ratings"">
                                                <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-star-half-o"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-star-o"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                            </ul>
                                        </div>
                                        <div class=""clearfix""><");
            WriteLiteral("/div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 199 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n                    <div class=\"clearfix\"> </div>\r\n                </div>\r\n                <div role=\"tabpanel\" class=\"tab-pane fade\" id=\"imdb\" aria-labelledby=\"imdb-tab\">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 206 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                         foreach (var item in Model.Skip(27).Take(2))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-md-4 w3l-movie-gride-agile\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 12679, "\"", 12711, 2);
            WriteAttributeValue("", 12686, "/Website/Details/", 12686, 17, true);
#nullable restore
#line 209 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 12703, item.Id, 12703, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"hvr-shutter-out-horizontal\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 12790, "\"", 12810, 1);
#nullable restore
#line 210 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 12796, item.ImageUrl, 12796, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" title=""album-name"" class=""img-responsive"" alt="" "" />
                                    <div class=""w3l-action-icon""><i class=""fa fa-play-circle"" aria-hidden=""true""></i></div>
                                </a>
                                <div class=""mid-1 agileits_w3layouts_mid_1_home"">
                                    <div class=""w3l-movie-text"">
                                        <h6><a");
            BeginWriteAttribute("href", " href=\"", 13224, "\"", 13256, 2);
            WriteAttributeValue("", 13231, "/Website/Details/", 13231, 17, true);
#nullable restore
#line 215 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
WriteAttributeValue("", 13248, item.Id, 13248, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 215 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                    </div>\r\n                                    <div class=\"mid-2 agile_mid_2_home\">\r\n                                        <p>");
#nullable restore
#line 218 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                                      Write(item.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                        <div class=""block-stars"">
                                            <ul class=""w3l-ratings"">
                                                <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-star"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-star-half-o"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-star-o"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                                <li><a href=""#""><i class=""fa fa-star-o"" style=""color:#6F1E51"" aria-hidden=""true""></i></a></li>
                                            </ul>
                                        </div>
                                        <div class=""clearfix""");
            WriteLiteral("></div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 232 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n\r\n                    <div class=\"clearfix\"> </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6bf1cadb651644252690c7e0fd1e92145a1060d936344", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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