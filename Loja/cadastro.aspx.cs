using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Loja
{
    public partial class WebForm1 : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            string usuario = "";
            string senha = "";
            try
            {
                usuario = Session["userCrip"].ToString();
                senha = Session["passCrip"].ToString();
                Response.Redirect("home.aspx");

            }
            catch
            {
                
            }
        }



        protected void btncadastrar_Click(object sender, EventArgs e)
        {



            /** CHECANDO NOME COMPLETO**/
            char[] delimiters = new char[] { ' ', '\r', '\n' };

            string nome = nome_usu.Text;
            int tamanho = nome.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;

            if (tamanho < 2)
            {
                erroCadastro.Attributes.CssStyle.Add("display", "block");
            }
            else
            {
                erroCadastro.Attributes.CssStyle.Add("display", "none");

                string cpf = cpf_usu.Text;
                cpf = cpf.Replace(".", "").Replace("-", "");
                bool todosSaoNumeros = cpf.All(char.IsDigit);


                if (!todosSaoNumeros)
                {
                    erroCadastro.Attributes.CssStyle.Add("display", "block");
                }
                else
                {
                    erroCadastro.Attributes.CssStyle.Add("display", "none");
                    if (!Validacao.IsCpf(cpf))
                    {
                        erroCadastro.Attributes.CssStyle.Add("display", "block");
                    }
                    else
                    {
                        erroCadastro.Attributes.CssStyle.Add("display", "none");
                        string email = email_usu.Text;

                        if (!Validacao.ValidarEmail(email))
                        {
                            erroCadastro.Attributes.CssStyle.Add("display", "block");
                        }
                        else
                        {
                            erroCadastro.Attributes.CssStyle.Add("display", "none");
                            string tel = tel_usu.Text;
                            string cel = cel_usu.Text;
                            string modeloTel = @"^\((\d{2})\)\s?(\d{4,5}\-?\d{4})$";
                            Match matchTel = Regex.Match(tel, modeloTel);
                            Match matchCel = Regex.Match(cel, modeloTel);

                            if (!matchTel.Success || !matchCel.Success)
                            {
                                erroCadastro.Attributes.CssStyle.Add("display", "block");
                            }
                            else
                            {
                                erroCadastro.Attributes.CssStyle.Add("display", "none");


                                string cep = cep_usu.Text;
                                cep = cep.Replace("-", "");

                                todosSaoNumeros = cep.All(char.IsDigit);


                                if (!todosSaoNumeros)
                                {
                                    erroCadastro.Attributes.CssStyle.Add("display", "block");
                                }
                                else
                                {


                                    if (!Validacao.ValidaCEP(cep))
                                    {
                                        erroCadastro.Attributes.CssStyle.Add("display", "block");
                                    }
                                    else
                                    {
                                        erroCadastro.Attributes.CssStyle.Add("display", "none");
                                        if (log_usu.Text == "" || numero_usu.Text == "" || bairro_usu.Text == "" || dica_senha.Text == "" || estado_usu.Text == "" || cidade_usu.Text == "")
                                        {
                                            erroCadastro.Attributes.CssStyle.Add("display", "block");
                                        }
                                        else
                                        {
                                            erroCadastro.Attributes.CssStyle.Add("display", "none");
                                            string senhaUsuario = senha.Text;

                                            string modeloSenha = @"^(?=.*[a-zA-Z])(?=.*\d).{7,30}$";

                                            Match matchSenha = Regex.Match(senhaUsuario, modeloSenha);

                                            if (!matchSenha.Success)
                                            {
                                                erroCadastro.Attributes.CssStyle.Add("display", "block");
                                            }
                                            else
                                            {
                                                erroCadastro.Attributes.CssStyle.Add("display", "none");
                                                string confirmaSenha = confirma_senha.Text;

                                                if (confirmaSenha != senhaUsuario)
                                                {
                                                    erroCadastro.Attributes.CssStyle.Add("display", "block");
                                                }
                                                else
                                                {
                                                    erroCadastro.Attributes.CssStyle.Add("display", "none");
                                                    Usuario objUsuario = new Usuario();
                                                    objUsuario.Bairro = bairro_usu.Text;
                                                    objUsuario.Celular = cel_usu.Text;
                                                    objUsuario.Cep = cep_usu.Text;
                                                    objUsuario.Cidade = cidade_usu.Text;
                                                    objUsuario.Cpf = cpf_usu.Text;
                                                    objUsuario.DicaSenha = dica_senha.Text;
                                                    objUsuario.Email = email_usu.Text;
                                                    objUsuario.Estado = estado_usu.Text;
                                                    objUsuario.Logradouro = log_usu.Text;
                                                    objUsuario.Nome = nome_usu.Text;
                                                    objUsuario.Numero = numero_usu.Text;
                                                    objUsuario.Senha = Criptografia.Codificar(senha.Text);
                                                    objUsuario.Telefone = tel_usu.Text;

                                                    DALUsuario dalUsu = new DALUsuario();
                                                    try
                                                    {
                                                        dalUsu.inserirUsuario(objUsuario);
                                                        infoCadastro.Attributes.CssStyle.Add("display", "block");
                                                    }
                                                    catch (Exception)
                                                    {
                                                        alertaCadastro.Attributes.CssStyle.Add("display", "block");
                                                   
                                                    }
                                                    
                                                }
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}