using MediatR;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.Abstractions;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Application.Messaging;
public interface IQueryHandler<TQuery, TResponse>
: IRequestHandler<TQuery, Result<TResponse>>
where TQuery : IQuery<TResponse> {

}
