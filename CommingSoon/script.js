$("#registrationForm").submit(function( event ) {  
    event.preventDefault();
    var formData = $(this).serialize();
    $("#loaderContainer").css("display", "flex");
    $.ajax({
        type: "POST",
        url: "http://localhost:4644/api/Account/Register",
        data: formData,
        success: function (result) {
            console.log(result);
            $("#registrationContnetBody").html(result);
            $("#registrationContnetBody").replaceWith( "<div class='message-body'>" + result + "</div>" );
            $("#loaderContainer").css("display", "none");
        },
        error: function (xhr, status, error) {
            alert("Error: " + xhr.responseJSON["Message"]);
            $("#loaderContainer").css("display", "none");
        }
    });
});


$("#registrationFormAR").submit(function (event) {
    event.preventDefault();
    var formData = $(this).serialize();
    $("#loaderContainer").css("display", "flex");
    $.ajax({
        type: "POST",
        url: "http://localhost:4644/api/Account/RegisterAR",
        data: formData,
        success: function (result) {
            console.log(result);
            $("#registrationContnetBody").html(result);
            $("#registrationContnetBody").replaceWith("<div class='message-body'>" + result + "</div>");
            $("#loaderContainer").css("display", "none");
        },
        error: function (xhr, status, error) {
            alert("Error: " + xhr.responseJSON["Message"]);
            $("#loaderContainer").css("display", "none");
        }
    });
});