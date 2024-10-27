using MediatR;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.Abstractions;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Application.Messaging;
public interface ICommandHandler<TCommand> : IRequestHandler<TCommand, Result>
where TCommand : ICommand {

}

public interface ICommandHandler<TCommand, TResponse>
: IRequestHandler<TCommand, Result<TResponse>>
where TCommand : ICommand<TResponse> {

}