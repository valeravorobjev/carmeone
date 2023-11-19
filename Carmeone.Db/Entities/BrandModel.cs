namespace Carmeone.Db.Entities;

/// <summary>
/// Модель транспортного средства
/// </summary>
public class BrandModel
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid BrandModelId { get; set; }

    /// <summary>
    /// Идентификатор брэнда
    /// </summary>
    public Guid BrandId { get; set; }

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
    /// Связь с таблицей Brand
    /// </summary>
    public Brand Brand { get; set; }

    /// <summary>
    /// Транспортные средства
    /// </summary>
    public ICollection<Vehicle> Vehicles { get; set; }
}