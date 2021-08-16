using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_view
{
    class Vista
    {
        private int monedaOrigen;
        private float ta;
        private float ca;
        private float total;

        public float Ta
        {
            get { return ta; }
            set { ta = value; }
        }

        public float Ca
        {
            get { return ca; }
            set { ca = value; }
        }

        public float Total
        {
            get { return total; }
            set { total = value; }
        }

        public int MonedaOrigen
        {
            get { return this.monedaOrigen; }
            set { this.monedaOrigen = value; }
        }

        public Vista()
        {
            this.PedirDatos();
        }
        private void PedirDatos()
        {
            Console.WriteLine("Seleccione la moneda de origen: 1) Dolar 2) Peso colombiano 3) Sol peruano");
            switch (Console.ReadLine())
            {
                case "1":

                    this.MonedaOrigen = 1;
                    break;
                case "2":

                    this.MonedaOrigen = 2;
                    break;
                case "3":

                    this.MonedaOrigen = 3;
                    break;
            }
            Console.WriteLine("Ingrese la cantidad a convertir: ");
            ca = Single.Parse(Console.ReadLine());
        }

        public void MostrarResultado()
        {   //convierto a long para evitar que me de el total en notación exponencial
            Console.WriteLine("El monto equivale a " + Convert.ToInt64(Total) + " Bolívares Soberanos");
            Console.ReadKey();
        }
    }
}