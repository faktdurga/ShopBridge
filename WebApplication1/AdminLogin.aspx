<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="WebApplication1.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="container">
      <div class="row">
          <div class="col-md-6 mx-auto" >
                            <div class="card">
                  <div class="card-body">
                      <div class="row">
                          <div class="col">
                              <center>
                                    <img width="150px" src="Image/Admin.jpg" / >
                              </center>
                          </div>
                      </div>
                      <div class="row">
                          <div class="col">
                              <center>
                                    <h3>Admin Login</h3>
                              </center>
                          </div>
                      </div>
                      <div class="row">
                          <div class="col">
                              </hr>
                          </div>
                      </div>
                      <div class="row">
                          <div class="col">
                              
                              <div class="form-group">
                                  <asp:TextBox CssClass="form-control" ID="txtUserID" runat="server"  ></asp:TextBox>

                              </div>
                              <p></p>
                              <div class="form-group">
                                  <asp:TextBox CssClass="form-control" ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>

                              </div>
                               <p></p>
                              <div class="form-group">
                                  <asp:Button class="btn btn-success" ID="btnLogin"  runat="server" Text="Log In" OnClick="btnLogin_Click" />

                              </div>
                               <p></p>
                            

                          </div>
                      </div>
                  </div>
              </div>
              <a href="Home.aspx"><< Back To Home</a><br /><br />
          </div>
    </div>
</div>

</asp:Content>
