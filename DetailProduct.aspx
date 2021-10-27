<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="DetailProduct.aspx.cs" Inherits="DetailProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <!-- Page Banner Section Start -->
<div class="page-banner-section section">
    <div class="page-banner-wrap row row-0 d-flex align-items-center ">

        <!-- Page Banner -->
        <div class="col-lg-4 col-12 order-lg-2 d-flex align-items-center justify-content-center">
            <div class="page-banner">
                <h1>CHI TIẾT SẢN PHẨM</h1>
                <div class="breadcrumb">
                    <ul>
                        <li><a href="Default.aspx">TRANG CHỦ</a></li>
                        <li><a>CHI TIẾT SẢN PHẨM</a></li>
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

<!-- Single Product Section Start -->
<div class="product-section section mt-90 mb-90">
    <div class="container">
        
        <div class="row mb-90">
                    
            <div class="col-lg-6 col-12 mb-50">

                <!-- Image -->
                <div class="single-product-image thumb-right">

                    <div class="tab-content">
                        <div class="tab-pane fade show active big-image-slider">
                            <%foreach (var item in listImages)
                                {  %>
                            <div class="big-image"><img src="Images/<%: item.ToString() %>" alt="Big Image"><a href="Images/<%: item.ToString() %>" class="big-image-popup"><i class="fa fa-search-plus"></i></a></div>
                            <%}%>
                        </div>
                    </div>

                </div>

            </div>
                    
            <div class="col-lg-6 col-12 mb-50">

                <!-- Content -->
                <div class="single-product-content">

                    <!-- Category & Title -->
                    <div class="head-content">

                        <div class="category-title">
                            <a class="cat">
                                 -<asp:Label ID="discount" runat="server"></asp:Label>%
                            </a>
                            <h5 class="title">
                                <asp:Label ID="name" runat="server"></asp:Label>
                            </h5>
                        </div>

                        <h5 class="price">
                            <asp:Label ID="originPrice" runat="server"></asp:Label>
                        </h5>

                    </div>
                    <div class="ratting">
                        <h4><strong><asp:Label ID="salePrice" runat="server"></asp:Label></strong></h4>
                    </div>
                    <div class="single-product-description">

                        <div class="desc">
                            <asp:Label ID="promotion" runat="server"></asp:Label>
                        </div>

                        <div class="actions">

                            <a href="CartHandling.aspx?id=<%: id %>" class="add-to-cart"><i class="ti-shopping-cart"></i><span>+ giỏ hàng</span></a>

                        </div>

                    </div>

                </div>

            </div>
            
        </div>
        
        <div class="row">
            
            <div class="col-lg-10 col-12 ml-auto mr-auto">
                
                <ul class="single-product-tab-list nav">
                    <li><a href="#product-description" class="active" data-bs-toggle="tab" >Mô tả</a></li>
                    <li><a href="#product-specifications" data-bs-toggle="tab" >Thông số kỹ thuật</a></li>
                </ul>
                
                <div class="single-product-tab-content tab-content">
                    <div class="tab-pane fade show active" id="product-description">
                        
                        <div class="row">
                            <asp:Label ID="content" runat="server"></asp:Label>
                        </div>
                        
                    </div>
                    <div class="tab-pane fade" id="product-specifications">
                        <asp:Label ID="specifications" runat="server" ></asp:Label>
                    </div>
                </div>
                
            </div>
            
        </div>
        
    </div>
</div><!-- Single Product Section End -->

</asp:Content>

