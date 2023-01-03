namespace Carmeone.Repositories.Models;

/// <summary>
/// Модель валидации. Содержит состояние валидации модели в целом.
/// А так же статусы с кодами для всех полей, проверяемой модели.
/// </summary>
public class CValidation
{
    public CValidation()
    {
        FieldErrors = new Dictionary<string, string>();
    }

    /// <summary>
    /// Валидна ли модель. Ture если валидна.
    /// </summary>
    public bool IsValid => FieldErrors.Count == 0;

    /// <summary>
    /// Ошибки полей, проверяемой модели
    /// </summary>
    public Dictionary<string, string> FieldErrors { get; set; } = null!;

    public override string ToString()
    {
        string isvalid = IsValid ? "Validation: SUCCESS" : "Validation: INVALID";
        string validations = FieldErrors.Count > 0
            ? "FieldErrors: " + string.Join(", ", FieldErrors.Select(f => $"{f.Key}={f.Value}"))
            : string.Empty;

        return string.Join(" | ", new[] { isvalid, validations });
    }
}