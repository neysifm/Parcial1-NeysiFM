using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_NeysiFM.BLL
{
    public interface IFormularioRegistro<T>
    {
        bool ValidarCampos();
        bool ValidarBuscar();
        bool ValidarEliminar();
        bool ValidarGuardar();
        void LimpiarCampos();
        T LlenaClase();
        void LlenaCampos(T obj);


    }
}
