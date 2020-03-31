<?php

    $email = $_POST("email");
    $password = $_POST("password");
    
    $DBip = "79.24.89.93";
    $DBuser = "gofast";
    $DBpassword = "qGZGg01k0lbWXkKD";
    $DBdatabase = "gofast";

    $badFormatElail = false;

    $conn = new mysqli($ip, $user, $password, $database);
    
    if ($conn->connect_error) {
        exit("Connection Failed: ".$conn->connection_error);
    }

    if (!filter_var($email, FILTER_VALIDATE_EMAIL))  
        $badFormatEmail = true;

    if ($badFormatEmail === false) {
        $result = $conn->query("SELECT id, password FROM account WHERE mail LIKE '$email'");
        if (!$result) {
            exit("Failed to fetch the account: ".$conn->connection_error);
        }
        else {
            if ($res->num_rows == 0) {
                exit("Email not fount")
            }
            else {
                if (!$result->fetch_assoc()["password"] === $password) {
                    exit("Wrong Password");
                }
                else {
                    session_start();
                    $_SESSION["id"] = $result->fetch_assoc()["id"];
                }
            }
        }
    }
?>