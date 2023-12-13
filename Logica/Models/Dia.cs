using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Dia
    {
        public int idDia { get; set; }
        public string descripcion { get; set; }

        public DataTable Listar()
        {
            Conexion MiCnn = new Conexion();
            DataTable ret = MiCnn.EjecutarSELECT("ListarDias");
            return ret;
        }
    }
}
