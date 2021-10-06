﻿<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <!-- Page Banner Section Start -->
<div class="page-banner-section section">
    <div class="page-banner-wrap row row-0 d-flex align-items-center ">

        <!-- Page Banner -->
        <div class="col-lg-4 col-12 order-lg-2 d-flex align-items-center justify-content-center">
            <div class="page-banner">
                <h1>LIÊN HỆ</h1>
                <p>similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita</p>
                <div class="breadcrumb">
                    <ul>
                        <li><a href="#">TRANG CHỦ</a></li>
                        <li><a href="#">LIÊN HỆ</a></li>
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

<!-- Contact Section Start -->
<div class="contact-section section mt-90 mb-40">
    <div class="container">
        <div class="row">
            
            <!-- Contact Page Title -->
            <div class="contact-page-title col mb-40">
                <h1>Chào, Howdy <br>Hãy Kết nối với Chúng tôi</h1>
            </div>
        </div>
        <div class="row">
            
            <!-- Contact Tab List -->
            <div class="col-lg-4 col-12 mb-50">
                <ul class="contact-tab-list nav">
                    <li><a class="active" data-bs-toggle="tab" href="#contact-address">Kết nối với chúng tôi</a></li>
                    <li><a data-bs-toggle="tab" href="#contact-form-tab">Để lại cho chúng tôi một tin nhắn</a></li>
                    <li><a data-bs-toggle="tab" href="#store-location">Tất cả vị trí Cửa hàng</a></li>
                </ul>
            </div>
            
            <!-- Contact Tab Content -->
            <div class="col-lg-8 col-12">
                <div class="tab-content">
                    
                    <!-- Contact Address Tab -->
                    <div class="tab-pane fade show active row d-flex" id="contact-address">
                       
                        <div class="col-lg-4 col-md-6 col-12 mb-50">
                            <div class="contact-information">
                                <h4>Địa chỉ</h4>
                                <p>Địa chỉ:</p>
                            </div>
                        </div>
                       
                        <div class="col-lg-4 col-md-6 col-12 mb-50">
                            <div class="contact-information">
                                <h4>Điện thoại</h4>
                                <p><a href="tel:01234567890">01234 567 890</a><a href="tel:01234567891">01234 567 891</a></p>
                            </div>
                        </div>
                       
                        <div class="col-lg-4 col-md-6 col-12 mb-50">
                            <div class="contact-information">
                                <h4>Web</h4>
                                <p><a href="mailto:nkockkibo@gmail.com">nkockkibo@gmail.com</a><a href="#">www.example.com</a></p>
                            </div>
                        </div>
                        
                    </div>
                    
                    <!-- Contact Form Tab -->
                    <div class="tab-pane fade row d-flex" id="contact-form-tab">
                        <div class="col">
                            
                            <form id="contact-form" action="assets/php/mail.php" method="post" class="contact-form mb-50">
                                <div class="row">
                                    <div class="col-md-6 col-12 mb-25">
                                        <label for="first_name">First Name*</label>
                                        <input id="first_name" type="text" name="first_name">
                                    </div>
                                    <div class="col-md-6 col-12 mb-25">
                                        <label for="last_name">Last Name*</label>
                                        <input id="last_name" type="text" name="last_name">
                                    </div>
                                    <div class="col-md-6 col-12 mb-25">
                                        <label for="email_address">Email*</label>
                                        <input id="email_address" type="email" name="email_address">
                                    </div>
                                    <div class="col-md-6 col-12 mb-25">
                                        <label for="phone_number">Phone</label>
                                        <input id="phone_number" type="text" name="phone_number">
                                    </div>
                                    <div class="col-12 mb-25">
                                        <label for="message">Message*</label>
                                        <textarea id="message" name="message"></textarea>
                                    </div>
                                    <div class="col-12">
                                        <input type="submit" value="SEND NOW">
                                    </div>
                                </div>
                            </form>
                            <p class="form-messege"></p>
                            
                        </div>
                    </div>
                    
                    <!-- Contact Stores Tab -->
                    <div class="tab-pane fade row d-flex" id="store-location">
            
                        <div class="col-md-6 col-12 mb-50">
                            <div class="single-store">
                                <h3>E&E Australia</h3>
                                <p>You address will be here Lorem Ipsum is simply dummy text.</p>
                                <p><a href="tel:01234567890">01234 567 890</a> / <a href="tel:01234567891">01234 567 891</a></p>
                                <p><a href="mailto:info@example.com">info@example.com</a> / <a href="#">www.example.com</a></p>
                            </div>
                        </div>

                        <div class="col-md-6 col-12 mb-50">
                            <div class="single-store">
                                <h3>E&E England</h3>
                                <p>You address will be here Lorem Ipsum is simply dummy text.</p>
                                <p><a href="tel:01234567890">01234 567 890</a> / <a href="tel:01234567891">01234 567 891</a></p>
                                <p><a href="mailto:info@example.com">info@example.com</a> / <a href="#">www.example.com</a></p>
                            </div>
                        </div>

                        <div class="col-md-6 col-12 mb-50">
                            <div class="single-store">
                                <h3>E&E Germany</h3>
                                <p>You address will be here Lorem Ipsum is simply dummy text.</p>
                                <p><a href="tel:01234567890">01234 567 890</a> / <a href="tel:01234567891">01234 567 891</a></p>
                                <p><a href="mailto:info@example.com">info@example.com</a> / <a href="#">www.example.com</a></p>
                            </div>
                        </div>

                        <div class="col-md-6 col-12 mb-50">
                            <div class="single-store">
                                <h3>E&E France</h3>
                                <p>You address will be here Lorem Ipsum is simply dummy text.</p>
                                <p><a href="tel:01234567890">01234 567 890</a> / <a href="tel:01234567891">01234 567 891</a></p>
                                <p><a href="mailto:info@example.com">info@example.com</a> / <a href="#">www.example.com</a></p>
                            </div>
                        </div>

                        <div class="col-md-6 col-12 mb-50">
                            <div class="single-store">
                                <h3>E&E Canada</h3>
                                <p>You address will be here Lorem Ipsum is simply dummy text.</p>
                                <p><a href="tel:01234567890">01234 567 890</a> / <a href="tel:01234567891">01234 567 891</a></p>
                                <p><a href="mailto:info@example.com">info@example.com</a> / <a href="#">www.example.com</a></p>
                            </div>
                        </div>

                        <div class="col-md-6 col-12 mb-50">
                            <div class="single-store">
                                <h3>E&E Denmark</h3>
                                <p>You address will be here Lorem Ipsum is simply dummy text.</p>
                                <p><a href="tel:01234567890">01234 567 890</a> / <a href="tel:01234567891">01234 567 891</a></p>
                                <p><a href="mailto:info@example.com">info@example.com</a> / <a href="#">www.example.com</a></p>
                            </div>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</div><!-- Contact Section End -->
</asp:Content>