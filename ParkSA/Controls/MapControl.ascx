<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MapControl.ascx.cs" Inherits="ParkSA.Controls.MapControl" %>
<div id="mapPanel">
    <div id="googleMap" style="width:100%;height:400px;border-radius:4px;border:1px solid #ddd;"></div>
</div>
<script>
function myMap() {
var mapProp= {
    center:new google.maps.LatLng(-34.8845909,138.6773887),
    zoom:11
};
var map=new google.maps.Map(document.getElementById("googleMap"),mapProp);
}
</script>

<script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyCw3shA4GOTABeBPJ7BZAO0eO805tl6Dvs&callback=myMap"></script>
