<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ProfileUser.aspx.cs" Inherits="ProfileUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <!-- Page Banner Section Start -->
<div class="page-banner-section section">
    <div class="page-banner-wrap row row-0 d-flex align-items-center ">

        <!-- Page Banner -->
        <div class="col-lg-4 col-12 order-lg-2 d-flex align-items-center justify-content-center">
            <div class="page-banner">
                <h1>Thông tin cá nhân</h1>
                <div class="breadcrumb">
                    <ul>
                        <li><a href="Default.aspx">TRANG CHỦ</a></li>
                        <li><a>Thông tin cá nhân</a></li>
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

<!-- Register Section Start -->
<div class="register-section section mt-90 mb-90">
    <div class="container">
        <div class="row">
            
            <!-- Register -->
            <div class="col-12 d-flex justify-content-center">
                <div class="ee-register">
                    <!-- Register Form -->
                    <form id="Form1" runat="server">
                        <div class="row">
                            <div class="ee-account-image pb-30">
                                <h4>Cập nhật ảnh đại diện</h4>
                                <asp:Image class="image-placeholder" ID="previewAvatar" runat="server" />
                            </div>
                            <div class="col-12 mb-30">
                                <label>Ảnh đại diện</label>
                                <asp:FileUpload ID="avatar" runat="server" />
                                <label class="d-block">jpeg, jpg, png, gif 250x250</label>
                            </div>
                            <div class="col-12 mb-30">
                                <asp:TextBox ID="name" placeholder="Tên khách hàng" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Tên không được để trống" Display="Dynamic" ControlToValidate="name" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-12 mb-30">
                                <asp:TextBox ID="email" placeholder="Email" runat="server" TextMode="Email"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email không được để trống" Display="Dynamic" ControlToValidate="email" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="email" ErrorMessage="Email không đúng định dạng" ForeColor="#CC0000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>  
                            </div>
                            <div class="col-12 mb-30">
                                <asp:TextBox ID="phoneNumber" placeholder="Số điện thoại" runat="server" TextMode="Phone"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Số điện thoại không được để trống" Display="Dynamic" ControlToValidate="phoneNumber" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="phoneNumber" ErrorMessage="Số điện thoại không đúng định dạng" ForeColor="#CC0000" ValidationExpression="[0-9]{10}" Display="Dynamic"></asp:RegularExpressionValidator>  
                            </div>
                            <div class="col-12 mb-30">
                                <asp:TextBox ID="address" placeholder="Địa chỉ" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Địa chỉ không được để trống" Display="Dynamic" ControlToValidate="address" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-12 mb-30">
                                <asp:TextBox ID="password" placeholder="Mật khẩu" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Mật khẩu không được để trống" Display="Dynamic" ControlToValidate="password" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            </div>
                            
                            <div class="col-12">
                                <asp:Button ID="Button1" runat="server" Text="Sửa" OnClick="Button1_Click" />
                            </div>
                        </div>
                    </form>
                    
                </div>
            </div>
            
        </div>
    </div>
</div><!-- Register Section End -->
</asp:Content>

