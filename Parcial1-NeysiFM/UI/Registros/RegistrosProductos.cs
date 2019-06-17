using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Parcial1_NeysiFM.BLL;
using Parcial1_NeysiFM.DAL;
using Parcial1_NeysiFM.Entidades;
using Parcial1_NeysiFM.UI.Consultas;

namespace Parcial1_NeysiFM.UI.Registros
{
    public partial class RegistrosProductos : MetroFramework.Forms.MetroForm, IFormularioRegistro<Productos>
    {
        public RegistrosProductos()
        {
            InitializeComponent();
        }

        List<PrecioDetalle> listaPreciosDetalle = new List<PrecioDetalle>();
        public double CalcularInventario()
        {
            Double valorInventario = 0;
            try
            {
             valorInventario =  (Convert.ToInt32(TextBoxExistencia.Text) * Convert.ToInt32(TextBoxCosto.Text));
            }catch(Exception)
            {          
            }
            return valorInventario;
        }

        private void LimpiarError()
        {
            errorProvider.Clear();
            TextBoxExistencia.Text = "0";
            TextBoxCosto.Text = "0";
            TextBoxValorInventario.Text = "0";      }

        private void MetroTextBox3_Click(object sender, EventArgs e)
        {
          TextBoxValorInventario.Text =   CalcularInventario().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            LlenaCombo();
        }

        public void LlenaCombo()
        {
            this.metroComboBox1.DisplayMember = "Descripcion";
            this.metroComboBox1.ValueMember = "UbicacionId";
            List<Ubicaciones> listaUbicaciones = ObtenerUbicaciones();
            this.metroComboBox1.DataSource = listaUbicaciones;
            this.metroComboBox1.Update();
            if(listaUbicaciones.Count() > 0)
            {
                metroComboBox1.SelectedIndex = 0;
            }
            MessageBox.Show(this.metroButton1.ToString());
        }
        private void MetroTileValorInventarioInicio_Click(object sender, EventArgs e)
        {
            ValorInventario vi = new ValorInventario();
            vi.Show();
        }

        private void ButtonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public bool ValidarCampos()
        {
            bool validar = true;

            if (string.IsNullOrEmpty(TextBoxDescripcion.Text))
            {
                errorProvider.SetError(TextBoxDescripcion, "La Descripcion no debe de estar vacia, Llenar descripcion del Producto");
                validar = false;
            }           
            if (string.IsNullOrEmpty(TextBoxExistencia.Text) || TextBoxExistencia.Text == "0")
            {
                errorProvider.SetError(TextBoxExistencia, "La Existencia debe ser mayor a '0', Llenar Existencia del Producto");
                validar = false;
            }
            if (string.IsNullOrEmpty(TextBoxCosto.Text) || TextBoxCosto.Text == "0")
            {
                errorProvider.SetError(TextBoxCosto, "El Costo debe ser mayor a '0', Llenar Costo del Producto");
                validar = false;
            }
            return validar;
        }

        public bool ValidarBuscar()
        {
            if(IDnumericUpDown.Value <= 0)
            {
                return false;
            }
            if(ProductosBLL.Buscar(Convert.ToInt32(IDnumericUpDown.Value)) == null)
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
            if(!ValidarCampos())
            {
                return false;
            }
            return true;
        }

        public void LimpiarCampos()
        {
            IDnumericUpDown.Value = 0;
            TextBoxDescripcion.Clear();
            TextBoxExistencia.Clear();
            TextBoxCosto.Clear();
            TextBoxValorInventario.Clear();
            LimpiarError();
            dataGridView1.DataSource = null;
            dataGridView1.Update();
        }

        public Productos LlenaClase()
        {
           
            Productos producto = new Productos
            {
                Descripcion = TextBoxDescripcion.Text,
                Existencia = Convert.ToInt32(TextBoxExistencia.Text),
                Costo = Convert.ToDouble(TextBoxCosto.Text),
                ValorInventario = Convert.ToDouble(TextBoxValorInventario.Text),
                ProductosId = Convert.ToInt32(IDnumericUpDown.Value),
                UbicacionId = Convert.ToInt32(metroComboBox1.SelectedValue),
                PreciosDetalle = this.listaPreciosDetalle
                    
                };
                return producto;
        }

        public void LlenaCampos(Productos producto)
        {
            TextBoxDescripcion.Text = producto.Descripcion;
            TextBoxExistencia.Text = producto.Existencia.ToString();
            TextBoxCosto.Text = producto.Costo.ToString();
            TextBoxValorInventario.Text = producto.ValorInventario.ToString();
            IDnumericUpDown.Value = producto.ProductosId;
            metroComboBox1.SelectedValue = producto.UbicacionId;
            ActualizarGrid(producto.PreciosDetalle);
            
            
        }

        void ActualizarGrid(List<PrecioDetalle> lista)
        {
            this.dataGridView1.DataSource = lista;
            this.dataGridView1.Update();
        }

        public bool ValidarModificar()
        {
            if(!ValidarBuscar() ||  !ValidarGuardar())
            {
                return false;
            }
            return true;
        }

        private void ButtonBuscar_Click(object sender, EventArgs e)
        {
            if(ValidarBuscar() == false)
            {
                MessageBox.Show("No existe un producto con este ID");
                return;
            }
            LlenaCampos(ProductosBLL.Buscar(Convert.ToInt32(IDnumericUpDown.Value)));
        }

        private void ButtonGuardar_Click(object sender, EventArgs e)
        {
           
            if(IDnumericUpDown.Value > 0)
            {
                if(ValidarModificar())
                {
                    if(ProductosBLL.Modificar(LlenaClase()))
                    {
                        MessageBox.Show("El registro se actualizo correctamente");
                        LimpiarCampos();
                        return;
                    }
                } 

            } else
            {
                if (ValidarGuardar())
                {
                    if (ProductosBLL.Guardar(LlenaClase()) == true)
                    {
                        MessageBox.Show("El registro se guardo correctamente");
                        LimpiarCampos();
                        return;
                    }

                }
            }
            MessageBox.Show("Error al intentar guardar o modificar el registro!");
        }

        public List<Ubicaciones> ObtenerUbicaciones()
        {
            return UbicacionesBLL.GetList(x => true);
        }

        private void ButtonEliminar_Click(object sender, EventArgs e)
        {
            if(ValidarEliminar())
            {
                if(ProductosBLL.Eliminar(Convert.ToInt32(IDnumericUpDown.Value)))
                {
                    MessageBox.Show("Registro Eliminado Correctamente!");
                    LimpiarCampos();
                    return;
                }

                MessageBox.Show("Error al intentar eliminar el registro!");
            }
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            FUbicaciones FU = new FUbicaciones();
            FU.ShowDialog();
            this.LlenaCombo();
        }

        private void PreciosdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AgregarmetroButton_Click(object sender, EventArgs e)
        {
            if(ValidarPrecio())
            {
                PrecioDetalle precioDetalle = LlenaPrecio();
                this.listaPreciosDetalle.Add(precioDetalle);
                this.ActualizarGrid(listaPreciosDetalle);

            }
            


        }

        private PrecioDetalle LlenaPrecio()
        {
            return new PrecioDetalle() {
                    Precio = Convert.ToDouble(this.PreciometroTextBox.Text),
                    TipoPrecio = this.TipoPreciometroTextBox.Text
            };
        }

        private bool ValidarPrecio()
        {
            if(string.IsNullOrEmpty(this.PreciometroTextBox.Text) || string.IsNullOrEmpty(this.TipoPreciometroTextBox.Text))
            {
                return false;
            }

            return true;
        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
