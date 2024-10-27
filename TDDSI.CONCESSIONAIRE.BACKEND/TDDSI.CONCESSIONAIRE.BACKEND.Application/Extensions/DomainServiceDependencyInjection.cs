using Microsoft.Extensions.DependencyInjection;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.DomainService;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Application.Extensions;
public static class DomainServiceDependencyInjection {
    public static IServiceCollection AddDomainService( this IServiceCollection service ) {
        var _services = AppDomain.CurrentDomain.GetAssemblies()
            .Where( assembly => {
                return assembly.FullName is not null && assembly.FullName.Contains( "TDDSI.CONCESSIONAIRE.BACKEND.Domain", StringComparison.InvariantCulture );
            } )
            .SelectMany( assemby => assemby.GetTypes() )
            .Where( type => type.CustomAttributes.Any( customAttribute => customAttribute.AttributeType == typeof( DomainServiceAttribute ) ) );

        foreach (var _service in _services) {
            service.AddScoped( _service );
        }

        return service;
    }
}
