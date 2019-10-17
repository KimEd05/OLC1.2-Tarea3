using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OLC1_Tarea3.global
{
    class Simbolo
    {
        
        public EnumTipo tipo;
        public Object valor;

        public Simbolo() 
        { 
        
        }
        
        public Simbolo(EnumTipo tipo, Object valor)
        {
            this.tipo = tipo;
            this.valor = valor;
        }

        public enum EnumTipo
        {
            entero, cadena, error
        }
    }
}
