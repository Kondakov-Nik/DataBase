// База данных работиников озон
// author Kondakov N.S

namespace Data_Base
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            dataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name_Worker = new DataGridViewTextBoxColumn();
            Age = new DataGridViewTextBoxColumn();
            Post = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            button_add_worker = new Button();
            button2 = new Button();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            обАвтореToolStripMenuItem = new ToolStripMenuItem();
            textBox_name = new TextBox();
            label_name = new Label();
            textBox_age = new TextBox();
            textBox_post = new TextBox();
            textBox_salary = new TextBox();
            label_age = new Label();
            label_post = new Label();
            label_salary = new Label();
            label_ID = new Label();
            textBox_ID = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            ClearOne_button = new Button();
            textBox_error = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Name_Worker, Age, Post, Salary });
            dataGridView.Location = new Point(13, 191);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(544, 301);
            dataGridView.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Name_Worker
            // 
            Name_Worker.HeaderText = "Имя";
            Name_Worker.Name = "Name_Worker";
            Name_Worker.ReadOnly = true;
            // 
            // Age
            // 
            Age.HeaderText = "Возраст";
            Age.Name = "Age";
            Age.ReadOnly = true;
            // 
            // Post
            // 
            Post.HeaderText = "Должность";
            Post.Name = "Post";
            Post.ReadOnly = true;
            // 
            // Salary
            // 
            Salary.HeaderText = "Зарплата";
            Salary.Name = "Salary";
            Salary.ReadOnly = true;
            // 
            // button_add_worker
            // 
            button_add_worker.BackColor = Color.PaleGoldenrod;
            button_add_worker.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_add_worker.Location = new Point(307, 99);
            button_add_worker.Name = "button_add_worker";
            button_add_worker.Size = new Size(235, 29);
            button_add_worker.TabIndex = 1;
            button_add_worker.Text = "Добавить работника";
            button_add_worker.UseVisualStyleBackColor = false;
            button_add_worker.Click += button_add_worker_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.PaleGoldenrod;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(443, 498);
            button2.Name = "button2";
            button2.Size = new Size(114, 38);
            button2.TabIndex = 2;
            button2.Text = "Очистить базу";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Clear_button_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(568, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, открытьToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(53, 20);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(133, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { обАвтореToolStripMenuItem });
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // обАвтореToolStripMenuItem
            // 
            обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            обАвтореToolStripMenuItem.Size = new Size(130, 22);
            обАвтореToolStripMenuItem.Text = "Об авторе";
            обАвтореToolStripMenuItem.Click += AuthorToolStripMenuItem_Click;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(102, 69);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(120, 23);
            textBox_name.TabIndex = 4;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_name.Location = new Point(32, 72);
            label_name.Name = "label_name";
            label_name.Size = new Size(40, 20);
            label_name.TabIndex = 5;
            label_name.Text = "Имя";
            // 
            // textBox_age
            // 
            textBox_age.Location = new Point(102, 105);
            textBox_age.Name = "textBox_age";
            textBox_age.Size = new Size(120, 23);
            textBox_age.TabIndex = 6;
            // 
            // textBox_post
            // 
            textBox_post.Location = new Point(422, 33);
            textBox_post.Name = "textBox_post";
            textBox_post.Size = new Size(120, 23);
            textBox_post.TabIndex = 7;
            // 
            // textBox_salary
            // 
            textBox_salary.Location = new Point(422, 65);
            textBox_salary.Name = "textBox_salary";
            textBox_salary.Size = new Size(120, 23);
            textBox_salary.TabIndex = 8;
            // 
            // label_age
            // 
            label_age.AutoSize = true;
            label_age.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_age.Location = new Point(32, 108);
            label_age.Name = "label_age";
            label_age.Size = new Size(64, 20);
            label_age.TabIndex = 9;
            label_age.Text = "Возраст";
            // 
            // label_post
            // 
            label_post.AutoSize = true;
            label_post.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_post.Location = new Point(307, 34);
            label_post.Name = "label_post";
            label_post.Size = new Size(88, 20);
            label_post.TabIndex = 10;
            label_post.Text = "Должность";
            // 
            // label_salary
            // 
            label_salary.AutoSize = true;
            label_salary.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_salary.Location = new Point(307, 68);
            label_salary.Name = "label_salary";
            label_salary.Size = new Size(73, 20);
            label_salary.TabIndex = 11;
            label_salary.Text = "Зарплата";
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_ID.Location = new Point(32, 36);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(24, 20);
            label_ID.TabIndex = 12;
            label_ID.Text = "ID";
            // 
            // textBox_ID
            // 
            textBox_ID.Location = new Point(102, 35);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(120, 23);
            textBox_ID.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // ClearOne_button
            // 
            ClearOne_button.BackColor = Color.PaleGoldenrod;
            ClearOne_button.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ClearOne_button.Location = new Point(14, 498);
            ClearOne_button.Name = "ClearOne_button";
            ClearOne_button.Size = new Size(114, 38);
            ClearOne_button.TabIndex = 14;
            ClearOne_button.Text = "Удалить строку";
            ClearOne_button.UseVisualStyleBackColor = false;
            ClearOne_button.Click += ClearOne_button_Click;
            // 
            // textBox_error
            // 
            textBox_error.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_error.Location = new Point(32, 134);
            textBox_error.Multiline = true;
            textBox_error.Name = "textBox_error";
            textBox_error.ReadOnly = true;
            textBox_error.Size = new Size(510, 43);
            textBox_error.TabIndex = 15;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(568, 543);
            Controls.Add(textBox_error);
            Controls.Add(ClearOne_button);
            Controls.Add(textBox_ID);
            Controls.Add(label_ID);
            Controls.Add(label_salary);
            Controls.Add(label_post);
            Controls.Add(label_age);
            Controls.Add(textBox_salary);
            Controls.Add(textBox_post);
            Controls.Add(textBox_age);
            Controls.Add(label_name);
            Controls.Add(textBox_name);
            Controls.Add(button2);
            Controls.Add(button_add_worker);
            Controls.Add(dataGridView);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "База данных";
            KeyDown += MainWindow_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button button_add_worker;
        private Button button2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem обАвтореToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private TextBox textBox_name;
        private Label label_name;
        private TextBox textBox_age;
        private TextBox textBox_post;
        private TextBox textBox_salary;
        private Label label_age;
        private Label label_post;
        private Label label_salary;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name_Worker;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn Post;
        private DataGridViewTextBoxColumn Salary;
        private Label label_ID;
        private TextBox textBox_ID;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button ClearOne_button;
        private TextBox textBox_error;
    }
}