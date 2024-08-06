namespace ModelsForSpechForms.Interfaces;

public interface IUser
{
    // Уникальный идентификатор пользователя
    int Id { get; set; }
    int Num { get; set; }

    // Фамилия пользователя
    string LastName { get; set; }

    // Имя пользователя
    string Name { get; set; }

    // Отчество пользователя
    string MiddleName { get; set; }

    // Дата рождения пользователя
    DateTime DateOfBirth { get; set; }
}
