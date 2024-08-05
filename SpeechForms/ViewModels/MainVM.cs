

using System.Collections.ObjectModel;

namespace SpeechForms.ViewModels;

public class MainVM : ViewModel
{
    

    public MainVM()
    {
        
        var dataList = AttendanceGenerator.GenerateRandomAttendanceData(10, 2024, 08);
        UserAttendanceTables.AddRange(dataList);
    }

    public RadObservableCollection<IUserAttendanceTable> UserAttendanceTables { get; set; } = new RadObservableCollection<IUserAttendanceTable>();



    #region SelectedUser
    /// <summary>Фамилия пользователя</summary>
    private IUserAttendanceTable _selectedTable;

    /// <summary>Фамилия пользователя</summary>
    public IUserAttendanceTable SelectedTable
    {
        get => _selectedTable;
        set => Set(ref _selectedTable, value);
    }
    #endregion


    public RadObservableCollection<string> RecognizedWords { get; set; } = new RadObservableCollection<string>();





}