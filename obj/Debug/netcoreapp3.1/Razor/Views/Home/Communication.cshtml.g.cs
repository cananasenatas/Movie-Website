#pragma checksum "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Communication.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c68cc977804e089e397a160971477d5ebca23270"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Communication), @"mvc.1.0.view", @"/Views/Home/Communication.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68cc977804e089e397a160971477d5ebca23270", @"/Views/Home/Communication.cshtml")]
    public class Views_Home_Communication : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Asus\source\repos\MovieWebSite\Views\Home\Communication.cshtml"
  
    ViewData["Title"] = "Communication";
    Layout = "~/Views/Shared/Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""contact-agile"">
    <div id=""map""></div>
    <div class=""faq"">
        <h4 class=""latest-text w3_latest_text"">İletişim</h4>
        <div class=""container"">
            <div class=""col-md-3 location-agileinfo"">
                <div class=""icon-w3"" style=""background-color: #6F1E51"">
                    <span class=""glyphicon glyphicon-map-marker"" aria-hidden=""true""></span>
                </div>
                <h3>Adres</h3>

                <h4>İstanbul Teknik Üniversitesi, Reşitpaşa Mah.</h4>
                <h4> Katar Cad. No:4 </h4>
                <h4>34467 Sarıyer/İstanbul</h4>
            </div>
            <div class=""col-md-3 call-agileits"">
                <div class=""icon-w3"" style=""background-color: #6F1E51"">
                    <span class=""glyphicon glyphicon-earphone"" aria-hidden=""true""></span>
                </div>
                <h3>Arama</h3>
                <h4>+180 441 2625</h4>
                <h4>+140 564 8808</h4>
                <h4>+167 893 3904<");
            WriteLiteral(@"/h4>
            </div>
            <div class=""col-md-3 mail-wthree"">
                <div class=""icon-w3"" style=""background-color: #6F1E51"">
                    <span class=""glyphicon glyphicon-envelope"" aria-hidden=""true""></span>
                </div>
                <h3>Email</h3>
                <h4><a href=""mailto:info@example.com"">asena@mail.com</a></h4>
                <h4><a href=""mailto:info@example.com"">olcsan@mail.com</a></h4>

            </div>
            <div class=""col-md-3 social-w3l"">
                <div class=""icon-w3"" style=""background-color: #6F1E51"">
                    <span class=""glyphicon glyphicon-user"" aria-hidden=""true""></span>
                </div>
                <h3>Sosyal medya</h3>
                <ul>
                    <li><a href=""https://www.facebook.com/olcsan/""><i class=""fa fa-facebook"" aria-hidden=""true""></i><span class=""text"">Facebook</span></a></li>
                    <li class=""twt""><a href=""https://twitter.com/olcsan""><i class=""fa fa-twitter");
            WriteLiteral(@""" aria-hidden=""true""></i><span class=""text"">Twitter</span></a></li>

                </ul>
            </div>
            <div class=""clearfix""></div>
            <form action=""#"" method=""post"">
                <input type=""text"" name=""your name"" placeholder=""İsim""");
            BeginWriteAttribute("required", " required=\"", 2416, "\"", 2427, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <input type=\"text\" name=\"your name\" placeholder=\"Soyisim\"");
            BeginWriteAttribute("required", " required=\"", 2504, "\"", 2515, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <input type=\"text\" name=\"your email\" placeholder=\"Email\"");
            BeginWriteAttribute("required", " required=\"", 2591, "\"", 2602, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <input type=\"text\" name=\"subject\" placeholder=\"Konu\"");
            BeginWriteAttribute("required", " required=\"", 2674, "\"", 2685, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <textarea name=\"your message\" placeholder=\"Mesajınız\"");
            BeginWriteAttribute("required", " required=\"", 2758, "\"", 2769, 0);
            EndWriteAttribute();
            WriteLiteral(@"></textarea>
                <input type=""submit"" value=""Gönder"">
            </form>
        </div>
    </div>
</div>

<script type=""text/javascript"" src=""https://maps.googleapis.com/maps/api/js""></script>
<script type=""text/javascript"">
				google.maps.event.addDomListener(window, 'load', init);
				function init() {
					var mapOptions = {
						zoom: 11,
						center: new google.maps.LatLng(40.6700, -73.9400),
						styles: [{""featureType"":""all"",""elementType"":""labels.text.fill"",""stylers"":[{""saturation"":36},{""color"":""#000000""},{""lightness"":40}]},{""featureType"":""all"",""elementType"":""labels.text.stroke"",""stylers"":[{""visibility"":""on""},{""color"":""#000000""},{""lightness"":16}]},{""featureType"":""all"",""elementType"":""labels.icon"",""stylers"":[{""visibility"":""off""}]},{""featureType"":""administrative"",""elementType"":""geometry.fill"",""stylers"":[{""color"":""#000000""},{""lightness"":20}]},{""featureType"":""administrative"",""elementType"":""geometry.stroke"",""stylers"":[{""color"":""#000000""},{""lightness"":17},{""weight"":1.2}]},{""fea");
            WriteLiteral(@"tureType"":""landscape"",""elementType"":""geometry"",""stylers"":[{""color"":""#000000""},{""lightness"":20}]},{""featureType"":""poi"",""elementType"":""geometry"",""stylers"":[{""color"":""#000000""},{""lightness"":21}]},{""featureType"":""road.highway"",""elementType"":""geometry.fill"",""stylers"":[{""color"":""#000000""},{""lightness"":17}]},{""featureType"":""road.highway"",""elementType"":""geometry.stroke"",""stylers"":[{""color"":""#000000""},{""lightness"":29},{""weight"":0.2}]},{""featureType"":""road.arterial"",""elementType"":""geometry"",""stylers"":[{""color"":""#000000""},{""lightness"":18}]},{""featureType"":""road.local"",""elementType"":""geometry"",""stylers"":[{""color"":""#000000""},{""lightness"":16}]},{""featureType"":""transit"",""elementType"":""geometry"",""stylers"":[{""color"":""#000000""},{""lightness"":19}]},{""featureType"":""water"",""elementType"":""geometry"",""stylers"":[{""color"":""#000000""},{""lightness"":17}]}]
					};
					var mapElement = document.getElementById('map');
					var map = new google.maps.Map(mapElement, mapOptions);
					var marker = new google.maps.Marker({
						position: ");
            WriteLiteral("new google.maps.LatLng(40.6700, -73.9400),\r\n\t\t\t\t\t\tmap: map,\r\n\t\t\t\t\t});\r\n\t\t\t\t}\r\n</script>\r\n\r\n\r\n");
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