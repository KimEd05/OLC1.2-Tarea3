using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _OLC1_Tarea3.com.vista
{
    public partial class MenuErrores : Form
    {
        public MenuErrores()
        {
            InitializeComponent();
        }

        private void buttonErrores_Click(object sender, EventArgs e)
        {

        }

        private void buttonAST_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetDirectoryName(Environment.CurrentDirectory) + "\\" + Program.pestanaActual + ".jpg");
            Program.ventanaPrincipal.cerrarSubmenu();
        }
    }
}
