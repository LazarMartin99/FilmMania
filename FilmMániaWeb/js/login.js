$(document).ready(function() {
    function check_session() {
        $.ajax({
            url: "check_session.php",
            method: "POST",
            success: function(data) {
                if (data == 1) {
                    window.location.href = "index.php";
                }
            }
        })
    }
    $(document).on("click", '.ticket', function() {
        check_session();
    });


    $(function() {

        let errorusername=false;
        let errorpassword=false;

        $('#username').focusout(function () {
            validateUsername();
        });

        $('#password').focusout(function () {
            validatePassword();
        });

        function validateUsername() {
            var username = document.getElementById('username').value;
            var pattern = /^.{3,10}$/

            if (!pattern.test(username)) {

                errorusername=true;
                $('.message').html("A felhasználónév 3-10 karakter hosszú lehet!");
                $('.message').show();


            } else {
                $('.message').hide();
            }
        }

        function validatePassword() {
            var password = document.getElementById('password').value;
            var pattern = /^(?=.[a-z])(?=.*[0-9])(?=.{8,})/;

            if (!pattern.test(password)) {

                errorpassword=true;
                $('.messagepwd').html("A jelszónak tartalmaznia kell számot és legalább 8 karakter hosszú!");
                $('.messagepwd').show();
            } else {
                $('.messagepwd').hide();
            }
        }

        $("#enter").click(function() {
            let username = $("#username").val();
            let password = $("#password").val();

            console.log(username, password);

            errorusername=false;
            errorpassword=false;

            validateUsername();
            validatePassword();
            if(errorusername==false && errorpassword==false)
            {
                $.ajax({
                    url: "login.php",
                    method: "post",
                    data: { username: username, password: password },
                    success: function(data) {
                        if (data == 1) {
                            location.reload();
                        } else {
                            $(".p").after(" <div class='alert alert-danger'> Hibás felhasználónév vagy jelszó </div> ");
                        }
                    }

                });
            }
        });
    });

});



