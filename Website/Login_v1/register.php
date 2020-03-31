<?php

    $username = $_POST["username"];
    $email = $_POST["email"];
    $password = $_POST["password"];
    $confirmPassword = $_POST["confirmPassword"];
    $age = $_POST["age"];
    $image = $_POST["image"];
    
    $DBip = "";
    $DBuser = "";
    $DBpassword = "";
    $DBdatabase = "";

    $error = "";

    $conn = new mysqli($ip, $user, $password, $database);
    
    if ($conn->connect_error) {
        $error = "databaseError");
    }

    if (!ctype_alnum($username))
        $error = "badFormatUsername";
    else {
        if ($conn->query("SELECT * FROM account WHERE user = '$username'")->num_rows > 0)
            $error = "usernameAlreadyTaken";
    }

    if (!filter_var($email, FILTER_VALIDATE_EMAIL))  
        $error = "badFormatEmail";
    else {
        if ($conn->query("SELECT * FROM account WHERE mail = '$email'")->num_rows > 0)
            $error = "emailAlreadyTaken";
    }

    if ($password != $confirmPassword)
        $error = "passwordsDoNotMatch";

    if (!is_numeric($age))
        $error = "badAgeFormat";
    else {
        if ($age > 200)
            $error = "badAgeFormat";
        if ($age < 16)
            $error = "tooYoung";
    }

    if ($error === "") {
        if (!$conn->query("INSERT INTO account (user, mail, password, age, image) VALUES ('$username', '$email', '$password', '$age', '$image')"))
            $error = "databaseError";
        else {
            echo "newAccountCreatedSuccessfully";
        }
    }
    else
        echo $error;
?>
