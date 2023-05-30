// База данных работиников озон
// author Kondakov N.S

// todo иконка
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Data_Base //определение пространства имен Data_Base
{
    public class DataWork //классс для работы с базой
    {
        // коллекция workers объектов типа WorkersOzon
        public ObservableCollection<WorkersOzon> workers;


        // конструктор класса 
        public DataWork()
        {
            workers = new ObservableCollection<WorkersOzon>();
        }

        // добавления нового работника в коллекцию workers
        public void AddNewWorker(int id_worker, string name, int age, string post, double salary)
        {
            // создание нового объекта типа WorkersOzon
            WorkersOzon new_worker = new WorkersOzon(id_worker, name, age, post, salary);

            // добавление нового работника в коллекцию
            workers.Add(new_worker);
        }


        // сохранить базу данных в файл
        public void SaveDB(string name)
        {
            // использование StreamWriter для записи данных в файл с заданным именем
            using (StreamWriter sw = new StreamWriter(name, false, System.Text.Encoding.Unicode))
            {
                foreach (WorkersOzon s in workers)
                {
                    sw.WriteLine(s.ToString());
                }
            }
        }

        // открыть базу данных из файла
        public void OpenFile(string name_file)
        {
            // проверка, существует ли файл
            if (!System.IO.File.Exists(name_file))
                throw new Exception("Файл не существует");

            // проверка, если в коллекции workers уже есть данные, удаляем их
            if (workers.Count != 0)
                DeleteDB();

            // использование StreamReader для чтения данных из файла
            using (StreamReader sw = new StreamReader(name_file))
            {
                while (!sw.EndOfStream)
                {
                    string str = sw.ReadLine();

                    // разделение строки на отдельные символы используя разделитель "|"
                    String[] dataFromFile = str.Split(new String[] { "|" },
                        StringSplitOptions.RemoveEmptyEntries);

                    // извлечение значений из строки и создание нового работника
                    int id_worker = Convert.ToInt32(dataFromFile[0]);
                    string name = dataFromFile[1];
                    int age = Convert.ToInt32(dataFromFile[2]);
                    string post = dataFromFile[3];
                    double salary = Convert.ToDouble(dataFromFile[4]);
                    AddNewWorker(id_worker, name, age, post, salary);
                }
            }
        }

        // удалить базу данных
        public void DeleteDB()
        {
            workers.Clear();
        }
    }
}
