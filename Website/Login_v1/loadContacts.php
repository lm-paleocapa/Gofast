<?php
    header('Content-Type: application/json');

    $DBip = "";
    $DBuser = "";
    $DBpassword = "";
    $DBdatabase = "";

    $conn = new mysqli($DBip, $DBuser, $DBpassword, $DBdatabase);
    
    session_start();

    $id = $_SESSION["id"];
    $email = $_SESSION["email"];
    $password = $_SESSION["password"];
    $image = $_SESSION["image"];

    $username = $conn->query("SELECT user FROM account WHERE id = '$id'");
    
    $response = array();

    $result = $conn->query("SELECT * FROM account WHERE username = '$username'");

    int i = 0;
    while ($friend = mysql_fetch_array($result) {
        $response[i] = ["image" => $friend["image"], "name" => $friend["username"], "id" => $friend["id"], "state" => $friend["state"]];
    }

    echo json_encode($response);
?>