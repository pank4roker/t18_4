using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_4
{
    /// <summary>
    /// Определение класса Teacher, наследующего от класса Person
    /// </summary>
    class Teacher : Person
    {
        /// <summary>
        /// Свойства полей 
        /// </summary>
        public string Title{ get; set; }
        public int Experience { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Teacher() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="who"> Кто это </param>
        /// <param name="name"> Имя </param>
        /// <param name="surname"> Фамилия </param>
        /// <param name="dateofbirth"> Дата рождения</param>
        /// <param name="title"> Должность </param>
        /// <param name="experience"> Стаж </param>
        public Teacher(string who, string name, string surname, DateTime dateofbirth, string faculty,string title, int experience):base(who, name, surname, dateofbirth, faculty)
        {
            Title = title;
            Experience = experience;
        }
        /// <summary>
        /// Переопределение метода Age() класса Person
        /// </summary>
        /// <returns> Возраст </returns>
        /*public override int Age()
        {
            return base.Age();
        }*/

        /// <summary>
        /// Переопределение метода Info() класса Person
        /// </summary>
        public override void Info()
        {
            base.Info();
            Write($"Должность:{Title}\nСтаж:{Experience} лет\n");
        }
        /// <summary>
        ///  Статический метод для ввода информации о преподователе
        /// </summary>
        /// <returns></returns>
        public static Teacher Input()
        {
            WriteLine();
            string who = "Преподователь";
            Write("Введите имя: ");
            string name = ReadLine();
            Write("Введите фамилию: ");
            string surname = ReadLine();
            Write("Введите дату рождения: ");
            DateTime dateofbirth = DateTime.Parse(ReadLine());
            Write("Введите факультет: ");
            string faculty = ReadLine();
            Write("Введите должность: ");
            string title = ReadLine();
            Write("Введите стаж: ");
            int experience = Convert.ToInt32(ReadLine());
            return new Teacher(who, name, surname, dateofbirth, faculty,title,experience);
            
        }
    }
}
