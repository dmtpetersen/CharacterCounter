// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$(document).ready(function () {
    $("#count-chars").submit(function (e) {
        count();
        return false;
    });
});

function count() {
    var dataType = 'application/json; charset=utf-8';
    var submission = $('#charset').val();
    var data = submission;

    $.ajax({
        type: "POST",
        contentType: "application/json",
        url: "api/Count",
        dataType: 'json',
        data: JSON.stringify(data),
        success: function (chars) {
            $("#count-result").empty();
            $("#count-result").append("The character count is " + chars);
        }
    });
}
