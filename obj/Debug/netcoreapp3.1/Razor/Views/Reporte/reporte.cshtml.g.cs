#pragma checksum "C:\Users\User\Desktop\ChampAppFinal\Views\Reporte\reporte.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a23e6b44e7f160da02d314dc5e86ffb386a3da9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reporte_reporte), @"mvc.1.0.view", @"/Views/Reporte/reporte.cshtml")]
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
#line 1 "C:\Users\User\Desktop\ChampAppFinal\Views\_ViewImports.cshtml"
using ChampApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\ChampAppFinal\Views\_ViewImports.cshtml"
using ChampApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a23e6b44e7f160da02d314dc5e86ffb386a3da9f", @"/Views/Reporte/reporte.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8699394e8eb62c10899b85b6590077e09329877", @"/Views/_ViewImports.cshtml")]
    public class Views_Reporte_reporte : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChampApp.Models.reporte>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\User\Desktop\ChampAppFinal\Views\Reporte\reporte.cshtml"
  
    Layout = Url.Content("~/Views/Shared/_Layout2.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral("    <center>\r\n        <div class=\"col-md-10\">\r\n            <h1 class=\"display-4\">Crear un Reporte</h1>\r\n");
#nullable restore
#line 8 "C:\Users\User\Desktop\ChampAppFinal\Views\Reporte\reporte.cshtml"
             using (Html.BeginForm( FormMethod.Post, new { enctype = "multipart/form-data" }))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a23e6b44e7f160da02d314dc5e86ffb386a3da9f4166", async() => {
                WriteLiteral("\r\n                    <div class=\"form-input col-xl-5 input-group-lg  w-100 p-3 h-75\" style=\"width: 100px; height: 100px; background-color: rgba(0,0,255,0.1);\">\r\n                        ");
#nullable restore
#line 12 "C:\Users\User\Desktop\ChampAppFinal\Views\Reporte\reporte.cshtml"
                   Write(Html.TextBoxFor(m => m.nombre, null, new { @placeholder = "Nombre del producto", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-input col-xl-5 input-group-lg w-100 p-3 h-75\" style=\"width: 100px; height: 200px; background-color: rgba(0,0,255,0.1);\">\r\n                        ");
#nullable restore
#line 15 "C:\Users\User\Desktop\ChampAppFinal\Views\Reporte\reporte.cshtml"
                   Write(Html.TextBoxFor(m => m.Correo, null, new { @placeholder = "Correo", @class = "form-control", @type ="Email" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-input col-xl-5 input-group-lg w-100 p-3 h-75\" style=\"width: 100px; height: 200px; background-color: rgba(0,0,255,0.1);\">\r\n                        ");
#nullable restore
#line 18 "C:\Users\User\Desktop\ChampAppFinal\Views\Reporte\reporte.cshtml"
                   Write(Html.TextBoxFor(m => m.descripcion, null, new { @placeholder = "Descripcion", @class = "form-control", @type ="text" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div><br />\r\n\r\n                    <input type=\"submit\" class=\"btn btn-outline-success btn-lg\" value=\"Enviar\">\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\User\Desktop\ChampAppFinal\Views\Reporte\reporte.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </center>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChampApp.Models.reporte> Html { get; private set; }
    }
}
#pragma warning restore 1591
