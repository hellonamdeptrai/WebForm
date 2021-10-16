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
                    <li><a href="CreateCategory.aspx"><i data-feather="plus"></i></a></li>
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
                      <form runat="server">
                          <table id="data-table-category" class="table table-hover">
                              <thead>
                                <tr>
                                  <th scope="col">Id</th>
                                  <th scope="col">Tên danh mục</th>
                                  <th scope="col">Mô tả</th>
                                  <th scope="col">Ngày chỉnh sửa</th>
                                    <th scope="col">Ngày tạo</th>
                                  <th scope="col">Hành động</th>
                                </tr>
                              </thead>
                              <tbody>
                                  <% foreach (Category item in listCategories)
                                     { %>
                                <tr>
                                  <th scope="row"><%: item.Id %></th>
                                  <td><%: item.Name %></td>
                                  <td><%: item.Description %></td>
                                  <td><%: item.DateEdit %></td>
                                    <td><%: item.DateCreated %></td>
                                    <td>
                                        <a href="EditCategory.aspx?id=<%: item.Id %>&page=<%: page %>" role="button" class="btn btn-outline-primary px-3"><i class="fa fa-pencil" aria-hidden="true"></i></a>
                                        <a href="DeleteCategory.aspx?id=<%: item.Id %>&page=<%: page %>" role="button" class="btn btn-outline-danger px-3"><i class="fa fa-trash-o" aria-hidden="true"></i></a>
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
                              <a class="page-link" href="Category.aspx?p=<%: page-1 %>" aria-label="Previous">
                                <span aria-hidden="true">&laquo;</span>
                                <span class="sr-only">Previous</span>
                              </a>
                            </li>
                          <%foreach (int item in pageList)
                            {
                                cp++; %>
                        <li class="page-item <%: item==page?"active":"" %>"><a class="page-link" href="Category.aspx?p=<%: item %>"><%: item %></a></li>
                          <%} %>
                          <li class="page-item <%: page+1==cp?"disabled":"" %>">
                              <a class="page-link" href="Category.aspx?p=<%: page+1 %>" aria-label="Next">
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
          <!-- Container-fluid Ends-->
</asp:Content>

