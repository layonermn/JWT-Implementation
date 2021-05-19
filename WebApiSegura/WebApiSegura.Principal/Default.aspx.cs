using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.IO;
using System.Net;
using System.Text;

namespace WebApiSegura.Principal
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {

                }
                catch (Exception)
                {
                    throw new Exception("Internal error.");
                }
            }
        }

        protected void btnConsumir_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResultado.ForeColor = System.Drawing.Color.Green;
                this.txtResultado.Text = string.Empty;

                string Username = this.txtUsername.Text;
                string Password = this.txtPassword.Text;

                string Url = $"http://localhost:63227/api/login/authenticate";
                StringBuilder jsonData = new StringBuilder();
                jsonData.Append("{");
                jsonData.Append(" 'Username':'").Append(Username).Append("'").Append(",");
                jsonData.Append(" 'Password':'").Append(Password).Append("'");
                jsonData.Append("}");

                string AutToken
                            = new WebApiSegura.Repositorios.UsuariosRepositorio()
                                        .get_UsuarioAutorizacionToken(Url, jsonData.ToString(), "POST");

                this.txtResultado.Text = AutToken;
            }
            catch (Exception ex)
            {
                this.txtResultado.Text = ex.Message;
                this.txtResultado.ForeColor = System.Drawing.Color.Red;
            }


        }
    }
}