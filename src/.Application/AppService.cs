using .Localization;
using Volo.Abp.Application.Services;

namespace ;

/* Inherit your application services from this class.
 */
public abstract class AppService : ApplicationService
{
    protected AppService()
    {
        LocalizationResource = typeof(Resource);
    }
}
