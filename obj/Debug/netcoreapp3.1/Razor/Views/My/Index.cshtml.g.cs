#pragma checksum "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89c8a7d61506ab55886a52f73a3f78b67d258fd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_My_Index), @"mvc.1.0.view", @"/Views/My/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Index.cshtml"
using FighterApp.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Index.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89c8a7d61506ab55886a52f73a3f78b67d258fd6", @"/Views/My/Index.cshtml")]
    public class Views_My_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/index.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("head", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\" src=\"http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js\"></script> \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "89c8a7d61506ab55886a52f73a3f78b67d258fd64016", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width, user-scalable=no, initial-scale=1, minimum-scale=1, maximum-scale=1"">
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <link rel=""apple-touch-icon"" href=""/img/touch_icon.png"">
    <link media=""only screen and (max-device-width: 480px)"" href=""small-device.css"" type= ""text/css"" rel=""stylesheet"">

");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<img src=\"img/backround.png\"");
            BeginWriteAttribute("alt", " alt=\"", 842, "\"", 848, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n<div class=\"MainContainer\">\r\n<div class=\"LeftSide\">\r\n");
#nullable restore
#line 29 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Index.cshtml"
 for (var i =0;i<40;i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button");
            BeginWriteAttribute("id", " id=\"", 945, "\"", 981, 1);
#nullable restore
#line 31 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Index.cshtml"
WriteAttributeValue("", 950, Convert.ToInt32((Fighter_id)i), 950, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onClick=\"AddHeroToGame(this.id)\"><img");
            BeginWriteAttribute("src", " src=\"", 1020, "\"", 1079, 1);
#nullable restore
#line 31 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Index.cshtml"
WriteAttributeValue("", 1026, getFighterAvatar(Enum.GetName(typeof(Fighter_id),i)), 1026, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Index.cshtml"
                                                                                                                                              Write(Enum.GetName(typeof(Fighter_id),i));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 34 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Index.cshtml"
                                                                                                                                    
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
    <div class=""RightSide"">
        <div class=""p1""></div>
    VS
        <div class=""p2""></div>
    </div>
</div>
<a class=""ProceedLink"" href=""/sfV/Game/_1/_2""><button class=""PostButton"" onClick=""PostGame()"">FIGHT</button></a>

<script>
    var i = 0;
    var ids = [-1,-1];

    function AddHeroToGame(fighter_Id)
    {
        if (ids.find(element => element == -1)) {
        }
        var wasNew = true;   
        if (ids.find(element => element == fighter_Id)) { 
            $(""#""+fighter_Id).toggleClass(""clicked"");
            $("".p""+(ids.indexOf(fighter_Id)+1)).text("""");
            ids[ids.indexOf(fighter_Id)] = -1;
            console.log(""already exists! removed:"" + GetFighterName(fighter_Id));
            ResetButtonHref("".ProceedLink"");
            wasNew = false;
            }
        if (ids[0] == -1 && wasNew == true) {
            ids[0] = fighter_Id;
            $(""#""+fighter_Id).toggleClass(""clicked"");
            $("".p1"").append(GetFighterName(fighter_Id));");
            WriteLiteral(@"

            }
        else if (ids[0] != -1 && ids[1] == -1 && wasNew == true) {
            ids[1] = fighter_Id;
            $(""#""+fighter_Id).toggleClass(""clicked"");
            $("".p2"").append(GetFighterName(fighter_Id));
            }

        console.log(ids.length + "":"" + ids[0] + ""+"" + ids[1]);        
        if (ids[0] != -1 && ids[1] != -1)
        {
            ReplaceButtonHref("".ProceedLink"");
        }
    }
    function ResetButtonHref(button_class)
    {
        var newHref = ""sfV/Game/_1/_2"";
        $(button_class).prop(""href"", newHref);
    }

    function ReplaceButtonHref(button_class)
    {
        var href = $(button_class).prop(""href"");
        var newHref = href
        newHref = href.replace(""_1"", ids[0]).replace(""_2"", ids[1]);
        $(button_class).prop(""href"", newHref);
    }
    function PostGame()
    {
        var url = ""/start/_1/_2"";
        console.log(""staring game with ids: "" + ids[0] + ""and""+ ids[1]);
        $.ajax(url.replace(""_1"", ids");
            WriteLiteral("[0]).replace(\"_2\", ids[1]), {type: \'POST\'} ).done(function() {console.log(\"i did it:\" + ids[0] + \" \" + ids[1]);});\r\n        ids = [];\r\n    }\r\n    function GetFighterName(id)\r\n    {\r\n        return $(\"#\"+id).text();\r\n    }\r\n</script>\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Index.cshtml"
           
    public string getFighterAvatar(string _name)
    {
        string imageUrl = $"/img/characters/{_name}.png";
        return imageUrl;
    }

#line default
#line hidden
#nullable disable
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
