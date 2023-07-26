<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="FacultyList.aspx.cs" Inherits="UniversityAdministration.FacultyList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 30px;
            margin-top: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style1">
        <table class="table table-bordered table-hover">
            <thead>
                <tr>
                    <th>ID</th>
                    <th>Faculty Name</th>
                    <th>University Name</th>
                    <th>Operation</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("faculty_id") %></td>
                            <td><%#Eval("faculty_name") %></td>
                            <td><%# GetUniName(Convert.ToInt32( Eval("university_id"))) %></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%#"FacultyDelete.aspx?id=" + Eval("faculty_id") %>' CssClass="btn btn-danger">Delete</asp:HyperLink>
                                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl='<%#"UpdateFaculty.aspx?id="+Eval("faculty_id") %>' CssClass="btn btn-warning">Update</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
    <div class="auto-style1">
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="/Faculty/AddFaculty.aspx" CssClass="btn btn-success">Add Faculty</asp:HyperLink>
    </div>
</asp:Content>
