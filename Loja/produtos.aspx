<%@ Page Title="" Language="C#" MasterPageFile="~/LojaMaster.Master" AutoEventWireup="true" CodeBehind="produtos.aspx.cs" Inherits="Loja.produtos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!--Produtos-->
    <div id="product">
        <div class="page-header">
            <div class="container">
                <div class="row">
                    <h2>Produtos</h2>
                </div>
            </div>
        </div>
    </div>


    <script>
        function acrescentar(id) {

            idcarrinho =[id] {id: id};
            console.log(idcarrinho);

            // Check browser support
         //   if (typeof (Storage) !== "undefined") {
                // Store
      //          localStorage.setItem("lastname", "Smi-th");
                // Retrieve
     //           document.getElementById("result").innerHTML = localStorage.getItem("lastname");
     //       } else {
        //       document.getElementById("result").innerHTML = "Sorry, your browser does not support Web Storage...";
     //       }
        }
    </script>
    <%= obj_produto  %>
    <!--produtos-->



</asp:Content>
