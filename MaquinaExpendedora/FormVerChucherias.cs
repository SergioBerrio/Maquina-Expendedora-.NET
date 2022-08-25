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
    public partial class FormVerChucherias : Form
    {
        public static string[,] nombresGolosinas = new string[4, 4]{
            {"Kit Kat", "Chicles de fresa", "Lacasitos", "Palotes"},

            {"Kinder Bueno", "Bolsa variada Haribo", "Cheetos", "Twix"},

            {"Pringles", "M&M'S", "Papa Delta", "Chicles de menta"},

            {"Monster", "Crunch", "Milkybar", "Fritos"}
        };

        public static double[,] precioGolosinas = new double[4, 4]{
            {1.1, 0.8, 1.5, 0.9},

            {1.8, 1, 1.2, 1},

            {1.5, 1.3, 1.2, 0.8},

            {1.2, 1.1, 1.1, 0.75}
        };

        public FormVerChucherias()
        {
            InitializeComponent();
        }

        private void FormVerChucherias_Load(object sender, EventArgs e)
        {
            dgvChucherias.ColumnCount = 3;
            dgvChucherias.Columns[0].Name = "Código";
            dgvChucherias.Columns[1].Name = "Producto";
            dgvChucherias.Columns[2].Name = "Precio (€)";

            dgvChucherias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dgvChucherias.Rows.Add("[" + i + j + "]", nombresGolosinas[i, j], precioGolosinas[i, j]);
                }
            }
        }
    }
}
