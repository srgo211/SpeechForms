using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Extensions.DependencyInjection;
using SpeechForms.Bl;
using SpeechForms.Commands.Base;
using SpeechForms.ViewModels;
using System.IO;
using System.Windows;

namespace SpeechForms.Commands;

internal class PrintCommand : Command
{
    public static bool IsEnable { get; set; } = true;
    public override bool CanExecute(object parameter)
    {

        return IsEnable;
    }
    public override void Execute(object parameter)
    {
        IsEnable = false;

        var ser = App.Services.GetRequiredService<MainVM>();

        string pathPattern = FilesDatas.GetPathPattern(1);
        string pathSaveFolder = Path.Combine(Environment.CurrentDirectory, "Result");
        string pathSaveFile = Path.Combine(pathSaveFolder, $"{DateTime.Now.ToString("dd-MM-yyyy")}.xlsx");
        FilesDatas.CreateDirectory(pathSaveFolder);

        try
        {
            var datas = Extensions.Map.Convert(ser.UserAttendanceTables);      
            PrintDatas print = new PrintDatas(pathPattern, pathSaveFile);
            print.Run(datas);

            MessageBox.Show("Печать успешно завершена!");

            FilesDatas.OpenFolderInExplorer(pathSaveFile);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally 
        {
            IsEnable = true;
        }

        



    }

    
}

