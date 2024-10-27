using MediatR;
using TDDSI.CONCESSIONAIRE.BACKEND.Domain.Abstractions;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Application.Messaging;
public interface IQuery<TResponse> : IRequest<Result<TResponse>> {

}