<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site.master" AutoEventWireup="true" CodeFile="EditPersonnel.aspx.cs" Inherits="Admin_EditPersonnel" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="container-fluid">
            <div class="page-header">
              <div class="row">
                <div class="col-sm-6">
                  <h3>Sửa nhân viên</h3>
                  <ol class="breadcrumb">
                    <li class="breadcrumb-item"><a href="Default.aspx">Trang chủ</a></li>
                    <li class="breadcrumb-item">Sửa nhân viên</li>
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
                    <h5>Sửa nhân viên</h5>
                  </div>
                  <form id="Form1" class="form theme-form" runat="server">
                    <div class="card-body">
                      <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="name">Tên nhân viên *</label>
                              <asp:TextBox class="form-control" ID="name" placeholder="Nhập tên nhân viên..." runat="server"></asp:TextBox>
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Tên không được để trống" Display="Dynamic" ControlToValidate="name" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="Email">Email *</label>
                              <asp:TextBox class="form-control" ID="Email" placeholder="Nhập email..." runat="server" TextMode="Email"></asp:TextBox>
                            <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email không được để trống" Display="Dynamic" ControlToValidate="Email" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="Pass">Mật khẩu *</label>
                              <asp:TextBox class="form-control" ID="Pass" placeholder="Nhập mật khẩu ..." runat="server" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Mật khẩu không được để trống" Display="Dynamic" ControlToValidate="Pass" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                      </div>
                       <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="exampleFormControlSelect9">Trạng thái *</label>
                              <asp:DropDownList class="form-select digits" ID="Status" runat="server">
                                  <asp:ListItem Value="1"> Mở </asp:ListItem>
                                  <asp:ListItem Value="2"> Khóa </asp:ListItem>
                              </asp:DropDownList>
                          </div>
                        </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="Phone">Số điện thoại *</label>
                              <asp:TextBox class="form-control" ID="Phone" placeholder="Nhập số điện thoại..." runat="server" TextMode="Phone"></asp:TextBox>
                              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Phone" Display="Dynamic" ErrorMessage="Số điện thoại chưa đúng định dạng  (1234567899)" ForeColor="#CC0000" ValidationExpression="^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$"></asp:RegularExpressionValidator>
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Số điện thoại không được để trống" Display="Dynamic" ControlToValidate="Phone" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="Address">Quê quán *</label>
                              <asp:TextBox class="form-control" ID="Address" placeholder="Nhập quê quán ..." runat="server" TextMode="MultiLine"></asp:TextBox>
                              <asp:RequiredFieldValidator class="form-text" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Quên quán không được để trống" Display="Dynamic" ControlToValidate="Address" ForeColor="#CC0000"></asp:RequiredFieldValidator>

                          </div>
                        </div>
                      </div>
                        <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="Avatar">Avatar *</label>
                              <asp:FileUpload class="form-control" ID="Avatar" runat="server" />
                              <asp:Image ID="Previewimage" runat="server"  Width="200"/>
                          </div>
                        </div>
                      </div>
                      <div class="row">
                        <div class="col">
                          <div class="mb-3">
                            <label class="form-label" for="exampleFormControlSelect9">Quyền *</label>
                              <asp:DropDownList class="form-select digits" ID="Position" runat="server">
                                  <asp:ListItem Value="1"> Admin </asp:ListItem>
                                  <asp:ListItem Value="2"> Nhân viên </asp:ListItem>
                              </asp:DropDownList>
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

