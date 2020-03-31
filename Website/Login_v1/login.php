<?php

    $email = $_POST("email");
    $password = $_POST("password");
    
    $DBip = "79.24.89.93";
    $DBuser = "gofast";
    $DBpassword = "qGZGg01k0lbWXkKD";
    $DBdatabase = "gofast";

    $error = "";

    $conn = new mysqli($ip, $user, $password, $database);
    
    if ($conn->connect_error) {
        exit("Connection Failed: ".$conn->connection_error);
    }

    if (!filter_var($email, FILTER_VALIDATE_EMAIL))  
        $error = "badFormatEmail";

    if ($badFormatEmail === false) {
        $result = $conn->query("SELECT id, password FROM account WHERE mail LIKE '$email'");
        if (!$result) {
            $error = "databaseError";
        }
        else {
            if ($res->num_rows == 0) {
                $error = "emailNotFound";
            }
            else {
                if (!$result->fetch_assoc()["password"] === $password) {
                    $error = "wrongPassword";
                }
                else {
                    session_start();
                    $_SESSION["id"] = $result->fetch_assoc()["id"];
                    header("Location: ../chat.php");
                }
            }
        }
    }

    echo $error;
?>