using Newtonsoft.Json;

namespace SpeechForms.ViewModels;

public class UserAttendanceTableVM : ViewModel, IUserAttendanceTable
{
    [JsonIgnore]
    public Guid Guid { get; set; } = Guid.NewGuid();
    public bool IsCalculation { get; set; }
    public IUser User { get; set; }
    public IAttendanceByDayBase MonthAttendanceDays { get; set; }
}
