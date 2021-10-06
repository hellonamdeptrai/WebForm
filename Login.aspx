<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
<!-- Page Banner Section Start -->
<div class="page-banner-section section">
    <div class="page-banner-wrap row row-0 d-flex align-items-center ">

        <!-- Page Banner -->
        <div class="col-lg-4 col-12 order-lg-2 d-flex align-items-center justify-content-center">
            <div class="page-banner">
                <h1>ĐĂNG NHẬP</h1>
                <p>similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita</p>
                <div class="breadcrumb">
                    <ul>
                        <li><a href="#">TRANG CHỦ</a></li>
                        <li><a href="#">ĐĂNG NHẬP</a></li>
                    </ul>
                </div>
            </div>
        </div>

        <!-- Banner -->
        <div class="col-lg-4 col-md-6 col-12 order-lg-1">
            <div class="banner"><a href="#"><img src="assets/images/banner/banner-15.jpg" alt="Banner"></a></div>
        </div>

        <!-- Banner -->
        <div class="col-lg-4 col-md-6 col-12 order-lg-3">
            <div class="banner"><a href="#"><img src="assets/images/banner/banner-14.jpg" alt="Banner"></a></div>
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
                    <form action="#">
                        <div class="row">
                            <div class="col-12 mb-30"><input type="text" placeholder="Tên đăng nhập hoặc địa chỉ Email"></div>
                            <div class="col-12 mb-20"><input type="password" placeholder="Nhập mật khẩu"></div>
                            <div class="col-12 mb-15">
                                
                                <input type="checkbox" id="remember_me">
                                <label for="remember_me">Lưu thông tin đăng nhập</label>
                                
                                <a href="#">Quên mật khẩu?</a>
                                
                            </div>
                            <div class="col-12"><input type="submit" value="Đăng nhập"></div>
                        </div>
                    </form>
                    <h4>Nếu bạn không có tài khoản? Hãy <a href="register">ĐĂNG KÍ</a></h4>
                    
                </div>
            </div>
            
            <div class="col-md-1 col-12 d-flex">
                
                <div class="login-reg-vertical-boder"></div>
                
            </div>
            
            <!-- Login With Social -->
            <div class="col-md-5 col-12 d-flex">
                
                <div class="ee-social-login">
                    <h3>Đăng nhập bằng...</h3>
                    
                    <a href="#" class="facebook-login">Đăng nhập bằng <i class="fa fa-facebook"></i></a>
                    <a href="#" class="twitter-login">Đăng nhập bằng <i class="fa fa-twitter"></i></a>
                    <a href="#" class="google-plus-login">Đăng nhập bằng <i class="fa fa-google-plus"></i></a>
                    
                </div>
                
            </div>
            
        </div>
    </div>
</div><!-- Login Section End -->
</asp:Content>

