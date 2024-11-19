using .MauiBlazor.Settings;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.IdentityModel.MauiBlazor;

namespace .MauiBlazor;

[ExposeServices(typeof(IAbpMauiAccessTokenProvider))]
public class MauiBlazorAccessTokenProvider : IAbpMauiAccessTokenProvider , ITransientDependency
{
    private readonly IApplicationSettingService _ApplicationSettingService;

    public MauiBlazorAccessTokenProvider(IApplicationSettingService ApplicationSettingService)
    {
        _ApplicationSettingService = ApplicationSettingService;
    }

    public async Task<string> GetAccessTokenAsync()
    {
        return await _ApplicationSettingService.GetAccessTokenAsync();
    }
}
