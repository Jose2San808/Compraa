using Compraa.Entities;
using Compraa.Services;
using System;

namespace Compraa
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            {
                Funciones funciones = new Funciones();
                Cliente cliente = funciones.SolicitarDatosCliente();
                int suma = funciones.SolicitarPreciosArticulos();
                funciones.ImprimirInformacionCliente(cliente);
                funciones.CalcularDescuentoOPromocion(suma);
            }
        }
    }
}

