using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    internal class Cuenta
    {
        private int numero;
        private Cliente titular;

        public Cliente Titular { get { return titular; } set { titular = value; } }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private int tipo;   //1-Caja Ahorro 2-Cuenta Corriente

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public Cuenta()
        {
            this.saldo = this.tipo = this.numero = 0;
        }
        public Cuenta(int numero, int tipo, double saldo, Cliente titular)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.saldo = saldo;
            this.titular = titular;
        }
        public override string ToString()
        {
            return "|Cuenta: " + tipo + " |Numero: " + numero + " |Saldo: $" + saldo + "\n|Titular a cargo: " + titular.ToString();
        }
    }
}
