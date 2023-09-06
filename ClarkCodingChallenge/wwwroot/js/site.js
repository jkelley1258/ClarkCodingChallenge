// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function sendContactInformation(e, contactSubmitURL) {
    var contactObj = $("#contactForm").serializeArray();

    $.ajax({
        type: "POST",
        url: contactSubmitURL,
        data: contactObj,
        cache: false,
        success: function (result) {
            alert("submit successful");
            $("#contactForm")[0].reset();
        },
        error: function (result) {
            alert("failed to submit results");
        }
    });

    e.preventDefault();
}