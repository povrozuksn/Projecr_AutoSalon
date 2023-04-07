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
    }
}
