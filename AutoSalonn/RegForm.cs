using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalonn
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pas1TB.Text == Pas2TB.Text)
            {
                File.AppendAllText("users.txt",
                                NameTB.Text + ", " +
                                SecNameTB.Text + ", " +
                                LoginTB.Text + ", " +
                                Pas1TB.Text +
                                Environment.NewLine);
            }
            else MessageBox.Show("Пароли не совпадают");
            
        }
    }
}
