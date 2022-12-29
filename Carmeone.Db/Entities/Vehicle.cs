using Carmeone.Db.Entities.Base;

namespace Carmeone.Db.Entities;

/// <summary>
/// Транспортное средство
/// </summary>
public abstract class Vehicle
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public string VehicleId { get; set; } = null!;
    
    /// <summary>
    /// Тип транспортного средства
    /// </summary>
    public VehicleType VehicleType { get; set; }
    
    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; } = null!;
    
    /// <summary>
    /// Новый или подержанный автомобиль
    /// </summary>
    public bool IsNew { get; set; }

    /// <summary>
    /// Идентификатор модели 
    /// </summary>
    public uint ModelId { get; set; }
    
    /// <summary>
    /// Количество владельцев
    /// </summary>
    public int OwnersCount { get; set; }
    
    /// <summary>
    /// Год выпуска
    /// </summary>
    public int YearManufacture { get; set; }

    /// <summary>
    /// Серийный номер
    /// </summary>
    public string SerialNumber { get; set; } = null!;

    /// <summary>
    /// Пробег
    /// </summary>
    public int Mileage { get; set; }

    /// <summary>
    /// Стоимость
    /// </summary>
    public decimal Cost { get; set; }
    
    /// <summary>
    /// Мощьность кВт
    /// </summary>
    public int Power { get; set; }

    /// <summary>
    /// Цвет
    /// </summary>
    public ColorType ColorType { get; set; }

    /// <summary>
    /// Цвет
    /// </summary>
    public bool IsMetalic { get; set; }

    /// <summary>
    /// Тип двигателя
    /// </summary>
    public EngineType EngineType { get; set; }

    /// <summary>
    /// Тип коробки передач
    /// </summary>
    public TransmissionType TransmissionType { get; set; }
    
    /// <summary>
    /// Объем двигателя
    /// </summary>
    public int EngineCapacity { get; set; }

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
    
    /// <summary>
    /// Связь с таблицей автомобилей
    /// </summary>
    public ICollection<Car> Cars { get; set; }
    /// <summary>
    /// Связь с таблицей мотоциклов
    /// </summary>
    public ICollection<Moto> Motos { get; set; }
    /// <summary>
    /// Связь с таблицей автобусов
    /// </summary>
    public ICollection<Bus> Buses { get; set; }
}