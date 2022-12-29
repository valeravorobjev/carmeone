namespace Carmeone.Db.Entities;

/// <summary>
/// Бренд транспортного средства (Mersedes, BMV, Audi, ...)
/// </summary>
public class Brand
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public uint BrandId { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Фотография
    /// </summary>
    public string Photo { get; set; } = null!;

    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; set; } = null!;
    
    /// <summary>
    /// Связь с таблицей BrandModel
    /// </summary>
    public BrandModel BrandModel { get; set; }
}