namespace TDDSI.CONCESSIONAIRE.BACKEND.Domain.Abstractions;
public interface IEntityBase<T> {
    T Id { get; init; }
}
