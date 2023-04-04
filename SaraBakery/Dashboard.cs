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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        double prices = 0; 

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userLabel.Text = SignIn.user;
        }

        private void sum(double _price) 
        {
            prices = _price + prices;
            tp.Text = prices.ToString();
        }

        private void littleTortaChoco_Click(object sender, EventArgs e)
        {
            int price = 35000;
            sum(price);
        }

        private void extraTortaChoco_Click(object sender, EventArgs e)
        {
            int price = 70000;
            sum(price);
        }

        private void littleTortaRojaXD_Click(object sender, EventArgs e)
        {
            int price = 40000;
            sum(price);
        }

        private void extraTortaRojaXD_Click(object sender, EventArgs e)
        {
            int price = 80000;
            sum(price);
        }

        private void littleTortaNaranja_Click(object sender, EventArgs e)
        {
            int price = 30000;
            sum(price);
        }

        private void extraTortaNaranja_Click(object sender, EventArgs e)
        {
            int price = 50000;
            sum(price);
        }
    }
}
