using System.ComponentModel.DataAnnotations;
using TDDSI.CONCESSIONAIRE.BACKEND.Application.Messaging;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Application.Features.Users.CreateUser;
public record UserCommand(
    [Required] string FirstName
    , string? SecondName
    , [Required] string SurName
    , string? SecondSurName
    ) : ICommand<UserCommandResponse>;
