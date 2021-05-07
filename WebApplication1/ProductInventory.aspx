<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProductInventory.aspx.cs" Inherits="WebApplication1.ProductInventory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Product Details</h3>
                                 
                              </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="Image/60-products.jpg" / >                        
                              </center>
                            </div>
                        </div>


                        <div class="row">
                            <div class="col">

                                <hr />
                            </div>
                        </div>

                        <div class="row">
                           <%-- <div class="col">

                                <asp:FileUpload CssClass="form-group" ID="FileUpload1" runat="server" />

                            </div>--%>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-3">

                                <label>Product ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="txtProductID" runat="server" placeholder="ID"></asp:TextBox>
                                        <%--<input id="btnGo" class="btn btn-primary" type="button" value="GO" />--%><asp:Button ID="btnGO" class="btn btn-primary" runat="server" Text="Go" OnClick="btnGO_Click" />
                                    </div>
                                </div>
                            </div>

                            <div class="col-md-9">
                                <label>Product Name</label>
                                <div class="form-group">

                                    <asp:TextBox CssClass="form-control" ID="txtProductName" runat="server" placeholder="Product Name"></asp:TextBox>

                                </div>
                            </div>



                        </div>

                        <br />
                        <div class="row">
                            <div class="col-md-4">

                                <label>Suffix</label>
                                <div class ="form-group">

                               

                             <asp:TextBox CssClass="form-control" ID="txtSuffix" runat="server" placeholder="ex:- size, color etc"></asp:TextBox>

                                
                                </div>

                                <label>Manufacturer Name</label>
                                <div class ="form-group">

                             <asp:TextBox CssClass="form-control" ID="txtManufacturer" runat="server" placeholder="Manufacturer"></asp:TextBox>
                                </div>

                            </div>

                            <div class="col-md-4">

                                <label>Model Number</label>
                                <div class ="form-group">

                                <asp:TextBox CssClass="form-control" ID="txtModel" runat="server" placeholder="ModelNumber"></asp:TextBox>
                                </div>

                                <label>Manufacture Date</label>
                                <div class ="form-group">

                                 <asp:TextBox CssClass="form-control" ID="txtMDate" runat="server" placeholder="dd-mm-yhyy"  TextMode="Date"></asp:TextBox>
                                   
                               
                                </div>

                            </div>

                           <div class="col-md-4">

                                <label>Product Category</label>
                                <div class ="form-group">

                                    <asp:ListBox CssClass="form-control" ID="lstProductCategories" runat="server" SelectionMode="Multiple">
                                    <asp:ListItem Text="APPARELS" Value="Apparels" />
                                    <asp:ListItem Text="CONSUMER ELECTRONICS" Value="Consumer Electronics" />
                                    <asp:ListItem Text="FOOTWEAR" Value="Footware" />
                                    <asp:ListItem Text="FOOD, HEALTH & BEAUTY SUPPLEMENTS" Value="Food, Health & Beauty Supplements" />
                                    <asp:ListItem Text="JEWELLERY" Value="Jwellery" />
                                    <asp:ListItem Text="HOME DECOR ITEMS" Value="Home Decor" />
                                    <asp:ListItem Text="MOBILE PHONES" Value="Mobile Phones" />
                                    <asp:ListItem Text="FASHION ACCESSORIES" Value="Fashion Accessories" />
                                    <asp:ListItem Text="KITCHEN WARE AND HOUSEHOLD APPLIANCES" Value="Kitchenware & Household Appliances" />
                                    <asp:ListItem Text="TOYS AND GAMES" Value="Toys & Games" />
                                    <asp:ListItem Text="SPORTS GOOD AND FITNESS EQUIPMENT" Value="Sports & Fitness" />
                                    <asp:ListItem Text="BAY CARE" Value="Baby Cares" />
                                    <asp:ListItem Text="COMPUTER HARDWARE, SOFTWARE, AND ACCESSORIES" Value="Computer, Hardware, Software & Accesories" />
                                    <asp:ListItem Text="BOOKS" Value="Books" />
                                    <asp:ListItem Text="MOVIES & MUSIC" Value="CD, DVD" />
                                    <asp:ListItem Text="AUTO & ANCILARY" Value="Auto Parts and Accessories" />
                                   
                                   
                                    </asp:ListBox>

                                </div>

                              

                            </div>

                        </div>

                        <br />

                        <div class="row">
                            <div class="col-md-4">

                                <label>Model Name</label>

                                <asp:TextBox CssClass="form-control" ID="txtModelName" runat="server" placeholder="Model Name" ></asp:TextBox>


                            </div>

                            <div class="col-md-4">
                                <label>Product Cost (Per Unit)</label>

                                <asp:TextBox CssClass="form-control" ID="txtProductCost" runat="server" placeholder="INR" TextMode="Number" ></asp:TextBox>


                            </div>

                            <div class="col-md-4">
                                <label>Available Quantity</label>

                                <asp:TextBox CssClass="form-control" ID="txtQuantity" runat="server" placeholder="Qty" TextMode="Number"></asp:TextBox>


                            </div>


                        </div>
   
                        <br />

                        <div class="row">
                            <div class="col-md-12">

                                <label>Product Description</label>

                                <asp:TextBox CssClass="form-control" ID="txtAddress" runat="server" placeholder="Product Discription & Instruction of use, care" TextMode="MultiLine"></asp:TextBox>


                            </div>


                        </div>

                        <br />

                        <div class="row">
                            <div class="d-grid gap-2 col-4 mx-auto">
                                <asp:Button ID="btnAdd" class="btn btn-lg btn-success " runat="server" Text="Add" OnClick="btnAdd_Click" />
                            </div>
                                                        
                            <div class="d-grid gap-2 col-4 mx-auto">
                                <asp:Button ID="btnUpdate" class="btn btn-lg btn-warning " runat="server" Text="Update" OnClick="btnUpdate_Click" />
                            </div>

                            <div class="d-grid gap-2 col-4 mx-auto">
                                <asp:Button ID="btnDelete" class="btn btn-lg btn-danger " runat="server" Text="Delete" OnClick="btnDelete_Click" />
                            </div>

                        </div>

                    </div>
                </div>



            </div>

            <div class="col-md-6">

                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Product List</h3>
                                  
                              </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">

                                <hr />
                            </div>
                        </div>



                        <br />


                        <div class="row">
                            <div class="col">

                                <asp:GridView ID="grdProductList" class="table-bordered-warning" runat="server"></asp:GridView>
                            </div>
                        </div>


                    </div>
                </div>



            </div>

            <a href="Home.aspx"><< Back To Home</a><br />
            <br />
        </div>
</asp:Content>
