using ModelsForSpechForms.Interfaces;

namespace ModelsForSpechForms;

public class Extension
{
    public static MonthDays GetDaysInMonth(int month, bool isLeapYear = false) =>
        month switch
        {
            1 => MonthDays.January,
            2 when isLeapYear => MonthDays.February29,
            2 => MonthDays.February28,
            3 => MonthDays.March,
            4 => MonthDays.April,
            5 => MonthDays.May,
            6 => MonthDays.June,
            7 => MonthDays.July,
            8 => MonthDays.August,
            9 => MonthDays.September,
            10 => MonthDays.October,
            11 => MonthDays.November,
            12 => MonthDays.December,
            _ => throw new ArgumentException("Неверный номер месяца. Введите число от 1 до 12.")
        };
}
