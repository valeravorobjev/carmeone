namespace Carmeone.Db.Entities.Base;

/// <summary>
/// Транспортное средство
/// </summary>
public abstract class Vehicle
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public string Id { get; set; } = null!;
    
    /// <summary>
    /// Тип транспортного средства
    /// </summary>
    public VehicleType VehicleType { get; set; }
    
    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Фотографии
    /// </summary>
    public string Photos { get; set; } = null!;
    
    /// <summary>
    /// Порядок следования фотографий
    /// </summary>
    public byte PhotoOrders { get; set; }
    
    /// <summary>
    /// Дата создания объявления
    /// </summary>
    public DateTime CreateDate { get; set; }
    
    /// <summary>
    /// Дата истечения публикации
    /// </summary>
    public DateTime ExpirationDate { get; set; }
    
    /// <summary>
    /// Автоматически возобнавлять объявление
    /// </summary>
    public bool IsAutoRenew { get; set; }
    
    /// <summary>
    /// Состояние транспортного средства
    /// </summary>
    public VehicleStateType VehicleStateType { get; set; }
    
    /// <summary>
    /// Расход топлива на 100 км
    /// </summary>
    public int FuelConsumption { get; set; }
    
    /// <summary>
    /// Класс экологической безопасности
    /// </summary>
    public EnvironmentalSafetyType EnvironmentalSafetyType { get; set; }
    
    /// <summary>
    /// Эфективность выбросов СО
    /// </summary>
    public EfficiencyClassType EfficiencyClass { get; set; }
    
    /// <summary>
    /// Цель размещения транспортного средства на площадке
    /// </summary>
    public TargetType TargetType { get; set; }
}