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
        Car[] cars_list = new Car[3];

        public FiltrForm()
        {
            InitializeComponent();

            cars_list[0] = new Car("Феррари 599 GTO", "Купе", "мкпп", 1000000);
            cars_list[1] = new Car("Ягуар ХК", "Кабриолет", "акпп", 2000000);
            cars_list[2] = new Car("ВАЗ 2121", "Универсал", "мкпп", 500000);

            int x = 10;
            for(int i=0; i<3; i++)
            {
                cars_list[i].btn.Font = new Font("Microsoft Sans Serif", 12F);
                cars_list[i].btn.Location = new Point(x, 200);
                cars_list[i].btn.Size = new Size(200, 30);
                cars_list[i].btn.Click += new EventHandler(button1_Click);
                Controls.Add(cars_list[i].btn);

                cars_list[i].pb.Location = new Point(x, 230);
                cars_list[i].pb.Size = new Size(200, 200);
                cars_list[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(cars_list[i].pb);

                x += 210;
            }
            

        }

        private void FiltrForm_Load(object sender, EventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<3; i++)
            {
                cars_list[i].btn.Visible = true;
                

                if (nameComboBox.Text != "" &&
                    nameComboBox.Text != cars_list[i].name)
                {
                    cars_list[i].btn.Visible = false;
                    
                }
                if (kuzovComboBox.Text != "" &&
                    kuzovComboBox.Text != cars_list[i].kuzov)
                {
                    cars_list[i].btn.Visible = false;
                   
                }
                if (kppComboBox.Text != "" &&
                    kppComboBox.Text != cars_list[i].kpp)
                {
                    cars_list[i].btn.Visible = false;
                   
                }
                if (priceTextBox.Text != "" &&
                    Convert.ToInt32(priceTextBox.Text) < cars_list[i].price)
                {
                    cars_list[i].btn.Visible = false;
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CarForm car = new CarForm(btn.Text);
            car.Show();
        }
    }
}
