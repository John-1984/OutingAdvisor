$(document).ready();

//Initiallize before use
function initializeSuggestions() {
    HideSection("#divSearch", "#divOuter");

    $("#btnSave").on("click", function (e) {
        e.preventDefault(); // <------------------ stop default behaviour of button
        var element = this;
        $.ajax({
            url: "/Suggestions/SaveSuggestions",
            type: "POST",
            data: fetchSuggestions(element),
            dataType: "json",
            traditional: true,
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                if (data.Result == "True") {
                    $(element).parent(0).parent(".parent").find(".Message")[0].innerText = "Thanks for Feedback";
                    alert("Done");
                } else {
                    $(element).parent(0).parent(".parent").find(".Message")[0].innerText = "A Server Issue Happened.";
                    alert("Error occurs on the Database level!::" + data.Result);
                }
            },
            error: function (jqXHR, exception) {
                $(element).parent(0).parent(".parent").find(".Message")[0].innerText = "A Server Issue Happened.";
                alert("An error has occured!!!");
            }
        });
    });
}

function fetchSuggestions(element) {
    var _parent = $(element).parent(0).parent(".parent");
    var _usefullness = _parent.find(".usefullness").attr('data-value');
    var _satisfaction = _parent.find(".satisfaction").attr('data-value');
    var _easeofuse = _parent.find(".easeofuse").attr('data-value');
    var _lookandfeel = _parent.find(".lookandfeel").attr('data-value');
    var _feedback = _parent.find(".feedback")[0].value;

    return JSON.stringify({ 'Usefullness': _usefullness, 'Satisfaction': _satisfaction, 'EaseOfUse': _easeofuse, 'LookAndFeel': _lookandfeel, 'Feedback': _feedback });
}