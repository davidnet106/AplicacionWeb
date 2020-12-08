using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppEmpleadosCrud.App
{
    public partial class Formulario : System.Web.UI.Page
    {
        ValidarCajas validar = new ValidarCajas();
        GestionDatos datos = new GestionDatos();
        protected void Page_Load(object sender, EventArgs e)
        {
            // cuando carga el formulario
           if(!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    InCodigo.Text = Request.QueryString["id"];
                    Empleado myEmpleado = datos.consultaEmpleado(InCodigo.Text);
                    InNombre.Text = myEmpleado.Nombre;
                    InApellido.Text = myEmpleado.Apellido;
                    InCargo.Text = myEmpleado.Cargo;
                    InSalario.Text = myEmpleado.Salario;
                    InArea.Text = myEmpleado.Area;
                    InCiudad.Text = myEmpleado.Ciudad;
                    BtnAgregarEmpleado.Visible = false;
                    BtnEditarEmpleado.Visible = true;
                    BtnBorrarEmpleado.Visible = true;
                    InCodigo.Enabled = false;
                }
                else
                {
                    InCodigo.Enabled = true;
                    BtnAgregarEmpleado.Visible = true;
                    BtnEditarEmpleado.Visible = false;
                    BtnBorrarEmpleado.Visible = false;
                    return;
                }
               
            }
        }

    protected void BtnAgregarEmpleado_Click(object sender, EventArgs e)
    {
            //enviar datos
            if (!validar.Vacio(InCodigo, ErrorCodigo, "El campo no puede estar vacío"))
                if (!validar.Vacio(InNombre, ErrorNombre, "El campo no puede estar vacío"))
                    if (!validar.Vacio(InApellido, ErrorApellido, "El campo no puede estar vacío"))
                        if (!validar.Vacio(InCargo, ErrorCargo, "El campo no puede estar vacío"))
                            if (!validar.Vacio(InSalario, ErrorSalario, "El campo no puede estar vacío"))
                                if (!validar.Vacio(InArea, ErrorArea, "El campo no puede estar vacío"))
                                    if (!validar.Vacio(InCiudad, ErrorCiudad, "El campo no puede estar vacío"))
                                    {
                                        InsertarDatosBD();
                                    }
    }

        private void InsertarDatosBD()
        {
            Empleado myEmpleado = new Empleado();
            myEmpleado.Codigo = InCodigo.Text;
            myEmpleado.Nombre = InNombre.Text;
            myEmpleado.Apellido = InApellido.Text;
            myEmpleado.Cargo = InCargo.Text;
            myEmpleado.Salario = InSalario.Text;
            myEmpleado.Area = InArea.Text;
            myEmpleado.Ciudad = InCiudad.Text;

            if (datos.ExisteEmpleado(InCodigo.Text))
            {
                if (datos.InsertarEmpleadoBD(myEmpleado))
                {
                    LabelRta.Text = "El Registro se agregó de forma correcta";
                }
                else
                {
                    LabelRta.Text = "Error al ingresar la información" + datos.error;
                }
               
            }    
            else
            {
                ErrorCodigo.Text = "El código "+ InCodigo.Text + " ya existe en la base";
            }
        }

        private void LimpiarCampos()
        {
            InCodigo.Text = "";
            InNombre.Text = "";
            InApellido.Text = "";
            InCargo.Text = "";
            InSalario.Text = "";
            InArea.Text = "";
            InCiudad.Text = "";
        }

        protected void InCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnEditarEmpleado_Click(object sender, EventArgs e)
        {
            Empleado myEmpleado = new Empleado();
            myEmpleado.Codigo = InCodigo.Text;
            myEmpleado.Nombre = InNombre.Text;
            myEmpleado.Apellido = InApellido.Text;
            myEmpleado.Cargo = InCargo.Text;
            myEmpleado.Salario = InSalario.Text;
            myEmpleado.Area = InArea.Text;
            myEmpleado.Ciudad = InCiudad.Text;

            if(datos.EditarEmpleadoBD(myEmpleado))
            {
                LabelRta.Text = "El registro fue actualizado correctamente. ";
            }
            else
            {
                LabelRta.Text = "Error al actualizar " + datos.error;
            }
        }

        protected void BtnBorrarEmpleado_Click(object sender, EventArgs e)
        {
            if (datos.EliminarEmpleadoBD(InCodigo.Text))
            {
                LabelRta.Text = "El registro fue borrado correctamente.";
                LimpiarCampos();
            }
            else
            {
                LabelRta.Text = "Error al borrar " + datos.error;
            }
        }
    }



}



    

