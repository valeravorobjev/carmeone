using Carmeone.Db.Entities.Base;

namespace Carmeone.Db.Entities;

public class Moto
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public string MotoId { get; set; } = null!;
    
    /// <summary>
    /// Тип мотоцикла
    /// </summary>
    public MotoType MotoType { get; set; }
    
    /// <summary>
    /// Связь с таблицей транспортного средства
    /// </summary>
    public Vehicle Vehicle { get; set; }
}