using Microsoft.Extensions.DependencyInjection;
using SpeechForms.Commands.Base;
using SpeechForms.Services;
using System.Windows;

namespace SpeechForms.Commands;

internal class RecCommand : Command
{
    public static bool IsEnable { get; set; } = false;
    public override bool CanExecute(object parameter)
    {

        return IsEnable;
    }
    public override void Execute(object parameter)
    {
        var ser = App.Services.GetRequiredService<SpeechRecognizerService>();
        ser.StartRecognition();
        IsEnable = false;
        RecStopCommand.IsEnable = true;
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
        RecCommand.IsEnable = true;
    }

}


internal class InitRecordCommand : Command
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
        Task.Run(()=> RunAsync(ser, pathModel).ConfigureAwait(false));
    }

    public async Task RunAsync(SpeechRecognizerService ser, string pathModel)
    {
   
        ser.RunPass(pathModel);
        RecCommand.IsEnable = true;
        MessageBox.Show("Модель распознования активирована!");
    }
}

internal class InitRecordWeekCommand : Command
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
        RecCommand.IsEnable = true;
        MessageBox.Show("Модель распознования активирована!");
    }
}