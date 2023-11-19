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
    /// Опции, которые включены в данный автомобиль. АБС, сигнализация, затемнение стекол и т.д.
    /// </summary>
    public IList<CarOptionType> CarOptionTypes { get; set; }
    
    /// <summary>
    /// Текстовое описание машины
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Связь с таблицей транспортного средства
    /// </summary>
    public Vehicle Vehicle { get; set; } = null!;
}