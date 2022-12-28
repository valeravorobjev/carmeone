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
    public string Id { get; set; } = null!;
    
    /// <summary>
    /// Тип автобуса
    /// </summary>
    public BusType BusType { get; set; }
}