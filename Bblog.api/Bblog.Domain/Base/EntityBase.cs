namespace Bblog.Domain.Base;
internal abstract class EntityBase : IEntityBase
{
    
}

public interface IEntityBase
{
    Guid Id { get; set; }
}

public interface IDeleteEntity
{
    bool IsDeleted { get; set; }
}