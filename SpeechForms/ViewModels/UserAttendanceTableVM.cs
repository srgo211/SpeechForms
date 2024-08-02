namespace SpeechForms.ViewModels;

public class UserAttendanceTableVM : ViewModel, IUserAttendanceTable
{
    public Guid Guid { get; } = Guid.NewGuid();
    public bool IsCalculation { get; set; }
    
    #region User
    /// <summary>User</summary>
    private IUser _User;

    /// <summary>User</summary>
    public IUser User
    {
        get => _User;
        set => Set(ref _User, value);
    }
    #endregion

    #region MonthAttendanceDays
    /// <summary>MonthAttendanceDays</summary>
    private IAttendanceByDayLong _MonthAttendanceDays;

    /// <summary>MonthAttendanceDays</summary>
    public IAttendanceByDayLong MonthAttendanceDays
    {
        get => _MonthAttendanceDays;
        set => Set(ref _MonthAttendanceDays, value);
    }
    #endregion
}
