using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MaquinaExpendedora
{
    public partial class FormRellenarMaquina : Form
    {
        string cantidadRellenar;
        int cantidad;

        public FormRellenarMaquina()
        {
            InitializeComponent();
        }

        private void btnKitKat_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }
            
            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Kit_Kat == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Kit_Kat += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Kit_Kat == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Kit_Kat += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Kit_Kat == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Kit_Kat += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Kit_Kat == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Kit_Kat += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Kit_Kat == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChiclesFresa_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Chicles_Fresa == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Chicles_Fresa += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Chicles_Fresa == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Chicles_Fresa += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Chicles_Fresa == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Chicles_Fresa += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Chicles_Fresa == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Chicles_Fresa += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Chicles_Fresa == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLacasitos_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Lacasitos == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Lacasitos += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Lacasitos == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Lacasitos += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Lacasitos == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Lacasitos += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Lacasitos == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Lacasitos += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Lacasitos == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPalotes_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Palotes == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Palotes += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Palotes == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Palotes += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Palotes == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Palotes += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Palotes == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Palotes += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Palotes == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKinderBueno_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Kinder_Bueno == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Kinder_Bueno += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Kinder_Bueno == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Kinder_Bueno += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Kinder_Bueno == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Kinder_Bueno += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Kinder_Bueno == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Kinder_Bueno += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Kinder_Bueno == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBolsaHaribo_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Bolsa_Variada_Haribo == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Bolsa_Variada_Haribo += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Bolsa_Variada_Haribo == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Bolsa_Variada_Haribo += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Bolsa_Variada_Haribo == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Bolsa_Variada_Haribo += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Bolsa_Variada_Haribo == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Bolsa_Variada_Haribo += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Bolsa_Variada_Haribo == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheetos_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Cheetos == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Cheetos += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Cheetos == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Cheetos += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Cheetos == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Cheetos += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Cheetos == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Cheetos += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Cheetos == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTwix_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Twix == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Twix += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Twix == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Twix += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Twix == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Twix += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Twix == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Twix += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Twix == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPringles_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Pringles == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Pringles += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Pringles == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Pringles += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Pringles == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Pringles += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Pringles == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Pringles += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Pringles == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMMs_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_MMs == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_MMs += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_MMs == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_MMs += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_MMs == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_MMs += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_MMs == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_MMs += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_MMs == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPapaDelta_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Papa_Delta == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Papa_Delta += Int32.Parse(cantidadRellenar);
                }

            }
            else if (VariablesEntorno.cantidad_Papa_Delta == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Papa_Delta += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Papa_Delta == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Papa_Delta += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Papa_Delta == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Papa_Delta += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Papa_Delta == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChiclesMenta_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Chicles_Menta == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Chicles_Menta += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Chicles_Menta == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Chicles_Menta += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Chicles_Menta == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Chicles_Menta += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Chicles_Menta == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Chicles_Menta += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Chicles_Menta == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMonster_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Monster == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Monster += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Monster == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Monster += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Monster == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Monster += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Monster == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Monster += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Monster == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrunch_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Crunch == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Crunch += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Crunch == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Crunch += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Crunch == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Crunch += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Crunch == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Crunch += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Crunch == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMilkybar_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Milkybar == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Milkybar += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Milkybar == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Milkybar += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Milkybar == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Milkybar += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Milkybar == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Milkybar += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Milkybar == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFritos_Click(object sender, EventArgs e)
        {
            cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");

            while (cantidadRellenar.Equals(""))
            {
                MessageBox.Show("Debes introducir un valor", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cantidadRellenar = Interaction.InputBox("Introduce la cantidad que quieras rellenar del producto seleccionado", "Rellenar cantidad");
            }

            cantidad = Int32.Parse(cantidadRellenar);

            if (VariablesEntorno.cantidad_Fritos == 1)
            {
                while (cantidad > 4)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 4)
                {
                    VariablesEntorno.cantidad_Fritos += Int32.Parse(cantidadRellenar);
                }

            }
            else if (VariablesEntorno.cantidad_Fritos == 2)
            {
                while (cantidad > 3)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 3)
                {
                    VariablesEntorno.cantidad_Fritos += Int32.Parse(cantidadRellenar);
                }

            }
            else if (VariablesEntorno.cantidad_Fritos == 3)
            {
                while (cantidad > 2)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 2)
                {
                    VariablesEntorno.cantidad_Fritos += Int32.Parse(cantidadRellenar);
                }
            }
            else if (VariablesEntorno.cantidad_Fritos == 4)
            {
                while (cantidad > 1)
                {
                    MessageBox.Show("\nTe has pasado, introduce una cantidad correcta!!", "Cantidad incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (cantidad == 1)
                {
                    VariablesEntorno.cantidad_Fritos += cantidad;
                }
            }
            else if (VariablesEntorno.cantidad_Fritos == 5)
            {
                MessageBox.Show("\nNo puedes rellenar más, la cantidad está completa!!", "Cantidad completa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }
    }
}
