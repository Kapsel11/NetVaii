#pragma checksum "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d91ea594a261a75a07feb7143319171d92dd89fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_MyGames), @"mvc.1.0.view", @"/Views/Game/MyGames.cshtml")]
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
#line 1 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\_ViewImports.cshtml"
using Fajn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\_ViewImports.cshtml"
using Fajn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
using Fajn.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d91ea594a261a75a07feb7143319171d92dd89fb", @"/Views/Game/MyGames.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c59fdf9666b0294d335209b7c0c41b2370dc4651", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_MyGames : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AllGamesFindViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
  
    ViewData["Title"] = "My Games";

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n function Remove(obj) {\r\n     \r\n     if(confirm(\"Are you sure you want to delete this game ? GameId =\"+obj))\r\n     {\r\n     var data = { };\r\n     data[\"GameId\"] = obj;\r\n$.ajax({\r\n    url: \'");
#nullable restore
#line 15 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
     Write(Url.Action("Delete", "Game"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
    type: ""POST"",
    dataType: 'TEXT',
    data: data,
    success: function () {
        var b =  document.getElementById(obj);
        b.remove();          
    },
    error: function () {
        alert(""Fail to delete"");
    }
});
     }


}
</script>

    <h4>My Games</h4>

    <table class=""table"" id=""table"">
        <thead>
          <tr>
            <th scope=""col"">GameID</th>
            <th scope=""col"">White</th>
            <th scope=""col"">Black</th>
            <th scope=""col"">Result</th>
            <th scope=""col"">Event</th>
            <th scope=""col"">Date</th>
            <th scope=""col"">Type</th>
            <th scope=""col"">PGN</th>
            <th scope=""col"">Update</th>
            <th scope=""col"">Delete</th>
          </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 51 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
          foreach (AllGamesFindViewModel game in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr");
            BeginWriteAttribute("id", " id=", 1248, "", 1264, 1);
#nullable restore
#line 53 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
WriteAttributeValue("", 1252, game.GameId, 1252, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n           <th scope=\"row\">");
#nullable restore
#line 54 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
                      Write(game.GameId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n           <td>");
#nullable restore
#line 55 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
          Write(game.White);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 56 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
          Write(game.Black);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 57 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
          Write(game.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d91ea594a261a75a07feb7143319171d92dd89fb7692", async() => {
#nullable restore
#line 58 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
                                                        Write(game.EventName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 59 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
          Write(game.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>    \r\n           <td>");
#nullable restore
#line 60 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
          Write(game.GameTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td><a");
            BeginWriteAttribute("href", " href=\"", 1593, "\"", 1609, 1);
#nullable restore
#line 61 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
WriteAttributeValue("", 1600, game.Pgn, 1600, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Download</a></td>\r\n           <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d91ea594a261a75a07feb7143319171d92dd89fb10175", async() => {
                WriteLiteral("Update");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
                                                                       WriteLiteral(game.GameId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n           <td>\r\n            <div class=\"form-group\">\r\n                <button type=\"button\" class=\"btn btn-sm btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1883, "\"", 1913, 3);
            WriteAttributeValue("", 1893, "Remove(", 1893, 7, true);
#nullable restore
#line 65 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
WriteAttributeValue("", 1900, game.GameId, 1900, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1912, ")", 1912, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Delete</button>\r\n            </div>\r\n          </tr>\r\n");
#nullable restore
#line 68 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AllGamesFindViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
