using TDDSI.CONCESSIONAIRE.BACKEND.Application.Messaging;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Application.Features.WeatherForecastsHistories.WeatherForecastById;
public record WeatherForecastHistoryByIdQuery(
    Guid Id
) : IQuery<WeatherForecastHistoryByIdQueryResponse>;