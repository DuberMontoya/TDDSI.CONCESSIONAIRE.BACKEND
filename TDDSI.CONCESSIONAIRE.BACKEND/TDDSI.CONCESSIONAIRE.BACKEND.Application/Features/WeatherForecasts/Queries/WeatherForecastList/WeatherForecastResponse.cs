using TDDSI.CONCESSIONAIRE.BACKEND.Domain.WeatherForecasts.Dtos;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Application.Features.WeatherForecasts.Queries.WeatherForecastList;
public record WeatherForecastResponse(
    IEnumerable<WeatherForecastDto> WeatherForecasts
);
