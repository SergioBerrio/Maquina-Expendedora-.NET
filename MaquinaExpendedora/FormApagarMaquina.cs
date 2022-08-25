using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaExpendedora
{
    public partial class FormApagarMaquina : Form
    {
        public int contador = 10;
        
        public FormApagarMaquina()
        {
            InitializeComponent();
        }

        private void FormApagarMaquina_Load(object sender, EventArgs e)
        {
            timer1.Start();

            lblContador.Text = contador.ToString();

            lblObtencionPorProducto.Text = "Producto [00]: " + VariablesEntorno.nombresGolosinas[0, 0] + " -> " + (VariablesEntorno.precioGolosinas[0, 0] * VariablesEntorno.cantidadComprada_Kit_Kat) + "€\n" 
                + "Producto [01]: " + VariablesEntorno.nombresGolosinas[0, 1] + " -> " + (VariablesEntorno.precioGolosinas[0, 1] * VariablesEntorno.cantidadComprada_Chicles_Fresa) + "€\n"
                + "Producto [02]: " + VariablesEntorno.nombresGolosinas[0, 2] + " -> " + (VariablesEntorno.precioGolosinas[0, 2] * VariablesEntorno.cantidadComprada_Lacasitos) + "€\n"
                + "Producto [03]: " + VariablesEntorno.nombresGolosinas[0, 3] + " -> " + (VariablesEntorno.precioGolosinas[0, 3] * VariablesEntorno.cantidadComprada_Palotes) + "€\n"
                + "Producto [10]: " + VariablesEntorno.nombresGolosinas[1, 0] + " -> " + (VariablesEntorno.precioGolosinas[1, 0] * VariablesEntorno.cantidadComprada_Kinder_Bueno) + "€\n"
                + "Producto [11]: " + VariablesEntorno.nombresGolosinas[1, 1] + " -> " + (VariablesEntorno.precioGolosinas[1, 1] * VariablesEntorno.cantidadComprada_Bolsa_Variada_Haribo) + "€\n"
                + "Producto [12]: " + VariablesEntorno.nombresGolosinas[1, 2] + " -> " + (VariablesEntorno.precioGolosinas[1, 2] * VariablesEntorno.cantidadComprada_Cheetos) + "€\n"
                + "Producto [13]: " + VariablesEntorno.nombresGolosinas[1, 3] + " -> " + (VariablesEntorno.precioGolosinas[1, 3] * VariablesEntorno.cantidadComprada_Twix) + "€\n"
                + "Producto [20]: " + VariablesEntorno.nombresGolosinas[2, 0] + " -> " + (VariablesEntorno.precioGolosinas[2, 0] * VariablesEntorno.cantidadComprada_Pringles) + "€\n"
                + "Producto [21]: " + VariablesEntorno.nombresGolosinas[2, 1] + " -> " + (VariablesEntorno.precioGolosinas[2, 1] * VariablesEntorno.cantidadComprada_MMs) + "€\n"
                + "Producto [22]: " + VariablesEntorno.nombresGolosinas[2, 2] + " -> " + (VariablesEntorno.precioGolosinas[2, 2] * VariablesEntorno.cantidadComprada_Papa_Delta) + "€\n"
                + "Producto [23]: " + VariablesEntorno.nombresGolosinas[2, 3] + " -> " + (VariablesEntorno.precioGolosinas[2, 3] * VariablesEntorno.cantidadComprada_Chicles_Menta) + "€\n"
                + "Producto [30]: " + VariablesEntorno.nombresGolosinas[3, 0] + " -> " + (VariablesEntorno.precioGolosinas[3, 0] * VariablesEntorno.cantidadComprada_Monster) + "€\n"
                + "Producto [31]: " + VariablesEntorno.nombresGolosinas[3, 1] + " -> " + (VariablesEntorno.precioGolosinas[3, 1] * VariablesEntorno.cantidadComprada_Crunch) + "€\n"
                + "Producto [32]: " + VariablesEntorno.nombresGolosinas[3, 2] + " -> " + (VariablesEntorno.precioGolosinas[3, 2] * VariablesEntorno.cantidadComprada_Milkybar) + "€\n"
                + "Producto [33]: " + VariablesEntorno.nombresGolosinas[3, 3] + " -> " + (VariablesEntorno.precioGolosinas[3, 3] * VariablesEntorno.cantidadComprada_Fritos) + "€";

            lblObtencionTotal.Text = (double)Math.Round(((VariablesEntorno.precioGolosinas[0, 0] * VariablesEntorno.cantidadComprada_Kit_Kat) + (VariablesEntorno.precioGolosinas[0, 1] * VariablesEntorno.cantidadComprada_Chicles_Fresa) + (VariablesEntorno.precioGolosinas[0, 2] * VariablesEntorno.cantidadComprada_Lacasitos) + (VariablesEntorno.precioGolosinas[0, 3] * VariablesEntorno.cantidadComprada_Palotes) + (VariablesEntorno.precioGolosinas[1, 0] * VariablesEntorno.cantidadComprada_Kinder_Bueno) + (VariablesEntorno.precioGolosinas[1, 1] * VariablesEntorno.cantidadComprada_Bolsa_Variada_Haribo) + (VariablesEntorno.precioGolosinas[1, 2] * VariablesEntorno.cantidadComprada_Cheetos) + (VariablesEntorno.precioGolosinas[1, 3] * VariablesEntorno.cantidadComprada_Twix) + (VariablesEntorno.precioGolosinas[2, 0] * VariablesEntorno.cantidadComprada_Pringles) + (VariablesEntorno.precioGolosinas[2, 1] * VariablesEntorno.cantidadComprada_MMs) + (VariablesEntorno.precioGolosinas[2, 2] * VariablesEntorno.cantidadComprada_Papa_Delta) + (VariablesEntorno.precioGolosinas[2, 3] * VariablesEntorno.cantidadComprada_Chicles_Menta) + (VariablesEntorno.precioGolosinas[3, 0] * VariablesEntorno.cantidadComprada_Monster) + (VariablesEntorno.precioGolosinas[3, 1] * VariablesEntorno.cantidadComprada_Crunch) + (VariablesEntorno.precioGolosinas[3, 2] * VariablesEntorno.cantidadComprada_Milkybar) + (VariablesEntorno.precioGolosinas[3, 3] * VariablesEntorno.cantidadComprada_Fritos)) * 100) / 100 + "€";    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador--;
            lblContador.Text = contador.ToString();

            if (contador == 0)
            {
                timer1.Stop();

                MessageBox.Show("La máquina se va a apagar!!", "Apagado programado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Application.Exit();
            }
        }
    }
}
