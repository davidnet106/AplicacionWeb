using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppEmpleadosCrud.App
{
    public partial class Datos : System.Web.UI.Page
    {

        GestionDatos datos = new GestionDatos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnListarTodo_Click(object sender, EventArgs e)
        {
            List<Empleado> listaempleados = datos.LeerTodos();
            gvEmpleados.DataSource = listaempleados;
            gvEmpleados.DataBind();
        }

        protected void gvEmpleados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEmpleados.PageIndex = e.NewPageIndex;
            List<Empleado> listaempleados = datos.LeerTodos();
            gvEmpleados.DataSource = listaempleados;
            gvEmpleados.DataBind();
        }

        protected void BtnBuscarCodigo_Click1(object sender, EventArgs e)
        {
            if(datos.ExisteEmpleado(inCodigoBuscar.Text))
            {
                Response.Redirect("Formulario.aspx?id=" + inCodigoBuscar.Text);
            }else
            {
                LabelBuscar.Text = "No existe el código en la BD";
            }
        }

        

        protected void gvEmpleados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Select")
            {
                int indice = Convert.ToInt32(e.CommandArgument);
                string valor = Convert.ToString(gvEmpleados.DataKeys[indice].Value);
                //Response.Write("Valor de fila" + indice);
                //Response.Write("Valor de celda" + valor);
                Response.Redirect("Formulario.aspx?id=" + valor);
            }
        }
    }
}