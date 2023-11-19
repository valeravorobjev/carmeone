using Carmeone.Db.Entities.Base;

namespace Carmeone.Db.Entities;

/// <summary>
/// Транспортное средство
/// </summary>
public class Vehicle
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid VehicleId { get; set; }
    
    /// <summary>
    /// Идентификатор модели транспортного средства
    /// </summary>
    public Guid BrandModelId { get; set; }

    /// <summary>
    /// Тип транспортного средства
    /// </summary>
    public VehicleType VehicleType { get; set; }

    /// <summary>
    /// Новый или подержанный автомобиль
    /// </summary>
    public bool IsNew { get; set; }

    /// <summary>
    /// Количество владельцев
    /// </summary>
    public int? OwnersCount { get; set; }

    /// <summary>
    /// Год выпуска
    /// </summary>
    public int? YearManufacture { get; set; }

    /// <summary>
    /// Серийный номер
    /// </summary>
    public string? SerialNumber { get; set; }

    /// <summary>
    /// Пробег
    /// </summary>
    public int? Mileage { get; set; }

    /// <summary>
    /// Стоимость
    /// </summary>
    public decimal? Cost { get; set; }

    /// <summary>
    /// Мощьность кВт
    /// </summary>
    public int? Power { get; set; }

    /// <summary>
    /// Цвет
    /// </summary>
    public ColorType? ColorType { get; set; }

    /// <summary>
    /// Металик или нет
    /// </summary>
    public bool? IsMetalic { get; set; }

    /// <summary>
    /// Тип двигателя
    /// </summary>
    public EngineType? EngineType { get; set; }

    /// <summary>
    /// Тип коробки передач
    /// </summary>
    public TransmissionType? TransmissionType { get; set; }

    /// <summary>
    /// Объем двигателя
    /// </summary>
    public int? EngineCapacity { get; set; }

    /// <summary>
    /// Фотографии
    /// </summary>
    public List<string>? Photos { get; set; }

    /// <summary>
    /// Порядок следования фотографий
    /// </summary>
    public byte? PhotoOrders { get; set; }

    /// <summary>
    /// Состояние транспортного средства
    /// </summary>
    public VehicleStateType? VehicleStateType { get; set; }

    /// <summary>
    /// Расход топлива на 100 км
    /// </summary>
    public int? FuelConsumption { get; set; }

    /// <summary>
    /// Класс экологической безопасности
    /// </summary>
    public EnvironmentalSafetyType EnvironmentalSafetyType { get; set; }

    /// <summary>
    /// Эфективность выбросов СО
    /// </summary>
    public EfficiencyClassType EfficiencyClass { get; set; }
    
    /// <summary>
    /// Модель бренда (конкретная модель автомобиля)
    /// </summary>
    public BrandModel BrandModel { get; set; }

    /// <summary>
    /// Связь с таблицей автомобилей
    /// </summary>
    public Car? Car { get; set; }

    /// <summary>
    /// Связь с таблицей мотоциклов
    /// </summary>
    public Moto? Moto { get; set; }

    /// <summary>
    /// Связь с таблицей автобусов
    /// </summary>
    public Bus? Bus { get; set; }
}