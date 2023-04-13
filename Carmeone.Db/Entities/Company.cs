namespace Carmeone.Db.Entities;

/// <summary>
/// Пользователь - компания
/// </summary>
public class Company
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid CompanyId { get; set; }
    
    /// <summary>
    /// Связь с таблицей аккаунта
    /// </summary>
    public Account Account { get; set; }
}