<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <section>
       <img src="Image/E-commerce....-1200x600New.jpg"" class="fluid-img" />
    </section>

     <section>

        <div class="container">
            <div class="row">
                <div class="col-12">
                    <center>
                    <h2>Our Features</h2>
                    <p><b>Our 3 primary features</b></p>
                    </center>
                </div>

                
            </div>

            <div class="row">
               <div class="col-md-4">
                    <center>
                    <img width="150px" src="Image/stand.png" />
                    <h4>Products Inventory</h4>
                        <p class="text-justify">Variety of products ranges available</p>
                    </center>
                </div>  
                 <div class="col-md-4">
                    <center>
                    <img width="150px" img src="Image/payment-method.png" / />
                    <h4>Easy Payment Mode</h4>
                        <p class="text-justify">Availiability of multiple payment options Debit Cards, Credit Cards, COD, EMI, Wallets etc.</p>
                    </center>
                </div>
                 <div class="col-md-4">
                    <center>
                    <img width="250px" img src="Image/Delivery.jpg" />
                    <h4>Free Delivery*</h4>
                        <p class="text-justify">Free delivery all over India</p>
                    </center>
                </div>
            </div>     
        </div>

    </section>

</asp:Content>
