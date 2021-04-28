using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CAPA_PRESENTACION
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["sesionNombre"].ToString() != "gabriel" && Session["sesionApellido"].ToString() != "cadena") 
                {


                    Response.Redirect("administrador.aspx");

                } else{
                    txtnombre.Text = Session["sesionNombre"].ToString;
                    txtcontraseña.Text = Session["sesionApellido"].ToString;

                }                catch (Exception)

            {
                Response.Redirect("administrador.aspx");
            }
        }


    }
}