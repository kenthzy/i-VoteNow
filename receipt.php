<!DOCTYPE html>
<html>
<head>
    <title>Vote Receipt</title>
    <link rel="icon" type="image/x-icon" href="images/icon.png">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="css/mix.css">
</head>
<body>
    
        <div class="text-center mt-4">
            <a href="result.php" class="btn btn-success">See the Results</a>
        </div>
        <?php
            session_start();

            if (isset($_SESSION['selected_candidates'])) {
                $selected_candidates = $_SESSION['selected_candidates'];

                // Display the receipt
                echo "<h2>Custom Vote Receipt</h2>";
                echo "<p>Thank you for voting! Below are the candidates you voted for:</p>";
                echo "<ul>";
                foreach ($selected_candidates as $candidate) {
                    echo "<li><strong>{$candidate['position']}</strong>: {$candidate['name']}</li>";
                }
                echo "</ul>";

                // Clear the session variable to prevent displaying the receipt again on refresh
                unset($_SESSION['selected_candidates']);
            } else {
                echo "No vote receipt available.";
            }
?>
</body>
</html>
