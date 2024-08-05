using ModelsForSpechForms.Interfaces;

namespace ModelsForSpechForms.Models;

public class UserAttendanceTable : IUserAttendanceTable
{
    public Guid Guid { get; } = Guid.NewGuid();
    public bool IsCalculation { get; set; }
    public IUser User { get; set; }

    public IAttendanceByDayBase MonthAttendanceDays { get; set; }
}
