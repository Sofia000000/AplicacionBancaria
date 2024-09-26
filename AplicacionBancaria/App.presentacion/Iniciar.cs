using AplicacionBancaria.App.modelo;
using AplicacionBancaria.App.negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBancaria.App.presentacion
{
    internal class Iniciar
    {

        public void init() { 
            
            CuentaAhorro cuentaAhorro = new CuentaAhorro("Sofi", "A00000", "Calle Ejeplo 1", 1000);
            CuentaNomina cuentaNomina = new CuentaNomina("John", "B11111", "Calle Ejemplo 2", 1000, "CCSS", "Microsft", 10);

            Imprimir imprimir = new Imprimir();
            imprimir.imprimirCualquierCuenta(cuentaAhorro);
            imprimir.imprimirCualquierCuenta(cuentaNomina);
        }
    }
}
