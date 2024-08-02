namespace SpeechForms.ViewModels;

public class AttendanceByDayVM : AttendanceByDayBaseVM, IAttendanceByDay
{
    public IDay Day29 { get; set; }
    public IDay Day30 { get; set; }
}
