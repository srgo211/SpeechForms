using System.IO;
using ModelsForSpechForms.Models;
using Newtonsoft.Json;
using SpeechForms.ViewModels;

namespace SpeechForms.Extensions;

public class JsonHelper
{
    public static async Task SerializeToJsonAsync(string filePath, ICollection<IUserAttendanceTable> attendanceTable)
    {
        var settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.None // Добавляет информацию о типе для каждого объекта
        };

        string json = JsonConvert.SerializeObject(attendanceTable, Formatting.Indented, settings);

        await File.WriteAllTextAsync(filePath, json);
    }

    public static List<UserAttendanceTableData> DeserializeFromJsonAsync(string filePath)
    {
        var settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.None // Использует информацию о типе для десериализации
        };

        string json = File.ReadAllText(filePath);

        return JsonConvert.DeserializeObject<List<UserAttendanceTableData>>(json, settings);
    }




}




