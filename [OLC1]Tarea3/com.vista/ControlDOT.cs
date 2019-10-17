using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _OLC1_Tarea3.com.vista
{
    class ControlDOT
    {
        private static int cont;
        private static String grafo;

        public static String getDOT(ParseTreeNode root)
        {
            grafo = "digraph G{\n";
            grafo += "node[style=filled, fillcolor=\"tan: seashell\", fontname=\"Krempeng Sans\", fontsize=20.0];\n";
            grafo += "nodo0[label=\"" + escape(root.ToString()) + "\"];\n";
            cont = 1;
            recorrerAST("nodo0", root);
            grafo += "}";
            return grafo;
        }

        private static void recorrerAST(String padre, ParseTreeNode hijos)
        {
            foreach (ParseTreeNode hijo in hijos.ChildNodes)
            {
                String nombreHijo = "nodo" + cont.ToString();
                grafo += nombreHijo + "[label=\"" + escape(hijo.ToString()) + "\"];\n";
                grafo += padre + "->" + nombreHijo + ";\n";
                cont++;
                recorrerAST(nombreHijo, hijo);
            }
        }

        private static String escape(String cad)
        {
            cad = cad.Replace("\\", "\\\\");
            cad = cad.Replace("\"", "\\\"");
            return cad;
        }
    }
}
