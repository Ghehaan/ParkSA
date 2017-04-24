$(document).ready(function () {
    $("#filterButton").click(function () {
        $(this).toggleClass("selected");
        if ($(this).hasClass("selected")) {
            $("#FilterControl").slideDown();
        }
        else {
            $("#FilterControl").slideUp();
        }
    });
    $("#listButton").click(function () {
        $("#galleryButton").removeClass("selected");
        $("#mapButton").removeClass("selected");
        if (!$("#listButton").hasClass("selected")) {
            $("#listButton").addClass("selected");
            $(".ParkTypeList").show();
            $("#mapPanel").hide();
            $("#parksPanel .row > div").each(function () {
                $(this).removeClass("col-sm-4");
                $(this).addClass("col-sm-12");
                $(this).find(".Park").addClass("List");
            });

        }
        if ($("#galleryButton").hasClass("selected")) {
            $("#galleryButton").removeClass("selected");
        }
    });
    $("#galleryButton").click(function () {
        $("#listButton").removeClass("selected");
        $("#mapButton").removeClass("selected");
        if (!$("#galleryButton").hasClass("selected")) {
            $("#galleryButton").addClass("selected");
            $(".ParkTypeList").show();
            $("#mapPanel").hide();
            $("#parksPanel .row > div").each(function () {
                $(this).removeClass("col-sm-12");
                $(this).addClass("col-sm-4");
                $(this).find(".Park").removeClass("List");
                $(this).find(".Park").addClass("Gallery");
            });
        }
    });
    $("#mapButton").click(function () {
        $("#listButton").removeClass("selected");
        $("#galleryButton").removeClass("selected");
        if (!$("#mapButton").hasClass("selected")) {
            $("#mapButton").addClass("selected");
            $(".ParkTypeList").hide();
            $("#mapPanel").show();
        }
        //$("#mapPanel")
    });
    $("#listButton > .glyphicon").click(function () {
    });
    $("#listButton").trigger("click");
});