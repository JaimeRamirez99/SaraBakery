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
        bool isSelected = false;
        string correctArriveDate = string.Empty;
        int priceValue = 0;
        double prices = 0;
        List<string> direcciones = new List<string>() { "Envigado", "Medellin", "Cali", "Bogota" };
        List<string> informacion = new List<string>();

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            userLabel.Text = SignIn.user;
        }

        private void sum(double _price, string name) 
        {
            prices = _price + prices;
            tp.Text = prices.ToString();
            var priceAndName = $" {_price}----{name}";
            Carrito.Items.Add(priceAndName);
            informacion.Add(priceAndName);
        }

        private void littleTortaChoco_Click(object sender, EventArgs e)
        {
            int price = 35000;
            sum(price, "Torta Chocolate pequeña");
        }

        private void extraTortaChoco_Click(object sender, EventArgs e)
        {
            int price = 70000;
            sum(price, "Torta Chocolate grande");
        }

        private void littleTortaRojaXD_Click(object sender, EventArgs e)
        {
            int price = 40000;
            sum(price, "Tortar roja pequeña");
        }

        private void extraTortaRojaXD_Click(object sender, EventArgs e)
        {
            int price = 80000;
            sum(price, "Torta roja grande");
        }

        private void littleTortaNaranja_Click(object sender, EventArgs e)
        {
            int price = 30000;
            sum(price, "Torta de naranja pequeña");
        }

        private void extraTortaNaranja_Click(object sender, EventArgs e)
        {
            int price = 50000;
            sum(price, "Torta de naranja grande");
        }

        private void Carrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            btnEnvio.MouseClick += (x, y) => 
            { 
                Carrito.Visible = false; 
                ubicaciones.Visible = true; 
                btnEnvio.Visible = false;
            };
            if(ubicaciones.Visible == false)
            {
                foreach (var item in direcciones)
                {
                    ubicaciones.Items.Add(item);
                }
            }         
        }

        private void ubicaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

            ubicaciones.Visible = false;
            isSelected = true;
            switch (ubicaciones.SelectedItem)
            {
               case "Envigado":
                   priceValue = 10000; 
                   break;
               case "Medellin":
                   priceValue = 15000;
                   break;
               case "Cali":
                   priceValue = 13000;
                   break;
               case "Bogota":
                   priceValue = 12000;
                   break;
            };

            if(isSelected) 
            {
                confirmarCoti.Visible = true;
                totalEnvio.Visible = true;
                priceTotalEnvio.Visible = true;
                priceTotalEnvio.Text = priceValue.ToString();
            }
        }

        private void confirmarCoti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(confirmarCoti.SelectedItem.Equals("Aceptar"))
            {
                fecha.Visible = true;
                hora.Visible = true;
                label8.Visible= true;
                label9.Visible= true;
                finalizar.Visible = true;   
                confirmarCoti.Visible = false;               
            }
            if(confirmarCoti.SelectedItem.Equals("Cancelar"))
            {
                //TODO: Cerrar aplicacion
            }
        }

        private void finalizar_Click(object sender, EventArgs e)
        {
            fecha.Visible = false;
            hora.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            string facturaCompleta = string.Empty;
            correctArriveDate = fecha.Text + hora.Text;
            foreach (var item in informacion)
            {
                facturaCompleta += $"{item}\n";
            }
            MessageBox.Show($"{facturaCompleta}\n{Int32.Parse(priceTotalEnvio.Text) + "---Total Envio"}\n{Int32.Parse(priceTotalEnvio.Text) + prices + "Precio Total Final"}\n{correctArriveDate}");

        }
    }
}
