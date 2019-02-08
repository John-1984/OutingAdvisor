var pageX;
var pageY;
var percent;

$(document).ready(
    function () {
        starInitialize();
    });

function starInitialize() {
    $(document).on("mousedown", function (e) {
        pageX = e.pageX;
        pageY = e.pageY;
    });

    $(".star-icon").on("click", function (event) { starClick(event.target); });
}

function starClick(target) {
    var readOnly = $(target).attr("aria-readonly") ? $(target).attr("aria-readonly") : false;
    if (!readOnly) {
        percent = getPercent(target); changeCSS(target); saveValue(target);
    }
}

function changeCSS(target) {
    if (percent <= 0) { $(target).removeClass("star-nostar star-one star-two star-three star-four star-five").addClass("star-nostar"); }
    else if (percent > 0 && percent <= 20) { $(target).removeClass("star-nostar star-one star-two star-three star-four star-five").addClass("star-one"); }
    else if (percent > 20 && percent <= 40) { $(target).removeClass("star-nostar star-one star-two star-three star-four star-five").addClass("star-two"); }
    else if (percent > 40 && percent <= 60) { $(target).removeClass("star-nostar star-one star-two star-three star-four star-five").addClass("star-three"); }
    else if (percent > 60 && percent <= 80) { $(target).removeClass("star-nostar star-one star-two star-three star-four star-five").addClass("star-four"); }
    else if (percent > 80 && percent <= 100) { $(target).removeClass("star-nostar star-one star-two star-three star-four star-five").addClass("star-five"); }
}

function saveValue(target) {
    if (percent <= 0) { $(target).attr("data-value", "0"); }
    else if (percent > 0 && percent <= 20) { $(target).attr("data-value", "1"); }
    else if (percent > 20 && percent <= 40) { $(target).attr("data-value", "2"); }
    else if (percent > 40 && percent <= 60) { $(target).attr("data-value", "3"); }
    else if (percent > 60 && percent <= 80) { $(target).attr("data-value", "4"); }
    else if (percent > 80 && percent <= 100) { $(target).attr("data-value", "5"); }
}

function getPercent(target) {
    var offset = $(target).offset();
    var difference = pageX - offset.left;
    var controlWidth = 110;
    var percent = (difference / controlWidth) * 100;
    return percent;
}