using ModelsForSpechForms.Interfaces;

namespace ModelsForSpechForms.Models;

public class AttendanceByDayBase : IAttendanceByDayBase
{
    public byte Month { get; set; }
    public IDay Day1 { get; set; }
    public IDay Day2 { get; set; }
    public IDay Day3 { get; set; }
    public IDay Day4 { get; set; }
    public IDay Day5 { get; set; }
    public IDay Day6 { get; set; }
    public IDay Day7 { get; set; }
    public IDay Day8 { get; set; }
    public IDay Day9 { get; set; }
    public IDay Day10 { get; set; }
    public IDay Day11 { get; set; }
    public IDay Day12 { get; set; }
    public IDay Day13 { get; set; }
    public IDay Day14 { get; set; }
    public IDay Day15 { get; set; }
    public IDay Day16 { get; set; }
    public IDay Day17 { get; set; }
    public IDay Day18 { get; set; }
    public IDay Day19 { get; set; }
    public IDay Day20 { get; set; }
    public IDay Day21 { get; set; }
    public IDay Day22 { get; set; }
    public IDay Day23 { get; set; }
    public IDay Day24 { get; set; }
    public IDay Day25 { get; set; }
    public IDay Day26 { get; set; }
    public IDay Day27 { get; set; }
    public IDay Day28 { get; set; }
    

    public int AbsentDays { get; set; }
    public int PayableDays { get; set; }
    public string Description { get; set; }
}


public class Day : IDay
{
    public bool IsPass { get; set; }
    public bool IsWeekend { get; set; }
}


public class AttendanceByDayVis : AttendanceByDayBase, IAttendanceByDayVis
{
    public IDay Day29 { get; set; }
}

public class AttendanceByDay : AttendanceByDayVis,  IAttendanceByDay
{
    public IDay Day30 { get; set; }
}




public class AttendanceByDayLong : AttendanceByDay, IAttendanceByDayLong
{
    public IDay Day31 { get; set; }
}