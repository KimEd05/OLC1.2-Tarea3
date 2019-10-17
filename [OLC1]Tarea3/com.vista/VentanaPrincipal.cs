using _OLC1_Tarea3.com.analizador;
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
    public partial class VentanaPrincipal : Form
    {
        MenuArchivo menuArchivo = new MenuArchivo();
        MenuErrores menuErrores = new MenuErrores();

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void buttonArchivo_Click(object sender, EventArgs e)
        {
            if (Program.menuReportes)
            {
                Program.menuReportes = false;
                menuErrores.Visible = false;
            }

            if (!Program.menuArchivo)
            {
                Program.menuArchivo = true;
                menuArchivo.Visible = true;
            }
            else
            {
                Program.menuArchivo = false;
                menuArchivo.Visible = false;
            }
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            /*if (Program.menuArchivo)
            {
                Program.menuArchivo = false;
                menuArchivo.Visible = false;
            }

            if (!Program.menuReportes)
            {
                Program.menuReportes = true;
                menuErrores.Visible = true;
            }
            else
            {
                Program.menuReportes = false;
                menuErrores.Visible = false;
            }*/
            Process.Start(Path.GetDirectoryName(Environment.CurrentDirectory) + "\\" + Program.pestanaActual + ".jpg");
        }

        private void buttonCompilar_Click(object sender, EventArgs e)
        {
            Program.limpiarListas();
            bool resultado = true;
            foreach (TabPage pestana in tabControl.TabPages)
            {
                String entrada = ((RichTextBox)pestana.Controls[0]).Text;
                bool res = Sintactico.analizar(entrada, pestana.Name);
                if (!res)
                {
                    resultado = false;
                }

            }

            if (resultado)
            {
                AlertaAnalisis alerta = new AlertaAnalisis();
                alerta.Show();
            }
            else
            {
                AlertaErrores alerta = new AlertaErrores();
                alerta.Show();
            }

            Program.pestanaActual = tabControl.SelectedTab.Name;
            cerrarSubmenu();
        }

        public void cerrarSubmenu()
        {
            if (Program.menuArchivo)
            {
                Program.menuArchivo = false;
                menuArchivo.Visible = false;
            }

            if (Program.menuReportes)
            {
                Program.menuReportes = false;
                menuErrores.Visible = false;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            cerrarSubmenu();
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setLineColumnMouse(Object sender, MouseEventArgs e)
        {
            int index = ((RichTextBox)tabControl.SelectedTab.Controls[0]).SelectionStart;
            int line = ((RichTextBox)tabControl.SelectedTab.Controls[0]).GetLineFromCharIndex(index);
            labelLinea.Text = "Línea: " + (line + 1);

            int firstChar = ((RichTextBox)tabControl.SelectedTab.Controls[0]).GetFirstCharIndexFromLine(line);
            int column = index - firstChar;
            labelColumna.Text = "Columna: " + (column + 1);
        }

        public void setLineColumnKeyboard(object sender, KeyEventArgs e)
        {
            int index = ((RichTextBox)tabControl.SelectedTab.Controls[0]).SelectionStart;
            int line = ((RichTextBox)tabControl.SelectedTab.Controls[0]).GetLineFromCharIndex(index);
            labelLinea.Text = "Línea: " + (line + 1);

            int firstChar = ((RichTextBox)tabControl.SelectedTab.Controls[0]).GetFirstCharIndexFromLine(line);
            int column = index - firstChar;
            labelColumna.Text = "Columna: " + (column + 1);
        }
    }
}
