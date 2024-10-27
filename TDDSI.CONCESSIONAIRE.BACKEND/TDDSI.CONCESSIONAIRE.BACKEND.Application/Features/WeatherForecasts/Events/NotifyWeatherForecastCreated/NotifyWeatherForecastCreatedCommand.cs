using TDDSI.CONCESSIONAIRE.BACKEND.Application.Messaging;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Application.Features.WeatherForecasts.Events.NotifyWeatherForecastCreated;
public record NotifyWeatherForecastCreatedCommand(
    string Proccess
) : INotify;
