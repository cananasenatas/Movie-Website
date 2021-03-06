#pragma checksum "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\TvList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "347544f6766a11d0560cf25f0ed7a2545550ff89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TvList), @"mvc.1.0.view", @"/Views/Home/TvList.cshtml")]
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
#line 1 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\TvList.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\TvList.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"347544f6766a11d0560cf25f0ed7a2545550ff89", @"/Views/Home/TvList.cshtml")]
    public class Views_Home_TvList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<MovieWebSite.Models.Website>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\TvList.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"">
<link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.7.2/css/all.css"" integrity=""sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr"" crossorigin=""anonymous"">
<style>
    * {
        font-family: 'Poppins', sans-serif;
        -webkit-user-select: none;
        -moz-user-select: -moz-none;
        -o-user-select: none;
        user-select: none;
    }

    img {
        -webkit-user-drag: none;
        -moz-user-drag: none;
        -o-user-drag: none;
        user-drag: none;
    }

    img {
        pointer-events: none;
    }

    .movie_card {
        padding: 0 !important;
        width: 22rem;
        margin: 14px;
        border-radius: 10px;
        box-shadow: 0 3px 4px 0 rgba(0, 0, 0, 0.2), 0 4px 15px 0 rgba(0, 0, 0, 0.19);
    }

        .movie_card img {
            border-top-left-radius: 10px;
            border-top-right-r");
            WriteLiteral(@"adius: 10px;
            height: 33rem;
        }

    .movie_info {
        color: #5e5c5c;
    }

        .movie_info i {
            font-size: 20px;
        }

    .card-title {
        width: 80%;
        height: 4rem;
    }

    .play_button {
        background-color: #ff3d49;
        position: absolute;
        width: 60px;
        height: 60px;
        border-radius: 50%;
        right: 20px;
        bottom: 111px;
        font-size: 27px;
        padding-left: 21px;
        padding-top: 16px;
        color: #FFFFFF;
        cursor: pointer;
    }

    .credits {
        margin-top: 20px;
        margin-bottom: 20px;
        border-radius: 8px;
        border: 2px solid #8e24aa;
        font-size: 18px;
    }

        .credits .card-body {
            padding: 0;
        }

        .credits p {
            padding-top: 15px;
            padding-left: 18px;
        }

        .credits .card-body i {
            color: #8e24aa;
        }
</style>

");
            WriteLiteral("\n\r\n\r\n<div class=\"container mt-5\">\r\n    <h2 class=\"text-center\" style=\"background-color:black; color:white\">T??m Diziler</h2>\r\n    <div class=\"row justify-content-center\">\r\n");
#nullable restore
#line 102 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\TvList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card movie_card\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 2459, "\"", 2479, 1);
#nullable restore
#line 105 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\TvList.cshtml"
WriteAttributeValue("", 2465, item.ImageUrl, 2465, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                <div class=\"card-body\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2577, "\"", 2609, 2);
            WriteAttributeValue("", 2584, "/Website/Details/", 2584, 17, true);
#nullable restore
#line 107 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\TvList.cshtml"
WriteAttributeValue("", 2601, item.Id, 2601, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-play play_button\" data-toggle=\"tooltip\" data-placement=\"bottom\"");
            BeginWriteAttribute("title", " title=\"", 2691, "\"", 2709, 1);
#nullable restore
#line 107 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\TvList.cshtml"
WriteAttributeValue("", 2699, item.Name, 2699, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 108 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\TvList.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <span class=\"movie_info\">");
#nullable restore
#line 109 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\TvList.cshtml"
                                        Write(item.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"movie_info float-right\"><i class=\"fas fa-star\"></i>IMDB : ");
#nullable restore
#line 110 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\TvList.cshtml"
                                                                                      Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 113 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\TvList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 120 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\TvList.cshtml"
Write(Html.PagedListPager((IPagedList)Model, page => Url.Action("MovieList", new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js""></script>

<script>
    $(function () {
        $('[data-toggle=""tooltip""]').tooltip()
    })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<MovieWebSite.Models.Website>> Html { get; private set; }
    }
}
#pragma warning restore 1591
