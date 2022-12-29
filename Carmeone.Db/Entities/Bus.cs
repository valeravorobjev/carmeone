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
    public string BusId { get; set; } = null!;
    
    /// <summary>
    /// Тип автобуса
    /// </summary>
    public BusType BusType { get; set; }
    
    /// <summary>
    /// Связь с таблицей транспортного средства
    /// </summary>
    public Vehicle Vehicle { get; set; }
}