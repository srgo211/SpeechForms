using Microsoft.Extensions.DependencyInjection;
using SpeechForms.Commands.Base;
using System.Windows;

namespace SpeechForms.Commands;



internal class StartRecPassCommand : Command
{
    public static bool IsEnable { get; set; } = true;
    public override bool CanExecute(object parameter)
    {

        return IsEnable;
    }

    public override void Execute(object parameter)
    {
        string pathModel = @"D:\Download\vosk-model-ru-0.42";
        pathModel = @"D:\Download\vosk-model-small-ru-0.22";
        var ser = App.Services.GetRequiredService<SpeechRecognizerService>();
        IsEnable = false;
        Task.Run(() => RunAsync(ser, pathModel).ConfigureAwait(false));
    }

    public async Task RunAsync(SpeechRecognizerService ser, string pathModel)
    {
        ser.RunPass(pathModel);
        MessageBox.Show("Модель распознования пропусков активирована!");
        RecStopCommand.IsEnable = true;
        ser.StartRecognition();
       
    }
}

internal class StartRecWeekCommand : Command
{
    public static bool IsEnable { get; set; } = true;
    public override bool CanExecute(object parameter)
    {

        return IsEnable;
    }

    public override void Execute(object parameter)
    {
        string pathModel = @"D:\Download\vosk-model-ru-0.42";
        pathModel = @"D:\Download\vosk-model-small-ru-0.22";
        var ser = App.Services.GetRequiredService<SpeechRecognizerService>();
        IsEnable = false;
        Task.Run(() => RunAsync(ser, pathModel).ConfigureAwait(false));
    }

    public async Task RunAsync(SpeechRecognizerService ser, string pathModel)
    {
        ser.RunWeek(pathModel);
        MessageBox.Show("Модель распознования выходных активирована!");
        RecStopCommand.IsEnable = true;
        ser.StartRecognition();
    }
}

internal class RecStopCommand : Command
{
    public static bool IsEnable { get; set; } = false;
    public override bool CanExecute(object parameter)
    {

        return IsEnable;
    }
    public override void Execute(object parameter)
    {
        var ser = App.Services.GetRequiredService<SpeechRecognizerService>();
    
        ser.StopRecognition();
        
        IsEnable= false;
        StartRecPassCommand.IsEnable = true;
    }

}




