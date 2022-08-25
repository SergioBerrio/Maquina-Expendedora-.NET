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
    public partial class FormIniciarSesion : Form
    {

        public FormIniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (tbContrasena.Text.Equals("MaquinaExpendedora2022"))
            {
                MessageBox.Show("Inicio de sesión correcto!!", "Contraseña correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormRellenarMaquina formRellenarMaquina = new FormRellenarMaquina();
                formRellenarMaquina.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Inicio de sesión incorrecto!!", "Contraseña incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Apagando máquina...", "Máquina apagada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Application.Exit();
            }
        }
    }
}
