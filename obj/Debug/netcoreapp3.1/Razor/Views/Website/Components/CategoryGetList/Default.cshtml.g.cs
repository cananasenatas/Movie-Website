#pragma checksum "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\Components\CategoryGetList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "203f199d109801df77c380d7fc5228ea8de5ddb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Website_Components_CategoryGetList_Default), @"mvc.1.0.view", @"/Views/Website/Components/CategoryGetList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203f199d109801df77c380d7fc5228ea8de5ddb4", @"/Views/Website/Components/CategoryGetList/Default.cshtml")]
    public class Views_Website_Components_CategoryGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieWebSite.Models.Genres>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""movies_nav"" style=""background-color:black"">
    <div class=""container"">
        <nav class=""navbar navbar-default"">
            <div class=""navbar-header navbar-left"">
                <button type=""button"" style=""background-color:black "" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#bs-example-navbar-collapse-1"">
                    <span class=""sr-only"">Toggle navigation</span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                    <span class=""icon-bar""></span>
                </button>
            </div>
            <!-- Collect the nav links, forms, and other content for toggling -->
            <div class=""collapse navbar-collapse navbar-right"" id=""bs-example-navbar-collapse-1"">
                <nav>
                    <ul class=""nav navbar-nav"">
                        <li class=""active""><a href=""/Home/Index/"" style=""background-color: #6F1E51"">Ana Sayfa</a></li>
                      ");
            WriteLiteral(@"  <li class=""dropdown"" style=""background-color:black; color:white"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"">Film Türleri <b class=""caret""></b></a>
                            <ul class=""dropdown-menu multi-column columns-3"" style=""background-color: white"">

                                <li>
");
#nullable restore
#line 24 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\Components\CategoryGetList\Default.cshtml"
                                     foreach (var item in Model.Take(5))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-sm-4\">\r\n                                            <ul class=\"multi-column-dropdown\" style=\"background-color:white\">\r\n                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 1761, "\"", 1798, 2);
            WriteAttributeValue("", 1768, "/Home/CategoryDetails/", 1768, 22, true);
#nullable restore
#line 28 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\Components\CategoryGetList\Default.cshtml"
WriteAttributeValue("", 1790, item.Id, 1790, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\Components\CategoryGetList\Default.cshtml"
                                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\r\n\r\n                                            </ul>\r\n                                        </div>\r\n");
#nullable restore
#line 33 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\Components\CategoryGetList\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\Components\CategoryGetList\Default.cshtml"
                                     foreach (var item in Model.Skip(5).Take(5))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-sm-4\">\r\n                                            <ul class=\"multi-column-dropdown\" s>\r\n                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2284, "\"", 2321, 2);
            WriteAttributeValue("", 2291, "/Home/CategoryDetails/", 2291, 22, true);
#nullable restore
#line 38 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\Components\CategoryGetList\Default.cshtml"
WriteAttributeValue("", 2313, item.Id, 2313, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 38 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\Components\CategoryGetList\Default.cshtml"
                                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\r\n\r\n                                            </ul>\r\n                                        </div>\r\n");
#nullable restore
#line 43 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\Components\CategoryGetList\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\Components\CategoryGetList\Default.cshtml"
                                     foreach (var item in Model.Skip(10).Take(5))
                                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"col-sm-4\">\r\n                                            <ul class=\"multi-column-dropdown\">\r\n\r\n\r\n                                                <li><a");
            BeginWriteAttribute("href", " href=\"", 2812, "\"", 2849, 2);
            WriteAttributeValue("", 2819, "/Home/CategoryDetails/", 2819, 22, true);
#nullable restore
#line 51 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\Components\CategoryGetList\Default.cshtml"
WriteAttributeValue("", 2841, item.Id, 2841, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\Components\CategoryGetList\Default.cshtml"
                                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n\r\n                                            </ul>\r\n                                        </div>\r\n");
#nullable restore
#line 55 "C:\Users\Asus\source\repos\MovieWebSite\Views\Website\Components\CategoryGetList\Default.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <div class=""clearfix""></div>
                                </li>
                            </ul>
                        </li>

                        <li><a href=""/Home/TvList/"" style=""background-color: #6F1E51"">Diziler</a></li>
                        <li><a href=""/Home/RecentlyAdded/"" style=""background-color: black"">Son Eklenenler</a></li>
                        <li><a href=""/Home/AZList/"" style=""background-color: #6F1E51"">A - Z Sıralama</a></li>

                        <li><a href=""/Home/ImdbList/"" style=""background-color: black"">IMDB Puanı</a></li>

                    </ul>
                </nav>
            </div>
        </nav>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieWebSite.Models.Genres>> Html { get; private set; }
    }
}
#pragma warning restore 1591
