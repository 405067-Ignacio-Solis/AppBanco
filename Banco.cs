using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    internal class Banco
    {
        private string nombre;
        private Cuenta[] cuentas;
        private int ultima;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Banco()
        {
            nombre = string.Empty;
            ultima = 0;
            cuentas = new Cuenta[10];
        }
        public Banco(int cantidad)
        {
            nombre = string.Empty;
            ultima = 0;
            cuentas = new Cuenta[cantidad];
        }



        public bool addCuenta(Cuenta cuenta) {
            if (ultima <= cuentas.Length)
            {
                cuentas[ultima] = cuenta;
                ultima++;
                return true;
            }

            else return false;
        
        }
        public int calcularCantidadCajasAhorro()
        {
            int contadorCajasAhorro = 0;
            foreach (Cuenta cuenta in cuentas)
            {
                if (cuenta.Tipo == 1)
                {
                    contadorCajasAhorro++;
                }

            }
            return contadorCajasAhorro;
        }


        public int calcularCantidadCuentasCorriente()
        {
            int contadorCuentasCorriente = 0;
            foreach (Cuenta cuenta in cuentas)
            {
                if (cuenta.Tipo == 2)
                {
                    contadorCuentasCorriente++;
                }
            }
            return contadorCuentasCorriente;
        }

        public double calcularSaldoPromedioCajaAhorro()
        {
            double acumuladorSaldo = 0;
            int cuentasCCAANotNull = 0;
            
            foreach (Cuenta cuenta in cuentas)
            {
                if (cuenta != null)
                {
                    
                    if (cuenta.Tipo == 1)
                    {
                        cuentasCCAANotNull++;
                        acumuladorSaldo += cuenta.Saldo;
                    }

                }
            }
            double saldoPromedio = (acumuladorSaldo / cuentasCCAANotNull);
            return saldoPromedio;
        }
        public double calcularSaldoPromedioCuentaCorriente()
        {
            double acumuladorSaldo = 0;
            int cuentasCCNotNull = 0;

            foreach (Cuenta cuenta in cuentas)
            {
                if (cuenta != null)
                {
                    
                    if (cuenta.Tipo == 2)
                    {
                        cuentasCCNotNull++;
                        acumuladorSaldo += cuenta.Saldo;
                    }

                }
            }
            double saldoPromedio = (acumuladorSaldo / cuentasCCNotNull++);
            return saldoPromedio;

        }

        public double calcularPromedioSaldoGeneral() {
            double acumuladorSaldo = 0;
            int cuentasNotNull = 0;
            foreach (Cuenta cuenta in cuentas) {
                if (cuenta != null) {
                    cuentasNotNull++;
                    acumuladorSaldo += cuenta.Saldo;
                }
            }
            return (acumuladorSaldo / cuentasNotNull);
        }

        public double calcularPorcentajeClientesFemeninos() {
            double cantidadClientesFemeninos = 0;
            int cuentasNotNull = 0;
            foreach (Cuenta cuenta in cuentas) {
                if (cuenta != null) {
                    cuentasNotNull++;
                    if (cuenta.Titular.Sexo is false) {
                        cantidadClientesFemeninos++;
                    }
                }
            }
            double porcentajeClientesFemeninos = (cantidadClientesFemeninos / cuentasNotNull  );

            return porcentajeClientesFemeninos;
        }

        public Cliente calcularClienteMayorLimiteCredito() {

            Cliente titularMayorCredito = cuentas[0].Titular;
            foreach (Cuenta cuenta in cuentas) {
                if (cuenta != null) {
                    if (cuenta.Titular.LimiteCredito > titularMayorCredito.LimiteCredito) {
                        titularMayorCredito = cuenta.Titular;
                    }
                }
            }

            return titularMayorCredito;
        }

        public override string ToString()
        {
            string bancoString = string.Empty;

            bancoString += "|Nombre del banco: " + nombre + "|Cantidad de cuentas en el banco: " + cuentas.Length;
            return bancoString;
        }
    }
        
}
