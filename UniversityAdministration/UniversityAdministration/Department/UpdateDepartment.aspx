﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="UpdateDepartment.aspx.cs" Inherits="UniversityAdministration.Department.UpdateDepartment" %>

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
        <strong>
            <asp:Label ID="Label1" runat="server" Text="Label" Style="font-size: large">University Name</asp:Label></strong>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
        <br />
        <strong>
            <asp:Label ID="Label3" runat="server" Text="Label" Style="font-size: large">Faculty Name</asp:Label></strong>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" AutoPostBack="True"></asp:DropDownList>
        <br />
        <strong>
            <asp:Label ID="Label2" runat="server" Text="Label" Style="font-size: large">Department Name</asp:Label></strong>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Update Department"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="Button1_Click" />
    </div>
</asp:Content>

