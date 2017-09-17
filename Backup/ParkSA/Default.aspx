<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ParkSA._Default" %>

<%@ Register TagPrefix="cu" Src="Controls/FacilityFilterControl.ascx" TagName="FacilityFilter" %>
<%@ Register TagPrefix="cu" Src="Controls/ParksControl.ascx" TagName="Parks" %>
<%@ Register TagPrefix="cu" Src="Controls/MapControl.ascx" TagName="Map" %>
<%@ Register TagPrefix="cu" Src="Controls/FilterNavigationControl.ascx" TagName="FilterNavigation" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <header>
        <div class="container">
            <div class="row">
                <div class="col-sm-12">
                    <div> <!--class="header-content"-->
                        <div> <!--class="header-content-inner"--> 

                        <H1>Filter by Facility</H1>
                        <div><p>Includes over 250 glyphs in font format from the Glyphicon Halflings set. Glyphicons Halflings are normally not available for free, but their creator has made them available for Bootstrap free of cost. As a thank you, we only ask that you include a link back to Glyphicons whenever possible.</p>
                        </div>
                        <cu:FilterNavigation id="FilterNavigation" runat="server"></cu:FilterNavigation>
                        
                            <cu:FacilityFilter id="FacilityFilter" runat="Server"></cu:FacilityFilter>
                            <cu:Parks id="Parks" runat="Server"></cu:Parks>
                            <cu:Map id="Map" runat="Server"></cu:Map>
                            <!--<h1>Live and study in comfort in modern styled rooms in Klemzig, South Australia</h1>-->
                            <!--<a href="#download" class="btn btn-outline btn-xl page-scroll">Start Now for Free!</a>-->
                            <br />
                        </div>
                    </div>
                </div>               
            </div>
        </div>
    </header>
    <!--<section id="rooms" class="">-->
    <!-- download bg-primary -->
    <!--<div class="container">
            <div class="row">
                <div class="col-md-12">
                    
                </div>
            </div>
        </div>
    </section>-->
</asp:Content>
