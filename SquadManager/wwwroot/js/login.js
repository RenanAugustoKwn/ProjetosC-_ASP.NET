function Login(event) {
    event.preventDefault();
    var formData = {
        email: $("email").val(),
        password: $("password").val()
    }
    $.ajax({
        type: "POST",
        dataType: "json",
        contentType: "application/json; charset=UTF=8",
        data: JSON.stringify(formData),
        url: "https://localhost:44334/api/user",
        success: function(result) {

        },
        error: function (error) {

        }
    });
}
