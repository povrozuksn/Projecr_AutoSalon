using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AutoSalonn
{
    public partial class AddCarForm : Form
    {
        public AddCarForm()
        {
            InitializeComponent();
            Text = "Добавление машины";
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int a;
            if(!Int32.TryParse(PriceTB.Text, out a))
            {
                MessageBox.Show("Цена не число");
                return;
            }

            if(NameTB.Text == "" || KuzovCB.Text == "" || KppCB.Text == "" || PriceTB.Text == "")
            {
                MessageBox.Show("Поля с * обязательны к заполнению");
                return;
            }

            File.AppendAllText("cars.txt", 
                Environment.NewLine + 
                NameTB.Text + ", " + 
                KuzovCB.Text + ", " + 
                KppCB.Text + ", " +
                PriceTB.Text);

            if(FileNme != "")
            {
                File.Copy(FileNme, "../../Pictures/" + NameTB.Text + ".jpg");
            }

            MessageBox.Show("Сохранено");

            Close();
        }

        string FileNme = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileNme = openFileDialog1.FileName;
                pictureBox1.Load(FileNme);
            }
        }
    }
}
