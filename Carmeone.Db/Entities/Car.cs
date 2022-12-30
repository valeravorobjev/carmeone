using Carmeone.Db.Entities.Base;

namespace Carmeone.Db.Entities;

/// <summary>
/// Легковой автомобиль
/// </summary>
public class Car
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid CarId { get; set; }
    
    /// <summary>
    /// Тип транспортного средства
    /// </summary>
    public CarType CarType { get; set; }

    /// <summary>
    /// Количество сидений
    /// </summary>
    public int? SeatsCount { get; set; }

    /// <summary>
    /// Количество дверей
    /// </summary>
    public int? DorsCount { get; set; }

    /// <summary>
    /// Тип салона автомобиля
    /// </summary>
    public CarInteriorType? CarInteriorType { get; set; }

    /// <summary>
    /// Связь с таблицей транспортного средства
    /// </summary>
    public Vehicle Vehicle { get; set; } = null!;
}