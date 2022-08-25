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
    public partial class FormComprarChucherias : Form
    {
        public FormComprarChucherias()
        {
            InitializeComponent();
        }

        private void FormComprarChucherias_Load(object sender, EventArgs e)
        {
            if (VariablesEntorno.cantidad_Kit_Kat == 1 || VariablesEntorno.cantidad_Chicles_Fresa == 1 || VariablesEntorno.cantidad_Lacasitos == 1 || VariablesEntorno.cantidad_Palotes == 1 || VariablesEntorno.cantidad_Kinder_Bueno == 1 || VariablesEntorno.cantidad_Bolsa_Variada_Haribo == 1 || VariablesEntorno.cantidad_Cheetos == 1 || VariablesEntorno.cantidad_Twix == 1 || VariablesEntorno.cantidad_Pringles == 1 || VariablesEntorno.cantidad_MMs == 1 || VariablesEntorno.cantidad_Papa_Delta == 1 || VariablesEntorno.cantidad_Chicles_Menta == 1 || VariablesEntorno.cantidad_Monster == 1 || VariablesEntorno.cantidad_Crunch == 1 || VariablesEntorno.cantidad_Milkybar == 1 || VariablesEntorno.cantidad_Fritos == 1)
            {
                MessageBox.Show("Las cantidades están bajo mínimos, hay que rellenar existencias!!", "Falta de stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                lblCredito.Text = Double.Parse(tbDinero.Text).ToString();

                tbDinero.Text = "";

            } else
            {
                lblCredito.Text = (Double.Parse(tbDinero.Text) + Double.Parse(lblCredito.Text)).ToString();

                tbDinero.Text = "";
            }
        }

        private void btnKitKat_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {
                    VariablesEntorno.cantidad_Kit_Kat -= 1;
                    VariablesEntorno.cantidadComprada_Kit_Kat += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioKitKat = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Kit_Kat -= 1;
                    VariablesEntorno.cantidadComprada_Kit_Kat += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioKitKat * 100) / 100 + "€\n";
                }
            }
        }

        private void btnChiclesFresa_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {
                    VariablesEntorno.cantidad_Chicles_Fresa -= 1;
                    VariablesEntorno.cantidadComprada_Chicles_Fresa += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioChiclesFresa = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Chicles_Fresa -= 1;
                    VariablesEntorno.cantidadComprada_Chicles_Fresa += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioChiclesFresa * 100) / 100 + "€\n";
                }
            }
        }

        private void btnLacasitos_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {

                    VariablesEntorno.cantidad_Lacasitos -= 1;
                    VariablesEntorno.cantidadComprada_Lacasitos += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioLacasitos = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Lacasitos -= 1;
                    VariablesEntorno.cantidadComprada_Lacasitos += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioLacasitos * 100) / 100 + "€\n";
                }
            }
        }

        private void btnPalotes_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {

                    VariablesEntorno.cantidad_Palotes -= 1;
                    VariablesEntorno.cantidadComprada_Palotes += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioPalotes = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Palotes -= 1;
                    VariablesEntorno.cantidadComprada_Palotes += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioPalotes * 100) / 100 + "€\n";
                }
            }
        }

        private void btnKinderBueno_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {

                    VariablesEntorno.cantidad_Kinder_Bueno -= 1;
                    VariablesEntorno.cantidadComprada_Kinder_Bueno += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioKinderBueno = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Kinder_Bueno -= 1;
                    VariablesEntorno.cantidadComprada_Kinder_Bueno += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioKinderBueno * 100) / 100 + "€\n";
                }
            }
        }

        private void btnBolsaHaribo_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {
                    VariablesEntorno.cantidad_Bolsa_Variada_Haribo -= 1;
                    VariablesEntorno.cantidadComprada_Bolsa_Variada_Haribo += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioBolsaVariadaHaribo = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Bolsa_Variada_Haribo -= 1;
                    VariablesEntorno.cantidadComprada_Bolsa_Variada_Haribo += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioBolsaVariadaHaribo * 100) / 100 + "€\n";
                }
                if (lblCredito.Text.Equals(""))
                {
                    MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCheetos_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {

                    VariablesEntorno.cantidad_Cheetos -= 1;
                    VariablesEntorno.cantidadComprada_Cheetos += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioCheetos = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Cheetos -= 1;
                    VariablesEntorno.cantidadComprada_Cheetos += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioCheetos * 100) / 100 + "€\n";
                }
            }
        }

        private void btnTwix_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {

                    VariablesEntorno.cantidad_Twix -= 1;
                    VariablesEntorno.cantidadComprada_Twix += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioTwix = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Twix -= 1;
                    VariablesEntorno.cantidadComprada_Twix += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioTwix * 100) / 100 + "€\n";
                }
            }
        }

        private void btnPringles_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {

                    VariablesEntorno.cantidad_Pringles -= 1;
                    VariablesEntorno.cantidadComprada_Pringles += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioPringles = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Pringles -= 1;
                    VariablesEntorno.cantidadComprada_Pringles += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioPringles * 100) / 100 + "€\n";
                }
            }
        }

        private void btnMMs_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {

                    VariablesEntorno.cantidad_MMs -= 1;
                    VariablesEntorno.cantidadComprada_MMs += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioMMS = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_MMs -= 1;
                    VariablesEntorno.cantidadComprada_MMs += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioMMS * 100) / 100 + "€\n";
                }
            }
        }

        private void btnPapaDelta_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {

                    VariablesEntorno.cantidad_Papa_Delta -= 1;
                    VariablesEntorno.cantidadComprada_Papa_Delta += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioPapaDelta = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Papa_Delta -= 1;
                    VariablesEntorno.cantidadComprada_Papa_Delta += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioPapaDelta * 100) / 100 + "€\n";
                }
            }
        }

        private void btnChiclesMenta_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {

                    VariablesEntorno.cantidad_Chicles_Menta -= 1;
                    VariablesEntorno.cantidadComprada_Chicles_Menta += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioChiclesMenta = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Chicles_Menta -= 1;
                    VariablesEntorno.cantidadComprada_Chicles_Menta += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioChiclesMenta * 100) / 100 + "€\n";
                }
            }
        }

        private void btnMonster_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {

                    VariablesEntorno.cantidad_Chicles_Fresa -= 1;
                    VariablesEntorno.cantidadComprada_Chicles_Fresa += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioMonster = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Monster -= 1;
                    VariablesEntorno.cantidadComprada_Monster += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioMonster * 100) / 100 + "€\n";
                }
            }
        }

        private void btnCrunch_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {
                    VariablesEntorno.cantidad_Crunch -= 1;
                    VariablesEntorno.cantidadComprada_Crunch += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioCrunch = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Crunch -= 1;
                    VariablesEntorno.cantidadComprada_Crunch += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioCrunch * 100) / 100 + "€\n";
                }
            }
        }

        private void btnMilkybar_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {

                    VariablesEntorno.cantidad_Milkybar -= 1;
                    VariablesEntorno.cantidadComprada_Milkybar += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioMilkybar = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Milkybar -= 1;
                    VariablesEntorno.cantidadComprada_Milkybar += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioMilkybar * 100) / 100 + "€\n";
                }
            }
        }

        private void btnFritos_Click(object sender, EventArgs e)
        {
            if (lblCredito.Text.Equals(""))
            {
                MessageBox.Show("Introduce dinero!!", "Dinero no insertado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                while (Double.Parse(lblCredito.Text) < VariablesEntorno.precioGolosinas[0, 0])
                {
                    MessageBox.Show("\nTe falta dinero!! Introduce más dinero", "Dinero insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (Double.Parse(lblCredito.Text) == VariablesEntorno.precioGolosinas[0, 0])
                {

                    VariablesEntorno.cantidad_Fritos -= 1;
                    VariablesEntorno.cantidadComprada_Fritos += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if ((Double.Parse(lblCredito.Text) > VariablesEntorno.precioGolosinas[0, 0]))
                {

                    double diferenciaPrecioFritos = Double.Parse(lblCredito.Text) - VariablesEntorno.precioGolosinas[0, 0];
                    VariablesEntorno.cantidad_Fritos -= 1;
                    VariablesEntorno.cantidadComprada_Fritos += 1;

                    MessageBox.Show("\nAquí tienes tu producto: " + VariablesEntorno.nombresGolosinas[0, 0], "Producto adquirido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblDineroVuelta.Text = (double)Math.Round(diferenciaPrecioFritos * 100) / 100 + "€\n";
                }
            }
        }
    }
}
