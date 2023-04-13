namespace Carmeone.Services.Models;

/// <summary>
/// Результат. Ответ от сервиса, метода.
/// </summary>
/// <typeparam name="T">Тип результата</typeparam>
public class CarmeoneResult<T>
{
    /// <summary>
    /// Статус результата
    /// </summary>
    public StatusResult StatusResult { get; set; } = null!;

    /// <summary>
    /// Данные
    /// </summary>
    public T? Data { get; set; }
}