<?php
session_start();
include 'connect.php';
if (empty($_SESSION['userid'])) {
    header("location: index.php");
}
?>


<!DOCTYPE html>
<html>

<head>
    <title>Movies!</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="js/jquery-3.4.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/book.js"></script>

    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">

</head>

<body>

<div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel"
     aria-hidden="true">
    <div class="modal-dialog" role="document">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">Bejelentkezés</h5>
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                </button>
            </div>
            <div class="modal-body">
                <form>
                    <div class="form-group">
                        <input type="text" class="form-control" placeholder="Felhasználónév" id="username">
                    </div>
                    <div class="form-group p">
                        <input type="password" class="form-control" placeholder="Jelszó" id="password">
                    </div>
                </form>
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-success" id="enter">Belépés</button>
            </div>
        </div>
    </div>
</div>
<nav class="navbar navbar-expand-lg navbar-dark fixed-top">
    <a class="navbar-brand" href="index.php"> <img src="img/FilmMánialogo.jpg" class="logo">Kezdőlap</a>
    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent"
            aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
    </button>


    <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav ml-auto">
            <?php

            if (empty($_SESSION["userid"])) {
                echo '<li class="nav-item active">
        <a class="nav-link" href="#" data-toggle="modal" data-target="#exampleModal">Bejelentkezés </a>
      </li> ';
            } else {
                echo '  <li class="nav-item active">
                <a class="nav-link" href="orders.php" >Foglalásaim </a>
      </li><li class="nav-item active">
                <a class="nav-link" href="logout.php" >Kijelentkezés </a>
      </li>';
            }

            ?>

        </ul>
    </div>
</nav>

<div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
    <div class="carousel-inner">
        <div class="carousel-caption">
            <h1 class="alert alert-success" style="color:deepskyblue"> A hét sztárja: Leonardo DiCaprio</h1>
        </div>
        <div class="carousel-item active img-responsive">
            <img class="d-block w-100" src="img/__Inception_Wallpaper.jpg" alt="First slide">
        </div>
        <div class="carousel-item">
            <img class="d-block w-100" src="img/inglourious-basterds-main-review.jpg" alt="Second slide">
        </div>
        <div class="carousel-item">
            <img class="d-block w-100" src="img/wallstreetfarkasa.jpg" alt="Third slide">
        </div>
    </div>
    <a class="carousel-control-prev" href="#carouselExampleControls" role="button" data-slide="prev">
        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
    </a>
    <a class="carousel-control-next" href="#carouselExampleControls" role="button" data-slide="next">
        <span class="carousel-control-next-icon" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
    </a>
