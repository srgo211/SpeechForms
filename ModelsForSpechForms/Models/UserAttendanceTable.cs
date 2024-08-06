using ModelsForSpechForms.Interfaces;

namespace ModelsForSpechForms.Models;

public class UserAttendanceTable : IUserAttendanceTable
{
    public Guid Guid { get; set; } = Guid.NewGuid();
    public bool IsCalculation { get; set; }
    public IUser User { get; set; }

    public IAttendanceByDayBase MonthAttendanceDays { get; set; }
}




public class UserAttendanceTableData 
{
    public Guid Guid { get; set; } 
    public bool IsCalculation { get; set; }
    public User User { get; set; }

    public AttendanceByDayBase MonthAttendanceDays { get; set; }
}