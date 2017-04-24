<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ParksControl.ascx.cs" Inherits="ParkSA.Controls.ParksControl" %>
<link href="../Styles/parkList.css" rel="stylesheet" type="text/css" />
<div id="parksPanel">
<asp:Label ID="Total" runat="server" />
<asp:Panel ID="ParksList" CssClass="ParkTypeList" runat="server" />
</div>