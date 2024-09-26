using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBancaria.App.modelo
{
    internal class CuentaAhorro : Cliente
    {

        public double saldoAnterior { get; set; }
        public double ingresos { get; set; }
        public double retiros { get; set; }


        public CuentaAhorro()
        {

        }

        public CuentaAhorro( string nombre, string DNI, string direccion, double saldo)
        {
            this.nombre = nombre;
            this.DNI = DNI;
            this.direccion = direccion;
            this.saldoAnterior = saldo;
        }

        public virtual double calcularSaldo ()
        {
            return saldoAnterior + ingresos - retiros;
        }

        public double calcularSaldo(double tasaInteres)
        {
            return (tasaInteres * saldoAnterior) + ingresos - retiros;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }
    }
}
