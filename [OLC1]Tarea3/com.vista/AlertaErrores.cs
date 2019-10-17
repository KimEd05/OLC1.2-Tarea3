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
    public partial class AlertaErrores : Form
    {
        public AlertaErrores()
        {
            InitializeComponent();
            labelLexicos.Text = "Errores Léxicos: " + Program.erroresLexicos.Count;
            labelSintacticos.Text = "Errores Sintácticos: " + Program.erroresSintacticos.Count;
            labelSemanticos.Text = "Errores Semánticos: " + Program.erroresSemanticos.Count;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
