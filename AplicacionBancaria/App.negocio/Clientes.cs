using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionBancaria.App.negocio
{
    internal class Clientes
    {

        public List<modelo.Cliente> clientes {  get; set; }




        public List<modelo.Cliente> clientesOrdenados()
        {
            return clientes.OrderBy(c => c.nombre).OrderBy(c => c.fechaDeNacimiento).ToList();
        }
    }
}
