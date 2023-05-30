// ���� ������ ����������� ����
// author Kondakov N.S

//�������� ��������� � �������
using System.Windows.Forms;

namespace Data_Base //����������� ������������ ���� Data_Base
{
    public partial class MainWindow : Form // ����������� ������ MainWindow, ������� ����������� �� ������ Form
                                           // � ����������� ������������ ���� Data_Base
    {
        //���� ������:

        // ��� ����� 
        private string filename = "";

        // c����� �� ������ ������ DataWork
        private DataWork wrk = new DataWork();

        // ����������� ������ MainWindow
        public MainWindow()
        {
            // ������������� ����������� 
            InitializeComponent();

            // ���������� ����� ��� ���������� ������������� ���
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            // ����� ����� �������� ������� ���������� ���������� �� ����, ����� ������� ���������� ����� �����
            this.KeyPreview = true; 
 
        }
        // todo ��������
        // �������� ��������� ������
        private bool check_input()
        {
            bool Error = false;

            // ������� ���� ��� �������� ������
            Color errorColor = Color.FromArgb(200, 90, 90);


            // �������� ����� id
            if (string.IsNullOrWhiteSpace(textBox_ID.Text)) // ������ ���� �����
            {
                textBox_ID.BackColor = errorColor;
                Error = true;
            }
            // ���� ������ �������������
            else if (!int.TryParse(textBox_ID.Text, out int ID)) //�������� ����� out ������������ ����� ��� �������� ���������� ID �� ������ � �����
                                                                 //int.TryParse, ����� ����� ��� �������� �� �������� � ���������� ��������� ��������������.
            {
                textBox_ID.BackColor = errorColor;
                Error = true;
            }
            else
            {
                textBox_ID.BackColor = Color.White;
            }


            // �������� ����� ��������
            if (string.IsNullOrWhiteSpace(textBox_age.Text)) // ������ ���� �����
            {
                textBox_age.BackColor = errorColor;
                Error = true;
            }
            // ���� ������ �������������
            else if (!int.TryParse(textBox_age.Text, out int age))
            {
                textBox_age.BackColor = errorColor;
                Error = true;
            }

            else if (int.Parse(textBox_age.Text) < 18 || (int.Parse(textBox_age.Text) >= 65))
            {
                textBox_error.Text = "������� ��������� �� ������ 18 � �� ������ 65";
                textBox_age.BackColor = errorColor;
                Error = true;
            }
            else
            {
                textBox_age.BackColor = Color.White;
            }


            // �������� ����� �����
            if (string.IsNullOrWhiteSpace(textBox_name.Text)) // ������ ���� �����
            {
                textBox_name.BackColor = errorColor;
                Error = true;
            }
            // ���� ������ ������������� 
            else if (double.TryParse(textBox_name.Text, out _))
            {
                textBox_name.BackColor = errorColor;
                Error = true;
            }
            else
            {
                textBox_name.BackColor = Color.White;
            }

            // �������� ����� ���������
            if (string.IsNullOrWhiteSpace(textBox_post.Text)) // ������ ���� �����
            {
                textBox_post.BackColor = errorColor;
                Error = true;
            }
            // ���� ������ ������������� 
            else if (double.TryParse(textBox_post.Text, out _))
            {
                textBox_post.BackColor = errorColor;
                Error = true;
            }
            else
            {
                textBox_post.BackColor = Color.White;
            }

            // �������� ����� ��������
            if (string.IsNullOrWhiteSpace(textBox_salary.Text)) // ������ ���� �����
            {
                textBox_salary.BackColor = errorColor;
                Error = true;
            }
            // ���� ������ �������������
            else if (!double.TryParse(textBox_salary.Text, out double salary))
            {
                textBox_salary.BackColor = errorColor;
                Error = true;
            }
            else
            {
                textBox_salary.BackColor = Color.White;
            }

            // ���� ������ - ����� �� � ���������
            if (Error)
            {
                textBox_error.Text = "��������� ������������ ��������� ������";
            }

            return !Error;

        }



        // ���������� ������ �������� ���������
        private void button_add_worker_Click(object sender, EventArgs e)
        {
            if (check_input())
            {

                // ��������� ������ � ��������� �� ��������� ����� �����
                int id_worker = Convert.ToInt32(textBox_ID.Text);
                string name = textBox_name.Text;
                int age = Convert.ToInt32(textBox_age.Text);
                string post = textBox_post.Text;
                double salary = Convert.ToDouble(textBox_salary.Text);

                // ������� ��������� ����� �����
                textBox_ID.Text = "";
                textBox_name.Text = "";
                textBox_age.Text = "";
                textBox_post.Text = "";
                textBox_salary.Text = "";
               
                // ���������� ������ ��������� � ��������
                wrk.AddNewWorker(id_worker, name, age, post, salary);

                dataGridView.Rows.Add(id_worker, name, age, post, salary);
                textBox_error.Text = "";
            }
        }

        // ���������� ������ ���� ��������� ����
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ��������, ���� ��� ����� �� �������
            if (filename == "")
            {
                // ����������� ����������� ���� ���������� �����
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
                filename = saveFileDialog1.FileName;
                this.Text = filename;
            }
            // ���������� ���� ������ � ��������� ����
            wrk.SaveDB(filename);
        }

        // ���������� ������ ���� ������� ����
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // ����������� ����������� ���� ������ �����
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return; //������������� openFileDialog1
            {
                // ��������� ���������� ����� �����
                filename = openFileDialog1.FileName;
                this.Text = filename;
                // ������� �������
                dataGridView.Rows.Clear();
                // �������� ���� ������ �� ���������� �����
                wrk.OpenFile(filename);
                // ���������� ������� ������� �� �����
                WriteToDataGrid();

            }
        }

        // ���������� ������� ������� �� �����
        private void WriteToDataGrid()
        {
            for (int i = 0; i < wrk.workers.Count; i++)
            {
                // ��������� ���������� � ��������� �� ��������
                WorkersOzon worker = (WorkersOzon)wrk.workers[i];

                // ���������� ������ ��������� � �������
                dataGridView.Rows.Add(worker.Id_worker, worker.Name,
                    worker.Age, worker.Post, worker.Salary);
            }
            // ��������� ������ ��������� �������������
            dataGridView.Rows[wrk.workers.Count].ReadOnly = true;
        }

        // ������ �������� 
        private void Clear_button_Click(object sender, EventArgs e)
        {
            // ������� ������� ������
            wrk.DeleteDB();
            // ������� �������
            dataGridView.Rows.Clear();
        }

        // ������ ������� ������
        private void ClearOne_button_Click(object sender, EventArgs e)
        {
            // �������� ������ ���������� ������
            int ind = dataGridView.SelectedCells[0].RowIndex;

            // ������� ��� ������
            dataGridView.Rows.RemoveAt(ind);
        }

        // ���� - �� ������
        private void AuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�����: �������� ������");
        }
        // todo ���. �������
        // ������� ������� �� enter
        private void MainWindow_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_add_worker.PerformClick();// ��������� ������� button1

            }
        }
    }
}