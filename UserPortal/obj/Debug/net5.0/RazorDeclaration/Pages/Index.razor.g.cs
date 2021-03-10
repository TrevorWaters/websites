// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace UserPortal.Pages
{
    #line hidden
    using System;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using Microsoft.AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using UserPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using UserPortal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using UserPortal.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using UserPortal.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Extensions.Head;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\_Imports.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : BaseComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\taw11\Desktop\Hobbies\Code\Personalwebsite\UserPortal\Pages\Index.razor"
       
    private List<UserViewModel> Users = new List<UserViewModel>();
    private List<UserRolesViewModel> Roles = new List<UserRolesViewModel>();

    protected override async Task OnInitializedAsync()
    {
        InitDependencies();
        await RefreshUsers();
    }
    private async Task RefreshUsers()
    {
        Users = await GetUsersAsync();
    }
    public UserViewModel NewUser { get; set; } = new UserViewModel();
    private async Task AddNewUser()
    {
        await AddUserAsync(NewUser);
        NewUser = new UserViewModel();
        await RefreshUsers();
    }
    UserViewModel UpdateUser = new UserViewModel();
    private void SetUserForUpdate(UserViewModel user)
    {
        UpdateUser = user;
    }
    private async Task UpdateUserData()
    {
        await UpdateUserAsync(UpdateUser);
        await RefreshUsers();
    }
    private async Task DeleteUser(UserViewModel user)
    {
        await DeleteUserAsync(user);
        await RefreshUsers();
    } 



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591