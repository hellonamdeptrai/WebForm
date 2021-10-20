<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Admin_Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="container-fluid">
        <div class="page-header">
            <div class="row">
            <div class="col-sm-6">
                <h3>Sản phẩm</h3>
                <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="Default.aspx">Trang chủ</a></li>
                <li class="breadcrumb-item">Sản phẩm</li>
                </ol>
            </div>
            <div class="col-sm-6">
                <!-- Bookmark Start-->
                <div class="bookmark">
                <ul>
                    <li><a href="CreateProduct.aspx"><i data-feather="plus"></i></a></li>
                    <li><a href="javascript:void(0)"><i class="bookmark-search" data-feather="search"></i></a>
                    <form class="form-inline search-form">
                        <div class="form-group form-control-search">
                        <input type="text" placeholder="Tìm kiếm sản phẩm..."/>
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
                    <h5>Danh sách sản phẩm</h5>
                  </div>
                  <div class="table-responsive">
                      <form id="Form1" runat="server">
                          <table id="data-table-category" class="table table-hover">
                              <thead>
                                <tr>
                                  <th scope="col">Id</th>
                                  <th scope="col">Ảnh đại diện</th>
                                  <th scope="col">Tên sản phẩm</th>
                                  <th scope="col">Thương hiệu</th>
                                  <th scope="col">Giá bán</th>
                                  <th scope="col">Ngày chỉnh sửa</th>
                                  <th scope="col">Ngày tạo</th>
                                  <th scope="col">Hành động</th>
                                </tr>
                              </thead>
                              <tbody>
                                  <% foreach (Product item in listProducts)
                                     { %>
                                <tr>
                                  <th scope="row"><%: item.Id %></th>
                                  <td class="text-center">
                                      <img class="rounded" src="../Images/<%: item.Avatar %>" alt="Avatar" width="100"/>
                                  </td>
                                  <td><%: item.Name %></td>
                                  <td><%: item.Brand %></td>
                                  <td><%: item.SalePrice %></td>
                                  <td><%: item.DateEdit %></td>
                                  <td><%: item.DateCreated %></td>
                                    <td>
                                        <a href="EditProduct.aspx?id=<%: item.Id %>&page=<%: page %>" role="button" class="btn btn-outline-primary px-3"><i class="fa fa-pencil" aria-hidden="true"></i></a>
                                        <a href="DeleteProduct.aspx?id=<%: item.Id %>&page=<%: page %>" role="button" class="btn btn-outline-danger px-3"><i class="fa fa-trash-o" aria-hidden="true"></i></a>
                                    </td>
                                </tr>
                                <%} %>
                              </tbody>
                            </table>
                      </form>
                    
                  </div>
                    <nav class="d-flex justify-content-end m-2" aria-label="Page navigation example">
                      <ul class="pagination">
                          <li class="page-item <%: page-1==0?"disabled":"" %>">
                              <a class="page-link" href="Product.aspx?p=<%: page-1 %>" aria-label="Previous">
                                <span aria-hidden="true">&laquo;</span>
                                <span class="sr-only">Previous</span>
                              </a>
                            </li>
                          <%foreach (int item in pageList)
                            {
                                cp++; %>
                        <li class="page-item <%: item==page?"active":"" %>"><a class="page-link" href="Product.aspx?p=<%: item %>"><%: item %></a></li>
                          <%} %>
                          <li class="page-item <%: page+1==cp?"disabled":"" %>">
                              <a class="page-link" href="Product.aspx?p=<%: page+1 %>" aria-label="Next">
                                <span aria-hidden="true">&raquo;</span>
                                <span class="sr-only">Next</span>
                              </a>
                            </li>
                      </ul>
                    </nav>
                </div>
                </div>
              </div>
            </div>
          </div>
          <!-- Container-fluid Ends-->
</asp:Content>

