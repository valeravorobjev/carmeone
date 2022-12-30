namespace Carmeone.Db.Entities;

/// <summary>
/// Пользователь - компания
/// </summary>
public class CompanyUser
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid CompanyUserId { get; set; }
    
    /// <summary>
    /// Пользователь
    /// </summary>
    public User? User { get; set; }
}