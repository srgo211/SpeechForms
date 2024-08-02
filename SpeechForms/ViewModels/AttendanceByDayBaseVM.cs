using Microsoft.Extensions.DependencyInjection;
using SpeechForms.Bl;

namespace SpeechForms.ViewModels;

public class AttendanceByDayBaseVM : ViewModel, IAttendanceByDayBase
{
    public bool isCalculation = false;
    #region Month
    /// <summary>Месяц</summary>
    private byte _Month;

    /// <summary>Месяц</summary>
    public byte Month
    {
        get => _Month;
        set => Set(ref _Month, value);
    }
    #endregion

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



    #region AbsentDays
    /// <summary>Пропущенные дни</summary>
    private int _AbsentDays;

    /// <summary>Пропущенные дни</summary>
    public int AbsentDays
    {
        get => _AbsentDays;
        set => Set(ref _AbsentDays, value);
    }
    #endregion

    #region PayableDays
    /// <summary>дни подлежащие оплате </summary>
    private int _PayableDays;

    /// <summary>дни подлежащие оплате </summary>
    public int PayableDays
    {
        get => _PayableDays;
        set => Set(ref _PayableDays, value);
    }
    #endregion

    #region Description
    
    private string _Description;

    public string Description
    {
        get => _Description;
        set => Set(ref _Description, value);
    }
    #endregion

 

   
}

public class DayVM : ViewModel, IDay
{
   

    #region IsPass    
    private bool _IsPass;   
    public bool IsPass
    {
        get => _IsPass;
        set
        {
            if (Set(ref _IsPass, value))
            {
                Update();
            }
        }
    }
    #endregion

    #region IsWeekend   
    private bool _IsWeekend;
    public bool IsWeekend
    {
        get => _IsWeekend;
        set => Set(ref _IsWeekend, value);
    }
    #endregion

    protected void Update()
    {
        var ser = App.Services.GetRequiredService<MainVM>();
        var table = ser?.SelectedTable;

        if (table is null) return;

        if (table.IsCalculation) return;
        table.IsCalculation = true;
        var days = table.MonthAttendanceDays;
        var res = Calculate.CalculateAbsentDays(days);
        days.AbsentDays  = res.absentCount;
        days.PayableDays = res.absentCount;
        table.IsCalculation = false;
    }

}