$(document).ready(function () {
    $(document).on("change", ".time", function () {
        $(".seat-btn").removeAttr("disabled");

    });
    $(document).on('change','.date',function(){
        let pid = $(this).children(":selected").val();
        console.log(pid);
        $.ajax({
           url: 'getorders.php',
           method: 'post',
           data: {pid:pid},
           success: function(data){
                $(".order").html(data);
           }
        });

    });
    $(document).on('change','.datum',function(){
       let pid = $(this).children(":selected").val();

        $.ajax({
            url: 'gettimes.php',
            method: 'post',
            data: {pid: pid},
            success: function(data){
                $(".projection-time").html(data);
            }
        });
    });

    $(document).on('click','.delete' ,function(){

       let bookingid=$(this).attr("id");
       console.log(bookingid);
    $.ajax({

        url:'deletebooking.php',
        method: 'post',
        data: {bookingid:bookingid},
        success: function (data)
        {
            if(data==1)
            {
                $(".orders").before("<div class='alert alert-info font-weight-bold text-center display-4'>Sikeres törlés</div>");
                setTimeout(function(){

                    location.reload();

                },2000);
            }
        }




    })


    });


});