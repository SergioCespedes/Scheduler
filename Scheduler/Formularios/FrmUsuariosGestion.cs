using Scheduler.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler.Formularios
{
    public partial class FrmUsuariosGestion : Form
    {
        //objeto local de tipo usuario. 
        private Logica.Models.Usuario MiUsuarioLocal { get; set; }

        public FrmUsuariosGestion()
        {
            InitializeComponent();

            MiUsuarioLocal = new Logica.Models.Usuario();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmUsuariosGestion_Load(object sender, EventArgs e)
        {
           // MdiParent = Globales.ObjetosGlobales.MiFormularioPrincipal;

            CargarComboRolesDeUsuario();

            CargarListaUsuarios(CbVerActivos.Checked);

            ActivarBotonAgregar();

        }

        private void CargarComboRolesDeUsuario()
        {
            Logica.Models.UsuarioRol MiRol = new Logica.Models.UsuarioRol();

            DataTable dt = new DataTable();

            dt = MiRol.Listar();

            if (dt != null && dt.Rows.Count > 0)
            {
                //una asegurado que el dt tiene valores, los "dibujo" en el combobox
                CboxUsuarioTipoRol.ValueMember = "id";
                CboxUsuarioTipoRol.DisplayMember = "Descripcion";

                CboxUsuarioTipoRol.DataSource = dt;

                CboxUsuarioTipoRol.SelectedIndex = -1;

            }

        }

        //todas las funcionalidades especificas y que se puedan reutilizar DEBEN 
        //ser encapsuladas 
        private void CargarListaUsuarios(bool VerActivos, string FiltroBusqueda = "")
        {
            Logica.Models.Usuario miusuario = new Logica.Models.Usuario();

            DataTable lista = new DataTable();


            if (VerActivos)
            {
                //si se queiren ver los usuarios activos
                lista = miusuario.ListarActivos(FiltroBusqueda);
                DgvListaUsuarios.DataSource = lista;
            }
            else 
            {
                //usuarios inactivos               
                lista = miusuario.ListarInactivos(FiltroBusqueda);
                DgvListaUsuarios.DataSource = lista;

            }

        }

        private bool ValidarDatosRequeridos(bool OmitirContrasennia = false)
        {
            bool R = false;

            //validar que se hayan digitado valores en los campos obligatorios
            if (!string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()) &&
                CboxUsuarioTipoRol.SelectedIndex > -1
                )
            {
                if (OmitirContrasennia)
                {
                    //Si se omite la contraseña entonces se pasa a true
                    R = true;
                }
                else
                {
                    //Si no se omite la contraseña debemos validar también ese campo
                    if (!string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        //CONTRASEÑA
                        if (string.IsNullOrEmpty(TxtUsuarioContrasennia.Text.Trim()))
                        {
                            MessageBox.Show("Debe digitar la Contraseña", "Error de validación", MessageBoxButtons.OK);
                            return false;
                        }
                    }
                }
            }
            else
            {
                //indicar al usuario qué validación está faltando

                //CEDULA
                if (string.IsNullOrEmpty(TxtUsuarioCedula.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar la Cédula", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //NOMBRE
                if (string.IsNullOrEmpty(TxtUsuarioNombre.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Nombre", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //CORREO
                if (string.IsNullOrEmpty(TxtUsuarioCorreo.Text.Trim()))
                {
                    MessageBox.Show("Debe digitar el Correo", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                //ROL DE USUARIO
                if (CboxUsuarioTipoRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe Seleccionar un Rol de Usuario", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

            }

            return R;
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //lo primero que debemos hacer es validar los datos mínimos requeridos, 
            //esto se hace para evitar que queden registros sin datos a nivel de db
            //pero también porque se un campo de base de datos no acepta valores NULL
            //y se llama al INSERT, dará un error. 

            //Luego de esto y tomando en consideración el diagrama de casos de uso expandido
            //de usuario, hay que hacer validar que NO exista un usuario con la cedula y/o 
            //correo que se digitaron. (No se pueden repetir estos datos en distintas
            //filas en la tabla Usuario

            //Si ambas validaciones son Negativas entonces se procede a Agregar() el usuario.

            //---------------------------------//

            //usaremos un objeto local de tipo Usuario, que será al que daremos forma para luego
            //usar las funciones como agregar, actualizar, eliminar, etc. 

            if (ValidarDatosRequeridos())
            {
                MiUsuarioLocal = new Logica.Models.Usuario();

                MiUsuarioLocal.Cedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.Nombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.Correo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.Telefono = TxtUsuarioTelefono.Text.Trim();

                //con el combo de rol hay que extraer el valuemember seleccionado. 
                MiUsuarioLocal.MiUsuarioRol.UsuarioRolID = Convert.ToInt32(CboxUsuarioTipoRol.SelectedValue);

                MiUsuarioLocal.Contrasennia = TxtUsuarioContrasennia.Text.Trim();
                MiUsuarioLocal.Direccion = TxtUsuarioDireccion.Text.Trim();

                bool CedulaOk = MiUsuarioLocal.ConsultarPorCedula(MiUsuarioLocal.Cedula);

                bool CorreoOk = MiUsuarioLocal.ConsultarPorCorreo(MiUsuarioLocal.Correo);

                if (CedulaOk == false && CorreoOk == false)
                {
                    //se solicita confirmación por parte del usuario 
                    string Pregunta = string.Format("¿Está seguro de agregar al usuario {0}?", MiUsuarioLocal.Nombre);
                    DialogResult respuesta = MessageBox.Show(Pregunta, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {
                        //procedemos a Agregar el usuario
                        bool ok = MiUsuarioLocal.Agregar();

                        if (ok)
                        {
                            MessageBox.Show("Usuario ingresado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            CargarListaUsuarios(CbVerActivos.Checked);

                        }
                        else
                        {
                            MessageBox.Show("El Usuario no se pudo agregar...", ":(", MessageBoxButtons.OK);
                        }
                    }
                }
            }
        }


        private void LimpiarForm()
        {
            TxtUsuarioCodigo.Clear();
            TxtUsuarioCedula.Clear();
            TxtUsuarioNombre.Clear();
            TxtUsuarioCorreo.Clear();
            TxtUsuarioTelefono.Clear();
            TxtUsuarioContrasennia.Clear();
            TxtUsuarioDireccion.Clear();

            CboxUsuarioTipoRol.SelectedIndex = -1;

            CbUsuarioActivo.Checked = false;

        }

        private void DgvListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //primero validamos que se haya seleccionado una linea del dgv, y que sea solo una
            if (DgvListaUsuarios.SelectedRows.Count == 1)
            {
                LimpiarForm();

                //como necesito consultar por el ID del usuario, se debe extraer el valor de la columna 
                //correspondiente del DGV, en este caso "ColUsuarioID"
                DataGridViewRow MiDgvFila = DgvListaUsuarios.SelectedRows[0];
                int IDUsuario = Convert.ToInt32(MiDgvFila.Cells["ColUsuarioID"].Value);

                MiUsuarioLocal = new Logica.Models.Usuario();
                MiUsuarioLocal = MiUsuarioLocal.ConsultarPorID(IDUsuario);

                if (MiUsuarioLocal != null && MiUsuarioLocal.UsuarioID > 0)
                {
                    //una vez que se ha asegurado que existe el usuario y que tiene datos se "dibujan" esos 
                    //datos en los controles correspondientes del formulario 

                    TxtUsuarioCodigo.Text = MiUsuarioLocal.UsuarioID.ToString();
                    TxtUsuarioCedula.Text = MiUsuarioLocal.Cedula;
                    TxtUsuarioNombre.Text = MiUsuarioLocal.Nombre;
                    TxtUsuarioCorreo.Text = MiUsuarioLocal.Correo;
                    TxtUsuarioTelefono.Text = MiUsuarioLocal.Telefono;
                    TxtUsuarioDireccion.Text = MiUsuarioLocal.Direccion;

                    //en este caso no quiere que se muestre la contraseña ya que está encriptada y no se 
                    //requiere actualizarla y se deja en blanco el campo de texto 

                    CboxUsuarioTipoRol.SelectedValue = MiUsuarioLocal.MiUsuarioRol.UsuarioRolID;
                    CbUsuarioActivo.Checked = MiUsuarioLocal.Activo;

                    ActivarBotonesModificarYEliminar();

                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            ActivarBotonAgregar();
        }

        private void ActivarBotonAgregar()
        {
            BtnAgregar.Enabled = true;
            BtnModificar.Enabled = false;
            BtnEliminar.Enabled = false;
        }

        private void ActivarBotonesModificarYEliminar()
        {
            BtnAgregar.Enabled = false;
            BtnModificar.Enabled = true;
            BtnEliminar.Enabled = true;
        }

        private void DgvListaUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //esto limpìa la seleccion de fila automática que es el comportamiento estándar del control
            DgvListaUsuarios.ClearSelection();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {

            //al igual que con el agregar, se deben validar los datos requeridos pero, 
            //el campo de la contraseña debe ser opcional en este caso 

            if (ValidarDatosRequeridos(true))
            {
                //transferimos al objeto local los posibles cambios que se hayan hecho en los datos del usuario

                MiUsuarioLocal.Nombre = TxtUsuarioNombre.Text.Trim();
                MiUsuarioLocal.Cedula = TxtUsuarioCedula.Text.Trim();
                MiUsuarioLocal.Correo = TxtUsuarioCorreo.Text.Trim();
                MiUsuarioLocal.Telefono = TxtUsuarioTelefono.Text.Trim();
                MiUsuarioLocal.MiUsuarioRol.UsuarioRolID = Convert.ToInt32(CboxUsuarioTipoRol.SelectedValue);
                MiUsuarioLocal.Direccion = TxtUsuarioDireccion.Text.Trim();

                //depende de si e digitó o no una contraseña, habrán dos distintos UPDATE en los SPs
                MiUsuarioLocal.Contrasennia = TxtUsuarioContrasennia.Text.Trim();

                //en el diagrama expandido de casos de uso para el tema Usuario, se indica 
                // que para modificar o eliminar primero se debe consultar por el ID
                if (MiUsuarioLocal.ConsultarPorID())
                {
                    DialogResult Resp = MessageBox.Show("¿Desea modificar el usuario?", "???",
                                                           MessageBoxButtons.YesNo);
                    if (Resp == DialogResult.Yes)
                    {
                        //procedemos a modificar el registro del usuario 
                        if (MiUsuarioLocal.Actualizar())
                        {
                            MessageBox.Show("Usuario modificado correctamente!", ":)", MessageBoxButtons.OK);

                            LimpiarForm();
                            CargarListaUsuarios(CbVerActivos.Checked);
                            ActivarBotonAgregar();
                        }
                    }
                }
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (CbVerActivos.Checked)
            {
                //se procede a eliminar
                if (MiUsuarioLocal.UsuarioID > 0)
                {
                    string msg = string.Format("Esta Seguro que quiere eliminar al usuario {0}?", MiUsuarioLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(msg, "Confirmacion requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes && MiUsuarioLocal.Eliminar())
                    {

                        MessageBox.Show("El usuario ha sido eliminado", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarForm();
                        CargarListaUsuarios(CbVerActivos.Checked);
                        ActivarBotonAgregar();

                    }
                }
            }
            else
            {
                //se re activa
                if (MiUsuarioLocal.UsuarioID > 0)
                {
                    string msg = string.Format("Esta Seguro que quiere activar al usuario {0}?", MiUsuarioLocal.Nombre);

                    DialogResult respuesta = MessageBox.Show(msg, "Confirmacion requerida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes && MiUsuarioLocal.Activar())
                    {

                        MessageBox.Show("El usuario ha sido activado", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarForm();
                        CargarListaUsuarios(CbVerActivos.Checked);
                        ActivarBotonAgregar();

                    }
                }
            }

        }

        private void TxtUsuarioCedula_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = Validaciones.CaracteresNumeros(e);

        }

        private void TxtUsuarioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtUsuarioCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e, false, true);
        }

        private void TxtUsuarioTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresNumeros(e);
        }

        private void TxtUsuarioContrasennia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void TxtUsuarioDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Validaciones.CaracteresTexto(e);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbVerActivos_CheckedChanged(object sender, EventArgs e)
        {

            CargarListaUsuarios(CbVerActivos.Checked);

            

            if (CbVerActivos.Checked)
            {
                BtnEliminar.Text = "ELIMINAR";
            }
            else
            {
                BtnEliminar.Text = "ACTIVAR";
            }

        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtBuscar.Text.Trim()) && TxtBuscar.Text.Count() >= 3)
            {

                CargarListaUsuarios(CbVerActivos.Checked, TxtBuscar.Text.Trim());

            }
            else 
            {
                CargarListaUsuarios(CbVerActivos.Checked);
            
            }
        }
    }
}
