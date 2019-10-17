using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OLC1_Tarea3.global
{
    class Entorno
    {

        public Hashtable tabla;
        public Entorno anterior;

        public Entorno(Entorno anterior)
        {
            this.tabla = new Hashtable();
            this.anterior = anterior;
        }

        public void insertar(String nombre, Simbolo sim, int linea, int columna)
        {
            if (tabla[nombre] != null)
            {
                Console.WriteLine("La variable '" + nombre + "' ya existe. Línea: " + linea + " Columna: " + columna);
                return;
            }
            tabla.Add(nombre, sim);
        }

        public Simbolo buscar(String nombre, int linea, int columna)
        {
            for (Entorno e = this; e != null; e = e.anterior)
            {
                if (e.tabla[nombre] != null)
                {
                    Simbolo sim = (Simbolo)e.tabla[nombre];
                    return sim;
                }
            }
            Console.WriteLine("La variable '" + nombre + "' no existe. Línea: " + linea + " Columna: " + columna);
            return null;
        }

    }
}
