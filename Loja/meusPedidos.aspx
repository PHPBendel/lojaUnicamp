<%@ Page Title="" Language="C#" MasterPageFile="~/LojaMaster.Master" AutoEventWireup="true" CodeBehind="meusPedidos.aspx.cs" Inherits="Loja.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <!--Meus Pedidos-->
    <div id="pedidosdiv">
        <div class="page-header">
            <div class="container">
                <div class="row">
                    <h2>Meus Pedidos</h2>
                </div>
            </div>
        </div>
    </div>
    <section id="meusPedidos">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="list-group">

                        <div class="list-group-item" style="min-height: 175px;">
                            <div class="list-group-item-text">
                                <table class="table">
                                    <tr>
                                        <th>Pedido Nº 12/2534-2017</th>
                                        <th>Descrição</th>
                                        <th>Quantidade</th>
                                        <th>Data </th>
                                        <th>Valor</th>
                                        <th><a data-toggle="modal" data-target="#detalhesPedido" class="btn btn-primary btn-xs">Detalhes do pedido</a></th>
                                    </tr>
                                    <tr>
                                        <td style="vertical-align: middle;">
                                            <img alt="Boné UNICAMP branco" style="width: 100px;" src="img/bonep.jpg" />
                                        </td>
                                        <td style="vertical-align: middle;">BONÉ UNICAMP</td>
                                        <td style="vertical-align: middle;">2</td>
                                        <td style="vertical-align: middle;">16/05/2017</td>
                                        <td style="vertical-align: middle;">R$ 1,99</td>
                                        <td style="vertical-align: middle;"><a class="btn btn-sm btn-block btn-primary" data-toggle="modal" data-target="#detalhes"><i class="fa fa-plus-circle" style="font-size: 13px"></i>&nbsp;&nbsp; Detalhes Produto </a></td>
                                    </tr>
                                    <tr>
                                        <td style="vertical-align: middle;">
                                            <img alt="Boné UNICAMP branco" style="width: 100px;" src="img/bonep.jpg" />
                                        </td>
                                        <td style="vertical-align: middle;">BONÉ UNICAMP</td>
                                        <td style="vertical-align: middle;">4</td>
                                        <td style="vertical-align: middle;">16/05/2017</td>
                                        <td style="vertical-align: middle;">R$ 1,99</td>
                                        <td style="vertical-align: middle;"><a class="btn btn-sm btn-block btn-primary" data-toggle="modal" data-target="#detalhes"><i class="fa fa-plus-circle" style="font-size: 13px"></i>&nbsp;&nbsp; Detalhes Produto</a></td>
                                    </tr>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!--Meus Pedidos-->



    <!--MODAL PEDIDO -->
    <div class="container">
        <div class="modal fade" id="detalhesPedido" role="dialog">
            <div class="modal-dialog modal-xl">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h2 class="modal-title"><b>UNISHOP - Detalhes</b></h2>
                    </div>
                    <div class="modal-body">
                        <div class="col-md-12 text-left">
                            <div class="panel  panel-default">
                                <div class="panel-heading">

                                    <h3><b>Informações do pedido: 12/2534-2017</b></h3>
                                    <p>Pedido feito no dia: 18/05/2017 às 20:22</p>
                                </div>
                                <div class="panel-body text-left">
                                    <div class="panel  panel-default">
                                        <div class="panel-heading">
                                            <h4><strong>Status do pedido</strong></h4>

                                            <br />
                                            <table>
                                                <tr>
                                                    <td style="padding-right: 15px;"><i class="glyphicon glyphicon-ok" style="color: forestgreen; vertical-align: top;"></i></td>

                                                    <td style="padding-right: 15px;" class="text-left">
                                                        <p>

                                                            <strong>Recebemos seu pedido</strong><br />
                                                        </p>
                                                        <p>
                                                            18/05/2017 às 21:05
                                                       
                                                        </p>
                                                    </td>
                                                    <td style="padding-right: 15px;"><i class="glyphicon glyphicon-chevron-right"></i></td>
                                                    <td style="padding-right: 15px;"><i class="glyphicon glyphicon-ok" style="color: forestgreen; vertical-align: top;"></i></td>

                                                    <td style="padding-right: 15px;" class="text-left">
                                                        <p>

                                                            <strong>Aguardando pagamento</strong><br />
                                                        </p>
                                                        <p>
                                                            18/05/2017 às 21:05
                                                       
                                                        </p>
                                                    </td>

                                                    <td style="padding-right: 15px;"><i class="glyphicon glyphicon-chevron-right"></i></td>
                                                    <td style="padding-right: 15px;"><i class="glyphicon glyphicon-ok" style="color: forestgreen; vertical-align: top;"></i></td>

                                                    <td style="padding-right: 15px;" class="text-left">
                                                        <p>

                                                            <strong>Pagamento confirmado</strong><br />
                                                        </p>
                                                        <p>
                                                            18/05/2017 às 21:05
                                                       
                                                        </p>
                                                    </td>
                                                    <td style="padding-right: 15px;"><i class="glyphicon glyphicon-chevron-right"></i></td>
                                                    <td style="padding-right: 15px;"><i class="glyphicon glyphicon-ok" style="color: forestgreen; vertical-align: top;"></i></td>

                                                    <td class="text-left" width="200px">
                                                        <p>

                                                            <strong>Pedido em transporte</strong><br />
                                                        </p>
                                                        <p>
                                                            18/05/2017 às 21:05
                                                       
                                                        </p>
                                                    </td>
                                                    <td style="padding-right: 15px;"><i class="glyphicon glyphicon-chevron-right"></i></td>
                                                    <td style="padding-right: 15px;"><i class="glyphicon glyphicon-ok" style="color: forestgreen; vertical-align: top;"></i></td>

                                                    <td style="padding-right: 15px;" class="text-left">
                                                        <p>

                                                            <strong>Pedido entregue</strong><br />
                                                        </p>
                                                        <p>
                                                            18/05/2017 às 21:05
                                                       
                                                        </p>
                                                    </td>
                                                </tr>
                                            </table>

                                        </div>
                                    </div>

                                    <div class="panel  panel-default">
                                        <div class="panel-heading">
                                            <h4><strong>Endereços</strong></h4>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td width="230px" style="padding-right: 15px;">
                                                        <p><strong>Endereço de cobrança:</strong></p>

                                                        <p>
                                                            Rua Dracena 189, 13940-000
                                                            Águas de Lindóia - SP
                                                       
                                                        </p>
                                                    </td>
                                                    <td width="200px" style="padding-right: 15px;">
                                                        <p><strong>Endereço de entrega:</strong></p>

                                                        <p>
                                                            Rua Dracena 1829, 13940-000
                                                            Águas de Lindóia - SP
                                                       
                                                        </p>
                                                    </td>

                                                </tr>

                                            </table>
                                        </div>
                                    </div>
                                    <div class="panel  panel-default">
                                        <div class="panel-heading">
                                            <h4><strong>Informações do pagamento</strong></h4>
                                            <br />
                                            <table>
                                                <tr>
                                                    <td width="230px" style="padding-right: 15px;">
                                                        <p><strong>Valor total do pedido:</strong></p>

                                                        <p>
                                                            R$ 1 MILHÃO
                                                       
                                                        </p>
                                                    </td>
                                                    <td width="200px" style="padding-right: 15px;">
                                                        <p><strong>Forma de pagamento:</strong></p>

                                                        <p>
                                                            BOLETO DE CRÉDITO
                                                       
                                                        </p>
                                                    </td>
                                                    <td width="600px" style="padding-right: 15px;">
                                                        <p><strong>Pagamento efetuado em:</strong></p>

                                                        <p>
                                                            19/05/2017 às 20:37
                                                       
                                                        </p>
                                                    </td>
                                                    

                                                    <td width="200px" style="padding-right: 15px; text-align: center;">
                                                        <a href="#" class="noDec" style="font-weight: bold; color: black;"><i class="glyphicon glyphicon-file" style="font-size: 25px; color: red;"></i>
                                                        <p>Nota fiscal em PDF</p></a>

                                                    </td>
                                                </tr>

                                            </table>

                                        </div>
                                    </div>


                                    <div class="panel-footer" style="text-align: right;">
                                        <a style="font-size: 16px; text-align: center;" class="btn btn-sm btn-danger" href="#"><i style="font-size: 20px; top:4px;" class="glyphicon glyphicon-remove"></i>&nbsp;&nbsp; Cancelar pedido</a>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class="modal-footer">
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
   
    <!--Meus Pedidos-->


</asp:Content>
