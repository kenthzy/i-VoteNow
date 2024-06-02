<?php
require 'database.php';

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $student_id = $_POST['student_id'];
    $name = $_POST['name'];
    $email = $_POST['email'];
    $password = $_POST['password'];
    $repeatPassword = $_POST['repeatPassword'];

    if ($password === $repeatPassword) {
        $hashedPassword = password_hash($password, PASSWORD_DEFAULT);

        // Prepare SQL statement to prevent SQL injection
        $stmt = $conn->prepare("INSERT INTO users (student_id, name, email, password) VALUES (?, ?, ?, ?)");
        $stmt->bind_param("ssss", $student_id, $name, $email, $hashedPassword);

        if ($stmt->execute()) {
            echo "Registration successful!";
            header("Location: index.php");
        } else {
            echo "Error: " . $stmt->error;
        }

        $stmt->close();
    } else {
        echo "Passwords do not match.";
    }
}
?>

<!DOCTYPE html>
<html lang="en">
    <head>
        <title>i-VoteNow</title>
        <link rel="i-Vn Icon" type="x-icon" href="images\icon.png">
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css">
        <link rel="stylesheet" href="css/signUp.css">
    </head>
    <body>
      <nav class="navbar navbar-expand-lg navbar-light custom-navbar pt-2" id="navbar">
        <div class="container">
            <img src="images\BRAND.png" height="70" alt="LOGO" loading="lazy" />
            <div class="collapse navbar-collapse" id="navbarExample01">
                <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                        <a class="nav-link" aria-current="page" href="https://localhost/webDev/about.php">About  Us</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" aria-current="page" href="https://localhost/webDev/features.php">Features</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
       <section>
        <div class="container">
          <div class="info"></div>
          <div class="login">
            <h4>Sign Up</h4>
            <p id="support">Start to support your Candidate by
                Creating your i-VN account</p>
                <form action="signUp.php" method="POST">
    <div class="mb-3">
        <input type="text" class="form-control" name="student_id" placeholder="Type Student ID Number" required>
    </div>
    <div class="mb-3">
        <input type="text" class="form-control" name="name" placeholder="Type your Full Name" required>
    </div>
    <div class="mb-3">
        <input type="email" class="form-control" name="email" aria-describedby="emailHelp" placeholder="Create Voter's Email ( Use Student Email )" required>
    </div>
    <div class="col-auto">
        <input type="password" name="password" id="inputPassword" class="form-control" aria-describedby="passwordHelpInline" placeholder="Create Password" required>
    </div>
    <div class="col-auto">
        <input type="password" name="repeatPassword" id="repeatPassword" class="form-control" aria-describedby="passwordHelpInline" placeholder="Repeat Password" required>
    </div>
    <div class="mb-3 form-check">
        <input type="checkbox" class="form-check-input" id="agreeToTerms" required>
        <label for="agreeToTerms">Agree to Terms and Conditions</label>
    </div>
    <div class="d-grid gap-2">
        <button type="submit" class="btn btn-success">Sign Up</button>
    </div>
</form>

            <div class="signUp">
              <p>Already have an account ? <a href="https://localhost/webDev/index.php">Sign in </a></p>
            </div>
         </div>
        </div>
       </section>
    </body>
    <footer>
      <div class="footer-container">
      <p>Powered By MiniByte</p>
      </div>
  </footer>
</html>
