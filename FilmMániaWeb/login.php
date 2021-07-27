<?php 
    
    include_once 'connect.php';

    session_start();

    if($_SERVER["REQUEST_METHOD"]=="POST"&&isset($_POST["username"])&&isset($_POST["password"])){
        $username = $_POST["username"];
        $password = $_POST["password"];
        $sql = "SELECT * FROM login WHERE username = '$username' AND userpassword='$password' ";
        $result = $conn -> query($sql);
        
        if($result -> num_rows==1)
        {
            $row = $result -> fetch_assoc();
            $_SESSION["userid"]=$row["userId"];
            echo 1;
        }
        else
        {
            echo 0;
        }
        
        
    }

    
	
 ?>