namespace Carmeone.Db.Entities;

/// <summary>
/// Бренд транспортного средства (Mersedes, BMV, Audi, ...)
/// </summary>
public class Brand
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public uint Id { get; set; }
    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Фотография
    /// </summary>
    public string Photo { get; set; }
    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; }
}