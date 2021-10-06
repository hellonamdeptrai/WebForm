<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <!-- Page Banner Section Start -->
<div class="page-banner-section section">
    <div class="page-banner-wrap row row-0 d-flex align-items-center ">

        <!-- Page Banner -->
        <div class="col-lg-4 col-12 order-lg-2 d-flex align-items-center justify-content-center">
            <div class="page-banner">
                <h1>ĐĂNG KÍ</h1>
                <p>similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita</p>
                <div class="breadcrumb">
                    <ul>
                        <li><a href="#">TRANG CHỦ</a></li>
                        <li><a href="#">ĐĂNG KÍ</a></li>
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

<!-- Register Section Start -->
<div class="register-section section mt-90 mb-90">
    <div class="container">
        <div class="row">
            
            <!-- Register -->
            <div class="col-md-6 col-12 d-flex">
                <div class="ee-register">
                    
                    <h3>Chúng tôi sẽ cần đăng ký của bạn</h3>
                    <p>Bạn hãy đăng kí E&E sẽ cung cấp cho bạn một tài hoàn chỉnh</p>
                    
                    <!-- Register Form -->
                    <form action="#">
                        <div class="row">
                            <div class="col-12 mb-30"><input type="text" placeholder="Tên đăng nhập"></div>
                            <div class="col-12 mb-30"><input type="email" placeholder="Email"></div>
                            <div class="col-12 mb-30"><input type="password" placeholder="Mật khẩu"></div>
                            <div class="col-12 mb-30"><input type="password" placeholder="Nhập lại mật khẩu"></div>
                            <div class="col-12"><input type="submit" value="Đăng kí"></div>
                        </div>
                    </form>
                    
                </div>
            </div>
            
            <div class="col-md-1 col-12 d-flex">
                
                <div class="login-reg-vertical-boder"></div>
                
            </div>
            
            <!-- Account Image -->
            <div class="col-md-5 col-12 d-flex">
                
                <div class="ee-account-image">
                    <h3>Cập nhật ảnh đại diện</h3>
                    
                    <img src="assets/images/account-image-placeholder.jpg" alt="Account Image Placeholder" class="image-placeholder">
                    
                    <div class="account-image-upload">
                        <input type="file" name="chooseFile" id="account-image-upload">
                        <label class="account-image-label" for="account-image-upload">Chọn ảnh của bạn</label>
                    </div>
                    
                    <p>jpEG 250x250</p>
                    
                </div>
                
            </div>
            
        </div>
    </div>
</div><!-- Register Section End -->
</asp:Content>

