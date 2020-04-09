<?php

    $email = $_POST["email"];
    $password = $_POST["password"];
    
    $DBip = "";
    $DBuser = "";
    $DBpassword = "";
    $DBdatabase = "";

    $error = "";

    $conn = new mysqli($DBip, $DBuser, $DBpassword, $DBdatabase);
    
    if ($conn->connect_error) {
        exit("Connection Failed: ".$conn->connection_error);
    }

    if (!filter_var($email, FILTER_VALIDATE_EMAIL))  
        $error = "badFormatEmail";

    if ($error === "") {
        $result = $conn->query("SELECT id, password FROM account WHERE mail LIKE '$email'");
        if (!$result) {
            $error = "databaseError";
        }
        else {
            if ($result->num_rows == 0) {
                $error = "emailNotFound";
            }
            else {
                if ($result->fetch_assoc()["password"] !== $password) {
                    $error = "wrongPassword";
                }
                else {
                    session_start();
                    $_SESSION["id"] = $result->fetch_assoc()["id"];
                    echo "successfullyLoggedIn";
                }
            }
        }
    }

    echo $error;
?>