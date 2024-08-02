namespace SpeechForms.ViewModels;

public class UserVM : ViewModel, IUser
{
    public UserVM(int id)
    {
        Id = id;
    }
    public UserVM() { }


    public int Id { get; }

    #region Num
    /// <summary>Номер пользователя</summary>
    private int _Num;  

    /// <summary>Номер пользователя</summary>
    public int Num
    {
        get => _Num;
        set => Set(ref _Num, value);
    }
    #endregion

    #region LastName
    /// <summary>Фамилия пользователя</summary>
    private string _LastName;

    /// <summary>Фамилия пользователя</summary>
    public string LastName
    {
        get => _LastName;
        set => Set(ref _LastName, value);
    }
    #endregion

    #region Name
    /// <summary>Имя пользователя</summary>
    private string _Name;

    /// <summary>Имя пользователя</summary>
    public string Name
    {
        get => _Name;
        set => Set(ref _Name, value);
    }
    #endregion

    #region MiddleName
    /// <summary>Отчество пользователя</summary>
    private string _MiddleName;

    /// <summary>Отчество пользователя</summary>
    public string MiddleName
    {
        get => _MiddleName;
        set => Set(ref _MiddleName, value);
    }
    #endregion

    #region DateOfBirth
    /// <summary>Дата рождения пользователя</summary>
    private DateTime _DateOfBirth;

    /// <summary>Дата рождения пользователя</summary>
    public DateTime DateOfBirth
    {
        get => _DateOfBirth;
        set => Set(ref _DateOfBirth, value);
    }
    #endregion
}

