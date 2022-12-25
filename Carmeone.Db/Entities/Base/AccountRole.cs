namespace Carmeone.Db.Entities.Base;

/// <summary>
/// Роль аккаунта пользователя
/// </summary>
public enum AccountRole
{
    /// <summary>
    /// Простой пользователь
    /// </summary>
    Individual = 0,
    /// <summary>
    /// Компания
    /// </summary>
    Company = 1,
    /// <summary>
    /// Администратор
    /// </summary>
    Administrator = 1
}