using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_NeysiFM;
using Parcial1_NeysiFM.BLL;
using Parcial1_NeysiFM.DAL;
using Parcial1_NeysiFM.Entidades;

namespace Parcial1_NeysiFM.UI.Consultas
{
    public partial class ValorInventario : MetroFramework.Forms.MetroForm
    {
        public object ProductoBLL { get; private set; }

        public ValorInventario()
        {
            InitializeComponent();
        }

        private void ValorInventario_Load(object sender, EventArgs e)
        {
            this.MetroTextBoxValorInventario.Text = ObtenerTotalInventario().ToString();
        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroTileInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Double ObtenerTotalInventario()
        {
            double total = 0;
            total = InventarioBLL.Buscar(1).ValorInventario;

            return total;
        }

        private void MetroTileRefrescar_Click(object sender, EventArgs e)
        {
            MetroTextBoxValorInventario.Text = ObtenerTotalInventario().ToString();
        }
    }
}
