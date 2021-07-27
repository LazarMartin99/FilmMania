<?php
    include_once 'connect.php';


        if(isset($_POST['bookingid']))
        {
            $bookingid = $_POST['bookingid'];
            $sql= "DELETE FROM booking WHERE bookingId=$bookingid";
            $result = $conn -> query($sql) or die($conn->error);

            if($result){

                echo 1;

            }
            else{
                echo 0;
            }

        }












    ?>

