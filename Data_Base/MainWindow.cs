// База данных работиников озон
// author Kondakov N.S

//привязка коллекции к таблице
using System.Windows.Forms;

namespace Data_Base //определение пространства имен Data_Base
{
    public partial class MainWindow : Form // Определение класса MainWindow, который наследуется от класса Form
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

            // расширение файла при сохранении автоматически тхт
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            // форма будет получать события клавиатуры независимо от того, какой элемент управления имеет фокус
            this.KeyPreview = true; 
 
        }
        // todo проверка
        // проврека введенных данных
        private bool check_input()
        {
            bool Error = false;

            // красный цвет при неверных данных
            Color errorColor = Color.FromArgb(200, 90, 90);


            // проверка ввода id
            if (string.IsNullOrWhiteSpace(textBox_ID.Text)) // пустое поле ввода
            {
                textBox_ID.BackColor = errorColor;
                Error = true;
            }
            // если нельзя преобразовать
            else if (!int.TryParse(textBox_ID.Text, out int ID)) //Ключевое слово out используется здесь для передачи переменной ID по ссылке в метод
                                                                 //int.TryParse, чтобы метод мог изменить ее значение и возвратить результат преобразования.
            {
                textBox_ID.BackColor = errorColor;
                Error = true;
            }
            else
            {
                textBox_ID.BackColor = Color.White;
            }


            // проверка ввода возраста
            if (string.IsNullOrWhiteSpace(textBox_age.Text)) // пустое поле ввода
            {
                textBox_age.BackColor = errorColor;
                Error = true;
            }
            // если нельзя преобразовать
            else if (!int.TryParse(textBox_age.Text, out int age))
            {
                textBox_age.BackColor = errorColor;
                Error = true;
            }

            else if (int.Parse(textBox_age.Text) < 18 || (int.Parse(textBox_age.Text) >= 65))
            {
                textBox_error.Text = "Возраст работника не младше 18 и не старше 65";
                textBox_age.BackColor = errorColor;
                Error = true;
            }
            else
            {
                textBox_age.BackColor = Color.White;
            }


            // проверка ввода имени
            if (string.IsNullOrWhiteSpace(textBox_name.Text)) // пустое поле ввода
            {
                textBox_name.BackColor = errorColor;
                Error = true;
            }
            // если нельзя преобразовать 
            else if (double.TryParse(textBox_name.Text, out _))
            {
                textBox_name.BackColor = errorColor;
                Error = true;
            }
            else
            {
                textBox_name.BackColor = Color.White;
            }

            // проверка ввода должности
            if (string.IsNullOrWhiteSpace(textBox_post.Text)) // пустое поле ввода
            {
                textBox_post.BackColor = errorColor;
                Error = true;
            }
            // если нельзя преобразовать 
            else if (double.TryParse(textBox_post.Text, out _))
            {
                textBox_post.BackColor = errorColor;
                Error = true;
            }
            else
            {
                textBox_post.BackColor = Color.White;
            }

            // проверка ввода зарплаты
            if (string.IsNullOrWhiteSpace(textBox_salary.Text)) // пустое поле ввода
            {
                textBox_salary.BackColor = errorColor;
                Error = true;
            }
            // если нельзя преобразовать
            else if (!double.TryParse(textBox_salary.Text, out double salary))
            {
                textBox_salary.BackColor = errorColor;
                Error = true;
            }
            else
            {
                textBox_salary.BackColor = Color.White;
            }

            // если ошибка - вывод ее в текстбокс
            if (Error)
            {
                textBox_error.Text = "Проверьте правильность введенных данных";
            }

            return !Error;

        }



        // обработчик кнопки добавить работника
        private void button_add_worker_Click(object sender, EventArgs e)
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
               
                // добавление нового работника в колекцию
                wrk.AddNewWorker(id_worker, name, age, post, salary);

                dataGridView.Rows.Add(id_worker, name, age, post, salary);
                textBox_error.Text = "";
            }
        }

        // обработчик кнопки меню сохранить базу
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // проверка, если имя файла не указано
            if (filename == "")
            {
                // отображение диалогового окна сохранения файла
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
                filename = saveFileDialog1.FileName;
                this.Text = filename;
            }
            // сохранение базы данных в указанный файл
            wrk.SaveDB(filename);
        }

        // обработчик кнопки меню открыть базу
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // отображение диалогового окна выбора файла
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return; //переименовать openFileDialog1
            {
                // получение выбранного имени файла
                filename = openFileDialog1.FileName;
                this.Text = filename;
                // очистка таблицы
                dataGridView.Rows.Clear();
                // открытие базы данных из выбранного файла
                wrk.OpenFile(filename);
                // заполнение таблицы данными из файла
                WriteToDataGrid();

            }
        }

        // заполнение таблицы данными из файла
        private void WriteToDataGrid()
        {
            for (int i = 0; i < wrk.workers.Count; i++)
            {
                // Получение информации о работнике из колекции
                WorkersOzon worker = (WorkersOzon)wrk.workers[i];

                // Добавление данных работника в таблицу
                dataGridView.Rows.Add(worker.Id_worker, worker.Name,
                    worker.Age, worker.Post, worker.Salary);
            }
            // последнюю строку запрещаем редактировать
            dataGridView.Rows[wrk.workers.Count].ReadOnly = true;
        }

        // кнопка очистить 
        private void Clear_button_Click(object sender, EventArgs e)
        {
            // очищаем текущий список
            wrk.DeleteDB();
            // очищаем таблицу
            dataGridView.Rows.Clear();
        }

        // кнокпа удалить строку
        private void ClearOne_button_Click(object sender, EventArgs e)
        {
            // получаем индекс выделенной строки
            int ind = dataGridView.SelectedCells[0].RowIndex;

            // удаляем эту строку
            dataGridView.Rows.RemoveAt(ind);
        }

        // меню - об авторе
        private void AuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Кондаков Никита");
        }
        // todo гор. клавиши
        // горячая клавиша на enter
        private void MainWindow_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_add_worker.PerformClick();// имитируем нажатие button1

            }
        }
    }
}