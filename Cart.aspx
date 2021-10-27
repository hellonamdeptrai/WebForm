<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <!-- Page Banner Section Start -->
<div class="page-banner-section section">
    <div class="page-banner-wrap row row-0 d-flex align-items-center ">

        <!-- Page Banner -->
        <div class="col-lg-4 col-12 order-lg-2 d-flex align-items-center justify-content-center">
            <div class="page-banner">
                <h1>GIỎ Hàng</h1>
                <div class="breadcrumb">
                    <ul>
                        <li><a href="Default.aspx">TRANG CHỦ</a></li>
                        <li><a>GIỎ HÀNG</a></li>
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

<!-- Cart Page Start -->
<div class="page-section section pt-90 pb-50">
    <div class="container">
        <div class="row">
            <div class="col-12">
                <form action="#">				
                    <!-- Cart Table -->
                    <div class="cart-table table-responsive mb-40">
                        <table class="table">
                            <thead>
                                <tr>
                                    <th class="pro-thumbnail">Ảnh</th>
                                    <th class="pro-title">Tên sản phẩm</th>
                                    <th class="pro-price">Giá</th>
                                    <th class="pro-quantity">Số lượng</th>
                                    <th class="pro-subtotal">Tổng giá</th>
                                    <th class="pro-remove">Xóa</th>
                                </tr>
                            </thead>
                            <tbody>
                                <% foreach (Carts item in listCarts)
                                    {%>
                                <tr>
                                    <td class="pro-thumbnail"><a href="#"><img src="Images/<%: item.Avatar %>" alt="Product"></a></td>
                                    <td class="pro-title"><a href="#"><%: item.Name %></a></td>
                                    <td class="pro-price"><span><%: item.SalePrice %>đ</span></td>
                                    <td class="pro-quantity"><span><%: item.Quantity %></span></td>
                                    <td class="pro-subtotal"><span><%: item.TotalPrice %>đ</span></td>
                                    <td class="pro-remove"><a href="DeleteCart.aspx?id=<%: item.IdProduct %>"><i class="fa fa-trash-o"></i></a></td>
                                </tr>
                                <% } %>
                            </tbody>
                        </table>
                    </div>
                    
                </form>	
                    
                <div class="row">

                    <div class="col-lg-6 col-12 mb-15">
                        
                    </div>

                    <!-- Cart Summary -->
                    <div class="col-lg-6 col-12 mb-40 d-flex">
                        <div class="cart-summary">
                            <div class="cart-summary-wrap">
                                <h4>Tóm Tắt Giỏ Hàng</h4>
                                <p>Địa chỉ giao hàng <span><asp:Label ID="address" runat="server"></asp:Label></span></p>
                                <h2>Tổng Tiền <span><asp:Label ID="TotalPriceCart" runat="server"></asp:Label></span></h2>
                            </div>
                            <form runat="server" class="cart-summary-button">
                                <asp:Button class="checkout-btn" ID="Button1" runat="server" Text="Thanh Toán" OnClick="Button1_Click" />
                            </form>
                        </div>
                    </div>

                </div>
                
            </div>
        </div>
    </div>
</div>
<!-- Cart Page End --> 
</asp:Content>

