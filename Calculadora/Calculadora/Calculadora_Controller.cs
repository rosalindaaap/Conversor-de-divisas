using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora_view;     //para poder acceder a los métodos y clases de la vista
using Calculadora_model;    //para poder acceder a los métodos y clases del modelo

namespace Calculadora_controller
{
    class controladorCalculadora
    {
        private Vista oDisplay;
        public controladorCalculadora()
        {
            oDisplay = new Vista();

            if (oDisplay.MonedaOrigen == 1)
            {
                dolar oDolar;
                oDolar = new dolar();
                oDolar.Cantidad = oDisplay.Ca;
                oDisplay.Ta = oDolar.Tasa;
                oDisplay.Total = oDolar.resultado();
                oDisplay.MostrarResultado();
            } else if (oDisplay.MonedaOrigen == 2)
            {
                peso oPeso;
                oPeso = new peso();
                oPeso.Cantidad = oDisplay.Ca;
                oDisplay.Ta = oPeso.Tasa;
                oDisplay.Total = oPeso.resultado();
                oDisplay.MostrarResultado();
            } else if (oDisplay.MonedaOrigen == 3)
            {
                sol oSol;
                oSol = new sol();
                oSol.Cantidad = oDisplay.Ca;
                oDisplay.Ta = oSol.Tasa;
                oDisplay.Total = oSol.resultado();
                oDisplay.MostrarResultado();
            }
        }
    }
}