using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _OLC1_Tarea3.com.vista
{
    public partial class MenuArchivo : Form
    {

        private int contadorTab = 1;
        Controlador controlador = new Controlador();

        public MenuArchivo()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            Program.ventanaPrincipal.tabControl.TabPages.Add(crearPestana());
            Program.ventanaPrincipal.cerrarSubmenu();
            contadorTab++;
        }

        private TabPage crearPestana()
        {
            TabPage tabPage = new TabPage();
            tabPage.Text = "Tab" + contadorTab;
            tabPage.Name = "Tab" + contadorTab;
            RichTextBox textBox = new RichTextBox();
            textBox.SetBounds(3, 3, 865, 283);
            textBox.MouseClick += new MouseEventHandler(Program.ventanaPrincipal.setLineColumnMouse);
            textBox.KeyDown += new KeyEventHandler(Program.ventanaPrincipal.setLineColumnKeyboard);
            textBox.KeyUp += new KeyEventHandler(Program.ventanaPrincipal.setLineColumnKeyboard);
            tabPage.Controls.Add(textBox);
            Program.ventanaPrincipal.tabControl.SelectedTab = tabPage;
            return tabPage;
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            TabPage tabPage = crearPestana();
            controlador.Abrir((RichTextBox)tabPage.Controls[0], tabPage);
            contadorTab++;
            Program.ventanaPrincipal.tabControl.TabPages.Add(tabPage);
            Program.ventanaPrincipal.cerrarSubmenu();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (Program.path[Program.ventanaPrincipal.tabControl.SelectedTab.Name] != null)
            {
                controlador.Guardar((RichTextBox)Program.ventanaPrincipal.tabControl.SelectedTab.Controls[0], Program.path[Program.ventanaPrincipal.tabControl.SelectedTab.Name].ToString());

            }
            else
            {
                controlador.GuardarComo((RichTextBox)Program.ventanaPrincipal.tabControl.SelectedTab.Controls[0]);
            }
            Program.ventanaPrincipal.cerrarSubmenu();
        }

        private void buttonGuardarComo_Click(object sender, EventArgs e)
        {
            controlador.GuardarComo((RichTextBox)Program.ventanaPrincipal.tabControl.SelectedTab.Controls[0]);
            Program.ventanaPrincipal.cerrarSubmenu();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            Program.ventanaPrincipal.tabControl.TabPages.RemoveAt(Program.ventanaPrincipal.tabControl.SelectedIndex);
            Program.ventanaPrincipal.cerrarSubmenu();
        }
    }
}
