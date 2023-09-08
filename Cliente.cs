using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBanco
{
    internal class Cliente:Persona
    {
        private int codigo;
        private int limiteCredito;


        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int LimiteCredito {
            get { return limiteCredito; }
            set { limiteCredito = value; }

        }

        public Cliente(int codigo, int limiteCredito, string nombre, int documento, bool sexo) 
            :base(nombre,documento,sexo){
            this.codigo = codigo;
            this.limiteCredito = limiteCredito;

            
        }


    }
}
