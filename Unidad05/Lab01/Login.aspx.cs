﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkRecordarClave_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx?msj=Es usted un usuario muy boludo");
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.ToLower() == "admin" && txtClave.Text == "admin")
            {
                Page.Response.Write("Ingreso OK");
            }
            else
            {
                Page.Response.Write("Usuario y/o contraseña incorrectos");
            }

        }
    }
}