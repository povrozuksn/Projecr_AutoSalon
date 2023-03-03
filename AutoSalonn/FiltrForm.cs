using AutoSalonn.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalonn
{
    public struct Car
    {
        public string name;
        public string kuzov;
        public string kpp;
        public int price;
        public Button btn;
        public PictureBox pb;

        public Car(string _name, string _kuzov, string _kpp, int _price)
        {
            name = _name;
            kuzov = _kuzov;
            kpp = _kpp;
            price = _price;
            btn = new Button();
            btn.Text = name;
            pb = new PictureBox();
            try
            {
                pb.Load("../../Pictures/" + name + ".jpg");             
            }
            catch (Exception) { }
        }
    }

    public partial class FiltrForm : Form
    {
        public static Car[] cars_list = new Car[9];

        public FiltrForm()
        {
            InitializeComponent();

            int x = 10;
            int y = 150;

            for (int i=0; i< cars_list.Length; i++)
            {
                cars_list[i].btn.Font = new Font("Microsoft Sans Serif", 12F);
                cars_list[i].btn.Location = new Point(x, y);
                cars_list[i].btn.Size = new Size(200, 30);
                cars_list[i].btn.Click += new EventHandler(carClick);
                Controls.Add(cars_list[i].btn);

                cars_list[i].pb.Location = new Point(x, y);
                cars_list[i].pb.Size = new Size(200, 200);
                cars_list[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(cars_list[i].pb);

                x += 210;
                if(x > 620)
                {
                    x = 10;
                    y += 210;
                }
            } 
        }

        private void FiltrForm_Load(object sender, EventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 150;
            for (int i=0; i<cars_list.Length; i++)
            {
                cars_list[i].btn.Visible = true;
                cars_list[i].pb.Visible = true;

                if (KuzovCheckedListBox.CheckedItems.Count > 0 &&
                    !KuzovCheckedListBox.CheckedItems.Contains(cars_list[i].kuzov))
                {
                    cars_list[i].btn.Visible = false;
                    cars_list[i].pb.Visible = false;
                }
                if (NameTextBox.Text != "" &&
                    !cars_list[i].name.Contains(NameTextBox.Text))
                {
                    cars_list[i].btn.Visible = false;
                    cars_list[i].pb.Visible = false;
                }
                if (kppComboBox.Text != "" &&
                    kppComboBox.Text != cars_list[i].kpp)
                {
                    cars_list[i].btn.Visible = false;
                    cars_list[i].pb.Visible = false;
                }
                if (priceTextBox.Text != "" &&
                    Convert.ToInt32(priceTextBox.Text) < cars_list[i].price)
                {
                    cars_list[i].btn.Visible = false;
                    cars_list[i].pb.Visible = false;
                }

                if (cars_list[i].btn.Visible)
                {
                    cars_list[i].btn.Location = new Point(x, y);                    
                    cars_list[i].pb.Location = new Point(x, y);

                    x += 210;
                    if (x > 620)
                    {
                        x = 10;
                        y += 210;
                    }
                }                
            }
        }

        public static void carClick(object sender, EventArgs e)
        {
            for (int i = 0; i < cars_list.Length; i++)
            {
                if (((Button)sender).Text == cars_list[i].btn.Text)
                {
                    CarForm car = new CarForm(cars_list[i]);
                    car.ShowDialog();
                }
            }
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindButton_Click(null,null);
            }
        }

        private void priceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindButton_Click(null, null);
            }

        }
    }
}
