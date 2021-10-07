<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site.master" AutoEventWireup="true" CodeFile="Category.aspx.cs" Inherits="Admin_Category" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="container-fluid">
        <div class="page-header">
            <div class="row">
            <div class="col-sm-6">
                <h3>Danh mục</h3>
                <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="Default.aspx">Trang chủ</a></li>
                <li class="breadcrumb-item">Danh mục</li>
                </ol>
            </div>
            <div class="col-sm-6">
                <!-- Bookmark Start-->
                <div class="bookmark">
                <ul>
                    <li><a href="javascript:void(0)"><i class="bookmark-search" data-feather="search"></i></a>
                    <form class="form-inline search-form">
                        <div class="form-group form-control-search">
                        <input type="text" placeholder="Tìm kiếm danh mục..."/>
                        </div>
                    </form>
                    </li>
                </ul>
                </div>
                <!-- Bookmark Ends-->
            </div>
            </div>
        </div>
    </div>
          <!-- Container-fluid starts-->
          <div class="container-fluid">
            <div class="row">
              <div class="col-sm-12">
                <div class="card">
                  <div class="card-header">
                    <h5>Danh sách danh mục</h5>
                  </div>
                  <div class="table-responsive">
                    <table class="table table-hover">
                      <thead>
                        <tr>
                          <th scope="col">#</th>
                          <th scope="col">First Name</th>
                          <th scope="col">Last Name</th>
                          <th scope="col">Username</th>
                          <th scope="col">Role</th>
                          <th scope="col">Country</th>
                        </tr>
                      </thead>
                      <tbody>
                        <tr>
                          <th scope="row">1</th>
                          <td>Alexander</td>
                          <td>Orton</td>
                          <td>@mdorton</td>
                          <td>Admin</td>
                          <td>USA</td>
                        </tr>
                        <tr>
                          <th scope="row">2</th>
                          <td>John Deo</td>
                          <td>Deo</td>
                          <td>@johndeo</td>
                          <td>User</td>
                          <td>USA</td>
                        </tr>
                        <tr>
                          <th scope="row">3</th>
                          <td>Randy Orton</td>
                          <td>the Bird</td>
                          <td>@twitter</td>
                          <td>admin</td>
                          <td>UK</td>
                        </tr>
                        <tr>
                          <th scope="row">4</th>
                          <td>Randy Mark</td>
                          <td>Ottandy</td>
                          <td>@mdothe</td>
                          <td>user</td>
                          <td>AUS</td>
                        </tr>
                        <tr>
                          <th scope="row">5</th>
                          <td>Ram Jacob</td>
                          <td>Thornton</td>
                          <td>@twitter</td>
                          <td>admin</td>
                          <td>IND</td>
                        </tr>
                      </tbody>
                    </table>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <!-- Container-fluid Ends-->
</asp:Content>

