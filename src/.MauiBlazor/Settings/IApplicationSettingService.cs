namespace .MauiBlazor.Settings;

public interface IApplicationSettingService
{   
   Task<string> GetAccessTokenAsync();
    
    Task SetAccessTokenAsync(string? accessToken);
}
