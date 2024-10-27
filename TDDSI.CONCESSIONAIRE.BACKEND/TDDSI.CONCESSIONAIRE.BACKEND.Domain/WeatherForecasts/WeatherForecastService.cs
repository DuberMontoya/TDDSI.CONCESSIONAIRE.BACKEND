using TDDSI.CONCESSIONAIRE.BACKEND.Domain.Constants;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.DomainService;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.Ports;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.WeatherForecasts.Dtos;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Domain.WeatherForecasts;
[DomainService]
public class WeatherForecastService(
    IQueryWrapper queryWrapper,
    IUnitOfWork unitOfWork
) {
    public async Task<IEnumerable<WeatherForecast>> GenerateForecastTimesAsync(
        CancellationToken cancellationToken
    ) {
        IEnumerable<WeatherForecast> weatherForecastList = WeatherForecastList();
        ArgumentNullException.ThrowIfNull( nameof( weatherForecastList ) );

        await unitOfWork.Repository<WeatherForecast>()
            .AddAsync( weatherForecastList, cancellationToken );

        return weatherForecastList;
    }

    public async Task<IEnumerable<WeatherForecastDto>> WeatherForecastsAsync() =>
        await queryWrapper
        .QueryAsync<WeatherForecastDto>(
            nameof( SqlQueriesConstants.AllWeastherForecasts )
        );

    public static IEnumerable<WeatherForecast> WeatherForecastList() {
        string[] sumaries = WeatherForecast.Summaries();
        return Enumerable
            .Range( 1, 5 )
            .Select( index => WeatherForecast.Create(
                DateOnly.FromDateTime( DateTime.Now.AddDays( index ) ),
                Random.Shared.Next( -20, 55 ),
                sumaries[Random.Shared.Next( sumaries.Length )]
            ) ).ToArray();
    }
}
