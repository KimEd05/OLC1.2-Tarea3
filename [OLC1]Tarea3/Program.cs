using _OLC1_Tarea3.com.vista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _OLC1_Tarea3
{
    static class Program
    {
        public static Boolean menuArchivo = false;
        public static Boolean menuReportes = false;
        public static Hashtable path;
        public static List<Error> erroresLexicos;
        public static List<Error> erroresSintacticos;
        public static List<Error> erroresSemanticos;
        public static string pestanaActual;
        public static VentanaPrincipal ventanaPrincipal;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false); 
            
            ventanaPrincipal = new VentanaPrincipal();
            path = new Hashtable();
            erroresLexicos = new List<Error>();
            erroresSintacticos = new List<Error>();
            erroresSemanticos = new List<Error>();

            Application.Run(ventanaPrincipal);
        }

        public static void limpiarListas()
        {
            erroresLexicos = new List<Error>();
            erroresSintacticos = new List<Error>();
            erroresSemanticos = new List<Error>();
            pestanaActual = "";
        }
    }
}
