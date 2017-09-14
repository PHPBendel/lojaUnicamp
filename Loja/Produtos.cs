using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace Loja
{
    public class Produtos
    {
        public string Montar_produtos()
        {
                string query = "";
                query = @"SELECT p.id,p.descricao_completa,
                        p.preco,p.nome,im.imagem,p.desc1,p.desc2,p.desc3,p.quantidade
                        FROM dbo.produto p INNER JOIN dbo.imagem_produto im ON im.id = p.fk_id_imagem";
                SqlCommand comm = new SqlCommand(query, Conexao.connection());
                SqlDataReader sdt = comm.ExecuteReader();
                StringBuilder divProduto = new StringBuilder();
            while (sdt.Read())
            {
                divProduto.AppendLine(@"
                       <div class='container'>
        <div class='modal fade' id='detalhes" + sdt["id"].ToString() + @"'role='dialog'>
            <div class='modal-dialog modal-lg'>
                <div class='modal-content'>
                    <div class='modal-header'>
                        <button type='button' class='close' data-dismiss='modal'>&times;</button>
                        <h2 class='modal-title'><b>UNISHOP - Detalhes</b></h2>
                    </div>
                    <div class='modal-body'>
                        <div class='alert alert-danger' id='alertasd" + sdt["id"].ToString() + @"' hidden='true'>
                            <p>Mensagem de erro</p>
                        </div>
                        <div class='alert alert-info' id='alertasi" + sdt["id"].ToString() + @"' hidden='true'>
                            <p>Mensagem</p>
                        </div>
                        <div class='alert alert-warning' id='alertasw" + sdt["id"].ToString() + @"' hidden='true'>
                            <p>Alertas</p>
                        </div>
                        <div class='col-md-4 text-center'>
                            <div class='panel  panel-pricing'>
                                <div class='panel-heading'>
                                    <img alt='" + sdt["nome"].ToString() + @"' style='width: 200px;' src='img/" + sdt["imagem"].ToString() + @"' />
                                    <h3><b>" + sdt["nome"].ToString() + @"</b></h3>
                                </div>
                                <div class='panel-body text-center'>
                                    <p><strong>" + sdt["preco"].ToString() + @"</strong></p>
                                </div>
                                <ul class='list-group text-center'>
                                    <li class='list-group-item'><i class='fa fa-check'></i>" + sdt["desc1"].ToString() + @"</li>
                                    <li class='list-group-item'><i class='fa fa-check'></i>" + sdt["desc2"].ToString() + @"</li>
                                    <li class='list-group-item'><i class='fa fa-check'></i>" + sdt["desc3"].ToString() + @"</li>
                                </ul>
                                <div class='panel-footer'>
                                    <a id='adicionar" + sdt["id"].ToString() + @"' onclick=""acrescentar('" + sdt["id"].ToString()+@"')"" style='font-size: 16px' class='btn btn-lg btn-block btn-success adicionar'><i style='font-size: 20px' class='fa fa-cart-arrow-down'></i>&nbsp;&nbsp; Adicionar ao Carrinho!</a>
                                </div>
                            </div>
                        </div>
                        <div class='col-md-4 text-center' style='width: 560px;'>
                            <div class='panel  panel-pricing'>
                                <div class='panel-heading'>
                                    <img alt='" + sdt["nome"].ToString() + @"' style='width: 460px;' src='img/"+ sdt["imagem"].ToString() + @"' />
                                </div>
                                <ul class='list-group text-center'>
                                    <b>" + sdt["descricao_completa"].ToString() + @"</b>
                                </ul>
                                <div class='panel-footer'>
                                    <b>5x no Cartão de Crédito ou 10% de desconto no Boleto Bancário</b>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class='modal-footer'>
                    </div>
                </div>
            </div>
        </div>
    </div>


                ");
                divProduto.AppendLine("<section id = \"plans" + sdt["id"].ToString() + "\" > ");
                divProduto.AppendLine(" <div class=\"container\">");
                divProduto.AppendLine(" <div class=\"alert alert-danger\" id='alertasmd" + sdt["id"].ToString() + @"' hidden='true'>");
                divProduto.AppendLine("  <p>Mensagem de erro</p>");
                divProduto.AppendLine("  </div>");
                divProduto.AppendLine("   <div class=\"alert alert-info\" id=\"alertasmi" + sdt["id"].ToString() + "\" hidden='true'> ");
                divProduto.AppendLine(" <p>Mensagem</p>");
                divProduto.AppendLine(" </div>");
                divProduto.AppendLine("  <div class=\"alert alert-warning\" id=\"alertasmw" + sdt["id"].ToString() + "\" hidden='true'> ");
                divProduto.AppendLine("  <p>Alertas</p>");
                divProduto.AppendLine("</div>");
                divProduto.AppendLine(" <div class=\"row\">");
                divProduto.AppendLine(" <div class=\"col-md-4 text-center\">");
                divProduto.AppendLine("<div class=\"panel  panel-pricing\">");
                divProduto.AppendLine("<div class=\"panel-heading\">");
                divProduto.AppendLine("  <img alt = '" + sdt["nome"].ToString() +"' style=\"width: 200px; \" src=\"img/"+sdt["imagem"].ToString()+"\" />");
                divProduto.AppendLine("    <h3>"+sdt["nome"].ToString()+"</h3>");
                divProduto.AppendLine("</div>");
                divProduto.AppendLine("<div class=\"panel-body text-center\">");
                divProduto.AppendLine("<p><strong>R$ "+ sdt["preco"].ToString() +"</strong></p>");
                divProduto.AppendLine("</div>");
                divProduto.AppendLine("<ul class=\"list-group text-center\">");
                divProduto.AppendLine("<li class=\"list-group-item\"><i class=\"fa fa-check\"/></i>"+sdt["desc1"].ToString()+"</li>");
                divProduto.AppendLine("     <li class=\"list-group-item\"><i class=\"fa fa-check\"></i>" + sdt["desc2"].ToString() + "</li>");
                divProduto.AppendLine("         <li class=\"list-group-item\"><i class=\"fa fa-check\"></i>" + sdt["desc3"].ToString() + "</li>");
                divProduto.AppendLine("</ul>");
                divProduto.AppendLine("<div class=\"panel-footer\">");
                divProduto.AppendLine(" <a class=\"btn btn-lg btn-block btn-danger\" data-toggle=\"modal\" data-target=\"#detalhes" + sdt["id"].ToString() + "\"><i class=\"	fa fa-plus-circle\" style=\"font-size: 20px\"></i>&nbsp;&nbsp;&nbsp;&nbsp; Ver detalhes!</a>");
                divProduto.AppendLine(" <a class=\"btn btn-lg btn-block btn-success adicionar\" onclick=\"acrescentar('" + sdt["id"].ToString() + "')\" id='adicionarM" + sdt["id"].ToString() + "'><i style = \"font-size: 25px\" class=\"fa fa-cart-arrow-down\"></i>&nbsp;&nbsp;&nbsp;&nbsp; Adicionar ao Carrinho!</a>");
                divProduto.AppendLine("  </div>");
                divProduto.AppendLine(" </div>");
                divProduto.AppendLine("</div>");
                divProduto.AppendLine(" </div>");

                divProduto.AppendLine("</div>");
                divProduto.AppendLine("</section>");
             }
                return divProduto.ToString();
        }
    }
}