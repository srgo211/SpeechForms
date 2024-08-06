using System.IO;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace SpeechForms.Extensions;

public class SerializationHelper
{
    public static async Task SerializeUsersAsync(IEnumerable<IUserAttendanceTable> attendanceTables, string filePath)
    {
        var users = new List<IUser>();

        foreach (var attendance in attendanceTables)
        {
            if (attendance.User != null)
            {
                users.Add(attendance.User);
            }
        }

        var options = new JsonSerializerOptions
        {
            WriteIndented = true // Для более читабельного JSON
        };

        await using var stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
        await JsonSerializer.SerializeAsync(stream, users, options);
    }

    public static async Task<List<IUser>> DeserializeUsersAsync(string filePath)
    {
        await using var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        return await JsonSerializer.DeserializeAsync<List<IUser>>(stream);
    }


    public static async Task SerializeToJsonAsync(string filePath, ICollection<IUserAttendanceTable> attendanceTable)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true, // для красивого форматирования JSON
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
        {
            await JsonSerializer.SerializeAsync(fs, attendanceTable, options);
        }
    }

    public static async Task<List<IUserAttendanceTable>> DeserializeFromJsonAsync(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
        {
            return await JsonSerializer.DeserializeAsync<List<IUserAttendanceTable>>(fs);
        }
    }

}

