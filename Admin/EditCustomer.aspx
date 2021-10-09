﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site.master" AutoEventWireup="true" CodeFile="EditCustomer.aspx.cs" Inherits="Admin_EditUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="container-fluid">
            <div class="page-header">
              <div class="row">
                <div class="col-sm-6">
                  <h3>Sửa khách hàng</h3>
                  <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="Default.aspx">Trang chủ</a></li>
                    <li class="breadcrumb-item">Sửa khách hàng</li>
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
                    <h5>Sửa khách hàng</h5>
                  </div>
                  <form id="Form1" class="form theme-form" runat="server">
                    <div class="card-body">
                      <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="name">Tên khách hàng</label>
                              <asp:TextBox class="form-control" ID="name" placeholder="Nhập tên khách hàng..." runat="server"></asp:TextBox>
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="brand">Email</label>
                              <asp:TextBox class="form-control" ID="brand" placeholder="Nhập email..." runat="server" TextMode="Email"></asp:TextBox>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="name">Mật khẩu</label>
                              <asp:TextBox class="form-control" ID="TextBox1" placeholder="Nhập tên sản phẩm..." runat="server"></asp:TextBox>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="name">Số điện thoại</label>
                              <asp:TextBox class="form-control" ID="TextBox2" placeholder="Nhập tên sản phẩm..." runat="server"></asp:TextBox>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="name">Quê quán</label>
                              <asp:TextBox class="form-control" ID="TextBox3" placeholder="Nhập tên sản phẩm..." runat="server"></asp:TextBox>
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

