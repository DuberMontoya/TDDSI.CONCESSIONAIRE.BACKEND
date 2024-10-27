using MediatR;

namespace TDDSI.CONCESSIONAIRE.BACKEND.Application.Messaging;
public interface INotifyHandler<TCommand> : INotificationHandler<TCommand>
where TCommand : INotify {

}
