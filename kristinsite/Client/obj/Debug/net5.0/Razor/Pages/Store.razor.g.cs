#pragma checksum "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62e73c79435ed9dff11e3adf3e3dcf8c3344107a"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 5 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
 if (products == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading...</em></p>");
#nullable restore
#line 8 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
}
else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "x-data", "{ cartOpen: false , isOpen: false }");
            __builder.AddAttribute(3, "class", "bg-white");
            __builder.AddMarkupContent(4, @"<header><div class=""container mx-auto px-6 py-3""><div class=""relative mt-6 max-w-lg mx-auto""><span class=""absolute inset-y-0 left-0 pl-3 flex items-center""><svg class=""h-5 w-5 text-gray-500"" viewBox=""0 0 24 24"" fill=""none""><path d=""M21 21L15 15M17 10C17 13.866 13.866 17 10 17C6.13401 17 3 13.866 3 10C3 6.13401 6.13401 3 10 3C13.866 3 17 6.13401 17 10Z"" stroke=""currentColor"" stroke-width=""2"" stroke-linecap=""round"" stroke-linejoin=""round""></path></svg></span>

                <input class=""w-full border rounded-md pl-10 pr-4 py-2 focus:border-blue-500 focus:outline-none focus:shadow-outline"" type=""text"" placeholder=""Search""></div></div></header>
    ");
            __builder.AddMarkupContent(5, "<div :class=\"cartOpen ? \'translate-x-0 ease-out\' : \'translate-x-full ease-in\'\" class=\"fixed right-0 top-0 max-w-xs w-full h-full px-6 py-4 transition duration-300 transform overflow-y-auto bg-white border-l-2 border-gray-300\"><div class=\"flex items-center justify-between\"><h3 class=\"text-2xl font-medium text-gray-700\">Your cart</h3>\n            <button @click=\"cartOpen = !cartOpen\" class=\"text-gray-600 focus:outline-none\"><svg class=\"h-5 w-5\" fill=\"none\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" viewBox=\"0 0 24 24\" stroke=\"currentColor\"><path d=\"M6 18L18 6M6 6l12 12\"></path></svg></button></div>\n        <hr class=\"my-3\">\n        <div class=\"flex justify-between mt-6\"><div class=\"flex\"><img class=\"h-20 w-20 object-cover rounded\" src=\"https://images.unsplash.com/photo-1593642632823-8f785ba67e45?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1189&q=80\" alt>\n                <div class=\"mx-3\"><h3 class=\"text-sm text-gray-600\">Mac Book Pro</h3>\n                    <div class=\"flex items-center mt-2\"><button class=\"text-gray-500 focus:outline-none focus:text-gray-600\"><svg class=\"h-5 w-5\" fill=\"none\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" viewBox=\"0 0 24 24\" stroke=\"currentColor\"><path d=\"M12 9v3m0 0v3m0-3h3m-3 0H9m12 0a9 9 0 11-18 0 9 9 0 0118 0z\"></path></svg></button>\n                        <span class=\"text-gray-700 mx-2\">2</span>\n                        <button class=\"text-gray-500 focus:outline-none focus:text-gray-600\"><svg class=\"h-5 w-5\" fill=\"none\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" viewBox=\"0 0 24 24\" stroke=\"currentColor\"><path d=\"M15 12H9m12 0a9 9 0 11-18 0 9 9 0 0118 0z\"></path></svg></button></div></div></div>\n            <span class=\"text-gray-600\">20$</span></div>\n        <div class=\"flex justify-between mt-6\"><div class=\"flex\"><img class=\"h-20 w-20 object-cover rounded\" src=\"https://images.unsplash.com/photo-1593642632823-8f785ba67e45?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1189&q=80\" alt>\n                <div class=\"mx-3\"><h3 class=\"text-sm text-gray-600\">Mac Book Pro</h3>\n                    <div class=\"flex items-center mt-2\"><button class=\"text-gray-500 focus:outline-none focus:text-gray-600\"><svg class=\"h-5 w-5\" fill=\"none\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" viewBox=\"0 0 24 24\" stroke=\"currentColor\"><path d=\"M12 9v3m0 0v3m0-3h3m-3 0H9m12 0a9 9 0 11-18 0 9 9 0 0118 0z\"></path></svg></button>\n                        <span class=\"text-gray-700 mx-2\">2</span>\n                        <button class=\"text-gray-500 focus:outline-none focus:text-gray-600\"><svg class=\"h-5 w-5\" fill=\"none\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" viewBox=\"0 0 24 24\" stroke=\"currentColor\"><path d=\"M15 12H9m12 0a9 9 0 11-18 0 9 9 0 0118 0z\"></path></svg></button></div></div></div>\n            <span class=\"text-gray-600\">20$</span></div>\n        <div class=\"flex justify-between mt-6\"><div class=\"flex\"><img class=\"h-20 w-20 object-cover rounded\" src=\"https://images.unsplash.com/photo-1593642632823-8f785ba67e45?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1189&q=80\" alt>\n                <div class=\"mx-3\"><h3 class=\"text-sm text-gray-600\">Mac Book Pro</h3>\n                    <div class=\"flex items-center mt-2\"><button class=\"text-gray-500 focus:outline-none focus:text-gray-600\"><svg class=\"h-5 w-5\" fill=\"none\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" viewBox=\"0 0 24 24\" stroke=\"currentColor\"><path d=\"M12 9v3m0 0v3m0-3h3m-3 0H9m12 0a9 9 0 11-18 0 9 9 0 0118 0z\"></path></svg></button>\n                        <span class=\"text-gray-700 mx-2\">2</span>\n                        <button class=\"text-gray-500 focus:outline-none focus:text-gray-600\"><svg class=\"h-5 w-5\" fill=\"none\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" viewBox=\"0 0 24 24\" stroke=\"currentColor\"><path d=\"M15 12H9m12 0a9 9 0 11-18 0 9 9 0 0118 0z\"></path></svg></button></div></div></div>\n            <span class=\"text-gray-600\">20$</span></div>\n        <div class=\"mt-8\"><form class=\"flex items-center justify-center\"><input class=\"form-input w-48\" type=\"text\" placeholder=\"Add promocode\">\n                <button class=\"ml-3 flex items-center px-3 py-2 bg-blue-600 text-white text-sm uppercase font-medium rounded hover:bg-blue-500 focus:outline-none focus:bg-blue-500\"><span>Apply</span></button></form></div>\n        <a class=\"flex items-center justify-center mt-4 px-3 py-2 bg-blue-600 text-white text-sm uppercase font-medium rounded hover:bg-blue-500 focus:outline-none focus:bg-blue-500\"><span>Chechout</span>\n            <svg class=\"h-5 w-5 mx-2\" fill=\"none\" stroke-linecap=\"round\" stroke-linejoin=\"round\" stroke-width=\"2\" viewBox=\"0 0 24 24\" stroke=\"currentColor\"><path d=\"M17 8l4 4m0 0l-4 4m4-4H3\"></path></svg></a></div>\n    ");
            __builder.OpenElement(6, "main");
            __builder.AddAttribute(7, "class", "my-8");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "container mx-auto px-6");
            __builder.AddMarkupContent(10, "<h3 class=\"text-gray-700 text-2xl font-medium\">Wrist Watch</h3>\n            ");
            __builder.AddMarkupContent(11, "<span class=\"mt-3 text-sm text-gray-500\">200+ Products</span>\n            ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "grid gap-6 grid-cols-1 sm:grid-cols-2 lg:grid-cols-3 xl:grid-cols-4 mt-6");
#nullable restore
#line 105 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
                 foreach (var product in products)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "w-full max-w-sm mx-auto rounded-md shadow-md overflow-hidden");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "flex items-end justify-end h-56 w-full bg-cover");
            __builder.AddAttribute(18, "style", "background-image: url(\'https://images.unsplash.com/photo-1495856458515-0637185db551?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=750&q=80\')");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
                                          () => ShowModal(product.ProductID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "p-2 rounded-full bg-blue-600 text-white mx-5 -mb-4 hover:bg-blue-500 focus:outline-none focus:bg-blue-500");
            __builder.AddMarkupContent(22, @"<svg class=""h-5 w-5"" fill=""none"" stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" viewBox=""0 0 24 24"" stroke=""currentColor""><path d=""M3 3h2l.4 2M7 13h10l4-8H5.4M7 13L5.4 5M7 13l-2.293 2.293c-.63.63-.184 1.707.707 1.707H17m0 0a2 2 0 100 4 2 2 0 000-4zm-8 2a2 2 0 11-4 0 2 2 0 014 0z""></path></svg>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "px-5 py-3");
            __builder.OpenElement(26, "h3");
            __builder.AddAttribute(27, "class", "text-gray-700 uppercase");
            __builder.AddContent(28, 
#nullable restore
#line 114 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
                                                             product.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                        ");
            __builder.OpenElement(30, "span");
            __builder.AddAttribute(31, "class", "text-gray-500 mt-2");
            __builder.AddContent(32, "$");
            __builder.AddContent(33, 
#nullable restore
#line 115 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
                                                           product.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 118 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
                }         

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<kristinsite.Client.Shared.ProductModal>(34);
            __builder.AddAttribute(35, "ProductId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int64>(
#nullable restore
#line 119 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
                                         ProductID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "Show", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 119 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
                                                          hideModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "ModalClosed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 119 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
                                                                                  HideModal

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\n            ");
            __builder.AddMarkupContent(39, @"<div class=""flex justify-center""><div class=""flex rounded-md mt-8""><a href=""#"" class=""py-2 px-4 leading-tight bg-white border border-gray-200 text-blue-700 border-r-0 ml-0 rounded-l hover:bg-blue-500 hover:text-white""><span>Previous</span></a>
                    <a href=""#"" class=""py-2 px-4 leading-tight bg-white border border-gray-200 text-blue-700 border-r-0 hover:bg-blue-500 hover:text-white""><span>1</span></a>
                    <a href=""#"" class=""py-2 px-4 leading-tight bg-white border border-gray-200 text-blue-700 border-r-0 hover:bg-blue-500 hover:text-white""><span>2</span></a>
                    <a href=""#"" class=""py-2 px-4 leading-tight bg-white border border-gray-200 text-blue-700 border-r-0 hover:bg-blue-500 hover:text-white""><span>3</span></a>
                    <a href=""#"" class=""py-2 px-4 leading-tight bg-white border border-gray-200 text-blue-700 rounded-r hover:bg-blue-500 hover:text-white""><span>Next</span></a></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 133 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 136 "/home/tee/Documents/websites/kristinsite/Client/Pages/Store.razor"
       
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
