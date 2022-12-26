namespace Carmeone.Db.Entities.Base;

/// <summary>
/// Состояние транспортного средства
/// </summary>
public enum VehicleStateType
{
    /// <summary>
    /// С автомобилем все в порядке, авто не попадало в аварии, новый автомобиль
    /// </summary>
    New = 0,
    /// <summary>
    /// Был ДТП (один) , не значительное ДТП
    /// </summary>
    MinorAccident = 1,
    /// <summary>
    /// Серьезное ДТП, был серьезный ремонт, много ДТП 2 и болеее
    /// </summary>
    MajorAccident = 2,
    /// <summary>
    /// Требует ремонта
    /// </summary>
    RequiresRepair = 2,
    /// <summary>
    /// На запчасти
    /// </summary>
    SpareParts = 3
}