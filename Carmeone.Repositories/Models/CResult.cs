namespace Carmeone.Repositories.Models;

/// <summary>
/// Результат. Ответ от сервиса, метода.
/// </summary>
/// <typeparam name="T">Тип результата</typeparam>
public class CResult<T>
{
    /// <summary>
    /// Статус результата
    /// </summary>
    public CStatusResult StatusResult { get; set; } = null!;

    /// <summary>
    /// Данные
    /// </summary>
    public T? Data { get; set; }
}