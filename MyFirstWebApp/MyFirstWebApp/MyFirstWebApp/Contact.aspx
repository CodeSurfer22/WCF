<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="MyFirstWebApp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Contacts</h2>
    <p>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="38px" ImageUrl="~/images/ExcelIcon.png" OnClick="ImageButton1_Click" Width="44px" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="CSV" />
    </p>
    </asp:Content>
