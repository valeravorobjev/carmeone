using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Carmeone.Db.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Carmeone.Db.Entities;

/// <summary>
/// Публикация объявления
/// </summary>
public class Publication
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid PublicationId { get; set; }
    
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
    /// Цель размещения транспортного средства на площадке
    /// </summary>
    public TargetType TargetType { get; set; }
    
    /// <summary>
    /// Транспортное средство
    /// </summary>
    public Vehicle Vehicle { get; set; }
    
    /// <summary>
    /// Связь многие ко многим с таблицей пользователей
    /// </summary>
    public ICollection<User> Users { get; set; }
    /// <summary>
    /// Связь многие ко многим с таблицей пользователей
    /// </summary>
    public ICollection<UserPublication> UserPublications { get; set; }
}