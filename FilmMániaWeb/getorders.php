<?php
require_once 'connect.php';
session_start();
if ($_SERVER['REQUEST_METHOD'] == "POST" && !empty($_POST['pid'])) {
          $pid = $_POST['pid'];
          $uid = $_SESSION['userid'];
          $html = '';
          $sql = "SELECT DISTINCT movie.title, projection.time, projection.price
FROM movie INNER JOIN projection ON movie.movieId = projection.movie_id INNER JOIN booking ON projection.projectionId = booking.projection_id
WHERE booking.user_id = '$uid' AND projection.projectionId = '$pid'";
          $result = $conn->query($sql) or die("Hiba: {$conn->error}\n");
          $sql = "SELECT booking.seatnumber, projection.price, booking.bookingId
FROM booking INNER JOIN projection ON booking.projection_id = projection.projectionId
WHERE booking.user_id = '$uid' AND booking.projection_id = '$pid'";
          $re = $conn->query($sql);
          $html .= '<div class="container"><table class="table table-light table-striped table-borderless orders">
            <thead>
            <tr class="table-info">
            <td>Film címe</td>
            <td>Idő</td>
            <td>Székek</td>
            <td>Ár</td>
            <td>Foglalás Törlése</td>
    </tr>
</thead><tbody>
';
          $vegosszeg = 0;
          while ($row = $result->fetch_array()) {

                    while ($r = $re->fetch_array()) {
                              $html .= '<tr>
                      <td>' . $row[0] . '</td>
                      <td>' . $row[1] . '</td>
                      <td>' . $r[0] . '</td>
                      <td>' . $r[1] . '</td>
                      <td><span> <img src="img/trash.png" id='.$r[2].' class="delete"></span></td>
</tr>';
                              $vegosszeg = $vegosszeg + $r[1];
                    }


          }
          $html .= "</tbody></table></div>";
          echo $html;
          echo "<div class='alert alert-info text-center font-weight-bold mb-4 mt-4'>Összesen fizetendő: " . $vegosszeg . " Ft</div>";

}