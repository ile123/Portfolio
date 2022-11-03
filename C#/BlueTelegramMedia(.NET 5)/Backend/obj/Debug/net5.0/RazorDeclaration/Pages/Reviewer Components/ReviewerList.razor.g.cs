// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
