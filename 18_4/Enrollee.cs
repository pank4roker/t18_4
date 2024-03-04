using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_4
{
    /// <summary>
    /// Определение класса Enrollee, наследующего от класса Person
    /// </summary>
    class Enrollee : Person
    {
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Enrollee() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="who"> Кто это </param>
        /// <param name="name"> Имя </param>
        /// <param name="surname"> Фамилия </param>
        /// <param name="dateofbirth"> Дата рождения</param>
        /// <param name="faculty"> Факультет </param>
        public Enrollee(string who,string name, string surname, DateTime dateofbirth, string faculty) : base(who,name, surname, dateofbirth, faculty) { }
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
        }
        /// <summary>
        ///  Статический метод для ввода информации о абитуриенте
        /// </summary>
        /// <returns></returns>
        public static Enrollee Input()
        {
            string who = "Aбитуриент";
            Write("Введите имя: ");
            string name = ReadLine();
            Write("Введите фамилию: ");
            string surname = ReadLine();
            Write("Введите дату рождения: ");
            DateTime dateofbirth = DateTime.Parse(ReadLine());
            Write("Введите факультет: ");
            string faculty = ReadLine();
            return new Enrollee(who,name,surname,dateofbirth,faculty);
        }
    }
}
