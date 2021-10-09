<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site.master" AutoEventWireup="true" CodeFile="EditProduct.aspx.cs" Inherits="Admin_EditProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="container-fluid">
            <div class="page-header">
              <div class="row">
                <div class="col-sm-6">
                  <h3>Sửa sản phẩm</h3>
                  <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="Default.aspx">Trang chủ</a></li>
                    <li class="breadcrumb-item">Sửa sản phẩm</li>
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
                    <h5>Sửa sản phẩm</h5>
                  </div>
                  <form id="Form1" class="form theme-form" runat="server">
                    <div class="card-body">
                      <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="name">Tên sản phẩm</label>
                              <asp:TextBox class="form-control" ID="name" placeholder="Nhập tên sản phẩm..." runat="server"></asp:TextBox>
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="brand">Thương hiệu</label>
                              <asp:TextBox class="form-control" ID="brand" placeholder="Nhập tên thương hiệu..." runat="server"></asp:TextBox>
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="exampleFormControlSelect9">Danh mục</label>
                              <asp:DropDownList class="form-select digits" ID="DropDownList1" runat="server">
                                  <asp:ListItem Selected="True" Value="White"> White </asp:ListItem>
                                  <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                                  <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                                  <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                                  <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                              </asp:DropDownList>
                          </div>
                        </div>

                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="brand">Giá gốc</label>
                              <asp:TextBox class="form-control" ID="TextBox1" placeholder="Nhập tên giá gốc..." runat="server" TextMode="Number"></asp:TextBox>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="brand">Giá bán</label>
                              <asp:TextBox class="form-control" ID="TextBox2" placeholder="Nhập tên giá bán..." runat="server" TextMode="Number"></asp:TextBox>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="brand">Avatar</label>
                              <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="brand">Hình ảnh điện thoại</label>
                               <asp:FileUpload class="form-control" ID="FileUpload2" runat="server" />
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="exampleFormControlSelect9">Trạng thái</label>
                              <asp:DropDownList class="form-select digits" ID="DropDownList2" runat="server">
                                  <asp:ListItem Selected="True" Value="White"> White </asp:ListItem>
                                  <asp:ListItem Value="Silver"> Silver </asp:ListItem>
                                  <asp:ListItem Value="DarkGray"> Dark Gray </asp:ListItem>
                                  <asp:ListItem Value="Khaki"> Khaki </asp:ListItem>
                                  <asp:ListItem Value="DarkKhaki"> Dark Khaki </asp:ListItem>
                              </asp:DropDownList>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="exampleFormControlSelect9">Thông tin khuyến mại</label>
                              <asp:TextBox class="summernote" ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="exampleFormControlSelect9">Thông số kỹ thuật</label>
                              <asp:TextBox class="summernote" ID="TextBox4" runat="server" TextMode="MultiLine"></asp:TextBox>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="exampleFormControlSelect9">Mô tả điện thoại</label>
                              <asp:TextBox class="summernote" ID="TextBox5" runat="server" TextMode="MultiLine"></asp:TextBox>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="card-footer text-end">
                        <asp:Button class="btn btn-primary" type="submit" ID="Button1" runat="server" Text="Thêm" />
                      <input class="btn btn-light" type="reset" value="Xóa form"/>
                    </div>
                  </form>
                </div>
              </div>
            </div>
          </div>
          <!-- Container-fluid Ends-->
</asp:Content>

