<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Search.aspx.cs" Inherits="Search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
     <!-- Page Banner Section Start -->
<div class="page-banner-section section">
    <div class="page-banner-wrap row row-0 d-flex align-items-center ">

        <!-- Page Banner -->
        <div class="col-lg-4 col-12 order-lg-2 d-flex align-items-center justify-content-center">
            <div class="page-banner">
                <h1>
                    tìm kiếm "<asp:Label ID="txtTitleCategory" runat="server"></asp:Label>"
                </h1>
                <div class="breadcrumb">
                    <ul>
                        <li><a href="Default.aspx">TRANG CHỦ</a></li>
                        <li><a>tìm kiếm</a></li>
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

<!-- Product Section Start -->
<div class="product-section section mt-90 mb-90">
    <div class="container">
        <div class="row">
           
            <div class="col-12">
                
                <!-- Shop Product Wrap Start -->
                <div class="shop-product-wrap grid row">
                   <% foreach (Product item in listProducts)
                           {%>
                        <div class="col-xl-3 col-lg-4 col-md-6 col-12 pb-30 pt-10">
                            <!-- Product Start -->
                            <div class="ee-product">

                                <!-- Image -->
                                <div class="image">
                                    <span class="label new">-<%: item.Discount %>%</span>
                                    <a href="DetailProduct.aspx?id=<%: item.Id %>&slug=<%: item.Slug %>" class="img"><img src="Images/<%: item.Avatar %>" alt="Product Image"></a>

                                    <a href="AddCart.aspx?id=<%: item.Id %>" class="add-to-cart"><i class="ti-shopping-cart"></i><span>+ giỏ hàng</span></a>

                                </div>

                                <!-- Content -->
                                <div class="content">

                                    <!-- Category & Title -->
                                    <div class="category-title">

                                        <a href="#" class="cat"><%: item.Brand %></a>
                                        <h5 class="title"><a href="DetailProduct.aspx?id=<%: item.Id %>&slug=<%: item.Slug %>"><%: item.Name %></a></h5>

                                    </div>

                                    <!-- Price & Ratting -->
                                    <div class="price-ratting">

                                        <h5 class="price"><%: item.SalePrice %>đ</h5>
                                    </div>

                                </div>

                            </div><!-- Product End -->
                        </div>
                         <%} %>
                </div><!-- Shop Product Wrap End -->
            </div>
            
        </div>
    </div>
</div><!-- Feature Product Section End -->
</asp:Content>

