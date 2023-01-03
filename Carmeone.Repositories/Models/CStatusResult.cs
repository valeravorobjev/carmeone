using System.Text.Json.Serialization;

namespace Carmeone.Repositories.Models;

/// <summary>
/// Статус результата
/// </summary>
public class CStatusResult
{
    /// <summary>
    /// Статус (строковой код)
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; } = null!;

    /// <summary>
    /// Сообщение. Текстовое описание.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
    
    /// <summary>
    /// Параметры валидации
    /// </summary>
    [JsonPropertyName("validation")]
    public CValidation? Validation { get; set; }
}