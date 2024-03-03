using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_4
{
    /// <summary>
    /// Определение класса Student, наследующего от класса Person
    /// </summary>
    class Student : Person
    {
        /// <summary>
        /// Свойство Couse для хранения курса студента
        /// </summary>
        public int Couse { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Student() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="who"> Кто это </param>
        /// <param name="name"> Имя </param>
        /// <param name="surname"> Фамилия </param>
        /// <param name="dateofbirth"> Дата рождения</param>
        /// <param name="faculty"> Факультет </param>
        /// <param name="couse"> Курс </param>
        public Student(string who,string name, string surname, DateTime dateofbirth, string faculty,int couse):base(who, name, surname, dateofbirth, faculty)
        {
            Couse = couse;
        }
        /// <summary>
        /// Переопределение метода Age() класса Person
        /// </summary>
        /// <returns> Возраст </returns>
        public override int Age()
        {
            return base.Age();
        }
        /// <summary>
        /// Переопределение метода Info() класса Person
        /// </summary>
        public override void Info()
        {
            base.Info();
            Write($"Курс: {Couse}\n");
        }
        /// <summary>
        /// Статический метод для ввода информации о студенте
        /// </summary>
        /// <returns></returns>
        public static Student Input()
        {
            WriteLine();
            string who = "СтуденТ";
            Write("Введите имя: ");
            string name = ReadLine();
            Write("Введите фамилию: ");
            string surname = ReadLine();
            Write("Введите дату рождения: ");
            DateTime dateofbirth = DateTime.Parse(ReadLine());
            Write("Введите факультет: ");
            string faculty = ReadLine();
            Write("Введите курс: ");
            int couse = Convert.ToInt32(ReadLine());
            return new Student(who,name, surname, dateofbirth, faculty,couse);
        }
    }
}
