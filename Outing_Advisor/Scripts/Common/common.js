$(document).ready(
    function () {
        initialize();
    });

function initialize() {
    $("#divFullDescription").on("click", function () { toggleContent('#divFullDescription') });
    $("#divTravelTips").on("click", function () { toggleContent('#divTravelTips') });
    $("#divHotelTips").on("click", function () { toggleContent('#divHotelTips') });
    $("#divHotelListing").on("click", function () { toggleContent('#divHotelListing') });
    $("#divReviews").on("click", function () { toggleContent('#divReviews') });
    $("#divFeedback").on("click", function () { toggleContent('#divFeedback') });

    $(".toggleButton").on("click", function (event) { toggleQuickDetails(event.target) });
    $(".ui-icon-circle-arrow-w").click(function (event) { previousImage(event.target); })
    $(".ui-icon-circle-arrow-e").click(function (event) { nextImage(event.target); })
}
    
function toggleContent(divId) {
    $(divId + "Content").toggleClass("invisible");
}

function toggleQuickDetails(target) {
    var element = $(target).parent().parent();
    element.find('.divRatings').toggleClass("invisible visible");
    element.find('.divPictures').toggleClass("invisible visible");
}

//Here change the source value of the image to change the image
function previousImage(target) {
    var element = $(target).parent();
    element.find('.picture').attr("src", "/Content/Images/fadedblue.png");
}
function nextImage(target) {
    var element = $(target).parent();
    element.find('.picture').attr("src", "/Content/Images/header.jpg");
}  

function ShowSection(target, parent) {
    $(parent).find(target).show();
}

function HideSection(target, parent) {
    $(parent).find(target).hide();
}