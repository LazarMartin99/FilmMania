<?php

include_once 'connect.php';


$sql = "SELECT movie.movieId, movie.title, movie.genre, movie.about, movie.rating, movie.img, rendezo.name, movie.year FROM movie inner JOIN rendezo on movie.directorId = rendezo.directorId;";
$result = $conn -> query($sql);
$html = "";
if($result)
{

    while($row = $result -> fetch_assoc())
    {
        $html.='<div class="col-lg-4"> 
            <form class="moviebox" method="POST" action="book.php">
        <div class="flip-box">
        <div class="flip-box-inner">
    <div class="flip-box-front">
    <div> <img class="movieimg" src="data:image/jpeg;base64,'.base64_encode( $row['img'] ).'"/> </div>
    <div>
         <p>Cím: '.$row['title'] .' </p>
         <p> Kategória: '.$row['genre'] .' </p>
         <p> IMDb pontszám: '.$row['rating'] .' </p>
    </div>
    </div>
    <div class="flip-box-back">
    <div>  <h1>'.$row['title'] .' </h1>  </div>
    <div>  <p>"'.$row['about'] .'" </p>  </div> 

     ';
        if(empty($_SESSION['userid'])){
            $html .= '<div class="alert alert-info">Jegyfoglalás előtt jelentkezz be!</div>';
        }else{
            $html .= '<button type="submit" name="mid" value="'.$row['movieId'].'" class="btn btn-info ticket">Jegyvásárlás</button>';
        }

        $html .= '</div>
    </div>
    </div>
    </form>
    </div>';
    }


}

echo $html;