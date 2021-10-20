<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site.master" AutoEventWireup="true" CodeFile="CreateProduct.aspx.cs" Inherits="Admin_CreateProduct"  ValidateRequest="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
        <div class="container-fluid">
            <div class="page-header">
              <div class="row">
                <div class="col-sm-6">
                  <h3>Thêm sản phẩm</h3>
                  <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="Default.aspx">Trang chủ</a></li>
                    <li class="breadcrumb-item">Thêm sản phẩm</li>
                  </ol>
                </div>
              </div>
            </div>
          </div>
          <!-- Container-fluid starts-->
          <div class="container-fluid">
            <div class="row">
              <div class="col-sm-12">
                <div class="card">
                  <div class="card-header pb-0">
                    <h5>Thêm sản phẩm</h5>
                  </div>
                  <form class="form theme-form" runat="server">
                    <div class="card-body">
                      <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="name">Tên sản phẩm *</label>
                              <asp:TextBox class="form-control" ID="name" placeholder="Nhập tên sản phẩm..." runat="server"></asp:TextBox>
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Tên không được để trống" Display="Dynamic" ControlToValidate="name" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="brand">Thương hiệu *</label>
                              <asp:TextBox class="form-control" ID="brand" placeholder="Nhập tên thương hiệu..." runat="server"></asp:TextBox>
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Thương hiệu không được để trống" Display="Dynamic" ControlToValidate="brand" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="listcategory">Danh mục *</label>
                              <asp:DropDownList class="form-select digits" ID="listcategory" runat="server">
                              </asp:DropDownList>
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator8" runat="server" ErrorMessage="Danh mục không được để trống" Display="Dynamic" ControlToValidate="listcategory" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>

                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="originprice">Giá gốc *</label>
                              <asp:TextBox class="form-control" ID="originprice" placeholder="Nhập tên giá gốc..." runat="server" TextMode="Number"></asp:TextBox>
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Giá gốc không được để trống" Display="Dynamic" ControlToValidate="originprice" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="saleprice">Giá bán *</label>
                              <asp:TextBox class="form-control" ID="saleprice" placeholder="Nhập tên giá bán..." runat="server" TextMode="Number"></asp:TextBox>
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator6" runat="server" ErrorMessage="Giá bán không được để trống" Display="Dynamic" ControlToValidate="saleprice" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="avatar">Avatar *</label>
                              <asp:FileUpload class="form-control" ID="avatar" runat="server" />
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Avatar không được để trống" Display="Dynamic" ControlToValidate="avatar" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="images">Hình ảnh điện thoại *</label>
                               <asp:FileUpload class="form-control" ID="images" runat="server" AllowMultiple="True" />
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator7" runat="server" ErrorMessage="Hình ảnh không được để trống" Display="Dynamic" ControlToValidate="images" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="status">Trạng thái *</label>
                              <asp:DropDownList class="form-select digits" ID="status" runat="server">
                                  <asp:ListItem Value="1"> Đang nhập </asp:ListItem>
                                  <asp:ListItem Value="2"> Mở bán </asp:ListItem>
                                  <asp:ListItem Value="3"> Cũ </asp:ListItem>
                                  <asp:ListItem Value="4"> Hết hàng </asp:ListItem>
                              </asp:DropDownList>
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Trạng thái không được để trống" Display="Dynamic" ControlToValidate="status" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="promotion">Thông tin khuyến mại *</label>
                              <asp:TextBox class="summernote" ID="promotion" runat="server" TextMode="MultiLine"></asp:TextBox>
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator9" runat="server" ErrorMessage="Thông tin khuyến mại không được để trống" Display="Dynamic" ControlToValidate="promotion" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="specifications">Thông số kỹ thuật *</label>
                              <asp:TextBox class="summernote" ID="specifications" runat="server" TextMode="MultiLine"></asp:TextBox>
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator11" runat="server" ErrorMessage="Thông số không được để trống" Display="Dynamic" ControlToValidate="specifications" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="content">Mô tả điện thoại *</label>
                              <asp:TextBox class="summernote" ID="content" runat="server" TextMode="MultiLine" ControlToValidate="content"></asp:TextBox>
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator10" runat="server" ErrorMessage="Mô tả không được để trống" Display="Dynamic" ControlToValidate="content" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="card-footer text-end">
                        <asp:Button class="btn btn-primary" type="submit" ID="Button1" runat="server" Text="Thêm" OnClick="Button1_Click" />
                      <input class="btn btn-light" type="reset" value="Xóa form"/>
                    </div>
                  </form>
                </div>
              </div>
            </div>
          </div>
          <!-- Container-fluid Ends-->
</asp:Content>

