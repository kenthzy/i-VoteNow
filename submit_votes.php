<?php
session_start();
include 'database.php'; 

// Initialize an array to store the selected candidates' information
$selected_candidates = array();

if ($_SERVER['REQUEST_METHOD'] === 'POST') {

    if (!isset($_SESSION['user_id'])) {
        echo "You are not logged in.";
        exit();
    }

    if (isset($_SESSION['has_voted']) && $_SESSION['has_voted']) {
        echo "You have already voted.";
        exit();
    }

    if (empty($_POST)) {
        echo "No candidates selected.";
        exit();
    }

    // Begin transaction
    $conn->begin_transaction();

    try {
        // Update the vote counts for the selected candidates and gather their information
        foreach ($_POST as $position => $candidate_id) {
            if (is_numeric($candidate_id)) {
                // Update the vote count for the selected candidate
                $stmt = $conn->prepare("UPDATE candidates SET vote_count = vote_count + 1 WHERE id = ?");
                $stmt->bind_param("i", $candidate_id);

                if (!$stmt->execute()) {
                    throw new Exception("Error updating vote count for candidate ID: $candidate_id");
                }

                $stmt->close();

               // Get the candidate's information
                $stmt_candidate = $conn->prepare("SELECT position, candidate_name FROM candidates WHERE id = ?");
                $stmt_candidate->bind_param("i", $candidate_id);
                $stmt_candidate->execute();
                $stmt_candidate->bind_result($candidate_position, $candidate_name);
                $stmt_candidate->fetch();
                $stmt_candidate->close();

                // Store candidate information
                $selected_candidates[] = array(
                    'position' => $candidate_position,
                    'name' => $candidate_name
                );
            }
        }

        // Update user's voting status
        $user_id = $_SESSION['user_id'];
        $stmt_update = $conn->prepare("UPDATE users SET has_voted = 1 WHERE id = ?");
        $stmt_update->bind_param("i", $user_id);

        if (!$stmt_update->execute()) {
            throw new Exception("Error updating user's voting status.");
        }

        $stmt_update->close();

        // Commit the transaction
        $conn->commit();

        // Update session variable to indicate that the user has voted
        $_SESSION['has_voted'] = true;

        echo "<!DOCTYPE html>
        <html lang='en'>
        <head>
            <meta charset='UTF-8'>
            <meta name='viewport' content='width=device-width, initial-scale=1.0'>
            <link rel='icon' type='image/x-icon' href='images/icon.png'>
            <title>Vote Receipt</title>
            <link rel='stylesheet' href='css/receipt.css'>
            <link rel='stylesheet' href='https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css'>
        </head>
        <body style='color: #011F21;'>
            <div class='receipt-container'>
                <h2>Vote Receipt</h2>
                <p>Thank you for voting! Below are the candidates you voted for:</p>
                <ul>";
        foreach ($selected_candidates as $candidate) {
            echo "<li><strong>{$candidate['position']}</strong>: {$candidate['name']}</li>";
        }
        echo "</ul>
            </div>
            <div class='maximo'>
                <p>Thank you for your participation. You may see the latest election results.</p>
                <a href='result.php' class='btn btn-success'>See Results</a>
            </div>
        </body>
        </html>";
        

    } catch (Exception $e) {
        
        $conn->rollback();
        echo "Failed to record votes: " . $e->getMessage();
        exit();
    }
}

$conn->close();
?>
