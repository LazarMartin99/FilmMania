<?php
session_start();
?>
<!DOCTYPE html>
<html>
<head>
    <title>Movies!</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <script src="js/jquery-3.4.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/popper.min.js"></script>
    <script src="js/login.js"></script>

    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="css/bootstrap.min.css">

</head>
<body>


<nav class="navbar navbar-expand-lg navbar-dark fixed-top">
    <img src="img/FilmMánialogo.jpg" class="logo" >
    <a class="navbar-brand" href="#"> Kezdőlap</a>
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


<!-- Modal -->
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
                        <input type="text" class="form-control" placeholder="Felhasználónév" id="username" name="username">
                        <div class="message"></div>
                    </div>
                    <div class="form-group p">
                        <input type="password" class="form-control" placeholder="Jelszó" id="password" name="password">
                        <div class="messagepwd"></div>
                    </div>
                </form>
            </div>
            <div class="modal-footer">
                <button type="submit" class="btn btn-info" id="enter">Belépés</button>
            </div>
        </div>
    </div>
</div>

<div id="carouselExampleControls" class="carousel slide" data-ride="carousel">
    <div class="carousel-inner">
        <div class="carousel-caption">
            <h1 class="alert alert-success" style="color:deepskyblue">  A hét sztárja: Leonardo DiCaprio</h1>
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

<div class="container bg">
    <div class="row">
        <div class="col-lg-12">
            <div class="message"></div>
        </div>
    </div>
    <div class="row">
              <?php
              include 'getmovies.php';
              ?>

    </div>
</div>


</div>

</body>
</html>
