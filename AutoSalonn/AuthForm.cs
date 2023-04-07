using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalonn
{
    public partial class AuthForm : Form
    {
        public static string name = "";
        public static string secname = "";
        public static bool isAdmin = false;

        public AuthForm()
        {
            InitializeComponent();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegForm reg = new RegForm();
            reg.ShowDialog();
        }

        private void InpButton_Click(object sender, EventArgs e)
        {
            string[] strs = File.ReadAllLines("users.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);

                if(LoginTB.Text == parts[2] && PasTB.Text == parts[3])
                {
                    name = parts[0];
                    secname = parts[1];
                    isAdmin = (parts[4] == "1");
                    Close(); 
                    return;
                }
            }
            MessageBox.Show("Введен неверный логин/пароль");
        }
    }
}
