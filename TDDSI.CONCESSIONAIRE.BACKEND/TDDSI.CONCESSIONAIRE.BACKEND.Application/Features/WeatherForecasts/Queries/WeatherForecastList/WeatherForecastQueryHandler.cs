using TDDSI.CONCESSIONAIRE.BACKEND.Application.Messaging;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.Abstractions;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.WeatherForecasts;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.WeatherForecasts.Dtos;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Application.Features.WeatherForecasts.Queries.WeatherForecastList;
internal sealed class WeatherForecastQueryHandler(
        WeatherForecastService forecastService
    ) : IQueryHandler<WeatherForecastQuery, WeatherForecastResponse> {

    public async Task<Result<WeatherForecastResponse>> Handle( WeatherForecastQuery request
        , CancellationToken cancellationToken
    ) {

        IEnumerable<WeatherForecastDto> weatherForecasts = await forecastService.WeatherForecastsAsync();
        return new WeatherForecastResponse( weatherForecasts );
    }
}
