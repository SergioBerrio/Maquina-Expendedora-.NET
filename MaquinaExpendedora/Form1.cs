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
    public partial class Form1 : Form
    {
        public static int cantidad_Kit_Kat;
        public static int cantidad_Chicles_Fresa;
        public static int cantidad_Lacasitos;
        public static int cantidad_Palotes;
        public static int cantidad_Kinder_Bueno;
        public static int cantidad_Bolsa_Variada_Haribo;
        public static int cantidad_Cheetos;
        public static int cantidad_Twix;
        public static int cantidad_Pringles;
        public static int cantidad_MMs;
        public static int cantidad_Papa_Delta;
        public static int cantidad_Chicles_Menta;
        public static int cantidad_Monster;
        public static int cantidad_Crunch;
        public static int cantidad_Milkybar;
        public static int cantidad_Fritos;

        public static int cantidadComprada_Kit_Kat;
        public static int cantidadComprada_Chicles_Fresa;
        public static int cantidadComprada_Lacasitos;
        public static int cantidadComprada_Palotes;
        public static int cantidadComprada_Kinder_Bueno;
        public static int cantidadComprada_Bolsa_Variada_Haribo;
        public static int cantidadComprada_Cheetos;
        public static int cantidadComprada_Twix;
        public static int cantidadComprada_Pringles;
        public static int cantidadComprada_MMs;
        public static int cantidadComprada_Papa_Delta;
        public static int cantidadComprada_Chicles_Menta;
        public static int cantidadComprada_Monster;
        public static int cantidadComprada_Crunch;
        public static int cantidadComprada_Milkybar;
        public static int cantidadComprada_Fritos;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprarChucherias_Click(object sender, EventArgs e)
        {
            FormComprarChucherias formComprarChucherias = new FormComprarChucherias();
            formComprarChucherias.Show();

            this.Hide();
        }

        private void btnVerChucherias_Click(object sender, EventArgs e)
        {
            FormVerChucherias formVerChucherias = new FormVerChucherias();
            formVerChucherias.Show();

            this.Hide();
        }

        private void btnRellenarMaquina_Click(object sender, EventArgs e)
        {
            FormIniciarSesion formRellenarMaquinaContrasena = new FormIniciarSesion();
            formRellenarMaquinaContrasena.Show();

            this.Hide();
        }

        private void btnApagarMaquina_Click(object sender, EventArgs e)
        {
            FormApagarMaquina formApagarMaquina = new FormApagarMaquina();
            formApagarMaquina.Show();

            this.Hide();
        }
    }
}
