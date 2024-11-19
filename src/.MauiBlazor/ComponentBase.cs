using .Localization;
using Volo.Abp.AspNetCore.Components;

namespace .MauiBlazor;

public abstract class ComponentBase : AbpComponentBase
{
    protected ComponentBase()
    {
        LocalizationResource = typeof(Resource);
    }
}
