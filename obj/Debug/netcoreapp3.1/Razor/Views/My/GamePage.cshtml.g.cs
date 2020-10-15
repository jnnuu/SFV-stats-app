#pragma checksum "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c486a3fbdb5cd8d029f719eeac4dd28af266634"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_My_GamePage), @"mvc.1.0.view", @"/Views/My/GamePage.cshtml")]
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
#line 1 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
using FighterApp.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
using System;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c486a3fbdb5cd8d029f719eeac4dd28af266634", @"/Views/My/GamePage.cshtml")]
    public class Views_My_GamePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/gamepage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("head", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\" src=\"http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js\"></script> \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0c486a3fbdb5cd8d029f719eeac4dd28af2666344117", async() => {
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
    <link rel=""apple-touch-icon"" href=""/img/touch_icon.png""/>
    <link media=""only screen and (max-device-width: 480px)"" href=""small-device.css"" type= ""text/css"" rel=""stylesheet""/>
");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div");
            BeginWriteAttribute("id", " id=\"", 2938, "\"", 2969, 1);
#nullable restore
#line 99 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
WriteAttributeValue("", 2943, getFighterId("PlayerOne"), 2943, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"playerBox1\">\r\n        <div class=\"stats p1\">WIN percentage: ");
#nullable restore
#line 100 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
                                         Write(GetWinPercentageP1());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <button");
            BeginWriteAttribute("onClick", " onClick=\"", 3082, "\"", 3161, 5);
            WriteAttributeValue("", 3092, "InputWinner(", 3092, 12, true);
#nullable restore
#line 101 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
WriteAttributeValue(" ", 3104, getFighterId("PlayerOne"), 3105, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3131, ",", 3132, 2, true);
#nullable restore
#line 101 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
WriteAttributeValue(" ", 3133, getFighterId("PlayerTwo"), 3134, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3160, ")", 3160, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <a href=\"/sfv\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 3202, "\"", 3236, 1);
#nullable restore
#line 103 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
WriteAttributeValue("", 3208, ViewData["PlayerOneAvatar"], 3208, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </button>\r\n        </a> \r\n    </div>\r\n    <div");
            BeginWriteAttribute("id", " id=\"", 3294, "\"", 3325, 1);
#nullable restore
#line 107 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
WriteAttributeValue("", 3299, getFighterId("PlayerTwo"), 3299, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"playerBox2\">\r\n        <button");
            BeginWriteAttribute("onClick", " onClick=\"", 3363, "\"", 3440, 5);
            WriteAttributeValue("", 3373, "InputWinner(", 3373, 12, true);
#nullable restore
#line 108 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
WriteAttributeValue("", 3385, getFighterId("PlayerTwo"), 3385, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3411, ",", 3411, 1, true);
#nullable restore
#line 108 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
WriteAttributeValue(" ", 3412, getFighterId("PlayerOne"), 3413, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3439, ")", 3439, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <a href=\"/sfv\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 3485, "\"", 3519, 1);
#nullable restore
#line 110 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
WriteAttributeValue("", 3491, ViewData["PlayerTwoAvatar"], 3491, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </button>\r\n        </a> \r\n        <div class=\"stats p2\">WIN percentage: ");
#nullable restore
#line 113 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
                                         Write(GetWinPercentageP2());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n<div class=\"GeneralStats\">\r\n    <div class=\"top3winrate\">");
#nullable restore
#line 117 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
                        Write(TopThreePlayed());

#line default
#line hidden
#nullable disable
            WriteLiteral(";</div>\r\n    <div class=\"top3played\">");
#nullable restore
#line 118 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
                       Write(TopThreeWins());

#line default
#line hidden
#nullable disable
            WriteLiteral(@";</div>
</div>

<script type=""text/javascript"">
    function InputWinner(id1, id2)
    {
        var winUrl = ""http://192.168.100.19:5000/sfv/winner/"";
        var loseUrl = ""http://192.168.100.19:5000/sfv/loser/"";
        winUrl += id1;
        loseUrl += id2;
        console.log(""Winner url: "" + winUrl);
        console.log(""Loser url: "" + loseUrl);
        $.ajax(winUrl, {
            type: ""POST"",
        });
        $.ajax(loseUrl, {
            type: ""POST"",
        });
    }
</script>
");
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Jonni\source\repos\SFV-stats-app-master\FighterApp\Views\My\GamePage.cshtml"
           
    //set up correct id's for the playerBox divs.
    public int getFighterId(string dataKey)
    {
        string name = ViewData[dataKey] as string;
        int i = 0;
        foreach (var en in Enum.GetNames(typeof(Fighter_id)))
        {
            string HeroName = "";
            for (int j = 0; j < en.Length; j++)
            {
                HeroName += en[j];
            }
            if (name == HeroName)
            {
                break;
            }
            i++;
        }
        return i;
    }

    public string TopThreePlayed()
    {
        Fighter[] fighters = ViewData["TopThreePlayed"] as Fighter[];
        string retstring = "";
        for (int i = 0 ; i<fighters.Length; i++)
        {
            retstring += $"{i+1}. {fighters[i].name} ({fighters[i].timesPlayed})";
        }
        return retstring;
    }
    
    public string TopThreeWins()
    {
        Fighter[] fighters = ViewData["TopThreeWins"] as Fighter[];
        string retstring = "";
        for (int i = 0; i<fighters.Length;i++)
        {
            //calculate win percentage first
            float winPerc = fighters[i].timesWon / fighters[i].timesPlayed;
            retstring += $"{i+1}. {fighters[i].name} ({winPerc.ToString("P0")})";
            
        }
        return retstring;
    }

    public string GetWinPercentageP1()
    {
        int played = (int)ViewData["id1_played"];
        int won = (int)ViewData["id1_won"];
        System.Console.WriteLine($"p1:w:{won}/p:{played}");
        if (won == 0 || played == 0)
        {
            return  "0 %" ;
        }

        float percentage = (float)won/played;
        string returnString = percentage.ToString("P0");
        return returnString;
    }

     public string GetWinPercentageP2()
    {
        int played = (int)ViewData["id2_played"];
        int won = (int)ViewData["id2_won"];
        System.Console.WriteLine($"p2:w:{won}/p:{played}");
        if (won == 0 || played == 0)
        {
            return "0 %";
        }

        float percentage = (float)won/played;
        string returnString = percentage.ToString("P0");
        return returnString;
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
