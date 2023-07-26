<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ProfessorList.aspx.cs" Inherits="UniversityAdministration.Professor.ProfessorList" %>

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
                    <th>Professor Name</th>
                    <th>Department Name</th>
                    <th>Faculty Name</th>
                    <th>University Name</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("professor_id") %></td>
                            <td><%# Eval("professor_name") %></td>
                            <td><%# GetDepName(Convert.ToInt32( Eval("department_id"))) %></td>
                            <td><%# GetFacName(Convert.ToInt32( Eval("faculty_id"))) %></td>
                            <td><%# GetUniName(Convert.ToInt32( Eval("university_id"))) %></td>
                            <td>
                                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl='<%#"/Professor/DeleteProfessor.aspx?id=" + Eval("professor_id") %>'>Delete</asp:HyperLink>
                                <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn btn-warning" NavigateUrl='<%#"/Professor/UpdateProfessor.aspx?id=" + Eval("professor_id") %>'>Update</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
    <div class="auto-style1">
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="/Professor/AddProfessor.aspx" CssClass="btn btn-success">Add Professor</asp:HyperLink>
    </div>
</asp:Content>