</div>
<?php
if (isset($_POST["mid"])) {
    $movieid = $_POST['mid'];
    $sql = "SELECT * FROM movie WHERE movieId = '$movieid'";
    $result = $conn->query($sql);
    $row = $result->fetch_assoc();


    ?>
    <div class="container">
        <div class="card movie-card text-center">
            <div class="card-header">
                <ul class="nav nav-tabs card-header-tabs">
                    <li class="nav-item">
                        <a class="nav-link active" href="#">Jegyfoglalás a <?php echo $row['title']; ?> című filmre.</a>
                    </li>
                </ul>
            </div>
            <div class="card-body">
                <div class="row">
                    <div class="col-lg-4"><?php echo '<img class="movieimg" src="data:image/jpeg;base64,' . base64_encode($row['img']) . '"/>'; ?></div>
                    <div class="col-lg-8">
                        <form method="post" action="book.php">
                            <div class="form-group">
                                <h2><?php echo $row['title']; ?></h2>
                                <h3><?php echo $row['genre']; ?></h3>
                                <p><?php echo $row['about']; ?></p>
                                <?php
                                $date = '<select class="custom-select datum"><option>Válassz dátumot!</option>';
                                $sql = "SELECT * FROM projection WHERE movie_id = '$movieid'";
                                $result = $conn->query($sql);
                                while ($row = $result->fetch_assoc()) {
                                    $date .= '<option value="' . $row["projectionId"] . '">' . $row['date'] . '</option>';
                                }
                                $date .= '</select>';

                                if (isset($_POST['submit'])) {
                                    $pid = $_POST['pid'];

                                }
                                ?>
                            </div>
                            <div class="form-group">
                                <?php
                                $sql = "SELECT * FROM projection WHERE movie_id = '$movieid'";
                                $res = $conn -> query($sql);
                                if($res ->num_rows > 1){
                                    echo $date;
                                    echo '<div class="form-group projection-time mt-2">
                            </div>
                            <div class="form-group">
                                <button name="submit" value="projectionID" disabled class="seat-btn btn btn-primary">
                                    Választok ülőhelyet
                                </button>
                            </div>';
                                }else{
                                    echo "<div class='alert alert-info text-center font-weight-bold'>Ehhez a filmhez nem tartozik vetítés!</div>";
                                }

                                ?>
                            </div>

                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
<?php } ?>
<?php if (!empty($_POST['pid'])) {

    ?>
    <div class="container">
        <div class="card select-chair text-center">
            <div class="card-header">
                <ul class="nav nav-tabs card-header-tabs">
                    <li class="nav-item">

                        <a class="nav-link active" href="#">Válassz ülőhelyet!</a>

                    </li>
                </ul>
            </div>

            <div class="card-body">
                <div class="screen">
                    <h1>Vászon</h1>
                </div>
                <form action="book.php" method="get">

                    <?php
                    $i = 1;
                    echo "<div class='row justify-content-center'>";
                    echo "";
                    $pid = $_POST['pid'];
                    $sql = "SELECT seatnumber FROM booking WHERE projection_id = '$pid'";
                    $result = $conn->query($sql);
                    while ($row = $result->fetch_assoc()) {
                        while (($i < $row['seatnumber']) && $i < 51) {
                            echo "<div class=\"form-check-inline\">
<div class='col-1'><label class=\"form-check-label\" for=\"inlineCheckbox1\">$i</label><input type='checkbox' id='chair' name='chair[" . $i . "]' value='$i'></div>
</div>";
                            $i++;
                        }
                        if ($row['seatnumber'] == $i) {
                            echo "<div class=\"form-check-inline\">
<div class='col-1'><label class=\"form - check - label\" for=\"inlineCheckbox1\">$i</label><input disabled style='background-color: red;' type='checkbox' id='chair' name='chair[" . $i . "]' value='$i'></div>
</div>";
                            $i++;
                        }

                    }
                    while ($i < 51) {
                        echo "<div class=\"form-check-inline\">
<div class='col-1'><label class=\"form - check - label\" for=\"inlineCheckbox1\">$i</label><input type='checkbox' id='chair' name='chair[" . $i . "]' value='$i'></div>
</div>";
                        $i++;
                    }
                    echo "</div>";
                    echo "</div>";
                    ?>
                    <div class="row justify-content-center">
                        <div class="col-lg-2">
                            <div class="form-group">

                                <button value="<?php echo $_POST['pid'] ?>" name="projection"
                                        class="btn foglalas btn-info font-weight-bold form-control">Foglalás
                                </button>
                            </div>
                            <div class="valami"></div>
                        </div>

                    </div>
                </form>
            </div>
        </div>
    </div>
<?php } ?>
<?php


if (isset($_GET['projection'])) {
    $pid = $_GET['projection'];
    $userID = $_SESSION["userid"];
    if (is_array($_GET['chair']) && !empty($_GET['chair']) && isset($_GET['chair'])) {
        foreach ($_GET['chair'] as $seat) {
            $sql = "INSERT INTO `booking`(`user_id`, `projection_id`, `seatnumber`) VALUES ($userID,$pid,$seat)";
            $result = $conn->query($sql);

        }
        if ($result) {
            echo "<div class='container'>

<div class='row justify-content-center'>
<div class='col-lg-8'>
<h2 class='alert alert-info text-center mt-4'><i class=\"fa fa-check\"></i>Sikeres Foglalás!</h2>
</div>
</div>
</div>";
            //header("Refresh:2; url=index.php");
        }

    }
}


?>
</body>

</html>