﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="AddProfessor.aspx.cs" Inherits="UniversityAdministration.Professor.AddProfessor" %>

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
            <asp:Label ID="Label1" runat="server" Text="Label" Style="font-size: large">Select University</asp:Label></strong>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" AutoPostBack="true" AppendDataBoundItems="true" DataTextField="university_name" DataValueField="university_id" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        <br />
        <strong>
            <asp:Label ID="Label3" runat="server" Text="Label" Style="font-size: large">Select Faculty</asp:Label></strong>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control" AutoPostBack="True" AppendDataBoundItems="true" DataTextField="faculty_name" DataValueField="faculty_id" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"></asp:DropDownList>
        <br />
        <strong>
            <asp:Label ID="Label4" runat="server" Text="Label" Style="font-size: large">Select Department</asp:Label></strong>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control" AutoPostBack="true" AppendDataBoundItems="true" DataTextField="department_name" DataValueField="department_id"></asp:DropDownList>
        <br />
        <strong>
            <asp:Label ID="Label2" runat="server" Text="Label" Style="font-size: large">Professor Name</asp:Label></strong>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Add Professor"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn btn-success" OnClick="Button1_Click"  />
    </div>
</asp:Content>