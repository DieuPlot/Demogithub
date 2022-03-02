using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLoginFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String user = txtUserName.Text;
            String pass = txtPassword.Text;
            if(user == "admin" && pass=="admin")
            {
                MessageBox.Show("Successful");
            }
            else
            {
                MessageBox.Show("Fail");

            }
        }
    }
}
