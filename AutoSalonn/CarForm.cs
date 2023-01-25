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
        public CarForm(string carName)
        {
            InitializeComponent();

            Text = carName;
            label1.Text = carName;
            try
            {
                pictureBox1.Load("../../Pictures/" + carName + ".jpg");
                textBox1.Text = File.ReadAllText("../../Pictures/" + carName + ".txt");
            }
            catch (Exception) { } 

        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
