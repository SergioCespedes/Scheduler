using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models {
    public class Hora {
        public TimeSpan horaInicio {  get; set; }
        public TimeSpan horaFinal {  get; set; }
        public int idhora { get; set; }

        public bool Agregar() {
            bool ret = false;
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@horaInicio", this.horaInicio));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@horaFinal", this.horaFinal));
            int resultado = MiCnn.EjecutarDML("AgregarHora");
            if (resultado > 0) ret = true;
            return ret;
        }

        public bool Actualizar() {
            bool ret = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@idHora", this.idhora));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@horainicio", this.horaInicio));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@horaFin", this.horaFinal));

            int resultado = MiCnn.EjecutarDML("ActualizarHora");
            if (resultado > 0) ret = true;

            return ret;
        }

        public bool Eliminar() {
            bool ret = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@idHora", this.idhora));
            int resultado = MiCnn.EjecutarDML("EliminarHora");
            if (resultado > 0) ret = true;

            return ret;
        }
        public DataTable Listar() {
            Conexion MiCnn = new Conexion();
            DataTable ret = MiCnn.EjecutarSELECT("ListarHoras");
            return ret;
        }
        public DataTable ListarCmb()
        {
            Conexion MiCnn = new Conexion();
            DataTable ret = MiCnn.EjecutarSELECT("ListarHorasCmb");
            return ret;
        }

        public bool ConsultarPorID() {
            bool ret = false;

            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@idHora", this.idhora));
            DataTable datosHora = new DataTable();
            datosHora = MiCnn.EjecutarSELECT("ConsultarHora");

            if (datosHora != null && datosHora.Rows.Count > 0) {
                ret = true;
            }

            return ret;
        }

        public Hora ConsultarPorID(int idHora) {
            Hora ret = new Hora();
            Conexion MiCnn = new Conexion();
            MiCnn.ListaDeParametros.Add(new SqlParameter("@idHora", idHora));
            DataTable datosHora = new DataTable();
            datosHora = MiCnn.EjecutarSELECT("ConsultarHora");

            if (datosHora != null && datosHora.Rows.Count > 0) {
                DataRow MiFila = datosHora.Rows[0];
                ret.idhora = Convert.ToInt32(MiFila["idHora"]);
                ret.horaInicio = Convert.ToDateTime(MiFila["HoraInicio"]).TimeOfDay;
                ret.horaFinal = Convert.ToDateTime(MiFila["HoraFinal"]).TimeOfDay;
            }
            return ret;
        }
    }
}
