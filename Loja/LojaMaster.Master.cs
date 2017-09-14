using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Loja
{
    public partial class LojaMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string usuario = "";
            string senha = "";
            try
            {
                usuario = Session["userCrip"].ToString();
                senha = Session["passCrip"].ToString();
                login_modal.Attributes.CssStyle.Add("display", "none");
                cadastro.Attributes.CssStyle.Add("display", "none");
                deslogar.Attributes.CssStyle.Add("display", "block");

            }
            catch
            {
                if ((usuario == "") || (senha) == "")
                    deslogar.Attributes.CssStyle.Add("display", "none");
                    login_modal.Attributes.CssStyle.Add("display", "block");
                   cadastro.Attributes.CssStyle.Add("display", "block");
            }


        }

        protected void btnlogar_Click(object sender, EventArgs e)
        {
            if ((login.Text == "") || (senha.Text == ""))
               alertaLogin.Attributes.CssStyle.Add("display", "block");
            else
            {
                string query = "Select Count(*) From usuario where email = @login and Senha = @senha";

                SqlCommand comm = new SqlCommand(query, Conexao.connection());
                comm.Parameters.AddWithValue("@Login", login.Text);
                comm.Parameters.AddWithValue("@Senha", Criptografia.Codificar(senha.Text));

                int nroUsuarios = Convert.ToInt32(comm.ExecuteScalar());
                if (nroUsuarios > 0)
                {

                    string userCrip = Criptografia.Codificar(login.Text);
                    string passCrip = Criptografia.Codificar(senha.Text);
                    Session["userCrip"] = userCrip;
                    Session["passCrip"] = passCrip;
                    Response.Redirect("home.aspx");
                }
                else
                {
                    erroLogin.Attributes.CssStyle.Add("display", "block");

                }
            }
        }

        protected void produtos_Click(object sender, EventArgs e)
        {
            Response.Redirect("produtos.aspx");
        }

        protected void fale_conosco_Click(object sender, EventArgs e)
        {
            
        }

        protected void cadastro_Click(object sender, EventArgs e)
        {
            Response.Redirect("cadastro.aspx");
        }

        protected void meu_carrinho_Click(object sender, EventArgs e)
        {
            Response.Redirect("carrinho.aspx");
        }

        protected void meus_pedidos_Click(object sender, EventArgs e)
        {
            Response.Redirect("meusPedidos.aspx");
        }

        protected void inicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("cadastro.aspx");
        }

        protected void deslogar_Click(object sender, EventArgs e)
        {
            Session.Remove("userCrip");
            Session.Remove("passCrip");
            Response.Redirect("home.aspx");
        }
    }
}