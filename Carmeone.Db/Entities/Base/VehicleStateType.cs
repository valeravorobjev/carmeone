namespace Carmeone.Db.Entities.Base;

/// <summary>
/// Состояние транспортного средства
/// </summary>
public enum VehicleStateType
{
    /// <summary>
    /// С автомобилем все в порядке, авто не попадало в аварии, новый автомобиль
    /// </summary>
    New,

    /// <summary>
    /// Был ДТП (один) , не значительное ДТП
    /// </summary>
    MinorAccident,

    /// <summary>
    /// Серьезное ДТП, был серьезный ремонт, много ДТП 2 и болеее
    /// </summary>
    MajorAccident,

    /// <summary>
    /// Требует ремонта
    /// </summary>
    RequiresRepair,

    /// <summary>
    /// На запчасти
    /// </summary>
    SpareParts
}