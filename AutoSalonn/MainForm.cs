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

        private void CarClick(object sender, EventArgs e)
        {
            FiltrForm.carClick(sender, e);
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
            FiltrForm.cars_list[0] = new Car("ВАЗ Гранта", "Седан", "мкпп", 500000);
            FiltrForm.cars_list[1] = new Car("ВАЗ Ларгус", "Универсал", "мкпп", 500000);
            FiltrForm.cars_list[2] = new Car("ВАЗ 2121", "Универсал", "мкпп", 500000);
            FiltrForm.cars_list[3] = new Car("Феррари 599 GTO", "Купе", "мкпп", 1000000);
            FiltrForm.cars_list[4] = new Car("Феррари Портофино", "Купе", "акпп", 1000000);
            FiltrForm.cars_list[5] = new Car("Ягуар ХК", "Купе", "мкпп", 2000000);
            FiltrForm.cars_list[6] = new Car("Мерседес SL63", "Кабриолет", "акпп", 3000000);
            FiltrForm.cars_list[7] = new Car("Мерседес GLA", "Универсал", "акпп", 3000000);
            FiltrForm.cars_list[8] = new Car("Мерседес 190", "Седан", "мкпп", 500000);

        }
    }
}
