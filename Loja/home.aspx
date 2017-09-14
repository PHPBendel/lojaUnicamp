<%@ Page Title="" Language="C#" MasterPageFile="~/LojaMaster.Master" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="Loja.home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Slider -->
    <div id="home">
        <div id="slidernet">
            <section class="carousel carousel-fade slide home-slider" id="c-slide" data-ride="carousel"
                data-interval="4500" data-pause="false">
                <div class="carousel-inner">
                    <div class="item active">
                        <div class="container">
                            <div class="row">
                                <div class="col-md-6 fadein scaleInv anim_1">
                                    <div class="fadein scaleInv anim_2">
                                        <h1 class="carouselText1 animated fadeInUpBig">Canecas  <span class="colortext">Exclusivas</span></h1>
                                    </div>
                                    <div class="fadein scaleInv anim_1">
                                        <p class="carouselText2 animated fadeInLeft">
                                            Porcelana
                                       
                                        </p>
                                    </div>
                                    <div class="fadein scaleInv anim_1">
                                        <p class="carouselText2 animated fadeInRight">
                                            <i class="icon-ok"></i>Térmicas
                                       
                                        </p>
                                    </div>
                                    <div class="fadein scaleInv anim_1">
                                        <p class="carouselText2 animated fadeInDown ">
                                            <i class="icon-ok"></i>Plásticas
                                       
                                        </p>
                                    </div>
                                </div>
                                <div class="col-md-6 text-center fadein scaleInv anim_2">
                                    <div class="text-center">
                                        <div class="fadein scaleInv anim_3">
                                            <asp:Image ID="Image1" CssClass="slide1-3 animated rollIn" ImageUrl="img/canecav.png" runat="server"></asp:Image>

                                        </div>
                                        <div class="fadein scaleInv anim_8">
                                            <asp:Image ID="Image2" CssClass="slide1-1 animated rollIn" ImageUrl="img/canecapor.png" runat="server"></asp:Image>

                                        </div>
                                        <div class="fadein scaleInv anim_5">
                                            <asp:Image ID="Image3" CssClass="slide1-2 animated rollIn" ImageUrl="img/canecater.png" runat="server"></asp:Image>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <div class="container">
                            <div class="row">
                                <div class="col-md-6 animated fadeInUp notransition">
                                    <asp:Image ID="Image4" Style="width: 90%;" ImageUrl="img/produtoshome.jpg" runat="server"></asp:Image>
                                </div>
                                <div class="col-md-6 animated fadeInDown  notransition topspace30 text-right">
                                    <div class="car-highlight1 animated fadeInLeftBig">
                                        Vestuário
                                   
                                    </div>
                                    <br>
                                    <div class="car-highlight2 animated fadeInRightBig notransition">
                                        Linha Escritório
                                   
                                    </div>
                                    <br>
                                    <div class="car-highlight3 animated fadeInUpBig notransition">
                                        Canecas
                                   
                                    </div>
                                    <br>
                                    <div class="car-highlight4 animated flipInX notransition">
                                        Agendas
                                   
                                    </div>
                                    <br>
                                    <div style="color: black;" class="car-highlight5 animated rollIn notransition">
                                        Presentes <span class="font100">exclusivos!</span><br>
                                        <span class="font100" style="font-size: 20px;">Entrega</span> Rápida!<br>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="item">
                        <div class="container">
                            <div class="row">
                                <div class="col-md-12 text-center">
                                    <br>
                                    <br>
                                    <div class="animated fadeInDownBig notransition">
                                        <span style="color: black" class="car-largetext" />Produtos em Promoção Marcados por Cores!<br>
                                    </div>
                                    <br>
                                    <br>
                                    <div class="car-widecircle animated fadeInLeftBig notransition">
                                        <span>10% OFF</span>
                                    </div>
                                    <div class="car-middlecircle animated fadeInUpBig notransition">
                                        <span>20% OFF</span>
                                    </div>
                                    <div class="car-smallcircle animated fadeInRightBig notransition">
                                        <span>40% OFF</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <a class="left carousel-control animated fadeInLeft" href="#c-slide" data-slide="prev"><i class="glyphicon glyphicon-arrow-left"></i></a>
                <a class="right carousel-control animated fadeInRight" href="#c-slide" data-slide="next"><i class="glyphicon glyphicon-arrow-right"></i></a>
            </section>
        </div>
    </div>
    <!-- Slider -->

    <!-- Conteudo Home-->
    <div class="container">
        <div class="row">
            <div class="col-md-3">
                <div class="sidebar topspace30">
                    <div class="wowwidget">
                        <h3>Produtos</h3>
                        <ul class="categories">
                            <li><a href="#">Camisetas</a></li>
                            <li><a href="#">Chaveiros</a></li>
                            <li><a href="#">Canetas</a></li>
                            <li><a href="#">Bottons</a></li>
                            <li><a href="#">Bonés</a></li>
                            <li><a href="#">Bottons</a></li>
                            <li><a href="#">Bonés</a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col-md-9">
                <div class="thumbnail">
                    <asp:Image ID="Image11" CssClass="img-responsive" ImageUrl="img/banner.jpg"
                        runat="server" />
                </div>
            </div>
        </div>
    </div>
    <!-- Conteudo Home-->

   

    <!--Meus Pedidos-->
  

  
    <!--meu carrinho-->

    <!--isto é uma galeria que pode ser usada futuramente-->
    <!-- <br />
            <br />
            <div id="gallery">
            </div>
            <div class="page-header">
                <div class="container">
                    <h1>
                        Gallery</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4 portfolio-item">
                    <a href="#">
                        <img class="img-responsive" src="http://placehold.it/700x400" alt="">
                    </a>
                    <h3>
                        <a href="#">Project Name</a>
                    </h3>
                    <p>
                        So whether you are shopping for your wife’s birthday gift or looking for a new suit
                        to wear for that important meeting you know what to do.</p>
                </div>
                <div class="col-md-4 portfolio-item">
                    <a href="#">
                        <img class="img-responsive" src="http://placehold.it/700x400" alt="">
                    </a>
                    <h3>
                        <a href="#">Project Name</a>
                    </h3>
                    <p>
                        So whether you are shopping for your wife’s birthday gift or looking for a new suit
                        to wear for that important meeting you know what to do.</p>
                </div>
                <div class="col-md-4 portfolio-item">
                    <a href="#">
                        <img class="img-responsive" src="http://placehold.it/700x400" alt="">
                    </a>
                    <h3>
                        <a href="#">Project Name</a>
                    </h3>
                    <p>
                        So whether you are shopping for your wife’s birthday gift or looking for a new suit
                        to wear for that important meeting you know what to do.</p>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4 portfolio-item">
                    <a href="#">
                        <img class="img-responsive" src="http://placehold.it/700x400" alt="">
                    </a>
                    <h3>
                        <a href="#">Project Name</a>
                    </h3>
                    <p>
                        So whether you are shopping for your wife’s birthday gift or looking for a new suit
                        to wear for that important meeting you know what to do.</p>
                </div>
                <div class="col-md-4 portfolio-item">
                    <a href="#">
                        <img class="img-responsive" src="http://placehold.it/700x400" alt="">
                    </a>
                    <h3>
                        <a href="#">Project Name</a>
                    </h3>
                    <p>
                        So whether you are shopping for your wife’s birthday gift or looking for a new suit
                        to wear for that important meeting you know what to do.</p>
                </div>
                <div class="col-md-4 portfolio-item">
                    <a href="#">
                        <img class="img-responsive" src="http://placehold.it/700x400" alt="">
                    </a>
                    <h3>
                        <a href="#">Project Name</a>
                    </h3>
                    <p>
                        So whether you are shopping for your wife’s birthday gift or looking for a new suit
                        to wear for that important meeting you know what to do.</p>
                </div>
            </div>
            <br />
            <br />
            <div class="well">
                <div class="text-right">
                    <a class="btn btn-success">Leave a Review</a>
                </div>
                <hr>
                <div class="row">
                    <div class="col-md-12">
                        <span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star">
                        </span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star">
                        </span><span class="glyphicon glyphicon-star-empty"></span>Anonymous <span class="pull-right">
                            10 days ago</span>
                        <p>
                            This product was great in terms of quality. I would definitely buy another!</p>
                    </div>
                </div>
                <hr>
                <div class="row">
                    <div class="col-md-12">
                        <span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star">
                        </span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star">
                        </span><span class="glyphicon glyphicon-star-empty"></span>Anonymous <span class="pull-right">
                            12 days ago</span>
                        <p>
                            I've alredy ordered another one!</p>
                    </div>
                </div>
                <hr>
                <div class="row">
                    <div class="col-md-12">
                        <span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star">
                        </span><span class="glyphicon glyphicon-star"></span><span class="glyphicon glyphicon-star">
                        </span><span class="glyphicon glyphicon-star-empty"></span>Anonymous <span class="pull-right">
                            15 days ago</span>
                        <p>
                            I've seen some better than this, but not at this price. I definitely recommend this
                            item.</p>
                    </div>
                </div>
            </div>
        </div>
    </div>-->


</asp:Content>
