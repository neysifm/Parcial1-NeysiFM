using Parcial1_NeysiFM.BLL;
using Parcial1_NeysiFM.UI.Consultas;
using Parcial1_NeysiFM.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1_NeysiFM
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(InventarioBLL.Buscar(1) == null)
            {
                InventarioBLL.Guardar(new Entidades.Inventarios(0));
            }

        }

        private void MetroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void RegistroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrosProductos rp = new RegistrosProductos();
            rp.ShowDialog();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ValorInventario().ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
