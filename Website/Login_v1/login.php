<?php

    $email = $_POST["email"];
    $password = $_POST["password"];
    
    $DBip = "80.182.17.185";
    $DBuser = "gofast";
    $DBpassword = "SDSD123687u21nsad";
    $DBdatabase = "gofastdb";

    $error = "";

    $conn = new mysqli($DBip, $DBuser, $DBpassword, $DBdatabase);
    
    if ($conn->connect_error) {
        exit("Connection Failed: ".$conn->connection_error);
    }

    if (!filter_var($email, FILTER_VALIDATE_EMAIL))  
        $error = "badFormatEmail";

    if ($error === "") {
        $result = $conn->query("SELECT id, password, image, user FROM account WHERE mail LIKE '$email'");
        if (!$result) {
            $error = "databaseError";
        }
        else {
            if ($result->num_rows == 0) {
                $error = "emailNotFound";
            }
	    else {
		$result2 = mysqli_fetch_array($result);
                if ($result2["password"] !== $password) {
                    $error = "wrongPassword";
                }
                else {
                    session_start();
                    $_SESSION["id"] = $result2["id"];
                    $_SESSION["image"] = $result2["image"];
                    $_SESSION["email"] = $email;
                    $_SESSION["password"] = $password;
                    $_SESSION["username"] = $result2["user"];
                    echo "successfullyLoggedIn";
                }
            }
        }
    }

    echo $error;
?>
