using System.Diagnostics;
using System.IO;

namespace SpeechForms.Extensions;

internal class FilesDatas
{

    /// <summary>Удалить файл</summary>
    public static bool DeleteDirectory(string pathFile)
    {
        if (Directory.Exists(pathFile))
            try
            {
                Directory.Delete(pathFile, true);
                Thread.Sleep(300);
                return true;
            }
            catch (Exception ex)
            {
                //notification?.Error($"{ex.Message}", "Ошибка удаления директории");
                return false;
            }

        return true;
    }


    public static bool CreateDirectory(string pathDirectory)
    {
        DeleteDirectory(pathDirectory);
        try
        {
            Directory.CreateDirectory(pathDirectory);
            Thread.Sleep(300);
            return true;
        }
        catch (Exception ex)
        {
            //notification?.Error($"{ex.Message}", "Ошибка создания директории");
            return false;
        }
    }

    public static string GetPathPattern(int month = 1)
    {

        return Settings.PathPattern1;


    }


    public static void OpenFolderInExplorer(string folderPath)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            Arguments = folderPath,
            FileName = "explorer.exe"
        };

        Process.Start(startInfo);
    }
}
