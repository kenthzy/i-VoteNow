<?php
include 'database.php'; 

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    session_start();
    $userVotersEmail = $_POST['userVotersEmail'];
    $userPass = $_POST['userPass'];

    
    $stmt = $conn->prepare("SELECT id, password, has_voted FROM users WHERE email = ?");
    $stmt->bind_param("s", $userVotersEmail);
    $stmt->execute();
    $stmt->store_result();

    if ($stmt->num_rows > 0) {
        $stmt->bind_result($user_id, $hashedPassword, $has_voted);
        $stmt->fetch();

        if (password_verify($userPass, $hashedPassword)) {

            $_SESSION['user_id'] = $user_id;
            $_SESSION['has_voted'] = $has_voted;

            if ($has_voted) {
                header("Location: already_voted.php");
            } else {
                header("Location: vote.php");
            }
            exit();
        } else {
            // Invalid password
            echo "Invalid email or password.";
        }
    } else {
        // No user found with that email
        echo "Invalid email or password.";
    }

    $stmt->close();
}
$conn->close();
?>


<!DOCTYPE html>
<html lang="en">
<head>
    <title>i-VoteNow</title>
    <link rel="i-Vn Icon" type="x-icon" href="images/icon.png">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="css/main.css">
    <script src="js/function.js"></script>
</head>
<body>
<nav class="navbar navbar-expand-lg navbar-light custom-navbar pt-2" id="navbar">
    <div class="container">
        <img src="images/BRAND.png" height="70" alt="LOGO" loading="lazy" />
        <div class="collapse navbar-collapse" id="navbarExample01">
            <ul class="navbar-nav ms-auto mb-2 mb-lg-0">
                <li class="nav-item">
                    <a class="nav-link" aria-current="page" href="https://localhost/webDev/about.php">About Us</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" aria-current="page" href="https://localhost/webDev/features.php">Features</a>
                </li>
            </ul>
        </div>
    </div>
</nav>
<section class="upper">
    <div class="container">
        <div class="promotext">
            <h1>Vote Now.</h1>
            <p>Let’s start fresh beginnings and courage to <br> participate in shaping a better future<br> through your votes.</p>
        </div>
        <div class="login">
            <h4>Sign In</h4>
            <p>Use your i-VN account</p>
            <form name="form" action="index.php" method="POST">
                <div class="mb-3">
                    <input type="email" class="form-control" id="userVotersEmail" name="userVotersEmail" placeholder="Voter's Email">
                </div>
                <div class="col-auto">
                    <input type="password" id="userPass" name="userPass" class="form-control" aria-describedby="passwordHelpInline" placeholder="Password">
                </div>
                <div class="d-grid gap-2">
                    <button type="submit" id="btnSignIn" class="btn btn-success" value="Login" name="submit">Sign In</button>
                </div>
            </form>
            <div class="signUp">
                <p>Don’t have an account? <a href="https://localhost/webDev/signUp.php">Sign up</a></p>
            </div>
        </div>
    </div>
</section>
<section class="middle">
    <div class="Why">
        <div class="votetext">
            <h1>WHY VOTING MATTERS</h1>
            <p>
                Voting allows citizens to actively participate in<br> 
                shaping their government and policies.<br>
                It ensures that our voices are heard, holds leaders<br> 
                accountable for their actions, and contributes to<br>
                positive change and progress in society. 
            </p>
        </div>
        <div class="info">
            <img src="images/logo.png" alt="cdm logo" id="logo1">
            <img src="images/ics.png" alt="ics logo" id="logo2">
            <h4>WE ARE CDMIANS</h4>
            <p>
                Our team, representing Colegio de Montalban under <br>
                the Institute of Computer Studies, is dedicated to <br>
                empowering democracy through the i-VoteNow system.<br>
                We believe that education extends beyond textbooks <br>
                and exams it’s about shaping responsible citizens <br>
                who actively contribute to society. Join us in <br>
                amplifying community voices and upholding <br>
                democratic principles.
            </p>
        </div>
    </div>
</section>
<section class="below">
    <div class="last">
        <div class="endingtxt">
            <h1>i-VoteNow Features</h1>
            <p>
                Get Voting is everything you need to run a free <br>
                and fair election for your class or school.<br>
                We encourage the school community to value voting <br>
                developing students’ trust, confidence <br>
                and motivation to participate in their democracy.<br>
            </p>
            <div class="d-grid gap-2">
                <button type="button" class="btn btn-success" id="learnMore"><a href="https://localhost/webDev/features.php">Learn More</a></button>
            </div>
        </div>
    </div>
</section>
<section class="newSection">
    <div class="new">
        <div class="newText">
            <h1>Become a Candidate</h1> 
            <p>Are you passionate about shaping the future?<br> 
                Consider stepping up as a candidate or a leader<br> 
                in our online voting system. Your voice matters,<br> 
                and your leadership can make a difference.<br>
                Join us today and be the change you want to see.<br>
            </p>
        </div>
        <div class="d-grid gap-2">
            <button type="button" class="btn btn-success" id="apply"><a href="https://docs.google.com/forms/d/e/1FAIpQLSfuVvjR6-DbHjlH6uRwGdCqGaXquqZVhJCWwpHuEEAtG-okxg/viewform?usp=sf_link">Apply Now</a></button>
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
