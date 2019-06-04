using Parcial1_NeysiFM.BLL;
using Parcial1_NeysiFM.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Parcial1_NeysiFM.UI.Registros
{
    public partial class FUbicaciones : MetroFramework.Forms.MetroForm, IFormularioRegistro<Ubicaciones>
    {
        public FUbicaciones()
        {
            InitializeComponent();
        }

        private void Ubicaciones_Load(object sender, EventArgs e)
        {

        }

        private void MetroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {

        }

        public bool ValidarCampos()
        {
            bool validar = true;

            if (string.IsNullOrEmpty(DescripcionmetroTextBox.Text))
            {
                errorProvider1.SetError(DescripcionmetroTextBox, "La Descripcion no debe de estar vacia, Llenar descripcion del Producto");
                validar = false;
            }
            return validar;
        }

        public bool ValidarBuscar()
        {
            if (IdnumericUpDown.Value <= 0)
            {
                return false;
            }
            if (UbicacionesBLL.Buscar(Convert.ToInt32(IdnumericUpDown.Value)) == null)
            {
                return false;
            }
            return true;
        }

        public bool ValidarEliminar()
        {
            return ValidarBuscar();
        }

        public bool ValidarGuardar()
        {
            if (!ValidarCampos())
            {
                return false;
            }
            return true;
        }

        public bool ValidarModificar()
        {
            if (!ValidarBuscar() || !ValidarGuardar())
            {
                return false;
            }
            return true;
        }

        public void LimpiarCampos()
        {
            IdnumericUpDown.Value = 0;
            DescripcionmetroTextBox.Clear();

        }

        public Ubicaciones LlenaClase()
        {
            Ubicaciones ubicaciones = new Ubicaciones
            {
                Descripcion = DescripcionmetroTextBox.Text,
                UbicacionesId = Convert.ToInt32(IdnumericUpDown.Value)
            };

            return ubicaciones;
        }

        public void LlenaCampos(Ubicaciones ubicaciones)
        {
            DescripcionmetroTextBox.Text = ubicaciones.Descripcion;
        }

        private void BuscarButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton4_Click(object sender, EventArgs e)
        {
            if (ValidarEliminar())
            {
                if (UbicacionesBLL.Eliminar(Convert.ToInt32(IdnumericUpDown.Value)))
                {
                    MessageBox.Show("Registro Eliminado Correctamente!");
                    LimpiarCampos();
                    return;
                }
                MessageBox.Show("Error al intentar eliminar el registro!");
            }
        }

        private void GuardarmetroButton3_Click(object sender, EventArgs e)
        {
            if (IdnumericUpDown.Value > 0)
            {
                if (ValidarModificar())
                {
                    if (UbicacionesBLL.Modificar(LlenaClase()))
                    {
                        MessageBox.Show("El registro se actualizo correctamente");
                        LimpiarCampos();
                        return;
                    }
                }

            }
            else
            {
                if (ValidarGuardar())
                {
                    if (UbicacionesBLL.Guardar(LlenaClase()) == true)
                    {
                        MessageBox.Show("El registro se guardo correctamente");
                        LimpiarCampos();
                        return;
                    }

                }
            }
            MessageBox.Show("Error al intentar guardar o modificar el registro!");
        }

        private void BuscarmetroButton1_Click(object sender, EventArgs e)
        {
            if (ValidarBuscar() == false)
            {
                MessageBox.Show("No existe un producto con este ID");
                return;
            }
            LlenaCampos(UbicacionesBLL.Buscar(Convert.ToInt32(IdnumericUpDown.Value)));
        }
    }
}
