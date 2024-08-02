namespace ModelsForSpechForms.Interfaces;

public interface IAttendanceByDayBase
{
    byte Month { get; set; }
    IDay Day1 { get; set; }
    IDay Day2 { get; set; }
    IDay Day3 { get; set; }
    IDay Day4 { get; set; }
    IDay Day5 { get; set; }
    IDay Day6 { get; set; }
    IDay Day7 { get; set; }
    IDay Day8 { get; set; }
    IDay Day9 { get; set; }
    IDay Day10 { get; set; }
    IDay Day11 { get; set; }
    IDay Day12 { get; set; }
    IDay Day13 { get; set; }
    IDay Day14 { get; set; }
    IDay Day15 { get; set; }
    IDay Day16 { get; set; }
    IDay Day17 { get; set; }
    IDay Day18 { get; set; }
    IDay Day19 { get; set; }
    IDay Day20 { get; set; }
    IDay Day21 { get; set; }
    IDay Day22 { get; set; }
    IDay Day23 { get; set; }
    IDay Day24 { get; set; }
    IDay Day25 { get; set; }
    IDay Day26 { get; set; }
    IDay Day27 { get; set; }
    IDay Day28 { get; set; }
  

    /// <summary>пропущенных дней </summary>
    int AbsentDays { get; set; }

    /// <summary>дни подлежащие оплате </summary>
    int PayableDays { get; set; }

    string Description { get; set; }

    

}

public interface IDay
{
    bool IsPass { get; set; }
    bool IsWeekend { get; set; }
}


public interface IAttendanceByDayVis : IAttendanceByDayBase
{
    IDay Day29 { get; set; }
   
}


public interface IAttendanceByDay : IAttendanceByDayVis
{    
    IDay Day30 { get; set; }   
}

public interface IAttendanceByDayLong : IAttendanceByDay
{
    IDay Day31 { get; set; }
}