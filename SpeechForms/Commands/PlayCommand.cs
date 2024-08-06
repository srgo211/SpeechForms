using Microsoft.Extensions.DependencyInjection;
using SpeechForms.Commands.Base;
using SpeechForms.ViewModels;
using SpeechSynthesis;

namespace SpeechForms.Commands;

internal class PlayCommand : Command
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
        if (ser?.SelectedTable is null)
        {
            IsEnable = true;
            return;
        }
        var serSpeech = App.Services.GetRequiredService<SpeechText>();

        var days = ser?.SelectedTable.MonthAttendanceDays;
        string text = GetTextFromDays(ser?.SelectedTable.User, days);      
              

        Task.Run(() =>
        {
            serSpeech.Start(text);
            IsEnable = true;
        });



    }

    private string GetTextFromDays(IUser user, IAttendanceByDayBase? days)
    {
        if (days is null || user is null) return "<speak version='1.0' xmlns='http://www.w3.org/2001/10/synthesis' xml:lang='ru-RU'>НЕТ ДАННЫХ!</speak>";

        // Массив с текстовыми представлениями чисел от 1 до 31
        string[] dayNames = {
            "", // Заполнитель для нулевого индекса, чтобы дни начинались с 1
            "первого", "второго", "третьего", "четвёртого", "пятого", "шестого", "седьмого", "восьмого", "девятого", "десятого",
            "одиннадцатого", "двенадцатого", "тринадцатого", "четырнадцатого", "пятнадцатого", "шестнадцатого", "семнадцатого", "восемнадцатого", "девятнадцатого", "двадцатого",
            "двадцать первого", "двадцать второго", "двадцать третьего", "двадцать четвёртого", "двадцать пятого", "двадцать шестого", "двадцать седьмого", "двадцать восьмого", "двадцать девятого", "тридцатого", "тридцать первого"
        };


        


        string startText = $"<speak version='1.0' xmlns='http://www.w3.org/2001/10/synthesis' xml:lang='ru-RU'>Инвормация о {user.LastName} {user.Name}!<break time='1000ms'/>Пропустил занятия:<break time='1000ms'/>";
        string pause = "<break time='700ms'/>";
        string text = default;

       
        if ( days.Day1)  text += $"{dayNames[1]}{pause}";
        if ( days.Day2)  text += $"{dayNames[2]}{pause}";
        if ( days.Day3)  text += $"{dayNames[3]}{pause}";
        if ( days.Day4)  text += $"{dayNames[4]}{pause}";
        if ( days.Day5)  text += $"{dayNames[5]}{pause}";
        if ( days.Day6)  text += $"{dayNames[6]}{pause}";
        if ( days.Day7)  text += $"{dayNames[7]}{pause}";
        if ( days.Day8)  text += $"{dayNames[8]}{pause}";
        if ( days.Day9)  text += $"{dayNames[9]}{pause}";
        if (days.Day10) text += $"{dayNames[10]}{pause}";
        if (days.Day11) text += $"{dayNames[11]}{pause}";
        if (days.Day12) text += $"{dayNames[12]}{pause}";
        if (days.Day13) text += $"{dayNames[13]}{pause}";
        if (days.Day14) text += $"{dayNames[14]}{pause}";
        if (days.Day15) text += $"{dayNames[15]}{pause}";
        if (days.Day16) text += $"{dayNames[16]}{pause}";
        if (days.Day17) text += $"{dayNames[17]}{pause}";
        if (days.Day18) text += $"{dayNames[18]}{pause}";
        if (days.Day19) text += $"{dayNames[19]}{pause}";
        if (days.Day20) text += $"{dayNames[20]}{pause}";
        if (days.Day21) text += $"{dayNames[21]}{pause}";
        if (days.Day22) text += $"{dayNames[22]}{pause}";
        if (days.Day23) text += $"{dayNames[23]}{pause}";
        if (days.Day24) text += $"{dayNames[24]}{pause}";
        if (days.Day25) text += $"{dayNames[25]}{pause}";
        if (days.Day26) text += $"{dayNames[26]}{pause}";
        if (days.Day27) text += $"{dayNames[27]}{pause}";
        if (days.Day28) text += $"{dayNames[28]}{pause}";
        if (days.Day29) text += $"{dayNames[29]}{pause}";
        if (days.Day30) text += $"{dayNames[30]}{pause}";
        if (days.Day31) text += $"{dayNames[31]}{pause}";



        string endText = $"Всего пропущенных занятий:{pause} {days.AbsentDays}{pause}\n" +
            $"Всего дней подлежащих к оплате:{pause} {days.PayableDays}{pause}\n</speak>";

        string res = $"{startText}{text}{endText}";



        return res;

    }
}

