using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalonn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Draw();
        }

        private void Draw()
        {
            FiltrButton.Location = new Point(this.Size.Width/2 - FiltrButton.Size.Width/2, FiltrButton.Location.Y);
            SelectedButton.Location = new Point(FiltrButton.Location.X, SelectedButton.Location.Y);
            HelpButton.Location = new Point(FiltrButton.Location.X + FiltrButton.Size.Width - HelpButton.Size.Width, HelpButton.Location.Y);
            button1.Location = new Point(this.Size.Width / 2 - button1.Size.Width / 2, button1.Location.Y);
            pictureBox1.Location = new Point(FiltrButton.Location.X - (pictureBox1.Size.Width + 50), pictureBox1.Location.Y);
            pictureBox6.Location = new Point(FiltrButton.Location.X - (pictureBox6.Size.Width + 50), pictureBox6.Location.Y);
            pictureBox2.Location = new Point(FiltrButton.Location.X + FiltrButton.Size.Width + 50, pictureBox2.Location.Y);
            pictureBox3.Location = new Point(FiltrButton.Location.X + FiltrButton.Size.Width + 50, pictureBox3.Location.Y);
            pictureBox5.Location = new Point(FiltrButton.Location.X + 60, pictureBox5.Location.Y);
            pictureBox4.Location = new Point(FiltrButton.Location.X + 60, pictureBox4.Location.Y);
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }

        private void FiltrButton_Click(object sender, EventArgs e)
        {
            FiltrForm filtr = new FiltrForm();
            filtr.ShowDialog();
        }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            SelectedForm select = new SelectedForm();
            select.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FiltrForm.cars_list.Clear();
            string[] strs = File.ReadAllLines("cars.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] {", "}, StringSplitOptions.None);
                Car car = new Car(parts[0], parts[1], parts[2], Convert.ToInt32(parts[3]));
                FiltrForm.cars_list.Add(car);
            }            
        }

        private void добавитьМашинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AuthForm.isAdmin)
            {
                AddCarForm addCar = new AddCarForm();
                addCar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Изменения может производить только админитсратор");
            }

            MainForm_Load(null, null);
        }

        private void удалитьМашинуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AuthForm.isAdmin)
            {
                DelCarForm delCar = new DelCarForm();
                delCar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Изменения может производить только админитсратор");
            }

            MainForm_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AuthForm.name == "")
            {                
                AuthForm auth = new AuthForm();
                auth.ShowDialog();
            }
            else
            {
                AuthForm.name = "";
            }

            if (AuthForm.name == "")
            {
                UserLabel.Text = "" ;
                button1.Text = "Войти";
            }
            else
            {
                UserLabel.Text = "Вы авторизовались как  " + AuthForm.name + " " + AuthForm.secname;
                button1.Text = "Выйти";
            }
        }

        private void FeedBackButton_Click(object sender, EventArgs e)
        {
            FeedBackForm feedBack = new FeedBackForm();
            feedBack.ShowDialog();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
