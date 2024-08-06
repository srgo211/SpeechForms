using Microsoft.Extensions.DependencyInjection;
using SpeechForms.ViewModels;
using System.Windows;

namespace SpeechForms.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private async void MainWindow_OnClosed(object? sender, EventArgs e)
    {
        var ser = App.Services.GetRequiredService<MainVM>();
        if (ser is null) return;
        //await SerializationHelper.SerializeUsersAsync(ser.UserAttendanceTables, Settings.PathFileUsers);

        await JsonHelper.SerializeToJsonAsync(Settings.PathFileUsers, ser.UserAttendanceTables);
        Console.WriteLine("Данные успешно сериализованы в файл.");
    }
}