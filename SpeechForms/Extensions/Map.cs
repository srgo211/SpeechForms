using ModelsForSpechForms.Models;
using System.Reflection;

namespace SpeechForms.Extensions;

public class Map
{

    public static ICollection<IPrintModel> Convert(ICollection<IUserAttendanceTable> datas)
    { 
        List<IPrintModel> printModels = new ();
        if(datas is null || datas.Count == 0) return printModels;

        foreach (var data in datas)
        {
            if(data is null || data.User is null || data.MonthAttendanceDays is null) continue;
            
            var model = Convert(data);
            printModels.Add(model);
        }
        return printModels;
    
    }

    public static IPrintModel Convert(IUserAttendanceTable data)
    {
        if (data is null) return new PrintModel();

        var user = data.User;
        var days = data.MonthAttendanceDays;

        string nameUser = $"{user.LastName} {user.Name}";

        IPrintModel model = new PrintModel()
        {
            Id = user.Num,
            User = nameUser,           
            Day1 = GetDay(days.Day1, days.IsWeekend1),
            Day2 = GetDay(days.Day2, days.IsWeekend2),
            Day3 = GetDay(days.Day3, days.IsWeekend3),
            Day4 = GetDay(days.Day4, days.IsWeekend4),
            Day5 = GetDay(days.Day5, days.IsWeekend5),
            Day6 = GetDay(days.Day6, days.IsWeekend6),
            Day7 = GetDay(days.Day7, days.IsWeekend7),
            Day8 = GetDay(days.Day8, days.IsWeekend8),
            Day9 = GetDay(days.Day9, days.IsWeekend9),
            Day10 = GetDay(days.Day10, days.IsWeekend10),
            Day11 = GetDay(days.Day11, days.IsWeekend11),
            Day12 = GetDay(days.Day12, days.IsWeekend12),
            Day13 = GetDay(days.Day13, days.IsWeekend13),
            Day14 = GetDay(days.Day14, days.IsWeekend14),
            Day15 = GetDay(days.Day15, days.IsWeekend15),
            Day16 = GetDay(days.Day16, days.IsWeekend16),
            Day17 = GetDay(days.Day17, days.IsWeekend17),
            Day18 = GetDay(days.Day18, days.IsWeekend18),
            Day19 = GetDay(days.Day19, days.IsWeekend19),
            Day20 = GetDay(days.Day20, days.IsWeekend20),
            Day21 = GetDay(days.Day21, days.IsWeekend21),
            Day22 = GetDay(days.Day22, days.IsWeekend22),
            Day23 = GetDay(days.Day23, days.IsWeekend23),
            Day24 = GetDay(days.Day24, days.IsWeekend24),
            Day25 = GetDay(days.Day25, days.IsWeekend25),
            Day26 = GetDay(days.Day26, days.IsWeekend26),
            Day27 = GetDay(days.Day27, days.IsWeekend27),
            Day28 = GetDay(days.Day28, days.IsWeekend28),
            Day29 = GetDay(days.Day29, days.IsWeekend29),
            Day30 = GetDay(days.Day30, days.IsWeekend30),
            Day31 = GetDay(days.Day31, days.IsWeekend31),
        };

        var total = CountCharPass(model);

        model.TotalPass = total.countPass;
        model.TotalWeek = total.countWeek;
        model.TotalPay  = total.countPay;

        


        return model;
    }

    private static string GetDay(bool isPassDay, bool isWeekend)
    {

        if (isWeekend) return PrintModel.charWeek.ToString();

        if(isPassDay && !isWeekend) return PrintModel.charPass.ToString();

        return PrintModel.charPay?.ToString() ?? default;

    }

    public static (int countPass, int countWeek, int countPay) CountCharPass(IPrintModel model)
    {
        Type modelType = typeof(PrintModel);
        int countPass = 0;
        int countWeek = 0;
        int countPay = 0;

        foreach (PropertyInfo property in modelType.GetProperties())
        {
            if (property.Name.StartsWith("Day") && property.PropertyType == typeof(char))
            {
                string dayValue = (string)property.GetValue(model);
                if (dayValue == PrintModel.charPass.ToString())
                {
                    countPass++;
                }

                if (dayValue == PrintModel.charWeek.ToString())
                {
                    countWeek++;
                }

                if (dayValue == PrintModel.charPay)
                {
                    countPay++;
                }

            }
        }

        return (countPass, countWeek, countPay);
    }

}
