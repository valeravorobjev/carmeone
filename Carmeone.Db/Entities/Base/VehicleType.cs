namespace Carmeone.Db.Entities.Base;

/// <summary>
/// Тип транспортного средства
/// </summary>
public enum VehicleType
{
    /// <summary>
    /// Легковой автомобиль
    /// </summary>
    Car = 0,
    /// <summary>
    /// Мотоцикл
    /// </summary>
    Moto = 1,
    /// <summary>
    /// Водное транспортное средство (лодка, катер, яхта и т.д.)
    /// </summary>
    Boat = 2,
    /// <summary>
    /// Автобус
    /// </summary>
    Bus = 3,
    /// <summary>
    /// Грузовик
    /// </summary>
    Truck = 4,
    /// <summary>
    /// Автопогрузчик
    /// </summary>
    ForkLiftTruck = 5,
    /// <summary>
    /// Сельхозтехника
    /// </summary>
    AgriculturalMachinery = 6,
    /// <summary>
    /// Строительная техника
    /// </summary>
    ConstructionEquipment = 7,
    /// <summary>
    /// Автофургон
    /// </summary>
    Van = 8
}