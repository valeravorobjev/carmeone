namespace Carmeone.Db.Entities;

public class Publication
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public string PublicationId { get; set; }
    
    /// <summary>
    /// Дата создания объявления
    /// </summary>
    public DateTime CreateDate { get; set; }
    
    /// <summary>
    /// Дата истечения публикации
    /// </summary>
    public DateTime ExpirationDate { get; set; }
    
    /// <summary>
    /// Автоматически возобнавлять объявление
    /// </summary>
    public bool IsAutoRenew { get; set; }
    
    /// <summary>
    /// Транспортное средство
    /// </summary>
    public Vehicle Vehicle { get; set; }
    
    /// <summary>
    /// Связь многие ко многим с таблицей пользователей
    /// </summary>
    public ICollection<User> Users { get; set; }
}