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

    $friendId = $_GET["friendId"];

    $friend = $conn->query("SELECT user FROM account WHERE id = '$friendId'");
    $username = $conn->query("SELECT user FROM account WHERE id = '$id'");

    $messages = array();

    $query = $conn->query("SELECT messages, date FROM " . "$username" . "_messages WHERE user = '$friend'");

    while ($result = mysqli_fetch_assoc($query)) {
        $messages[] = ["content" => $result["messages"], "date" => strtotime($result["date"]), "mode" => "SEND"];
    }

    $query = $conn->query("SELECT messages, date FROM " . "$friend" . "_messages WHERE user = '$username'");

    while ($result = mysqli_fetch_assoc($query)) {
        $messages[] = ["content" => $result["messages"], "date" => strtotime($result["date"]), "mode" => "RECEIVE"];
    }
    usort($messages, function($a, $b) {
        return $a['date'] - $b['date'];
    });

    for ($i = 0; $i < sizeof($messages); $i++) {
        $messages[$i]["date"] = date("Y-m-d H:i:s", $messages[$i]["date"]);
    }

    echo json_encode($messages);
?>
