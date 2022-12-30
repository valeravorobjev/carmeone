using Carmeone.Db.Entities.Base;

namespace Carmeone.Db.Entities;

/// <summary>
/// Автобус
/// </summary>
public class Bus
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid BusId { get; set; }
    
    /// <summary>
    /// Тип автобуса
    /// </summary>
    public BusType BusType { get; set; }
    
    /// <summary>
    /// Связь с таблицей транспортного средства
    /// </summary>
    public Vehicle Vehicle { get; set; }
}