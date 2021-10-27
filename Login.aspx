<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <!-- Page Banner Section Start -->
<div class="page-banner-section section">
    <div class="page-banner-wrap row row-0 d-flex align-items-center ">

        <!-- Page Banner -->
        <div class="col-lg-4 col-12 order-lg-2 d-flex align-items-center justify-content-center">
            <div class="page-banner">
                <h1>ĐĂNG NHẬP</h1>
                <div class="breadcrumb">
                    <ul>
                        <li><a href="Default.aspx">TRANG CHỦ</a></li>
                        <li><a>ĐĂNG NHẬP</a></li>
                    </ul>
                </div>
            </div>
        </div>

        <!-- Banner -->
        <div class="col-lg-4 col-md-6 col-12 order-lg-1">
        </div>

        <!-- Banner -->
        <div class="col-lg-4 col-md-6 col-12 order-lg-3">
        </div>

    </div>
</div><!-- Page Banner Section End -->

<!-- Login Section Start -->
<div class="login-section section mt-90 mb-90">
    <div class="container">
        <div class="row">
            
            <!-- Login -->
            <div class="col-md-6 col-12 d-flex">
                <div class="ee-login">
                    
                    <h3>Đăng nhập tài khoản của bạn</h3>
                    <p>Hãy đăng nhập và trải nghiệm dịch vụ của chúng tôi</p>
                    
                    <!-- Login Form -->
                    <form runat="server">
                        <div class="row">
                            <asp:TextBox class="col-12 mb-30" ID="email" runat="server" placeholder="Địa chỉ Email"></asp:TextBox>
                            <asp:TextBox class="col-12 mb-30" ID="password" runat="server" placeholder="Nhập mật khẩu" TextMode="Password"></asp:TextBox>
                            <asp:Label class="mb-2" ID="errLogin" runat="server" ForeColor="#CC0000"></asp:Label>
                            <div class="col-12 mb-15">
                                
                                <asp:CheckBox ID="saveLogin" runat="server" />
                                <label for="MainContent_saveLogin">Lưu thông tin đăng nhập</label>
                                
                                <a href="#">Quên mật khẩu?</a>
                                
                            </div>
                            <div class="col-12">
                                <asp:Button ID="Button1" runat="server" Text="Đăng nhập" OnClick="Button1_Click" />
                            </div>
                        </div>
                    </form>
                    <h4>Nếu bạn không có tài khoản? Hãy <a href="Register.aspx">ĐĂNG KÝ</a></h4>
                    
                </div>
            </div>
            
            <div class="col-md-1 col-12 d-flex">
                
                <div class="login-reg-vertical-boder"></div>
                
            </div>
            
            <!-- Login With Social -->
            <div class="col-md-5 col-12 d-flex">
                
                <div class="ee-social-login">
                    <h3>Đăng nhập bằng...</h3>
                    <% if (Request.Cookies["LoginCookie"] != null)
                       { %>
                    <a onclick="document.getElementById('MainContent_email').value = '<%: Request.Cookies["LoginCookie"]["email"] %>'" class="facebook-login"><%: Request.Cookies["LoginCookie"]["email"] %> <i class="fa fa-user"></i></a>
                    <% } %>
                </div>
                
            </div>
            
        </div>
    </div>
</div><!-- Login Section End -->
</asp:Content>

