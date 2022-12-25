namespace Carmeone.Db.Entities;

/// <summary>
/// Модель транспортного средства
/// </summary>
public class Model
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public uint Id { get; set; }
    /// <summary>
    /// Идентификатор бренда
    /// </summary>
    public uint BrandId { get; set; }
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