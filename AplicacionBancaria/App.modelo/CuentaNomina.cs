using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBancaria.App.modelo
{
    internal class CuentaNomina: CuentaAhorro
    {

        string SS;
        string empresa;
        double comision;

        public CuentaNomina()
        {

        }

        public CuentaNomina(string nombre, string DNI, string direccion, double saldo, string SS, string empresa, double comision)
        {
            this.nombre = nombre;
            this.DNI = DNI;
            this.direccion = direccion;
            this.saldoAnterior = saldo;
            this.SS = SS;
            this.empresa = empresa;
            this.comision = comision;
        }

        public override double calcularSaldo()
        {
            double comisiones = retiros * comision;

            return saldoAnterior + ingresos - retiros - comisiones;
        }
    }
}
