namespace SpeechForms.ViewModels;

public class AttendanceByDayLongVM : AttendanceByDayVM, IAttendanceByDayLong
{
    public IDay Day31 { get; set; }
}
