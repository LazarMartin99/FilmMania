<?php

require_once 'connect.php';
if($_SERVER['REQUEST_METHOD'] == "POST" && !empty($_POST['pid'])){
          $pid = $_POST['pid'];
          $sql = "SELECT time, projectionId FROM projection WHERE projectionId = $pid";
          $res = $conn -> query($sql);
          $select = '';
          if($res){
                    $select .= '<select name="pid" class="custom-select time"><option>Válaszd ki az időpontot</option>';
                    while($row = $res -> fetch_array()){
                              $select .= '<option value="' . $row[1] . '">' . $row[0] . '</option>';
                    }
                    $select .= "</select>";

          }
          echo $select;
          $conn -> close();
}