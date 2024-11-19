using .Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace .Controllers;

/* Inherit your controllers from this class.
 */
public abstract class Controller : AbpControllerBase
{
    protected Controller()
    {
        LocalizationResource = typeof(Resource);
    }
}
