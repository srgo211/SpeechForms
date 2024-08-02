using Microsoft.Extensions.DependencyInjection;
using SpeechForms.Bl;
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

        var selectedTables = ser?.SelectedTable;
        var res = Calculate.CalculateAbsentDays(selectedTables);
        days.AbsentDays = res.absentCount;
        days.PayableDays = res.payableDays;

        var main = ser.UserAttendanceTables.FirstOrDefault(x => x.Guid == selectedTables.Guid);
        main.MonthAttendanceDays.AbsentDays = res.absentCount;
        main.MonthAttendanceDays.PayableDays = res.payableDays;

        Task.Run(() =>
        {
            serSpeech.Start(text);
            IsEnable = true;
        });



    }

    private string GetTextFromDays(IUser user, IAttendanceByDayLong? days)
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

       
        if (days.Day1.IsPass &&  !days.Day1.IsWeekend)  text += $"{dayNames[1]}{pause}";
        if (days.Day2.IsPass &&  !days.Day2.IsWeekend)  text += $"{dayNames[2]}{pause}";
        if (days.Day3.IsPass &&  !days.Day3.IsWeekend)  text += $"{dayNames[3]}{pause}";
        if (days.Day4.IsPass &&  !days.Day4.IsWeekend)  text += $"{dayNames[4]}{pause}";
        if (days.Day5.IsPass &&  !days.Day5.IsWeekend)  text += $"{dayNames[5]}{pause}";
        if (days.Day6.IsPass &&  !days.Day6.IsWeekend)  text += $"{dayNames[6]}{pause}";
        if (days.Day7.IsPass &&  !days.Day7.IsWeekend)  text += $"{dayNames[7]}{pause}";
        if (days.Day8.IsPass &&  !days.Day8.IsWeekend)  text += $"{dayNames[8]}{pause}";
        if (days.Day9.IsPass &&  !days.Day9.IsWeekend)  text += $"{dayNames[9]}{pause}";
        if (days.Day10.IsPass && !days.Day10.IsWeekend) text += $"{dayNames[10]}{pause}";
        if (days.Day11.IsPass && !days.Day11.IsWeekend) text += $"{dayNames[11]}{pause}";
        if (days.Day12.IsPass && !days.Day12.IsWeekend) text += $"{dayNames[12]}{pause}";
        if (days.Day13.IsPass && !days.Day13.IsWeekend) text += $"{dayNames[13]}{pause}";
        if (days.Day14.IsPass && !days.Day14.IsWeekend) text += $"{dayNames[14]}{pause}";
        if (days.Day15.IsPass && !days.Day15.IsWeekend) text += $"{dayNames[15]}{pause}";
        if (days.Day16.IsPass && !days.Day16.IsWeekend) text += $"{dayNames[16]}{pause}";
        if (days.Day17.IsPass && !days.Day17.IsWeekend) text += $"{dayNames[17]}{pause}";
        if (days.Day18.IsPass && !days.Day18.IsWeekend) text += $"{dayNames[18]}{pause}";
        if (days.Day19.IsPass && !days.Day19.IsWeekend) text += $"{dayNames[19]}{pause}";
        if (days.Day20.IsPass && !days.Day20.IsWeekend) text += $"{dayNames[20]}{pause}";
        if (days.Day21.IsPass && !days.Day21.IsWeekend) text += $"{dayNames[21]}{pause}";
        if (days.Day22.IsPass && !days.Day22.IsWeekend) text += $"{dayNames[22]}{pause}";
        if (days.Day23.IsPass && !days.Day23.IsWeekend) text += $"{dayNames[23]}{pause}";
        if (days.Day24.IsPass && !days.Day24.IsWeekend) text += $"{dayNames[24]}{pause}";
        if (days.Day25.IsPass && !days.Day25.IsWeekend) text += $"{dayNames[25]}{pause}";
        if (days.Day26.IsPass && !days.Day26.IsWeekend) text += $"{dayNames[26]}{pause}";
        if (days.Day27.IsPass && !days.Day27.IsWeekend) text += $"{dayNames[27]}{pause}";
        if (days.Day28.IsPass && !days.Day28.IsWeekend) text += $"{dayNames[28]}{pause}";
        if (days.Day29.IsPass && !days.Day29.IsWeekend) text += $"{dayNames[29]}{pause}";
        if (days.Day30.IsPass && !days.Day30.IsWeekend) text += $"{dayNames[30]}{pause}";
        if (days.Day31.IsPass && !days.Day31.IsWeekend) text += $"{dayNames[31]}{pause}";



        string endText = $"Всего пропущенных занятий:{pause} {days.AbsentDays}{pause}\n" +
            $"Всего дней подлежащих к оплате:{pause} {days.PayableDays}{pause}\n</speak>";

        string res = $"{startText}{text}{endText}";



        return res;

    }
}



internal class UpCommand : Command
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
        if (ser?.SelectedTable is null) return;

        var datas = ser.UserAttendanceTables;

        if (datas is null || datas.Count == 0) return;

        foreach (var data in datas)
        {
           

            var res = Calculate.CalculateAbsentDays(data);

            data.MonthAttendanceDays.AbsentDays = res.absentCount;
            data.MonthAttendanceDays.PayableDays = res.payableDays;

        }




    }

  
}