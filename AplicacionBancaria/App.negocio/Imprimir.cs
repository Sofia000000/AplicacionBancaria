using AplicacionBancaria.App.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IImprimir
{
    void imprimirCualquierCuenta(Cliente cliente);
}

namespace AplicacionBancaria.App.negocio
{
    internal class Imprimir: IImprimir
    {

        public void imprimirCualquierCuenta(Cliente cliente)
        {
            string datosCliente = $"Nombre: {cliente.nombre} \nDNI: {cliente.DNI} \nDireccion: {cliente.direccion} \nFecha de nacimiento: {cliente.fechaDeNacimiento}";

            Console.WriteLine(datosCliente);

            File.WriteAllText($"c;\\temp\\{cliente.nombre}.txt", datosCliente);
        }
    }
}
