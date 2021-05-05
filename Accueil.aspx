<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Accueil.aspx.cs" Inherits="MasterSite.Accueil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <style>
       .accueil{
           background-color:red;
           font-size:150%;
           text-align:justify;
           margin:5px;
       }
   </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="accueil">
        <p>
            ici cest la page d'accueil bienvenue et merci dans votre site!
        </p>
    </div>
</asp:Content>
