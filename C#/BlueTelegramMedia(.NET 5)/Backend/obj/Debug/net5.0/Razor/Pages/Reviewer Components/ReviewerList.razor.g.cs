#pragma checksum "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ed7b3c3e59c7cb6eb5569d7c9b5738dc89f4a07"
// <auto-generated/>
#pragma warning disable 1591
namespace Backend.Pages.Reviewer_Components
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
#line 5 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
using Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
using Backend.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/reviewers")]
    public partial class ReviewerList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-lg navbar-light bg-light");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container-fluid");
            __builder.AddMarkupContent(4, "<img src=\"images/logo_for_nav_2.png\">\r\n    &nbsp;&nbsp;&nbsp;\r\n    &nbsp;&nbsp;&nbsp;\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "collapse navbar-collapse");
            __builder.AddAttribute(7, "id", "navbarSupportedContent");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "navbar-nav me-auto mb-2 mb-lg-0");
            __builder.OpenElement(10, "li");
            __builder.AddAttribute(11, "class", "nav-item");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "btn btn-secondary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
                                                                      openMainPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Main Page");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            &nbsp;&nbsp;&nbsp;\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(19);
            __builder.AddAttribute(20, "Roles", "Admin");
            __builder.AddAttribute(21, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(22, "li");
                __builder2.AddAttribute(23, "class", "nav-item");
                __builder2.OpenElement(24, "button");
                __builder2.AddAttribute(25, "type", "button");
                __builder2.AddAttribute(26, "class", "btn btn-primary");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
                                                                            openUsers

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(28, "Users");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                &nbsp;&nbsp;&nbsp;\r\n                ");
                __builder2.AddMarkupContent(30, "<li class=\"nav-item\"><button type=\"button\" class=\"btn btn-danger\" disabled>Reviewers</button></li>\r\n                 &nbsp;&nbsp;&nbsp;\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(32);
            __builder.AddAttribute(33, "Roles", "Admin,Employee");
            __builder.AddAttribute(34, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(35, "li");
                __builder2.AddAttribute(36, "class", "nav-item");
                __builder2.OpenElement(37, "button");
                __builder2.AddAttribute(38, "type", "button");
                __builder2.AddAttribute(39, "class", "btn btn-success");
                __builder2.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
                                                                            openMovies

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(41, "Movies");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                &nbsp;&nbsp;&nbsp;\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
 if(reviewers == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<div>Loading.......</div>");
#nullable restore
#line 50 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-group");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "type", "text");
            __builder.AddAttribute(49, "placeholder", "Filter......");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 54 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
                                                                                  Filter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Filter = __value, Filter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.OpenElement(53, "select");
            __builder.AddAttribute(54, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
                   SelectedSort

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedSort = __value, SelectedSort));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(56, "option");
            __builder.AddAttribute(57, "value", "Id");
            __builder.AddContent(58, "Default");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "option");
            __builder.AddAttribute(61, "value", "Username");
            __builder.AddContent(62, "Username");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.OpenElement(64, "option");
            __builder.AddAttribute(65, "value", "Email");
            __builder.AddContent(66, "Email");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n    ");
            __builder.OpenElement(68, "table");
            __builder.AddAttribute(69, "class", "table");
            __builder.AddMarkupContent(70, @"<thead><tr><th scope=""col"">#</th>
                <th scope=""col"">Username</th>
                <th scope=""col"">Email</th>
                <th scope=""col"">Edit</th>
                <th scope=""col"">Change Password</th>
                <th scope=""col"">Delete</th></tr></thead>
        ");
            __builder.OpenElement(71, "tbody");
#nullable restore
#line 73 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
             foreach(var reviewer in reviewers)
            {
                if (!IsVisible(reviewer))
                {
                    continue;
                }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(72, "tr");
            __builder.OpenElement(73, "td");
            __builder.AddAttribute(74, "scope", "row");
#nullable restore
#line 80 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
__builder.AddContent(75, reviewer.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.OpenElement(77, "td");
            __builder.AddAttribute(78, "scope", "row");
#nullable restore
#line 81 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
__builder.AddContent(79, reviewer.Username);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenElement(81, "td");
            __builder.AddAttribute(82, "scope", "row");
#nullable restore
#line 82 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
__builder.AddContent(83, reviewer.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.OpenElement(85, "td");
            __builder.OpenElement(86, "a");
            __builder.AddAttribute(87, "href", "/EditReviewer/" + (
#nullable restore
#line 83 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
                                                 reviewer.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "class", "btn btn-primary");
            __builder.AddMarkupContent(89, "<span class=\"oi oi-pencil\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                    ");
            __builder.OpenElement(91, "td");
            __builder.OpenElement(92, "a");
            __builder.AddAttribute(93, "href", "/ChangePasswordReviewer/" + (
#nullable restore
#line 84 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
                                                           reviewer.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "class", "btn btn-primary");
            __builder.AddMarkupContent(95, "<span class=\"bi bi-minecart\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                    ");
            __builder.OpenElement(97, "td");
            __builder.OpenElement(98, "button");
            __builder.AddAttribute(99, "type", "button");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
                                                        () => DeleteReviewerAsync(reviewer.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(101, "<span class=\"oi oi-delete\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 87 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 90 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(102, "button");
            __builder.AddAttribute(103, "type", "button");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
                                openAddReviewer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(105, "<span class=\"oi oi-plus\"></span>\r\n            Add Reviewer\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 97 "C:\Users\Ilario\source\repos\BlueTelegramMedia(.NET 5)\Backend\Pages\Reviewer Components\ReviewerList.razor"
       
    public IEnumerable<Reviewer> reviewers { get; set; }
    private string selectedSort { get; set; }
    public string Filter { get; set; }
    public string SelectedSort
    {
        get{ return selectedSort; }
        set
        {
            selectedSort = value;
            selecteSortDictionary[selectedSort]();

        }

    }
    Dictionary<string, Action> selecteSortDictionary;
    protected override async Task OnInitializedAsync()
    {
        reviewers = await _reviewerService.GetReviewers();
        Filter = string.Empty;
        selecteSortDictionary = new Dictionary<string, Action>
        {
             ["Id"] = () => reviewers = reviewers.OrderBy(x => x.Id),
             ["Username"] = () => reviewers = reviewers.OrderBy(x => x.Username),
             ["Email"] = () => reviewers = reviewers.OrderBy(x => x.Email)
        };
    }
    private void openMainPage(){
        _navigationManager.NavigateTo("/");
    }
    private void openAddReviewer()
    {
        _navigationManager.NavigateTo("/addReviewer");
    }
    private void openUsers()
    {
        _navigationManager.NavigateTo("/users");
    }
    private void openMovies()
    {
        _navigationManager.NavigateTo("/movies");
    }
    private void openReviewerEdit(int ReviewerId)
    {
        _navigationManager.NavigateTo("/EditReviewer/" + ReviewerId);
    }
    private async Task DeleteReviewerAsync(int reviewerId)
    {
        await _reviewerService.DeleteReviewerAsync(reviewerId);
        reviewers = await _reviewerService.GetReviewers();
    }
    public bool IsVisible(Reviewer reviewer)
    {
        if (string.IsNullOrEmpty(reviewer.Username))
        {
            return true;
        }
        if (reviewer.Username.Contains(Filter, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
        if (reviewer.Username.StartsWith(Filter))
        {
            return true;
        }
        if (string.IsNullOrEmpty(reviewer.Email))
        {
            return true;
        }
        if (reviewer.Email.Contains(Filter, StringComparison.OrdinalIgnoreCase))
        {
            return true;
        }
        if (reviewer.Email.StartsWith(Filter))
        {
            return true;
        }
        return false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ReviewerService _reviewerService { get; set; }
    }
}
#pragma warning restore 1591
