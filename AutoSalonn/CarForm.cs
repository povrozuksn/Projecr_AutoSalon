using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AutoSalonn
{
    public partial class CarForm : Form
    {
        Car car;
        public CarForm(Car _car)
        {
            car = _car;
            InitializeComponent();

            Text = car.name;
            label1.Text = car.name;
            PriceLabel.Text = car.price.ToString();
            try
            {
                pictureBox1.Load("../../Pictures/" + car.name + ".jpg");
                textBox1.Text = File.ReadAllText("../../Pictures/" + car.name + ".txt");
            }
            catch (Exception) { } 

        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SelectedForm.my_car.Add(car);
        }
    }
}
