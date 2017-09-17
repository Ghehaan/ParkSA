<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FilterNavigationControl.ascx.cs" Inherits="ParkSA.Controls.FilterNavigationControl" %>
<script src="../Scripts/filterNavigation.js" type="text/javascript"></script>
<div class="filterPanel">
                            <div style="float:left;">
                                <div id="filterButton" class="button ">
                                    <span class="glyphicon glyphicon-filter"></span>
                                    Filter
                                </div>
                                <div id="sortButton" class="button ">
                                    <span class="sort-icon"></span>
                                    Sort
                                </div>
                                <div id="perPageButton" class="button ">
                                    <span class="glyphicon glyphicon-menu-hamburger"></span>
                                    Per Page
                                </div>
                            </div>
                            <div style="float:right;">
                                <div id="listButton" class="button">
                                    <span class="glyphicon glyphicon-th-list"></span>
                                    List
                                </div>
                                <div id="galleryButton" class="button ">
                                    <span class="glyphicon glyphicon-th"></span>
                                    Gallery
                                </div>
                                <div id="mapButton" class="button ">
                                    <span class="glyphicon glyphicon-map-marker"></span>
                                    Map
                                </div>
                            </div>
                            <div style="clear:both;"></div>
                        </div>