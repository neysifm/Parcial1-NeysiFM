using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_NeysiFM.UI.Consultas;

namespace Parcial1_NeysiFM
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LimpiarError()
        {
            DescripcionerrorProvider.Clear();
            ExistenciaerrorProvider.Clear();
            CostoerrorProvider.Clear();
            ValorInventarioerrorProvider.Clear();
        }

        private void MetroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void MetroTileValorInventarioInicio_Click(object sender, EventArgs e)
        {
            ValorInventario vi = new ValorInventario();
            vi.ShowDialog();
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            IDnumericUpDown.Value = 0;
            TextBoxDescripcion.Clear();
            TextBoxExistencia.Clear();
            TextBoxCosto.Clear();
            TextBoxValorInventario.Clear();
            LimpiarError();
        }
    }
}
