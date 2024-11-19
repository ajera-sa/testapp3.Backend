using Microsoft.AspNetCore.Components.Authorization;

namespace .MauiBlazor.OAuth;

public class ExternalAuthStateProvider : AuthenticationStateProvider
{
    private AuthenticationState? _currentUser;
    private readonly ExternalAuthService _externalAuthService;

    public ExternalAuthStateProvider(ExternalAuthService externalAuthService)
    {
        _externalAuthService = externalAuthService;
        externalAuthService.UserChanged += (newUser) =>
        {
            _currentUser = new AuthenticationState(newUser);
            NotifyAuthenticationStateChanged(Task.FromResult(_currentUser));
        };
    }

    public async override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        return _currentUser ??= new AuthenticationState(await _externalAuthService.GetCurrentUser());
    }
}
