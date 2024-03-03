using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

namespace _18_4
{
    class Program
    {
        static List<Teacher> teachers = new List<Teacher>();
        static List<Student> students = new List<Student>();
        static List<Enrollee> enrollees = new List<Enrollee>();
        static void Main(string[] args)
        {
            try
            {
                bool flag = true;
                while(flag)
                {
                    Clear();
                    Write("Кем вы являетесь T(teacher)/S(student)/E(enrollee): ");
                    string whos = ReadLine();
                    WriteLine();
                    switch(whos.ToLower())
                    {
                        case "t":
                            Teachers();
                            break;
                        case "s":
                            Students();
                            break;
                        case "e":
                            Enrollees();
                            break;
                        default:
                            break;

                    }
                }
               
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
        static void Teachers()
        { 
            bool flag1 = true;
            while (flag1)
            {
               
                Write("Список преподователей: \n");
                foreach(var elem in teachers)
                {
                    elem.Info();
                }
                WriteLine();
                Write("Какое действие вы хотите сделать: \n Добавить преподователя - 1 \n Изменить преподователя - 2 \n Удалить преподователя - 3 \n Поиск по возрасту - 4 \n Вернуться в меню  - 5 \n ");
                WriteLine();
                switch (ReadKey(true).KeyChar)
                {
                    case '1':
                        Teacher teacher = new Teacher();
                        teachers.Add(Teacher.Input());
                        Write("__________________\n");
                        break;
                    case '2':
                        WriteLine();
                        Write("Выберите элемент из списка: ");
                        int n = Convert.ToInt32(ReadLine());
                        Teacher teacher1 = new Teacher();
                        teachers[n - 1] = Teacher.Input();
                        break;
                    case '3':
                        Write("Введите индекс удаляемого объекта: ");
                        int index = Convert.ToInt32(ReadLine());
                        teachers.RemoveAt(index - 1);
                        break;
                    case '4':
                        Write("Введите начало диапозона лет: ");
                        int ndiap = Convert.ToInt32(ReadLine());
                        Write("Введите конец диапозона лет: ");
                        int kdiap = Convert.ToInt32(ReadLine());
                        List<Teacher> teash = new List<Teacher>();
                        foreach (Teacher teas in teachers)
                        {
                            if (teas.Age() >= ndiap && teas.Age() <= kdiap)
                            {
                                teash.Add(teas);
                            }
                        }

                        WriteLine($"\nУчителя с возрастом от {ndiap} до {kdiap} лет:");
                        foreach (Teacher tes in teash)
                        {
                            tes.Info();
                        }
                        Write("_________________");
                        WriteLine();
                        break;
                    case '5':
                        return;
                    default:
                        WriteLine("Вы ввели неверную цифру цифру"); flag1 = false;
                        break;
                }
         
            }

        }
        static void Students()
        {
            bool flag1 = true;
            while (flag1)
            {
                Write("Список студентов: \n");
                foreach (var elem in students)
                {
                    elem.Info();
                }
                WriteLine();
                Write("Какое действие вы хотите сделать: \n Добавить студента - 1 \n Изменить студента - 2 \n Удалить студента - 3 \n Поиск по возрасту - 4 \n Вернуться в меню  - 5 \n ");
                WriteLine();
                switch (ReadKey(true).KeyChar)
                {
                    case '1':
                        Student student = new Student();
                        students.Add(Student.Input());
                        Write("__________________\n");
                        break;
                    case '2':
                        WriteLine();
                        Write("Выберите элемент из списка: ");
                        int n = Convert.ToInt32(ReadLine());
                        Student student1 = new Student();
                        students[n - 1] = Student.Input();
                        break;
                    case '3':
                        Write("Введите индекс удаляемого объекта: ");
                        int index = Convert.ToInt32(ReadLine());
                        students.RemoveAt(index - 1);
                        break;
                    case '4':
                        Write("Введите начало диапозона лет: ");
                        int ndiap = Convert.ToInt32(ReadLine());
                        Write("Введите конец диапозона лет: ");
                        int kdiap = Convert.ToInt32(ReadLine());
                        List<Student> stude = new List<Student>();
                        foreach (Student stud in students)
                        {
                            if (stud.Age() >= ndiap && stud.Age() <= kdiap)
                            {
                                stude.Add(stud);
                            }
                        }

                        WriteLine($"\nСтуденты с возрастом от {ndiap} до {kdiap} лет:");
                        foreach (Student stud in stude)
                        {
                            stud.Info();
                        }
                        Write("_________________");
                        WriteLine();
                        break;
                    case '5':
                        return;
                    default:
                        WriteLine("Вы ввели неверную цифру цифру"); flag1 = false;
                        break;
                }
                
            }

        }
        static void Enrollees()
        {
            bool flag1 = true;
            while (flag1)
            {
                Write("Список абитуриентов: \n");
                foreach (var elem in enrollees)
                {
                    elem.Info();
                }
                WriteLine();
                Write("Какое действие вы хотите сделать: \n Добавить абитуриента - 1 \n Изменить абитуриента - 2 \n Удалить абитуриента - 3 \n Поиск по возрасту - 4 \n Вернуться в меню  - 5 \n ");
                WriteLine();
                switch (ReadKey(true).KeyChar)
                {
                    case '1':
                        Enrollee enrollee = new Enrollee();
                        enrollees.Add(Enrollee.Input());
                        Write("__________________\n");
                        break;
                    case '2':
                        WriteLine();
                        Write("Выберите элемент из списка: ");
                        int n = Convert.ToInt32(ReadLine());
                        Enrollee enrollee1 = new Enrollee();
                        enrollees[n - 1] = Enrollee.Input();
                        break;
                    case '3':
                        Write("Введите индекс удаляемого объекта: ");
                        int index = Convert.ToInt32(ReadLine());
                        enrollees.RemoveAt(index - 1);
                        break;
                    case '4':
                        Write("Введите начало диапозона лет: ");
                        int ndiap = Convert.ToInt32(ReadLine());
                        Write("Введите конец диапозона лет: ");
                        int kdiap = Convert.ToInt32(ReadLine());
                        List<Enrollee> enrol = new List<Enrollee>();
                        foreach (Enrollee enr in enrollees)
                        {
                            if (enr.Age() >= ndiap && enr.Age() <= kdiap)
                            {
                                enrol.Add(enr);
                            }
                        }

                        WriteLine($"\nАбитуриенты с возрастом от {ndiap} до {kdiap} лет:");
                        foreach (Enrollee stud in enrol)
                        {
                            stud.Info();
                        }
                        Write("_________________");
                        WriteLine();
                        break;
                    case '5':
                        return;
                    default:
                        WriteLine("Вы ввели неверную цифру цифру"); flag1 = false;
                        break;
                }

            }

        }
    }
}
