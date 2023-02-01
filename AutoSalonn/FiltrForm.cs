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

        public Car(string _name, string _kuzov, string _kpp, int _price, Button _btn)
        {
            name = _name;
            kuzov = _kuzov;
            kpp = _kpp;
            price = _price;
            btn = _btn;
        }
    }

    public partial class FiltrForm : Form
    {
        Car[] cars_list = new Car[3];

        public FiltrForm()
        {
            InitializeComponent();

            cars_list[0] = new Car("Феррари", "Купе", "мкпп", 1000000, button1);
            cars_list[1] = new Car("Ягуар", "Кабриолет", "акпп", 2000000, button3);
            cars_list[2] = new Car("ВАЗ 2121", "Универсал", "мкпп", 500000, button2);

        }

        private void FiltrForm_Load(object sender, EventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            for(int i=0; i<3; i++)
            {
                if (comboBox1.Text == cars_list[i].kuzov)
                {
                    cars_list[i].btn.Visible = false;
                }
            }
        }
    }
}
