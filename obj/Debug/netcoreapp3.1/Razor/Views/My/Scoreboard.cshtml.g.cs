#pragma checksum "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Scoreboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a669019b7d41af974cd6591c881eab27ce3a1865"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_My_Scoreboard), @"mvc.1.0.view", @"/Views/My/Scoreboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a669019b7d41af974cd6591c881eab27ce3a1865", @"/Views/My/Scoreboard.cshtml")]
    public class Views_My_Scoreboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/scoreboard.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Scoreboard.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            DefineSection("head", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\" src=\"http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js\"></script> \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a669019b7d41af974cd6591c881eab27ce3a18653665", async() => {
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
            WriteLiteral("\r\n<div class=\"scoreboard\">\r\n    <table cellspacing=\"0\">\r\n        <tr>\r\n            <td>Fighter</td>\r\n            <td>times played</td>\r\n            <td>times won</td>\r\n            <td>times lost</td>\r\n            <td>win percentage</td>\r\n        </tr>\r\n");
#nullable restore
#line 49 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Scoreboard.cshtml"
   for (int i =0; i<40;i++)
    {
        if (i%2 ==0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("id", " id=\"", 1818, "\"", 1825, 1);
#nullable restore
#line 53 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Scoreboard.cshtml"
WriteAttributeValue("", 1823, i, 1823, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"eo\"></tr>\r\n");
#nullable restore
#line 54 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Scoreboard.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("id", " id=\"", 1867, "\"", 1874, 1);
#nullable restore
#line 55 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Scoreboard.cshtml"
WriteAttributeValue("", 1872, i, 1872, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></tr>\r\n");
#nullable restore
#line 56 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Scoreboard.cshtml"
        
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n<script>\r\n    var thelist = \"");
#nullable restore
#line 64 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Scoreboard.cshtml"
              Write(GetScoreBoard());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
    var list = $("".scoreboard"").text();
    for (i=0;i<40;i++)
    {
        var string = thelist.split('|')[i];
        var field = string.split(',');
        $(""#""+i).append(""<td>"" + field[0] + ""</td>"" +""<td>"" + field[1] + ""</td>"" +""<td>"" + field[2] + ""</td>"" +""<td>"" + field[3] + ""</td>"" + ""<td>"" + field[4] +  ""</td>"");
    }
    

</script>");
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\Scoreboard.cshtml"
           
    public string GetScoreBoard()
    {
        Fighter[] fighters = ViewData["scoreboard"] as Fighter[];
        string retString = "";
        for (int i = 0; i < fighters.Length; i++)
        {
            string winpercentage = 0.ToString("P0");
            if (fighters[i].timesWon != 0 && fighters[i].timesPlayed != 0)
            {
                float winperc = (float)fighters[i].timesWon / (float)fighters[i].timesPlayed;
                winpercentage = winperc.ToString("P0");
            }

            retString += $"{fighters[i].name},{fighters[i].timesPlayed},{fighters[i].timesWon},{fighters[i].timesLost},{winpercentage}|";
        }
        return retString;
    }
    public string GetWinPercentage(int id)
    {
        string[] percentages = ViewData["winpercentage"] as string[];
            return percentages[id];

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
