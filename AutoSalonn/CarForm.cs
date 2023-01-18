using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AutoSalonn
{
    public partial class CarForm : Form
    {
        public CarForm(string carName)
        {
            InitializeComponent();

            Text = carName;
            label1.Text = carName;

            if (carName == "Феррари")
            {
                pictureBox1.Load("../../Pictures/ferrari.jpg");
                textBox1.Text = "Модель - Ferrari 348 1989 3.4 5MT 2dr Coupe" +
                                System.Environment.NewLine +
                                "Тип кузова - Coupe" +
                                System.Environment.NewLine +
                                "Объём двигателя - 3405 см3" +
                                System.Environment.NewLine +
                                "Привод - задний" +
                                System.Environment.NewLine +
                                "Макс. скорость - 275 км./ч.";
            }

            if (carName == "Ягуар")
            {
                pictureBox1.Load("../../Pictures/yaguar.jpg");
                textBox1.Text = "Модель - F-Type 2012 3.0 380hp AT AWD 2dr Cabriolet" +
                                System.Environment.NewLine +
                                "Тип кузова - Cabriolet" +
                                System.Environment.NewLine +
                                "Объём двигателя - 2995 см3" +
                                System.Environment.NewLine +
                                "Привод - полный" +
                                System.Environment.NewLine +
                                "Макс. скорость - 275 км./ч.";
            }

            if (carName == "ВАЗ 2121")
            {
                pictureBox1.Load("../../Pictures/VAZ2121.jpg");
                textBox1.Text = "Модель - Лада 4x4 2121 Нива" +
                                System.Environment.NewLine +
                                "Тип кузова - Универсал" +
                                System.Environment.NewLine +
                                "Объём двигателя - 1569 см3" +
                                System.Environment.NewLine +
                                "Привод - полный" +
                                System.Environment.NewLine +
                                "Макс. скорость - 142 км./ч.";
            }

        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
