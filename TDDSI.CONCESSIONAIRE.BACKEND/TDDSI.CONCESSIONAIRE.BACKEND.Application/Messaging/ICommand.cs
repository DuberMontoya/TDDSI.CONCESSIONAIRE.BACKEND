using MediatR;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.Abstractions;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Application.Messaging;
public interface ICommand : IRequest<Result>, IBaseCommand {

}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>, IBaseCommand {

}