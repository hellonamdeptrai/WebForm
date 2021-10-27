<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <!-- Page Banner Section Start -->
<div class="page-banner-section section">
    <div class="page-banner-wrap row row-0 d-flex align-items-center ">

        <!-- Page Banner -->
        <div class="col-lg-4 col-12 order-lg-2 d-flex align-items-center justify-content-center">
            <div class="page-banner">
                <h1>LIÊN HỆ</h1>
                <div class="breadcrumb">
                    <ul>
                        <li><a href="Default.aspx">TRANG CHỦ</a></li>
                        <li><a href="#">LIÊN HỆ</a></li>
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

<!-- Contact Section Start -->
<div class="contact-section section mt-90 mb-40">
    <div class="container">
        <div class="row">
            
            <!-- Contact Page Title -->
            <div class="contact-page-title col mb-40">
                <h1>Chào, các bạn <br>Hãy Kết nối với Chúng tôi</h1>
            </div>
        </div>
        <div class="row">
            <!-- Contact Tab Content -->
            <div class="col-lg-8 col-12">
                <div class="tab-content">
                    
                    <!-- Contact Address Tab -->
                    <div class="tab-pane fade show active row d-flex" id="contact-address">
                       
                        <div class="col-lg-4 col-md-6 col-12 mb-50">
                            <div class="contact-information">
                                <h4>Địa chỉ</h4>
                                <p>Địa chỉ: Hà Nội, Việt Nam</p>
                            </div>
                        </div>
                       
                        <div class="col-lg-4 col-md-6 col-12 mb-50">
                            <div class="contact-information">
                                <h4>Điện thoại</h4>
                                <p><a href="tel:01234567890">01234 567 890</a><a href="tel:01234567891">01234 567 891</a></p>
                            </div>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</div><!-- Contact Section End -->
</asp:Content>