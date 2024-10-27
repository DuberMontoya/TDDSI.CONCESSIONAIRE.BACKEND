using TDDSI.CONCESSIONAIRE.BACKEND.Application.Messaging;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.WeatherForecastsHistories;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Application.Features.WeatherForecasts.Events.NotifyWeatherForecastCreated;
internal sealed class NotifyWeatherForecastCreatedCommandHandler(
        WeatherForecastsHistoryService forecastsHistoryService
    )
    : INotifyHandler<NotifyWeatherForecastCreatedCommand> {
    public async Task Handle(
        NotifyWeatherForecastCreatedCommand notification
        , CancellationToken cancellationToken
    ) {
        WeatherForecastsHistory weatherForecastsHistory = WeatherForecastsHistory
            .Create(
                  notification.Proccess
                , true
                , DateOnly.FromDateTime( DateTime.Now )
                , "system"
            );
        await forecastsHistoryService
            .GenerateWeatherForecastsHistoryAsync(
                weatherForecastsHistory,
                cancellationToken
            );
    }
}
