#pragma checksum "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b431262067605d74e3312aaf35669adb25a550b3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b431262067605d74e3312aaf35669adb25a550b3", @"/Views/Game/MyGames.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c59fdf9666b0294d335209b7c0c41b2370dc4651", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_MyGames : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Game>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b431262067605d74e3312aaf35669adb25a550b34162", async() => {
                WriteLiteral(@"
    <h4>My Games</h4>
    <table class=""table"">
        <thead>
          <tr>
            <th scope=""col"">GameID</th>
            <th scope=""col"">White</th>
            <th scope=""col"">Black</th>
            <th scope=""col"">Result</th>
            <th scope=""col"">Event</th>
            <th scope=""col"">Date</th>
            <th scope=""col"">PGN</th>
            <th scope=""col"">Update</th>
            <th scope=""col"">Delete</th>
          </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 20 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
          foreach (Game game in Model)
         {

#line default
#line hidden
#nullable disable
                WriteLiteral("          <tr>\r\n           <th scope=\"row\">");
#nullable restore
#line 23 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
                      Write(game.GameId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n           <td>");
#nullable restore
#line 24 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
          Write(game.White);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 25 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
          Write(game.Black);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 26 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
          Write(game.Result);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 27 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
          Write(game.Event);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 28 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
          Write(game.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>           \r\n           <td><a");
                BeginWriteAttribute("href", " href=\"", 840, "\"", 856, 1);
#nullable restore
#line 29 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
WriteAttributeValue("", 847, game.Pgn, 847, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\"_blank\">Download</a></td>\r\n           <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b431262067605d74e3312aaf35669adb25a550b37146", async() => {
                    WriteLiteral("Update");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
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
                WriteLiteral("</td>\r\n           <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b431262067605d74e3312aaf35669adb25a550b39530", async() => {
                    WriteLiteral("Delete");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onclick", 14, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1085, "return", 1085, 6, true);
                AddHtmlAttributeValue(" ", 1091, "confirm(\'Are", 1092, 13, true);
                AddHtmlAttributeValue(" ", 1104, "you", 1105, 4, true);
                AddHtmlAttributeValue(" ", 1108, "sure", 1109, 5, true);
                AddHtmlAttributeValue(" ", 1113, "you", 1114, 4, true);
                AddHtmlAttributeValue(" ", 1117, "want", 1118, 5, true);
                AddHtmlAttributeValue(" ", 1122, "to", 1123, 3, true);
                AddHtmlAttributeValue(" ", 1125, "delete", 1126, 7, true);
                AddHtmlAttributeValue(" ", 1132, "this", 1133, 5, true);
                AddHtmlAttributeValue(" ", 1137, "game?", 1138, 6, true);
                AddHtmlAttributeValue(" ", 1143, "(GameID", 1144, 8, true);
                AddHtmlAttributeValue(" ", 1151, "=", 1152, 2, true);
#nullable restore
#line 31 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
AddHtmlAttributeValue(" ", 1153, game.GameId, 1154, 12, false);

#line default
#line hidden
#nullable disable
                AddHtmlAttributeValue("", 1166, ")\')", 1166, 3, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
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
                WriteLiteral("</td>\r\n          </tr>\r\n");
#nullable restore
#line 33 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\MyGames.cshtml"
         }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n       \r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Game>> Html { get; private set; }
    }
}
#pragma warning restore 1591
