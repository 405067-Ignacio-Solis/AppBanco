using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente(001,10000,"NombreCliente1",001,true);
            Cliente cliente2 = new Cliente(002, 10500, "NombreCliente2", 002, false);

            Cuenta cuenta1 = new Cuenta(01, 1, 2000, cliente1);
            Cuenta cuenta2 = new Cuenta(02, 2, 3000, cliente2);

            Banco banco = new Banco(2);

            banco.addCuenta(cuenta1);
            banco.addCuenta(cuenta2);

            Console.WriteLine("La cantidad de cajas de ahorro es: " + banco.calcularCantidadCajasAhorro());
            Console.WriteLine("La cantidad de cuentas corriente es: " + banco.calcularCantidadCuentasCorriente());
            Console.WriteLine("El saldo promedio para cajas de ahorro es: " + banco.calcularSaldoPromedioCajaAhorro());
            Console.WriteLine("El saldo promedio para cuentas corriente es: " + banco.calcularSaldoPromedioCuentaCorriente());
            Console.WriteLine("El saldo promedio de cuentas en general es: " + banco.calcularPromedioSaldoGeneral());
            Console.WriteLine("El porcentaje de clientes femeninos es: " + banco.calcularPorcentajeClientesFemeninos());
            Console.WriteLine("El cliente con mayor limite de credito es: " + banco.calcularClienteMayorLimiteCredito()); 


        }
    }
}
