namespace Carmeone.Db.Entities.Base;

/// <summary>
/// Тип транспортного средства
/// </summary>
public enum VehicleType
{
    /// <summary>
    /// Легковой автомобиль
    /// </summary>
    Car,
    /// <summary>
    /// Мотоцикл
    /// </summary>
    Moto,
    /// <summary>
    /// Водное транспортное средство (лодка, катер, яхта и т.д.)
    /// </summary>
    Boat,
    /// <summary>
    /// Автобус
    /// </summary>
    Bus,
    /// <summary>
    /// Грузовик
    /// </summary>
    Truck,
    /// <summary>
    /// Автопогрузчик
    /// </summary>
    ForkLiftTruck,
    /// <summary>
    /// Сельхозтехника
    /// </summary>
    AgriculturalMachinery,
    /// <summary>
    /// Строительная техника
    /// </summary>
    ConstructionEquipment,
    /// <summary>
    /// Автофургон
    /// </summary>
    Van = 8
}