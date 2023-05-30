// База данных работиников озон
// author Kondakov N.S

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Data_Base //определение пространства имен Data_Base
{
    // Класс работники озона
    public class WorkersOzon // todo убррать _
    {
        int id_worker;     // Id
        string name;       // Имя
        int age;       // Возраст
        string post;      // Должность
        double salary;     // Зарплата

        // конструктор класса
        public WorkersOzon(int id_worker, string name, int age, string post, double salary)
        {
            this.id_worker = id_worker;
            this.name = name;
            this.age = age;
            this.post = post;
            this.salary = salary;
        }

        public string Name
        {
            get //Вернуть Имя
            {
                return name;
            }

            set //Задать Имя
            {
                name = value;
            }
        }

        public int Id_worker
        {
            get //Вернуть Id
            {
                return id_worker;
            }
            set //Задать Id
            {
                id_worker = value;
            }
        }

        public int Age
        {
            get //Вернуть возраст
            {
                return age;
            }

            set //Задать возраст 
            {
                age = value;
            }
        }

        public string Post
        {
            get //Вернуть должность
            {
                return post;
            }

            set //Задать должность
            {
                post = value;
            }
        }

        public double Salary
        {
            get //Вернуть зарплату
            {
                return salary;
            }

            set //Задать зарплату 
            {
                salary = value;
            }
        }

        // Переопределение метода ToString. Каждый объект в языке С# получает метод ToString, который возращает строковое представление данного объекта.
        // При создании пользовательского класса необходимо переопределить метод, чтобы передать информацию о типе
        public override string ToString() // Преобразовать в строку
        {
            return id_worker + "|" + name + "|" + age + "|" +
                post + "|" + salary;
        }

    }
}
