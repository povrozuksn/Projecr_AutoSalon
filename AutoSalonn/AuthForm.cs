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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.ShowDialog();
        }
    }
}
