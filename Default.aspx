<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="MainContent">
    <!-- Hero Section Start -->
    <div class="hero-section section mb-30">
        <div class="container">
            <div class="row">
                <div class="col">
                    <!-- Hero Slider Start -->
                    <div class="hero-slider hero-slider-one">
                        <% foreach (Product item in listProducts)
                           {%>
                        <!-- Hero Item Start -->
                        <div class="hero-item">
                            <div class="row align-items-center justify-content-between">

                                <!-- Hero Content -->
                                <div class="hero-content col">

                                    <h2>MỚI NHẤT!</h2>
                                    <h1><span><%: item.Name %></span></h1>
                                    <h1>-<span class="big"><%: item.Discount %>%</span> OFF</h1>
                                    <a href="DetailProduct.aspx?id=<%: item.Id %>&slug=<%: item.Slug %>">Xem chi tiết</a>

                                </div>

                                <!-- Hero Image -->
                                <div class="hero-image col">
                                   <img src="Images/<%: item.Avatar %>" alt="Hero Image">
                                </div>
                        
                            </div>     
                        </div><!-- Hero Item End -->
                        <%} %>
                    </div><!-- Hero Slider End -->

                </div>
            </div>
        </div>
    </div><!-- Hero Section End -->

    <!-- Best Sell Product Section Start -->
    <div class="product-section section mb-60">
        <div class="container">
            <div class="row">
            
                <!-- Section Title Start -->
                <div class="col-12 mb-40">
                    <div class="section-title-one" data-title="GIÁ TỐT NHẤT"><h1>Giá tốt nhất</h1></div>
                </div><!-- Section Title End -->
            
                <div class="col-12">
                    <div class="row">
                        <% foreach (Product item in listProducts2)
                           {%>
                        <div class="col-xl-3 col-lg-4 col-md-6 col-12 pb-30 pt-10">
                            <!-- Product Start -->
                            <div class="ee-product">

                                <!-- Image -->
                                <div class="image">
                                    <span class="label new">-<%: item.Discount %>%</span>
                                    <a href="DetailProduct.aspx?id=<%: item.Id %>&slug=<%: item.Slug %>" class="img"><img src="Images/<%: item.Avatar %>" alt="Product Image"></a>

                                    <a href="CartHandling.aspx?id=<%: item.Id %>" class="add-to-cart"><i class="ti-shopping-cart"></i><span>+ giỏ hàng</span></a>

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
                    </div>
                </div>
            
            </div>
        </div>
    </div><!-- Best Sell Product Section End -->

    <!-- Feature Section Start -->
    <div class="feature-section section mb-60">
        <div class="container">
            <div class="row">
            
                <div class="col-lg-4 col-md-6 col-12 mb-30">
                    <!-- Feature Start -->
                    <div class="feature feature-shipping">
                        <div class="feature-wrap">
                            <div class="icon"><img src="assets/images/icons/feature-van.png" alt="Feature"></div>
                            <h4>MIỄN PHÍ GIAO HÀNG</h4>
                            <p>Mua Từ 100$</p>
                        </div>
                    </div><!-- Feature End -->
                </div>
            
                <div class="col-lg-4 col-md-6 col-12 mb-30">
                    <!-- Feature Start -->
                    <div class="feature feature-guarantee">
                        <div class="feature-wrap">
                            <div class="icon"><img src="assets/images/icons/feature-walet.png" alt="Feature"></div>
                            <h4>ĐẢM BẢO HOÀN TIỀN</h4>
                            <p>Hoàn tiền trong 15 ngày đầu</p>
                        </div>
                    </div><!-- Feature End -->
                </div>
            
                <div class="col-lg-4 col-md-6 col-12 mb-30">
                    <!-- Feature Start -->
                    <div class="feature feature-security">
                        <div class="feature-wrap">
                            <div class="icon"><img src="assets/images/icons/feature-shield.png" alt="Feature"></div>
                            <h4>THANH TOÁN AN TOÀN</h4>
                            <p>Bảo mật thanh toán</p>
                        </div>
                    </div><!-- Feature End -->
                </div>
            
            </div>
        </div>
    </div><!-- Feature Section End -->

    <!-- New Arrival Product Section Start -->
    <div class="product-section section mb-60">
        <div class="container">
            <div class="row">
            
                <!-- Section Title Start -->
                <div class="col-12 mb-40">
                    <div class="section-title-one" data-title="GIẢM GIÁ MẠNH NHẤT"><h1>Giảm giá mạnh nhất</h1></div>
                </div><!-- Section Title End -->
            
                <div class="col-12">
                    <div class="row">
                         <% foreach (Product item in listProducts3)
                           {%>
                        <div class="col-xl-3 col-lg-4 col-md-6 col-12 pb-30 pt-10">
                            <!-- Product Start -->
                            <div class="ee-product">

                                <!-- Image -->
                                <div class="image">
                                    <span class="label new">-<%: item.Discount %>%</span>
                                    <a href="DetailProduct.aspx?id=<%: item.Id %>&slug=<%: item.Slug %>" class="img"><img src="Images/<%: item.Avatar %>" alt="Product Image"></a>

                                    <a href="CartHandling.aspx?id=<%: item.Id %>" class="add-to-cart"><i class="ti-shopping-cart"></i><span>+ giỏ hàng</span></a>

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
                    </div>
                </div>
            
            </div>
        </div>
    </div><!-- New Arrival Product Section End -->

    <!-- New Arrival Product Section Start -->
    <div class="product-section section mb-60">
        <div class="container">
            <div class="row">
            
                <!-- Section Title Start -->
                <div class="col-12 mb-40">
                    <div class="section-title-one" data-title="ĐIỆN THOẠI SẮP BÁN"><h1>Điện thoại sắp bán</h1></div>
                </div><!-- Section Title End -->
            
                <div class="col-12">
                    <div class="row">
                         <% foreach (Product item in listProducts4)
                           {%>
                        <div class="col-xl-3 col-lg-4 col-md-6 col-12 pb-30 pt-10">
                            <!-- Product Start -->
                            <div class="ee-product">

                                <!-- Image -->
                                <div class="image">
                                    <span class="label new">-<%: item.Discount %>%</span>
                                    <a href="DetailProduct.aspx?id=<%: item.Id %>&slug=<%: item.Slug %>" class="img"><img src="Images/<%: item.Avatar %>" alt="Product Image"></a>

                                    <a href="CartHandling.aspx?id=<%: item.Id %>" class="add-to-cart"><i class="ti-shopping-cart"></i><span>+ giỏ hàng</span></a>

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
                    </div>
                </div>
            
            </div>
        </div>
    </div><!-- New Arrival Product Section End -->

</asp:Content>