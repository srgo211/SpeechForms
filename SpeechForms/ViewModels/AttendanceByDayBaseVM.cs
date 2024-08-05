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

    #region Day1
    private bool _Day1;
    public bool Day1
    {
        get => _Day1;
        set { if (Set(ref _Day1, value)) Update(this); }
    }
    #endregion

    #region Day2
    private bool _Day2;
    public bool Day2
    {
        get => _Day2;
        set { if (Set(ref _Day2, value)) Update(this); }
    }
    #endregion

    #region Day3
    private bool _Day3;
    public bool Day3
    {
        get => _Day3;
        set { if (Set(ref _Day3, value)) Update(this); }
    }
    #endregion

    #region Day4
    private bool _Day4;
    public bool Day4
    {
        get => _Day4;
        set { if (Set(ref _Day4, value)) Update(this); }
    }
    #endregion

    #region Day5
    private bool _Day5;
    public bool Day5
    {
        get => _Day5;
        set { if (Set(ref _Day5, value)) Update(this); }
    }
    #endregion

    #region Day6
    private bool _Day6;
    public bool Day6
    {
        get => _Day6;
        set { if (Set(ref _Day6, value)) Update(this); }
    }
    #endregion

    #region Day7
    private bool _Day7;
    public bool Day7
    {
        get => _Day7;
        set { if (Set(ref _Day7, value)) Update(this); }
    }
    #endregion

    #region Day8
    private bool _Day8;
    public bool Day8
    {
        get => _Day8;
        set { if (Set(ref _Day8, value)) Update(this); }
    }
    #endregion

    #region Day9
    private bool _Day9;
    public bool Day9
    {
        get => _Day9;
        set { if (Set(ref _Day9, value)) Update(this); }
    }
    #endregion

    #region Day10
    private bool _Day10;
    public bool Day10
    {
        get => _Day10;
        set { if (Set(ref _Day10, value)) Update(this); }
    }
    #endregion

    #region Day11
    private bool _Day11;
    public bool Day11
    {
        get => _Day11;
        set { if (Set(ref _Day11, value)) Update(this); }
    }
    #endregion

    #region Day12
    private bool _Day12;
    public bool Day12
    {
        get => _Day12;
        set { if (Set(ref _Day12, value)) Update(this); }
    }
    #endregion

    #region Day13
    private bool _Day13;
    public bool Day13
    {
        get => _Day13;
        set { if (Set(ref _Day13, value)) Update(this); }
    }
    #endregion

    #region Day14
    private bool _Day14;
    public bool Day14
    {
        get => _Day14;
        set { if (Set(ref _Day14, value)) Update(this); }
    }
    #endregion

    #region Day15
    private bool _Day15;
    public bool Day15
    {
        get => _Day15;
        set { if (Set(ref _Day15, value)) Update(this); }
    }
    #endregion

    #region Day16
    private bool _Day16;
    public bool Day16
    {
        get => _Day16;
        set { if (Set(ref _Day16, value)) Update(this); }
    }
    #endregion

    #region Day17
    private bool _Day17;
    public bool Day17
    {
        get => _Day17;
        set { if (Set(ref _Day17, value)) Update(this); }
    }
    #endregion

    #region Day18
    private bool _Day18;
    public bool Day18
    {
        get => _Day18;
        set { if (Set(ref _Day18, value)) Update(this); }
    }
    #endregion

    #region Day19
    private bool _Day19;
    public bool Day19
    {
        get => _Day19;
        set { if (Set(ref _Day19, value)) Update(this); }
    }
    #endregion

    #region Day20
    private bool _Day20;
    public bool Day20
    {
        get => _Day20;
        set { if (Set(ref _Day20, value)) Update(this); }
    }
    #endregion

    #region Day21
    private bool _Day21;
    public bool Day21
    {
        get => _Day21;
        set { if (Set(ref _Day21, value)) Update(this); }
    }
    #endregion

    #region Day22
    private bool _Day22;
    public bool Day22
    {
        get => _Day22;
        set { if (Set(ref _Day22, value)) Update(this); }
    }
    #endregion

    #region Day23
    private bool _Day23;
    public bool Day23
    {
        get => _Day23;
        set { if (Set(ref _Day23, value)) Update(this); }
    }
    #endregion

    #region Day24
    private bool _Day24;
    public bool Day24
    {
        get => _Day24;
        set { if (Set(ref _Day24, value)) Update(this); }
    }
    #endregion

    #region Day25
    private bool _Day25;
    public bool Day25
    {
        get => _Day25;
        set { if (Set(ref _Day25, value)) Update(this); }
    }
    #endregion

    #region Day26
    private bool _Day26;
    public bool Day26
    {
        get => _Day26;
        set { if (Set(ref _Day26, value)) Update(this); }
    }
    #endregion

    #region Day27
    private bool _Day27;
    public bool Day27
    {
        get => _Day27;
        set { if (Set(ref _Day27, value)) Update(this); }
    }
    #endregion

    #region Day28
    private bool _Day28;
    public bool Day28
    {
        get => _Day28;
        set { if (Set(ref _Day28, value)) Update(this); }
    }
    #endregion

    #region Day29
    private bool _Day29;
    public bool Day29
    {
        get => _Day29;
        set { if (Set(ref _Day29, value)) Update(this); }
    }
    #endregion

    #region Day30
    private bool _Day30;
    public bool Day30
    {
        get => _Day30;
        set { if (Set(ref _Day30, value)) Update(this); }
    }
    #endregion

    #region Day31
    private bool _Day31;
    public bool Day31
    {
        get => _Day31;
        set { if (Set(ref _Day31, value)) Update(this); }
    }



    #endregion

    #region Week
    public bool IsWeekend1 { get; set; }
    public bool IsWeekend2 { get; set; }
    public bool IsWeekend3 { get; set; }
    public bool IsWeekend4 { get; set; }
    public bool IsWeekend5 { get; set; }
    public bool IsWeekend6 { get; set; }
    public bool IsWeekend7 { get; set; }
    public bool IsWeekend8 { get; set; }
    public bool IsWeekend9 { get; set; }
    public bool IsWeekend10 { get; set; }
    public bool IsWeekend11 { get; set; }
    public bool IsWeekend12 { get; set; }
    public bool IsWeekend13 { get; set; }
    public bool IsWeekend14 { get; set; }
    public bool IsWeekend15 { get; set; }
    public bool IsWeekend16 { get; set; }
    public bool IsWeekend17 { get; set; }
    public bool IsWeekend18 { get; set; }
    public bool IsWeekend19 { get; set; }
    public bool IsWeekend20 { get; set; }
    public bool IsWeekend21 { get; set; }
    public bool IsWeekend22 { get; set; }
    public bool IsWeekend23 { get; set; }
    public bool IsWeekend24 { get; set; }
    public bool IsWeekend25 { get; set; }
    public bool IsWeekend26 { get; set; }
    public bool IsWeekend27 { get; set; }
    public bool IsWeekend28 { get; set; }
    public bool IsWeekend29 { get; set; }
    public bool IsWeekend30 { get; set; }
    public bool IsWeekend31 { get; set; }
    #endregion

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

    private void Update(IAttendanceByDayBase vm)
    {
        var res = Calculate.CalculateAbsentDays(vm);
        this.AbsentDays = res.absentCount;
        this.PayableDays = res.payableDays;       
    }


}

