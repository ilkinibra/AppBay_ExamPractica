#pragma checksum "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e741588aa429c4e7d87da89d175c7c2c414003b"
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
#line 2 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\_ViewImports.cshtml"
using AppBay_BackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\_ViewImports.cshtml"
using AppBay_BackEnd.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e741588aa429c4e7d87da89d175c7c2c414003b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6d271a3bc5199143afeb706f2f79e07c87c278a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100 slider-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/tablet.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml"
  
       ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<main>
          <!-- Slider Start -->
          <section class=""slider"">
            <div id=""carouselExampleSlidesOnly"" class=""carousel slide"" data-bs-ride=""carousel"">
                <div class=""carousel-inner"">
                  <div class=""carousel-item active"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0e741588aa429c4e7d87da89d175c7c2c414003b5062", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 363, "~/img/", 363, 6, true);
#nullable restore
#line 11 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 369, Model.sliders.ImageUrlBackGround, 369, 33, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                  </div>\r\n                  <div class=\"col-6 slider-mobile\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0e741588aa429c4e7d87da89d175c7c2c414003b6829", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 558, "~/img/", 558, 6, true);
#nullable restore
#line 14 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 564, Model.sliders.ImageUrl, 564, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                  </div>
                  <!-- <div class=""col-6 slider-text"">
                    <h1>Responsive Page Landing Page</h1>
                    <h4>Bootstrap Based Responsive Landing Page Template.</h4>
                    <div class=""app-download"">
                      <a class=""navbar-brand"" href=""#""><i class=""fa-solid fa-mobile-screen slider-icon""></i>
                        <span class=""available"">Available on the</span>
                        <span class=""appstore"">App Store</span>
                    </a>
                    </div> 
                  </div>-->
                </div>
              </div>
          </section>
        <!-- Slider End -->
        <!-- Card Start -->
        <section class=""card"">
         <div class=""container"">
          <div class=""row"">
            <div class=""row row-cols-1 row-cols-md-3 g-4"">
");
#nullable restore
#line 35 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml"
                 foreach (var item in Model.cards)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div class=\"col\">\r\n                <div class=\"card h-100 text-center card-area\">\r\n                  <i");
            BeginWriteAttribute("class", " class=\"", 1671, "\"", 1693, 1);
#nullable restore
#line 39 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml"
WriteAttributeValue("", 1679, item.IconPath, 1679, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                  <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 41 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml"
                                      Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 42 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                  </div>\r\n                </div>\r\n              </div>\n");
#nullable restore
#line 46 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
          </div>
         </div>

        </section>
        <!-- Card End -->
        <!--Modern Start  -->
        <section class=""modern"">
          <div class=""container"">
            <div class=""row"">
              <div class=""section-title text-center mt-5"">
                <h3 class=""modern-title"">Modern & clean landing page theme</h3>
                <p class=""modern-subtitle"">Lorem ipsum dolizzle sit tellivizzle, boom shackalack adipiscing elit. Nullam mofo velizzle, sure cool.</p>
              </div>
            </div>
            <div class=""modern-context d-flex"">
              <div class=""col-6 modern-img"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0e741588aa429c4e7d87da89d175c7c2c414003b11718", async() => {
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
            WriteLiteral("\r\n              </div>\r\n              <div class=\"col-6 modern-context\">\r\n");
#nullable restore
#line 67 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml"
                         foreach (var item in Model.moderns)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <div class=\"card mb-3 modern-card\" style=\"max-width: 540px;\">\r\n                    <div class=\"row g-0\">\n                                 <div class=\"col-2\">\r\n                        <i");
            BeginWriteAttribute("class", " class=\"", 3055, "\"", 3077, 1);
#nullable restore
#line 72 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml"
WriteAttributeValue("", 3063, item.IconPath, 3063, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                      </div>\r\n                      <div class=\"col-md-8\">\r\n                        <div class=\"card-body\">\r\n                          <h5 class=\"card-title\">");
#nullable restore
#line 76 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml"
                                            Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                          <p class=\"card-text\">");
#nullable restore
#line 77 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml"
                                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                      </div>\n                      \r\n                    </div>\r\n                     \r\n                  </div>\n");
#nullable restore
#line 84 "C:\Users\HP\Desktop\AspNet\AppBay_BackEnd\AppBay_BackEnd\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            
            </div>
        </div>
    </div>
        </section>
        <!--Modern End  -->
        <!-- TextSlider Start -->
        <section class=""TextSlider"">
          <div class=""container"">
            <div class=""row"">
              <p class=""textslider-text text-center"" style=""color:blue;"">What people say</p>
              <div id=""slider"">
                <ul>
                  <li>
                  <div class=""slider-container"">
                    <p>“Went with my wife, absolutely brilliant restaurant, the food tasted beautiful, so much depth and very well presented. As good if not better than any in the city centre. Will definitely be returning.” <br> Nathaniel Harwood – Google</p>
                  </div>
                  </li>
                    <li>
                    <div class=""slider-container"">
                    <p>“Great friendly service, the staff don't make you feel rushed, but are also very attentive, and on hand all the time if ne");
            WriteLiteral(@"eded, best Thai food I have had in years, flavours are out of this world, and extremely good prices for the quality you get is top notch!!!!!! Love it” <br>David Armstrong - Porter – Google</p>
                  </div>
                  </li>
                    <li>
                    <div class=""slider-container"">
                    <p>“Possibly one of the best in Manchester. A menu designed and prepared by a very skilled chef, ably assisted by his wife who provides a friendly welcome. Always consistent and of high quality.” <br>Paul Fletcher – Google</p>
                  </div>
                  </li>
                    <li>
                    <div class=""slider-container"">
                    <p>“Food was amazing and service could not have been better...we went for a quick lunch as our office is opposite the restaurant...very quick service...I am highly recommending this restaurant to all my family and friends...” <br>Nic Gent – Facebook Page</p>
                  </div>
                 ");
            WriteLiteral(@" </li>
                   <li>
                    <div class=""slider-container"">
                    <p>“Went for the first time last night for my Husbands Birthday, friendly staff, very tasty food, would highly recommend, we will be back.” <br>Joanne Simms – Facebook Page</p>
                  </div>
                  </li>
                   <li>
                    <div class=""slider-container"">
                    <p>“A lovely, well decorated restaurant, where great food is served by very friendly staff for a bargain price. The food is authentic and delicious. We'll definitely be returning.”<br>Joe H – Trip Advisor</p>
                  </div>
                  </li>
                </ul>
                </div>
                
            </div>
          </div>
        </section>
        <!-- TextSlider End -->
    </main>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
