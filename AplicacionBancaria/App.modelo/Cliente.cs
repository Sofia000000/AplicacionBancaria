using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBancaria.App.modelo
{
    public abstract class Cliente
    {
        public string nombre { get; set; }
        public string DNI { get; set; }

        public string direccion { get; set; }

        public DateTime fechaDeNacimiento { get; set; }

        public Cliente()
        {

        }

        public Cliente( string nombre, string DNI, string direccion, DateTime fechaDeNacimiento)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.DNI = DNI;
            this.fechaDeNacimiento = fechaDeNacimiento;
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
