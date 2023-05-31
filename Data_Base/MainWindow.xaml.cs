// База данных работиников озон
// author Kondakov N.S

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Data_Base //определение пространства имен Data_Base
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window // Определение класса MainWindow, который наследуется от класса Window
                                             // и принадлежит пространству имен Data_Base
    {
        //поля класса:

        // имя файла 
        private string filename = "";

        // cсылка на объект класса DataWork
        private DataWork wrk = new DataWork();

        // конструктор класса MainWindow
        public MainWindow()
        {
            // инициализация компонентов 
            InitializeComponent();
            
            // данные для таблицы
            DataGrid.ItemsSource = wrk.workers;
        }

        // проверка введенных данных
        private bool check_input()
        {
            bool Error = false;
            // cоздание нового экземпляра класса SolidColorBrush для цвета
            SolidColorBrush errorColor = new SolidColorBrush();
            SolidColorBrush DefaultColor = new SolidColorBrush();

            // красный цвет при неверных данных
            errorColor.Color = Color.FromRgb(255, 165, 165);

            // белый цвет если все верно
            DefaultColor.Color = Colors.White;

            // проверка ввода id
            if (string.IsNullOrWhiteSpace(textBox_ID.Text)) // пустое поле ввода
            {
                textBox_ID.Background = errorColor;
                Error = true;
            }
            // если нельзя преобразовать
            else if (!int.TryParse(textBox_ID.Text, out int ID)) //Ключевое слово out используется здесь для передачи переменной ID по ссылке в метод
                                                                 //int.TryParse, чтобы метод мог изменить ее значение и возвратить результат преобразования.
            {
                textBox_ID.Background = errorColor;
                Error = true;
            }
            else
            {
                textBox_ID.Background = DefaultColor;
            }


            // проверка ввода возраста
            if (string.IsNullOrWhiteSpace(textBox_age.Text)) // пустое поле ввода
            {
                textBox_age.Background = errorColor;
                Error = true;
            }
            // если нельзя преобразовать
            else if (!int.TryParse(textBox_age.Text, out int age))
            {
                textBox_age.Background = errorColor;
                Error = true;
            }

            else if (int.Parse(textBox_age.Text) < 18 || (int.Parse(textBox_age.Text) >= 65))
            {

                textBox_age.Background = errorColor;
                Error = true;
            }
            else
            {
                textBox_age.Background = DefaultColor;
            }


            // проверка ввода имени
            if (string.IsNullOrWhiteSpace(textBox_name.Text)) // пустое поле ввода
            {
                textBox_name.Background = errorColor;
                Error = true;
            }
            // если нельзя преобразовать 
            else if (double.TryParse(textBox_name.Text, out _))
            {
                textBox_name.Background = errorColor;
                Error = true;
            }
            else
            {
                textBox_name.Background = DefaultColor;
            }

            // проверка ввода должности
            if (string.IsNullOrWhiteSpace(textBox_post.Text)) // пустое поле ввода
            {
                textBox_post.Background = errorColor;
                Error = true;
            }
            // если нельзя преобразовать 
            else if (double.TryParse(textBox_post.Text, out _))
            {
                textBox_post.Background = errorColor;
                Error = true;
            }
            else
            {
                textBox_post.Background = DefaultColor;
            }

            // проверка ввода зарплаты
            if (string.IsNullOrWhiteSpace(textBox_salary.Text)) // пустое поле ввода
            {
                textBox_salary.Background = errorColor;
                Error = true;
            }
            // если нельзя преобразовать
            else if (!double.TryParse(textBox_salary.Text, out double salary))
            {
                textBox_salary.Background = errorColor;
                Error = true;
            }
            else
            {
                textBox_salary.Background = DefaultColor;
            }

            // если ошибка - вывод ее в текстбокс
            if (Error)
            {
                textBox_error.Text = "Проверьте правильность введенных данных";
            }

            return !Error;
        }

        // обработчик события нажатия на кнопку добавить работника
        private void button_add_worker_Click(object sender, RoutedEventArgs e)
        {
            if (check_input())
            {

                // получение данных о работнике из текстовых полей формы
                int id_worker = Convert.ToInt32(textBox_ID.Text);
                string name = textBox_name.Text;
                int age = Convert.ToInt32(textBox_age.Text);
                string post = textBox_post.Text;
                double salary = Convert.ToDouble(textBox_salary.Text);

                // очистка текстовых полей формы
                textBox_ID.Text = "";
                textBox_name.Text = "";
                textBox_age.Text = "";
                textBox_post.Text = "";
                textBox_salary.Text = "";

                // добавление нового работника в коллекцию
                wrk.AddNewWorker(id_worker, name, age, post, salary);
                textBox_error.Text = "Работник успешно добавлен";
            }
        }

        // обработчик события нажатия на кнопку меню открыть
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // отображение диалогового окна выбора файла
            if (openFileDialog.ShowDialog() == true)
            {
                // получение выбранного имени файла
                filename = openFileDialog.FileName;

                // открытие базы данных из выбранного файла
                wrk.OpenFile(filename);
            }
        }

        // обработчик события нажатия на кнопку меню сохранить
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            // проверка, если имя файла не указано
            if (filename == "")
            {
                // отображение диалогового окна сохранения файла
                if (saveFileDialog.ShowDialog() == DialogResult) return;
                filename = saveFileDialog.FileName;

            }
            // сохранение базы данных в указанный файл
            wrk.SaveDB(filename);
        }

        // обработчик события нажатия на кнопку очистить строку
        private void ClearOne_button_Click(object sender, RoutedEventArgs e)
        {
            {
                int ind = DataGrid.SelectedIndex;
                wrk.workers.RemoveAt(ind);
            }
        }

        // обработчик события нажатия на кнопку очистить базу
        private void ClearAll_button_Click(object sender, RoutedEventArgs e)
        {
            wrk.workers.Clear();
        }

        // обработчик события нажатия на кнопку меню об авторе
        private void Author_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Автор: Кондаков Никита");
        }

    }
}
