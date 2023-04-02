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
            userLabel.Text = SignInA.user;
        }

        private void ajustPrice(double _unitPrice)
        {
            double unitPrice = _unitPrice;
            Carrito.Items.Add(unitPrice.ToString("N3"));
            prices = unitPrice;
        }

        private void sum(double _price) 
        {
            prices = _price + prices;
            tp.Text = prices.ToString();
        }

        private void littleTortaChoco_Click(object sender, EventArgs e)
        {
            double price = 35.000;
            ajustPrice(price);
            sum(price);
        }

        private void extraTortaChoco_Click(object sender, EventArgs e)
        {
            double price = 70.000;
            ajustPrice(70.000);
            sum(price);
        }

        private void littleTortaRojaXD_Click(object sender, EventArgs e)
        {
            double price = 40.000;
            ajustPrice(40.000);
            sum(price);
        }

        private void extraTortaRojaXD_Click(object sender, EventArgs e)
        {
            double price = 80.000;
            ajustPrice(80.000);
            sum(price);
        }

        private void littleTortaNaranja_Click(object sender, EventArgs e)
        {
            double price = 30.000;
            ajustPrice(30.000);
            sum(price);
        }

        private void extraTortaNaranja_Click(object sender, EventArgs e)
        {
            double price = 50.000;
            ajustPrice(50.000);
            sum(price);
        }
    }
}
