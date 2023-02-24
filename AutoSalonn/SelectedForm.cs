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
        public static List<Car> my_car = new List<Car>();

        public SelectedForm()
        {
            InitializeComponent();

            int x = 10;
            int y = 150;

            foreach (Car car in my_car)
            {
                Button btn = new Button();
                btn.Text = car.btn.Text;
                btn.Font = new Font("Microsoft Sans Serif", 12F);
                btn.Location = new Point(x, y);
                btn.Size = new Size(200, 30);
                Controls.Add(btn);

                PictureBox pb = new PictureBox();
                pb.Image = car.pb.Image;
                pb.Location = new Point(x, y);
                pb.Size = new Size(200, 200);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(pb);

                Label lbl = new Label();
                lbl.Text = car.price.ToString();
                lbl.Font = new Font("Microsoft Sans Serif", 12F);
                lbl.Location = new Point(x, y+200);
                lbl.Size = new Size(200, 30);
                Controls.Add(lbl);


                x += 210;
                if (x > 620)
                {
                    x = 10;
                    y += 210;
                }
            }

        }

        private void SelectedForm_Load(object sender, EventArgs e)
        {

        }
    }
}
