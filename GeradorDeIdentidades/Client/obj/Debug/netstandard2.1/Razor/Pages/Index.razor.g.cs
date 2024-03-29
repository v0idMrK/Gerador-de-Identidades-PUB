#pragma checksum "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b515613b83c06e2ab87ff5ba5cea6bc686a73ec4"
// <auto-generated/>
#pragma warning disable 1591
namespace GeradorDeIdentidades.Client.Pages
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
#nullable restore
#line 2 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor"
using GeradorDeIdentidades.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor"
using GeradorDeIdentidades.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Gerador de Identidades</h2>\r\n\r\n");
#nullable restore
#line 9 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor"
 if (identity == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Aguarde...</em></p>\r\n");
#nullable restore
#line 12 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<div class=\"row\">\r\n        <div class=\"col text-left\">\r\n            <p>\r\n                Um gerador de identidades rápido para auxílio de desenvolvimento de aplicações.\r\n            </p>\r\n        </div>\r\n    </div>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row mt-5 mb-5");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container h-100 mt-5 mb-5");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row h-100 justify-content-center align-items-center");
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card text-center");
            __builder.AddAttribute(16, "style", "width: 24rem;");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-body");
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "h5");
            __builder.AddAttribute(22, "class", "card-title cursor-pointer");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor"
                                                                        CopyNameToClipboard

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 27 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor"
__builder.AddContent(24, identity.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "class", "card-text cursor-pointer");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor"
                                                                      CopyNifToClipboard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(29, "NIF: ");
            __builder.OpenElement(30, "span");
#nullable restore
#line 28 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor"
__builder.AddContent(31, identity.Nif);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "p");
            __builder.AddAttribute(34, "class", "card-text cursor-pointer");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor"
                                                                      CopyCCToClipboard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(36, "CC: ");
            __builder.OpenElement(37, "span");
#nullable restore
#line 29 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor"
__builder.AddContent(38, identity.CC);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "container");
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "row");
            __builder.AddMarkupContent(45, "\r\n                                ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col text-center");
            __builder.AddMarkupContent(48, "\r\n                                    ");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "class", "btn btn-primary");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor"
                                                                              Refresh

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(52, "Outra vez");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.AddMarkupContent(62, @"<div class=""row"">
        <div class=""d-flex align-items-center"">
            <div class=""container"">
                <div class=""col text-left"">
                    <p>
                        Estas identidades são fictícias. No entanto:
                        <ul>
                            <li>
                                <p>Os NIFs e CCs são válidos de acordo com os validadores portugueses.</p>
                            </li>
                            <li>
                                <p>Os nomes são escolhidos aleatoriamente.</p>
                            </li>
                        </ul>
                    </p>
                </div>
            </div>
        </div>

    </div>
");
#nullable restore
#line 62 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "M:\Code Projects Current\GeradorDeIdentidades\GeradorDeIdentidades\Client\Pages\Index.razor"
      


    private IdentityModel identity;

    private readonly string copiedString = "Copiado com sucesso :D";
    private readonly string errString = "Tente outra vez.";

    protected override async Task OnInitializedAsync()
    {
        identity = await Http.GetFromJsonAsync<IdentityModel>("Identity");
    }

    private async Task Refresh()
    {
        try
        {
            identity = await Http.GetFromJsonAsync<IdentityModel>("Identity");
        }
        catch
        {
            await ToastService.ShowError(errString);
        }

    }

    private async Task CopyNifToClipboard()
    {
        try
        {
            await ToastService.Show(copiedString);
            await ClipboardService.WriteTextAsync(identity.Nif);
        }
        catch
        {
        }
    }

    private async Task CopyCCToClipboard()
    {
        try
        {
            await ToastService.Show(copiedString);
            await ClipboardService.WriteTextAsync(identity.CC);
        }
        catch
        {
        }
    }

    private async Task CopyNameToClipboard()
    {
        try
        {
            await ToastService.Show(copiedString);
            await ClipboardService.WriteTextAsync(identity.Name);
        }
        catch
        {
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClipboardService ClipboardService { get; set; }
    }
}
#pragma warning restore 1591
