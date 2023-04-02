using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaraBakery
{
    public partial class SignInA : Form
    {
        public static string user = "";
        public static string password = "";
        public SignInA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = txtUser.Text;
            var dashboard = new Dashboard();
            dashboard.Show();
            Hide();
        }
    }
}
