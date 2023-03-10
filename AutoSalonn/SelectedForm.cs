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
    public partial class SelectedForm : Form
    {
        public static Dictionary<Car, int> MyCars = new Dictionary<Car, int>();

        public SelectedForm()
        {
            InitializeComponent();

            int x = 10;
            int y = 10;

            foreach (KeyValuePair <Car, int> myCar in MyCars)
            {
                Car car = myCar.Key;

                #region 1 столбец
                PictureBox pb = new PictureBox();
                pb.Image = car.pb.Image;
                pb.Location = new Point(x, y);
                pb.Size = new Size(200, 200);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(pb);
                #endregion

                #region 2 столбец
                Label lbl_name = new Label();
                lbl_name.Text = "Модель: " + car.name;
                lbl_name.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_name.Location = new Point(x+220, y);
                lbl_name.Size = new Size(200, 30);
                Controls.Add(lbl_name);

                Label lbl_kuzov = new Label();
                lbl_kuzov.Text = "Тип кузова: " + car.kuzov;
                lbl_kuzov.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_kuzov.Location = new Point(x + 220, y + 50);
                lbl_kuzov.Size = new Size(200, 30);
                Controls.Add(lbl_kuzov);

                Label lbl_kpp = new Label();
                lbl_kpp.Text = "Трансмиссия: " + car.kpp;
                lbl_kpp.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_kpp.Location = new Point(x + 220, y + 100);
                lbl_kpp.Size = new Size(200, 30);
                Controls.Add(lbl_kpp);
                #endregion

                #region 3 столбец
                Label lbl_price = new Label();
                lbl_price.Text = "Цена, руб.: " + car.price.ToString();
                lbl_price.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_price.Location = new Point(x + 440, y);
                lbl_price.Size = new Size(200, 30);
                Controls.Add(lbl_price);

                Label lbl_value = new Label();
                lbl_value.Text = "Кол-во, шт.: " + myCar.Value.ToString();
                lbl_value.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_value.Location = new Point(x + 440, y+50);
                lbl_value.Size = new Size(200, 30);
                Controls.Add(lbl_value);

                Button btn = new Button();
                btn.Text = car.btn.Text;
                btn.Font = new Font("Microsoft Sans Serif", 12F);
                btn.Location = new Point(x + 440, y + 100);
                btn.Size = new Size(200, 30);
                btn.Click += new EventHandler(FiltrForm.carClick);
                Controls.Add(btn);
                #endregion

                y += 210;
               
            }

        }

        private void SelectedForm_Load(object sender, EventArgs e)
        {

        }
    }
}
