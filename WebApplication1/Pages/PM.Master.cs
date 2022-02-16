using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace WebApplication1.Pages
{
    public partial class PM : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ESTO LO EJECUTARÍA AL CAMBIO PERO NO SIRVE, CUANDO CAMBIAS DE PANTALLA NO SACA EL EFECTO.
            //this.nav_default.Attributes.CssStyle.Add("background-color", "white");


            // ENCONTRE ESTA SOLUCION, NO ES DINAMICA COMO LO HIZO EL TIPO EN https://www.youtube.com/watch?v=BNLEbjNnjOY&t=2499s, 
            // PERO AL MENOS LO HACE Y CREO QUE ES SIMPLE.. 
            string javaScript = "creaPestana();";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", javaScript, true);
        }
    }
}