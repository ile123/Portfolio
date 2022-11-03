// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Backend.Pages.User_Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Backend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Backend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
using Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
using Backend.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
using Backend.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ChangePasswordUser/{UserId}")]
    public partial class ChangePassword : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\User Components\ChangePassword.razor"
       
    [Parameter]
    public string UserId { get; set; }

    public User user { get; set; }
    private Encryption encryption { get; set; } = new Encryption();
    public class Model
    {
        public string Password;
        public string RepeatPassword;
    };
    private Model model = new Model();
    protected override async Task OnInitializedAsync()
    {
        user = await _userService.GetUserAsync(int.Parse(UserId));
        user.Email = string.Empty;
        user.Firstname = string.Empty;
        user.Lastname = string.Empty;
        user.Role = string.Empty;
        user.Username = string.Empty;
    }
    private async Task UpdateUserAsync()
    {
        if (!model.Password.Equals(model.RepeatPassword))
        {
            await js.InvokeVoidAsync("alert","Both fields do not match!");
            return;
        }
        string temp = encryption.EncodePasswordToBase64(model.Password);
        user.Password = temp;
        await _userService.UpdateUserAsync(user);
        Close();
    }
    private void Close()
    {
        _navigationManager.NavigateTo("/users");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService _userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591
