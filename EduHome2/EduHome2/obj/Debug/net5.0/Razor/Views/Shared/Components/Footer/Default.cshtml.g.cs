#pragma checksum "C:\Users\user\OneDrive\Masaüstü\C# B_C\EduHome2\EduHome2\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86e35cf295f36e90c08560ab6dbe4fc4990cd93f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\user\OneDrive\Masaüstü\C# B_C\EduHome2\EduHome2\Views\_ViewImports.cshtml"
using EduHome2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\OneDrive\Masaüstü\C# B_C\EduHome2\EduHome2\Views\_ViewImports.cshtml"
using EduHome2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\OneDrive\Masaüstü\C# B_C\EduHome2\EduHome2\Views\_ViewImports.cshtml"
using EduHome2.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86e35cf295f36e90c08560ab6dbe4fc4990cd93f", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07794f39fb6b78e141765252736bdf6f3111f11a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bio>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("eduhome"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<footer class=""footer-area"">
            <div class=""main-footer"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-4 col-sm-6 col-xs-12"">
                            <div class=""single-widget pr-60"">
                                <div class=""footer-logo pb-25"">
                                    <a href=""index.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "86e35cf295f36e90c08560ab6dbe4fc4990cd93f4196", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 426, "~/img/logo/", 426, 11, true);
#nullable restore
#line 10 "C:\Users\user\OneDrive\Masaüstü\C# B_C\EduHome2\EduHome2\Views\Shared\Components\Footer\Default.cshtml"
AddHtmlAttributeValue("", 437, Model.FooterLogo, 437, 17, false);

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
            WriteLiteral(@"</a>
                                </div>
                                <p>I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and give you a coete account of the system. </p>
                                <div class=""footer-social"">
                                    <ul>
                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 844, "\"", 866, 1);
#nullable restore
#line 15 "C:\Users\user\OneDrive\Masaüstü\C# B_C\EduHome2\EduHome2\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 851, Model.FaceBook, 851, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 959, "\"", 982, 1);
#nullable restore
#line 16 "C:\Users\user\OneDrive\Masaüstü\C# B_C\EduHome2\EduHome2\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 966, Model.Pinterest, 966, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1076, "\"", 1095, 1);
#nullable restore
#line 17 "C:\Users\user\OneDrive\Masaüstü\C# B_C\EduHome2\EduHome2\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1083, Model.Vimeo, 1083, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                                        <li><a");
            BeginWriteAttribute("href", " href=\"", 1185, "\"", 1206, 1);
#nullable restore
#line 18 "C:\Users\user\OneDrive\Masaüstü\C# B_C\EduHome2\EduHome2\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1192, Model.Twitter, 1192, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""zmdi zmdi-twitter""></i></a></li>
                                    </ul>    
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-3 col-sm-6 col-xs-12"">
                            <div class=""single-widget"">
                                <h3>information</h3>
                                <ul>
                                    <li><a href=""#"">addmission</a></li>
                                    <li><a href=""#"">Academic Calender</a></li>
                                    <li><a href=""event.html"">Event List</a></li>
                                    <li><a href=""#"">Hostel &amp; Dinning</a></li>
                                    <li><a href=""#"">TimeTable</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-md-2 col-sm-6 col-xs-12"">
                            <div class=""sing");
            WriteLiteral(@"le-widget"">
                                <h3>useful links</h3>
                                <ul>
                                    <li><a href=""course.html"">our courses</a></li>
                                    <li><a href=""about.html"">about us</a></li>
                                    <li><a href=""teacher.html"">teachers &amp; faculty</a></li>
                                    <li><a href=""#"">teams &amp; conditions</a></li>
                                    <li><a href=""event.html"">our events</a></li>
                                </ul>
                            </div>
                        </div>
                        <div class=""col-md-3 col-sm-6 col-xs-12"">
                            <div class=""single-widget"">
                                <h3>get in touch</h3>
                                <p>Your address goes here, Street<br>City, Roadno 785 New York</p>
                                <p>+880  548  986  898  87<br>+880  659  785  658  98</p>
              ");
            WriteLiteral(@"                  <p>info@eduhome.com<br>www.eduhome.com</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>   
            <div class=""footer-bottom text-center"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-xs-12"">
                            <p>Copyright © <a href=""#"" target=""_blank"">HasTech</a> 2017. All Right Reserved By Hastech.</p>
                        </div> 
                    </div>
                </div>    
            </div>
        </footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bio> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
