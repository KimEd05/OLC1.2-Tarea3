using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _OLC1_Tarea3.com.vista
{
    class Controlador
    {

        public string Abrir(RichTextBox TextBox, TabPage tabPage)
        {
            OpenFileDialog abrir = new OpenFileDialog()
            {
                Title = "Abrir",
                //Filter = "fi | *.fi",
                AddExtension = true
            };
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(abrir.FileName))
                    {
                        String text = sr.ReadToEnd();
                        TextBox.Text = text;
                        tabPage.Name = abrir.SafeFileName/*.Replace(".fi", "")*/;
                        tabPage.Text = abrir.SafeFileName/*.Replace(".fi", "")*/;
                        Program.path.Add(abrir.SafeFileName/*.Replace(".fi", "")*/, abrir.FileName);
                        Program.ventanaPrincipal.tabControl.SelectedTab.Name = abrir.SafeFileName/*.Replace(".fi", "")*/;
                        Program.ventanaPrincipal.tabControl.SelectedTab.Text = abrir.SafeFileName/*.Replace(".fi", "")*/;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return abrir.FileName;
        }

        public void Guardar(RichTextBox TextBox, string rutaGuardar)
        {

            File.WriteAllText(Program.path[Program.ventanaPrincipal.tabControl.SelectedTab.Name].ToString(), TextBox.Text);
        }

        public string GuardarComo(RichTextBox TextBox)
        {
            SaveFileDialog guardarComo = new SaveFileDialog()
            {
                Title = "Guardar Como",
                //Filter = "fi | *.fi| | ",
                
                AddExtension = true
            };
            guardarComo.ShowDialog();
            try
            {
                StreamWriter guardar = new StreamWriter(guardarComo.FileName);
                guardar.WriteLine(TextBox.Text);
                Program.path.Add(Path.GetFileName(guardarComo.FileName), guardarComo.FileName);
                Program.ventanaPrincipal.tabControl.SelectedTab.Name = Path.GetFileName(guardarComo.FileName);
                Program.ventanaPrincipal.tabControl.SelectedTab.Text = Path.GetFileName(guardarComo.FileName);
                guardar.Close();

            }
            catch (Exception ee)
            {
                Console.WriteLine(ee);
            }
            return guardarComo.FileName;
        }

    }
}
