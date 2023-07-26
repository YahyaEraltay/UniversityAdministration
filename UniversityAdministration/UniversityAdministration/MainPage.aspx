<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="UniversityAdministration.MainPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            
            margin-left:30px;
            margin-top:30px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="auto-style1">
        <strong><asp:Label ID="Label1" runat="server" Text="Label" style="font-size:large">University Name</asp:Label></strong>
        <br /><br />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Add University"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="Button1_Click" />
    </div>
</asp:Content>
