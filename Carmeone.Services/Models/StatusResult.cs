namespace Carmeone.Services.Models;

/// <summary>
/// Статус результата
/// </summary>
public class StatusResult
{
    /// <summary>
    /// Статус (строковой код)
    /// </summary>
    public StatusCode StatusCode { get; set; }

    /// <summary>
    /// Сообщение. Текстовое описание.
    /// </summary>
    public string? Message { get; set; }
    
    /// <summary>
    /// Параметры валидации
    /// </summary>
    public Validation? Validation { get; set; }
}