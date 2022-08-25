using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedora
{
    class VariablesEntorno
    {
        //VARIABLES ARRAYS
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

        //VARIABLES DE INTERACCIÓN
        public static int cantidad_Kit_Kat = 5;
        public static int cantidad_Chicles_Fresa = 5;
        public static int cantidad_Lacasitos = 5;
        public static int cantidad_Palotes = 5;
        public static int cantidad_Kinder_Bueno = 5;
        public static int cantidad_Bolsa_Variada_Haribo = 5;
        public static int cantidad_Cheetos = 5;
        public static int cantidad_Twix = 5;
        public static int cantidad_Pringles = 5;
        public static int cantidad_MMs = 5;
        public static int cantidad_Papa_Delta = 5;
        public static int cantidad_Chicles_Menta = 5;
        public static int cantidad_Monster = 5;
        public static int cantidad_Crunch = 5;
        public static int cantidad_Milkybar = 5;
        public static int cantidad_Fritos = 5;

        public static int cantidadComprada_Kit_Kat = 0;
        public static int cantidadComprada_Chicles_Fresa = 0;
        public static int cantidadComprada_Lacasitos = 0;
        public static int cantidadComprada_Palotes = 0;
        public static int cantidadComprada_Kinder_Bueno = 0;
        public static int cantidadComprada_Bolsa_Variada_Haribo = 0;
        public static int cantidadComprada_Cheetos = 0;
        public static int cantidadComprada_Twix = 0;
        public static int cantidadComprada_Pringles = 0;
        public static int cantidadComprada_MMs = 0;
        public static int cantidadComprada_Papa_Delta = 0;
        public static int cantidadComprada_Chicles_Menta = 0;
        public static int cantidadComprada_Monster = 0;
        public static int cantidadComprada_Crunch = 0;
        public static int cantidadComprada_Milkybar = 0;
        public static int cantidadComprada_Fritos = 0;
    }
}
