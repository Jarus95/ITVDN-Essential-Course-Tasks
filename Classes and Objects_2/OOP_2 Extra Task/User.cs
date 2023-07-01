using System;

namespace OOP_2_Extra_Task
{
    public class User
    {
        readonly string login;
        readonly string name;
        readonly string lastName;
        readonly int age;
        DateTimeOffset date;

        public User(string login, string name, string lastName, int age, DateTimeOffset date)
        {
            this.login = login;
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.date = date;

        }

        public override string ToString()
        {
            return $"Login: {login} Name: {name} Lastname: {lastName} Age: {age} Date:{date}";
        }
    }

    


}


//Задание
//Используя Visual Studio, создайте проект по шаблону Console Application.
//Требуется:
//Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата
//заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз
//(при создании экземпляра данного класса) без возможности его дальнейшего изменения.
//Реализуйте вывод на экран информации о пользователе.
