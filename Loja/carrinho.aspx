<%@ Page Title="" Language="C#" MasterPageFile="~/LojaMaster.Master" AutoEventWireup="true" CodeBehind="carrinho.aspx.cs" Inherits="Loja.carrinho" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!--meu carrinho-->
    <div id="meucarrinho">
        <div class="page-header">
            <div class="container">
                <div class="row">
                    <h2>Meu Carrinho <span class="glyphicon">&#xe116;</span></h2>
                </div>
            </div>
        </div>
    </div>
   
    <%=obj_carrinho %>
</asp:Content>
