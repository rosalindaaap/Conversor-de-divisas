using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_model
{
    class Moneda
    {   //datos de la clase
        private float tasa;
        private float cantidad;

        //constructores
        public Moneda() {}
        public Moneda(float ta, float ca)
        {
            Tasa = ta;
            Cantidad = ca;
        }

        //funciones de acceso
        public float Tasa
        {
            get { return tasa; }
            set { tasa = value; }
        }

        public float Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        //métodos de la clase
        public float resultado()
        {
            return Tasa * Cantidad;
        }
    }

    class dolar : Moneda
    {   //constructores
        public dolar()
        {
            Tasa = 4110000;
            Cantidad = 0;
        }

        public dolar(float ta, float ca)
        {
            Tasa = ta;
            Cantidad = ca;
        }

    }

    class peso : Moneda
    {
        public peso()
        {   //constructores
            Tasa = 1050;
            Cantidad = 0;
        }

        public peso (float ta, float ca)
        {
            Tasa = ta;
            Cantidad = ca;
        }
    }

    class sol : Moneda
    {   //constructores
        public sol()
        {
            Tasa = 988830;
            Cantidad = 0;
        }

        public sol(float ta, float ca)
        {
            Tasa = ta;
            Cantidad = ca;
        }
    }
}