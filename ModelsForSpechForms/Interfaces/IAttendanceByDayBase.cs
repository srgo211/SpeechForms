namespace ModelsForSpechForms.Interfaces;

public interface IAttendanceByDayBase
{
    byte Month { get; set; }
    bool Day1 { get; set; }
    bool Day2 { get; set; }
    bool Day3 { get; set; }
    bool Day4 { get; set; }
    bool Day5 { get; set; }
    bool Day6 { get; set; }
    bool Day7 { get; set; }
    bool Day8 { get; set; }
    bool Day9 { get; set; }
    bool Day10 { get; set; }
    bool Day11 { get; set; }
    bool Day12 { get; set; }
    bool Day13 { get; set; }
    bool Day14 { get; set; }
    bool Day15 { get; set; }
    bool Day16 { get; set; }
    bool Day17 { get; set; }
    bool Day18 { get; set; }
    bool Day19 { get; set; }
    bool Day20 { get; set; }
    bool Day21 { get; set; }
    bool Day22 { get; set; }
    bool Day23 { get; set; }
    bool Day24 { get; set; }
    bool Day25 { get; set; }
    bool Day26 { get; set; }
    bool Day27 { get; set; }
    bool Day28 { get; set; }
    bool Day29 { get; set; }
    bool Day30 { get; set; }
    bool Day31 { get; set; }

    bool IsWeekend1 { get; set; }
    bool IsWeekend2 { get; set; }
    bool IsWeekend3 { get; set; }
    bool IsWeekend4 { get; set; }
    bool IsWeekend5 { get; set; }
    bool IsWeekend6 { get; set; }
    bool IsWeekend7 { get; set; }
    bool IsWeekend8 { get; set; }
    bool IsWeekend9 { get; set; }
    bool IsWeekend10 { get; set; }
    bool IsWeekend11 { get; set; }
    bool IsWeekend12 { get; set; }
    bool IsWeekend13 { get; set; }
    bool IsWeekend14 { get; set; }
    bool IsWeekend15 { get; set; }
    bool IsWeekend16 { get; set; }
    bool IsWeekend17 { get; set; }
    bool IsWeekend18 { get; set; }
    bool IsWeekend19 { get; set; }
    bool IsWeekend20 { get; set; }
    bool IsWeekend21 { get; set; }
    bool IsWeekend22 { get; set; }
    bool IsWeekend23 { get; set; }
    bool IsWeekend24 { get; set; }
    bool IsWeekend25 { get; set; }
    bool IsWeekend26 { get; set; }
    bool IsWeekend27 { get; set; }
    bool IsWeekend28 { get; set; }
    bool IsWeekend29 { get; set; }
    bool IsWeekend30 { get; set; }
    bool IsWeekend31 { get; set; }








    /// <summary>пропущенных дней </summary>
    int AbsentDays { get; set; }

    /// <summary>дни подлежащие оплате </summary>
    int PayableDays { get; set; }

    string Description { get; set; }

    

}
