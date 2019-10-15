using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OLC1_Tarea3.com.vista
{
    class Error
    {
        private string error;
        private string descripcion;
        private int fila;
        private int columna;
        private string pestana;

        public Error(string e, string d, int f, int c, string p)
        {
            this.error = e;
            this.descripcion = d;
            this.fila = f;
            this.columna = c;
            this.pestana = p;
        }

        public string getError()
        {
            return error;
        }

        public void setError(string error)
        {
            this.error = error;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public int getFila()
        {
            return fila;
        }

        public void setFila(int fila)
        {
            this.fila = fila;
        }

        public int getColumna()
        {
            return columna;
        }

        public void setColumnaa(int columna)
        {
            this.columna = columna;
        }

        public string getPestana()
        {
            return pestana;
        }

        public void setPestana(string pestana)
        {
            this.pestana = pestana;
        }

    }

}
