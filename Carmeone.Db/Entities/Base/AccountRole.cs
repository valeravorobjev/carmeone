namespace Carmeone.Db.Entities.Base;

/// <summary>
/// Роль аккаунта пользователя
/// </summary>
public enum AccountRole
{
    /// <summary>
    /// Простой пользователь
    /// </summary>
    Individual,
    /// <summary>
    /// Компания
    /// </summary>
    Company,
    /// <summary>
    /// Администратор
    /// </summary>
    Administrator
}