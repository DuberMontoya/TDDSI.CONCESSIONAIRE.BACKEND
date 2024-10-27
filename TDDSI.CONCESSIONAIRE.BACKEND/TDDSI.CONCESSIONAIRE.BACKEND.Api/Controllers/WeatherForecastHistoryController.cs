﻿using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using TDDSI.CONCESSIONAIRE.BACKEND.Application.Features.WeatherForecastsHistories.WeatherForecastById;
using TDDSI.CONCESSIONAIRE.BACKEND.Application.Messaging;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.Abstractions;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.Helpers;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Api.Controllers;
public class WeatherForecastHistoryController(
      ILogger<WeatherForecastHistoryController> logger
    , IDispatch dispatch
) : ControllerBase {

    [HttpGet( "weatherForecastHistoryById" )]
    public async Task<ActionResult<Result>> WeatherForecastHistoryByAsync(
          Guid Id
        , CancellationToken cancellationToken
    ) {
        logger.LogInformation(
            "En la siguiente fecha {date} a las {time}, se llamo el endpoint {endpoint} de la clase {class}",
                DateTime.Now.ZoneByIdPacificStandardTime().ToString( "dd/MM/yyyy", provider: new CultureInfo( "es-CO" ) ),
                DateTime.Now.ZoneByIdPacificStandardTime().ToString( "hh:mm tt" ),
                "WeatherForecastHistoryAsync",
                nameof( WeatherForecastHistoryController )
        );

        return await dispatch.Send(
            new WeatherForecastHistoryByIdQuery( Id )
            , cancellationToken
        );
    }
}