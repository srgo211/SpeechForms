using ModelsForSpechForms.Interfaces;

namespace ModelsForSpechForms.Models;

public class User : IUser
{
    public User(int id)
    {
        Id = id;
    }
    public User(){}

    // Уникальный идентификатор пользователя
    public int Id { get; private set; }
    public int Num { get; set; }

    // Фамилия пользователя
    public string LastName { get; set; }

    // Имя пользователя
    public string Name { get; set; }

    // Отчество пользователя
    public string MiddleName { get; set; }

    // Дата рождения пользователя
    public DateTime DateOfBirth { get; set; }
}
