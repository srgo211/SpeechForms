using System.IO;

namespace SpeechForms;

internal class Settings
{
    public static string PathPattern1 { get; set; } = GetFullPathFile("Pattern1.xlsx");
    public static string PathFileUsers { get; set; } = GetFullPathFile("users.json");

    public static string GetFullPathFile(string nameFile, string directory = "Resources")
    {
        string currentDirectory = Environment.CurrentDirectory;
        string pathFile = Path.Combine(currentDirectory, directory, nameFile);
        return pathFile;
    }
}
