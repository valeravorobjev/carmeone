using Carmeone.Db.Entities.Base;

namespace Carmeone.Db.Entities;

public class Moto
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public string Id { get; set; } = null!;
    
    /// <summary>
    /// Тип мотоцикла
    /// </summary>
    public MotoType MotoType { get; set; }
}