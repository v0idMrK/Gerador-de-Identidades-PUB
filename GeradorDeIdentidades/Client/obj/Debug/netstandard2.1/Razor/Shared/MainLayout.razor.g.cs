#pragma checksum "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9175b98edc6c8dcb60e48b507820bd7ffdad37b8"
// <auto-generated/>
#pragma warning disable 1591
namespace GeradorDeIdentidades.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\_Imports.razor"
using GeradorDeIdentidades.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\_Imports.razor"
using GeradorDeIdentidades.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "content px-4");
            __builder.AddMarkupContent(8, "\r\n            ");
#nullable restore
#line 6 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Shared\MainLayout.razor"
__builder.AddContent(9, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.AddMarkupContent(14, "<footer class=\"footer\">\r\n    <div class=\"container text-left\">\r\n        <span class=\"text-muted\">Made with &lt;3 by v0idMrK!</span>\r\n    </div>\r\n</footer>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591