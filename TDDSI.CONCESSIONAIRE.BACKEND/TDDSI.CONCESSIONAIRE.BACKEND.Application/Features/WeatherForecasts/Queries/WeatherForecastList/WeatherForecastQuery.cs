using TDDSI.CONCESSIONAIRE.BACKEND.Application.Messaging;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Application.Features.WeatherForecasts.Queries.WeatherForecastList;
public record WeatherForecastQuery(
) : IQuery<WeatherForecastResponse>;
