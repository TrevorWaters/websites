// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace kristinsite.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using kristinsite.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/tee/Documents/websites/kristinsite/Client/_Imports.razor"
using kristinsite.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
using kristinsite.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Store")]
    public partial class Store : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 137 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
       
    private Products[] products;
    
    private bool hideModal{ get; set; } = true;

    private long ProductID { get; set; }
    private void ShowModal(long id)
    {
        hideModal = false;
        ProductID = id;
    }
    private void HideModal()
    {
        hideModal = true;
        ProductID = 0;
    }
    protected override async Task OnInitializedAsync()
    {
        products = await Http.GetFromJsonAsync<Products[]>("Site");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
