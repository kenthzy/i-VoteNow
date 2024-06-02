<?php
include 'database.php';
session_start();

if (!isset($_SESSION['user_id'])) {
    header("Location: index.php");
    exit(); 
}

// Query to fetch all distinct positions
$sql_positions = "SELECT DISTINCT position FROM candidates";
$result_positions = $conn->query($sql_positions);

// Query to calculate the total number of votes
$sql_total_votes = "SELECT SUM(vote_count) AS total_votes FROM candidates";
$result_total_votes = $conn->query($sql_total_votes);
$row_total_votes = $result_total_votes->fetch_assoc();
$total_votes = $row_total_votes['total_votes'];

$max_votes = 200;
$percentage_votes = ($total_votes / $max_votes) * 100;
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Result</title>
    <link rel="icon" type="image/x-icon" href="images/icon.png">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <link rel="stylesheet" href="css/result.css">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css">
</head>

<body style="background-color: #011F21;">
<nav class="navbar navbar-expand-lg navbar-light custom-navbar pt-2" id="navbar">
    <div class="container">
        <img src="images/BRAND.png" height="70" alt="LOGO" loading="lazy" />
            <div class="d-grid gap-2">
                <button type="button" class="btn btn-success" onclick="logout()"><p> Sign Out </p> </button>
            </div>
    </div>
</nav>

<div class="welcome text-center">
    <h1>I-VoteNow Election Results</h1>
</div>
<div class="election-turnout text-center">
    <h4>The Election Total Turnout Votes</h4>
    <div class="container">
        <div class="col-md-6 mx-auto">
            <div class="progress-wrapper">
                <div class="progress">
                    <div class="progress-bar bg-success" role="progressbar" style="width: <?php echo min($percentage_votes, 100); ?>%;" aria-valuenow="<?php echo min($percentage_votes, 100); ?>" aria-valuemin="0" aria-valuemax="100"></div>
                </div>
            </div>
        </div>
    </div>
</div>

<?php

// Loop through each position to display results
while ($row_position = $result_positions->fetch_assoc()) {
    $position = $row_position['position'];
?>

<div class="resultSection text-center">
    <h4>Vote Result for <?php echo ucfirst($position); ?> Race</h4>
    <div class="container">
        <table class="table table-bordered table-hover table-success">
            <thead>
                <tr class="text-center">
                    <th scope="col" class="bg-success">Candidates Name</th>
                    <th scope="col" class="bg-success">Total Votes</th>
                </tr>
            </thead>
            <tbody>
                <?php
                // Query to fetch voting results for the current position
                $sql_candidates = "SELECT candidate_name, vote_count FROM candidates WHERE position = '$position'";
                $result_candidates = $conn->query($sql_candidates);

                if ($result_candidates->num_rows > 0) {
                    // Output data of each row
                    while ($row_candidate = $result_candidates->fetch_assoc()) {
                        echo "<tr class='text-center'>";
                        echo "<td>" . $row_candidate['candidate_name'] . "</td>";
                        echo "<td>" . $row_candidate['vote_count'] . "</td>";
                        echo "</tr>";
                    }
                } else {
                    echo "<tr><td colspan='2'>No candidates found</td></tr>";
                }
                ?>
            </tbody>
        </table>
    </div>
</div>

<?php
}
?>
<script>
    function logout() {
        window.location.href = "logout.php";
    }
</script>
</body>
<footer>
    <div class="footer-container text-center">
        <p>Powered By MiniByte</p>
    </div>
</footer>

</html>
