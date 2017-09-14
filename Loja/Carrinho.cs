using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Loja
{
    public class Carrinho
    {

        public string MontaCarrinhoVazio() {

            StringBuilder divCarrinho = new StringBuilder();
            divCarrinho.AppendLine(@"
      <section id = 'carrinhovazio' >
         <div class='container'>
            <div class='row'>
                <div class='col-md-12'>
                    <div class='list-group'>
                        <div class='list-group-item' style='min-height: 175px;'>
                            <div class='list-group-item-text'>
                                <h2 style = 'text-align: center;' > Não há produtos em seu carrinho.</h2>
                                <table>
                                    <tr>
                                        <td>
                                            <span style = 'font-size: 100px;' class='glyphicon'>&#xe116;</span>
                                        </td>
                                        <td>
                                            <p style = 'text-align: center; font-size: 18px;' >
                                                Para inserir algum produto no seu carrinho, navegue pelos departamentos ou utilize a busca do 
                                site.Ao encontrar os itens desejados, clique no botão 'Adicionar ao Carrinho' localizado na página do produto.
                                           
                                            </p>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        </section>");

            return divCarrinho.ToString();
        }
        public string MontaCarrinho() {


            StringBuilder divCarrinho = new StringBuilder();
            divCarrinho.AppendLine(@"
        <section id = 'carrinho' >
         <div class='container'>
            <div class='row'>
                <div class='col-md-12'>
                    <div class='list-group'>
                        <div class='list-group-item'>
                            <div class='list-group-item-text'>
                                <table class='table'>
                                    <tr>
                                        <td>
                                            <h2>Meu Carrinho</h2>
                                        </td>
                                        <td style = 'text-align: right;' >
                                            < span style= 'font-size: 50px;' class='glyphicon'>&#xe116;</span>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <p class='subtitulo'>Confira os itens adicionados</p>
                                        </td>
                                    </tr>
                                </table>
                                <div class='alert alert-danger' id='alertasdc' hidden='true'>
                                    <p>Mensagem de erro</p>
                                </div>
                                <div class='alert alert-info' id='alertasic' hidden='true'>
                                    <p>Mensagem</p>
                                </div>
                                <div class='alert alert-warning' id='alertaswc' style='' hidden='true'>
                                    <p>Alertas</p>
                                </div>
                                <table class='table'>
                                    <tr>
                                        <td>
                                            <asp:Button ID = 'continuarComprando' Class='btn btn-warning' runat='server' Text='Continuar Comprando' />
                                        </td>
                                        <td style = 'text-align: right;' >
                                            < asp:Button ID = 'finalizarCompra' Class='btn btn-success' runat='server' Text='Finalizar Compra' />
                                        </td>
                                    </tr>
                                </table>
                            </div>
                            <table class='table table-responsive' id='produtos'>
                                <thead>
                                    <tr>
                                        <th>Produto</th>
                                        <th style = 'text-align: center;' > Detalhes </ th >
                                        < th style='text-align: center'>Quantidade</th>
                                        <th style = 'text-align: center' > Valor Unitário</th>
                                        <th style = 'text-align: right' > Valor Total</th>
                                    </tr>
                                </thead>
                                <tr>
                                    <td style = 'vertical-align: middle;' >
                                        < img alt='Boné UNICAMP branco' style='width: 100px;' src='img/bonep.jpg' />Boné Unicamp</td>
                                    <td style = 'vertical-align: middle; text-align: center' >


                                         < asp:LinkButton data-toggle= 'modal' data-target= '#detalhes' class='' ID='LinkButton1' runat='server'><span style = 'font-size:20px;' class='glyphicon glyphicon-plus-sign'></span></asp:LinkButton></td>
                                    <td style = 'vertical-align: middle; text-align: center' >
                                        < asp:TextBox value = '2' ID='TextBox7' type='number' Width='80' runat='server'></asp:TextBox></td>
                                    <td style = 'vertical-align: middle; text-align: center' class=''>R$ 35,90</td>
                                    <td style = 'vertical-align: middle; text-align: right' class='' data-id='subTotalProdutos'>R$ 71,80</td>
                                </tr>
                                <tr>
                                    <td style = 'vertical-align: middle;' >
                                        < img alt='Boné UNICAMP branco' style='width: 100px;' src='img/bonep.jpg' />Boné Unicamp</td>
                                    <td style = 'vertical-align: middle; text-align: center' >


                                         < asp:LinkButton data-toggle= 'modal' data-target= '#detalhes' class='' ID='LinkButton2' runat='server'><span style = 'font-size:20px;' class='glyphicon glyphicon-plus-sign'></span></asp:LinkButton></td>
                                    <td style = 'vertical-align: middle; text-align: center' >
                                        < asp:TextBox value = '1' ID='TextBox6' type='number' Width='80' runat='server'></asp:TextBox></td>
                                    <td style = 'vertical-align: middle; text-align: center' class=''>R$ 35,90</td>
                                    <td style = 'vertical-align: middle; text-align: right' class='' data-id='subTotalProdutos'>R$ 35,90</td>
                                </tr>
                            </table>
                            <table class='table table-striped'>
                                <tr>
                                    <td></td>
                                    <td style = 'text-align: right;' >< b style='font-size: 18px;'>Total de Produtos</b>
                                    </td>
                                    <td style = 'text-align: right;' >< b style='font-size: 18px;'>R$ 107,70</b>
                                    </td>
                                </tr>
                                <tr>
                                    <td style = 'vertical-align: middle;' >
                                        < span >< b style='font-size: 14px;'>Calcular Frete</b></span>
                                        <asp:TextBox ID = 'TextBox8' placeholder= 'CEP' runat= 'server' ></ asp:TextBox>
                                        <a href = 'http://www.buscacep.correios.com.br/sistemas/buscacep/' target= '_blank' > Não Sei Meu CEP</a>
                                       </td>
                                    <td style = 'text-align: right; vertical-align: middle;' >


                                           < b style= 'font-size: 18px;' > Valor do Frete</b>
                                       </td>
                                    <td style = 'text-align: right; vertical-align: middle;' >


                                           < b style= 'font-size: 18px;' > R$ 20,00</b>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <span>Previsão de Entrega considerando a entrega de tipo 'normal'
                                           
                                            <br>

                                               e para pedidos feitos e aprovados até as 20h.Após este horário<br>
                                               acrescentar 1 dia útil.<br>

                                               Para consultar a Previsão de Entrega de uma Entrega Agendada
                                           
                                            <br>
                                            continue com a finalização da sua compra.
                                        </span>
                                    </td>
                                    <td style = 'text-align: right; vertical-align: middle;' >


                                           < b style= 'font-size: 18px;' > Valor Total</b>
                                       </td>
                                    <td style = 'text-align: right; vertical-align: middle;' >


                                           < b style= 'font-size: 18px;' > R$ 127,70</b>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>");

            return divCarrinho.ToString();
        }

    }
}