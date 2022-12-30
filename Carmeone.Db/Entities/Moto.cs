using Carmeone.Db.Entities.Base;

namespace Carmeone.Db.Entities;

/// <summary>
/// Мотоцикл
/// </summary>
public class Moto
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid MotoId { get; set; }
    
    /// <summary>
    /// Тип мотоцикла
    /// </summary>
    public MotoType MotoType { get; set; }
    
    /// <summary>
    /// Связь с таблицей транспортного средства
    /// </summary>
    public Vehicle Vehicle { get; set; }
}