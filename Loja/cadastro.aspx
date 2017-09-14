<%@ Page Title="" Language="C#" MasterPageFile="~/LojaMaster.Master" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="Loja.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <!--cadastro-->    

    
    <div id="cadastro">
        <div class="page-header">
            <div class="container">
                <div class="row">
                    <h2>Primeiro Acesso</h2>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div ID="erroCadastro" class="alert alert-danger" style="display:none" runat="server">
            <p>Campos inválidos</p>
        </div>
        <div id="infoCadastro" class="alert alert-info" data-id="alertas" style="display:none" runat="server">
            <p>Cadastro efetuado com sucesso!</p>
        </div>
        <div id="alertaCadastro" class="alert alert-warning" data-id="alertas" style="display:none" runat="server">
            <p id="textoAlertaCadastro" runat="server">Erro ao cadastrar</p>
        </div>
        <div class="row">
            <div class="col-md-4 text-left">
                <asp:Label runat="server" Font-Size="Medium">Nome</asp:Label>
                <asp:TextBox ID="nome_usu" placeholder="Nome Completo" class="form-control" runat="server"></asp:TextBox><br>
                <asp:Label runat="server" Font-Size="Medium">CPF</asp:Label>
                <asp:TextBox ID="cpf_usu" placeholder="999.999.999-99" class="form-control" runat="server"></asp:TextBox><br>
                <asp:Label runat="server" Font-Size="Medium">E-mail</asp:Label>
                <asp:TextBox ID="email_usu" placeholder="meuemail@email.com" class="form-control" runat="server"></asp:TextBox><br>
                <asp:Label runat="server" Font-Size="Medium">Telefone</asp:Label>
                <asp:TextBox ID="tel_usu" placeholder="(99) 9999-9999" class="form-control" runat="server"></asp:TextBox><br>
                <asp:Label runat="server" Font-Size="Medium">Celular</asp:Label>
                <asp:TextBox ID="cel_usu" placeholder="(99) 99999-9999" class="form-control" runat="server"></asp:TextBox><br>
            </div>
            <div class="col-md-4 text-left">
                <asp:Label runat="server" Font-Size="Medium">CEP</asp:Label>
                <asp:TextBox ID="cep_usu" placeholder="99999-999" class="form-control" runat="server"></asp:TextBox><br>
                <asp:Label runat="server" Font-Size="Medium">Logradouro</asp:Label>
                <asp:TextBox ID="log_usu" placeholder="Avenida da Saudade" class="form-control" runat="server"></asp:TextBox><br>
                <asp:Label runat="server" Font-Size="Medium">Numero</asp:Label>
                <asp:TextBox ID="numero_usu" placeholder="999" class="form-control" runat="server"></asp:TextBox><br>   
                   <asp:Label runat="server" Font-Size="Medium">Bairro</asp:Label>
                <asp:TextBox ID="bairro_usu" placeholder="Jardim São Marcos" class="form-control" runat="server"></asp:TextBox><br> 
                <asp:Label runat="server" Font-Size="Medium">Estado</asp:Label>
                <asp:TextBox ID="estado_usu" placeholder="São Paulo" class="form-control" runat="server"></asp:TextBox><br>
               
            </div>
            <div class="col-md-4 text-left">
                 <asp:Label runat="server"  Font-Size="Medium">Cidade</asp:Label>
                <asp:TextBox ID="cidade_usu" placeholder="Campinas" class="form-control" runat="server"></asp:TextBox><br>
                <asp:Label runat="server" Font-Size="Medium">Senha</asp:Label>
                <asp:TextBox ID="senha" type="password" placeholder="*********" class="form-control" runat="server"></asp:TextBox><br>
                <asp:Label runat="server" Font-Size="Medium">Confirmar Senha</asp:Label>
                <asp:TextBox ID="confirma_senha" type="password" placeholder="*********" class="form-control" runat="server"></asp:TextBox><br>
                <asp:Label runat="server" Font-Size="Medium">Dica da Senha</asp:Label>
                <asp:TextBox ID="dica_senha" type="text" placeholder="Nome do meu cão" class="form-control" runat="server"></asp:TextBox><br>
                <br>
                <asp:Button  ID="btncadastrar" class="btn btn-md btn-block btn-success" runat="server" Text="Cadastrar" OnClick="btncadastrar_Click" /><br />
                
            </div>
        </div>
    </div>
    <!--cadastro-->

</asp:Content>