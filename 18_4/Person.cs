using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _18_4
{
    /// <summary>
    /// Абстрактный класс персоны
    /// </summary>
    abstract class Person
    {
        /// <summary>
        /// Свойства 
        /// </summary>
        public string Who { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Faculty { get; set; }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Person() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="who"> Кто это </param>
        /// <param name="name"> Имя </param>
        /// <param name="surname"> Фамилия </param>
        /// <param name="dateofbirth"> Дата рождения</param>
        /// <param name="faculty"> Факультет </param>
        public Person(string who,string name, string surname, DateTime dateofbirth, string faculty)
        {
            Name = name;
            Surname = surname;
            Dateofbirth = dateofbirth;
            Faculty = faculty;
            Who= who;
        }
        /// <summary>
        /// Виртуальный метод возраста
        /// </summary>
        /// <returns></returns>
        virtual public int Age()
        {
            if (DateTime.Now > Dateofbirth.AddYears(DateTime.Now.Year - Dateofbirth.Year))
            {
                return DateTime.Now.Year - Dateofbirth.Year;
            }
            else
            {
                return DateTime.Now.Year - Dateofbirth.Year;
            }
        }
        /// <summary>
        /// Виртуальный метод вывода
        /// </summary>
        virtual public void Info()
        {
            Write($"\n{Who}\nИмя: {Name}\nФамилия: {Surname}\nГод рождения: {Dateofbirth}\nФакультет: {Faculty}\nВозраст: {Age()}\n");
        }
        
    }
}
