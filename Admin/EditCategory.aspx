<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site.master" AutoEventWireup="true" CodeFile="EditCategory.aspx.cs" Inherits="Admin_EditCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="container-fluid">
            <div class="page-header">
              <div class="row">
                <div class="col-sm-6">
                  <h3>Sửa danh mục</h3>
                  <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="Default.aspx">Trang chủ</a></li>
                    <li class="breadcrumb-item">Sửa danh mục</li>
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
                    <h5>Sửa danh mục</h5>
                  </div>
                  <form id="Form1" class="form theme-form" runat="server">
                    <div class="card-body">
                      <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="name">Tên danh mục *</label>
                              <asp:TextBox class="form-control" ID="name" placeholder="Nhập tên danh mục..." runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Tên danh mục không được để trống" Display="Dynamic" ControlToValidate="name" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="name">Mô tả danh mục</label>
                              <asp:TextBox class="form-control" ID="description" placeholder="Nhập mô tả danh mục..." runat="server"></asp:TextBox>
                          </div>
                        </div>
                      </div>
                    </div>
                    <div class="card-footer text-end">
                        <asp:Button class="btn btn-primary" type="submit" ID="Button1" runat="server" Text="Sửa" OnClick="Button1_Click" />
                      <input class="btn btn-light" type="reset" value="Xóa form"/>
                    </div>
                  </form>
                </div>
              </div>
            </div>
          </div>
          <!-- Container-fluid Ends-->
</asp:Content>

