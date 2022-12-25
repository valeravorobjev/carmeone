using Carmeone.Db.Entities.Base;

namespace Carmeone.Db.Entities;

/// <summary>
/// Легковой автомобиль
/// </summary>
public class Car: Vehicle
{
    /// <summary>
    /// Новый или подержанный автомобиль
    /// </summary>
    public bool IsNew { get; set; }
    /// <summary>
    /// Идентификатор модели 
    /// </summary>
    public uint ModelId { get; set; }
    /// <summary>
    /// Тип транспортного средства
    /// </summary>
    public CarType CarType { get; set; }
    /// <summary>
    /// Количество сидений
    /// </summary>
    public int SeatsCount { get; set; }
    /// <summary>
    /// Год выпуска автомобиля
    /// </summary>
    public int YearManufacture { get; set; }
    /// <summary>
    /// Пробег автомобиля
    /// </summary>
    public int Mileage { get; set; }
    /// <summary>
    /// Стоимость автомобиля
    /// </summary>
    public decimal Cost { get; set; }
    /// <summary>
    /// Мощьность автомобиля (лошадиных сил)
    /// </summary>
    public int Power { get; set; }
    /// <summary>
    /// Цвет автомобиля
    /// </summary>
    public  ColorType ColorType { get; set; }
    /// <summary>
    /// Цвет металик
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
}