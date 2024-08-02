namespace ModelsForSpechForms.Interfaces;

public interface IUserAttendanceTable
{
    Guid Guid { get; }
    bool IsCalculation { get; set; }
    IUser User { get; set; }

    IAttendanceByDayLong MonthAttendanceDays { get; set; }
}
