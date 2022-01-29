#pragma checksum "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\Find.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfa33b7457b85f42e8ecd155a692cd809f794e1e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Game_Find), @"mvc.1.0.view", @"/Views/Game/Find.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfa33b7457b85f42e8ecd155a692cd809f794e1e", @"/Views/Game/Find.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c59fdf9666b0294d335209b7c0c41b2370dc4651", @"/Views/_ViewImports.cshtml")]
    public class Views_Game_Find : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Fajn.ViewModels.AllGamesFindViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Event", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\Find.cshtml"
  
    ViewData["Title"] = "Find Game";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <h4>All Games</h4>
    <table class=""table"">
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
          </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 22 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\Find.cshtml"
          foreach (Fajn.ViewModels.AllGamesFindViewModel game in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\r\n           <th scope=\"row\">");
#nullable restore
#line 25 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\Find.cshtml"
                      Write(game.GameId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n           <td>");
#nullable restore
#line 26 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\Find.cshtml"
          Write(game.White);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 27 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\Find.cshtml"
          Write(game.Black);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 28 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\Find.cshtml"
          Write(game.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfa33b7457b85f42e8ecd155a692cd809f794e1e5668", async() => {
#nullable restore
#line 29 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\Find.cshtml"
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
#line 30 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\Find.cshtml"
          Write(game.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>         \r\n           <td>");
#nullable restore
#line 31 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\Find.cshtml"
          Write(game.GameTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td><a");
            BeginWriteAttribute("href", " href=\"", 994, "\"", 1010, 1);
#nullable restore
#line 32 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\Find.cshtml"
WriteAttributeValue("", 1001, game.Pgn, 1001, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Download</a></td>\r\n          </tr>\r\n");
#nullable restore
#line 34 "C:\Users\thedj\source\repos\Kapsel11\NetVaii\Fajn\Views\Game\Find.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n       \r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Fajn.ViewModels.AllGamesFindViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591