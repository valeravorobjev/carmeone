using System.Security.Cryptography;
using System.Text;

namespace Carmeone.Services.Common;

/// <summary>
/// Вспомогательные методы
/// </summary>
public static class Helpers
{
    /// <summary>
    /// Генерация пароля
    /// </summary>
    /// <param name="password">Пароль</param>
    /// <param name="salt">Соль</param>
    /// <returns></returns>
    public static string PassGen(string password, int salt)
    {
        var passtring = password + salt;

        var hashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(passtring));
        StringBuilder sbHash = new StringBuilder();
        foreach (byte hashByte in hashBytes)
        {
            sbHash.Append(hashByte.ToString("x2"));
        }

        return sbHash.ToString();
    }
}