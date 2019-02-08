$(document).ready(
    function () {
        searchInitialize();
    });

function searchInitialize() {
    $("#btnFilter").on("click", function () { window.location.href = "/Location/Location" });
    $("#btnHome").on("click", function () { window.location.href = "/Location/Home" });
}