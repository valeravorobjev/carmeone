namespace Carmeone.Db.Entities;

/// <summary>
/// Связующая таблица между публикациями и пользователями.
/// У одного пользователя может быть одна или более публикаций
/// </summary>
public class UserPublication
{
    /// <summary>
    /// Идентификатор пользователя
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Идентификатор публикации
    /// </summary>
    public Guid PublicationId { get; set; }

    /// <summary>
    /// Свойство для связи с пользователем
    /// </summary>
    public User User { get; set; } = null!;
    /// <summary>
    /// Свойство для связи с публикацией
    /// </summary>
    public Publication Publication { get; set; } = null!;
}