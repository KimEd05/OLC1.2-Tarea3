using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OLC1_Tarea3.global
{
    class Expresion
    {

        public Simbolo.EnumTipo tipo;
        public Object valor;
        public String error;

        public Expresion(Simbolo.EnumTipo tipo, Object valor)
        {
            this.tipo = tipo;
            this.valor = valor;
        }

        public Expresion(Simbolo.EnumTipo tipo, Object valor, String error)
        {
            this.tipo = tipo;
            this.valor = valor;
            this.error = error;
        }

    }
}
