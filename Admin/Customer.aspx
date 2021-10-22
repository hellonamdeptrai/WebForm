<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Site.master" AutoEventWireup="true" CodeFile="Customer.aspx.cs" Inherits="Admin_Customer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="container-fluid">
        <div class="page-header">
            <div class="row">
            <div class="col-sm-6">
                <h3>Khách hàng</h3>
                <ol class="breadcrumb">
                <li class="breadcrumb-item"><a href="Default.aspx">Trang chủ</a></li>
                <li class="breadcrumb-item">Khách hàng</li>
                </ol>
            </div>
            <div class="col-sm-6">
                <!-- Bookmark Start-->
                <div class="bookmark">
                <ul>
                    <li><a href="CreateCustomer.aspx"><i data-feather="plus"></i></a></li>
                    <li><a href="javascript:void(0)"><i class="bookmark-search" data-feather="search"></i></a>
                    <form class="form-inline search-form">
                        <div class="form-group form-control-search">
                        <input type="text" placeholder="Tìm kiếm khách hàng..."/>
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
                    <h5>Danh sách khách hàng</h5>
                  </div>
                  <div class="table-responsive">
                    <table class="table table-hover">
                      <thead>
                        <tr>
                          <th scope="col">Id</th>
                          <th scope="col">Avatar</th>
                          <th scope="col">Tên nhân viên</th>
                          <th scope="col">Email</th>
                          <th scope="col">Trạng thái</th>
                          <th scope="col">Số điện thoại</th>
                          <th scope="col">Quê Quán</th>
                          <th scope="col">Ngày tạo</th>
                          <th scope="col">Ngày chỉnh sửa</th>
                          <th scope="col">Hành động</th>
                        </tr>
                      </thead>
                      <tbody>
                          <% foreach (Customer item in listCustomer) 
                             { %>
                        <tr>
                          <th scope="row"><%: item.Id %></th>
                        <td class="text-center">
                            <img class="rounded" src="../Images/<%: item.Avatar %>" alt="Avatar" width="100"/>
                        </td>
                          <td><%: item.Name %></td>
                          <td><%: item.Email %></td>
                          <td>
                              <%: Int16.Parse(item.Status) == 1 ? "Mở":"Đã Khóa"  %>
                          </td>
                          <td><%: item.Phone %></td>
                          <td><%: item.Address %></td>
                          <td><%: item.Date_created %></td>
                          <td><%: item.Date_edit %></td>
                          <td>
                                 <a href="EditCustomer.aspx?id=<%: item.Id %>&page=<%: page %>" role="button" class="btn btn-outline-primary px-3"><i class="fa fa-pencil" aria-hidden="true"></i></a>
                                 <a href="DeleteCustomer.aspx?id=<%: item.Id %>&page=<%: page %>" role="button" class="btn btn-outline-danger px-3"><i class="fa fa-trash-o" aria-hidden="true"></i></a>
                           </td>
                        </tr>
                        <%} %>
                      </tbody>
                    </table>
                      </div>
                    <nav class="d-flex justify-content-end m-2" aria-label="Page navigation example">
                      <ul class="pagination">
                          <li class="page-item <%: page-1==0?"disabled":"" %>">
                              <a class="page-link" href="Customer.aspx?p=<%: page-1 %>" aria-label="Previous">
                                <span aria-hidden="true">&laquo;</span>
                                <span class="sr-only">Previous</span>
                              </a>
                            </li>
                          <%foreach (int item in pageList)
                            {
                                cp++; %>
                        <li class="page-item <%: item==page?"active":"" %>"><a class="page-link" href="Customer.aspx?p=<%: item %>"><%: item %></a></li>
                          <%} %>
                          <li class="page-item <%: page+1==cp?"disabled":"" %>">
                              <a class="page-link" href="Customer.aspx?p=<%: page+1 %>" aria-label="Next">
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
          </div>
          <!-- Container-fluid Ends-->
</asp:Content>

