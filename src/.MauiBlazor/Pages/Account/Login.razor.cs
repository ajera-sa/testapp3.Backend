using Microsoft.AspNetCore.Components;
using .MauiBlazor.OAuth;

namespace .MauiBlazor.Pages.Account;

public partial class Login
{
    [Inject]
    public ExternalAuthService ExternalAuthService { get; set; } = default!;

    [Inject]
    public NavigationManager NavigationManager { get; set; } = default!;

    protected async override Task OnInitializedAsync()
    {
        var result = await ExternalAuthService.LoginAsync();
        if (result.IsError)
        {
            await Message.Error($"{result.Error} {result.ErrorDescription}");
            return;
        }

        NavigationManager.NavigateTo("/", true);
    }

    private void Cancel()
    {
        NavigationManager.NavigateTo("/");
    }
}
