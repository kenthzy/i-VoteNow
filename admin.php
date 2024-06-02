<?php
include 'database.php';

// Fetch all users from the database
$sql = "SELECT student_id, name, email, has_voted FROM users";
$result = $conn->query($sql);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>List of Voters</title>
    <link rel="i-Vn Icon" type="x-icon" href="images\icon.png">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="css/mix.css">
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light custom-navbar pt-2" id="navbar">
        <div class="container">
            <img src="images\BRAND.png" height="70" alt="LOGO" loading="lazy" />
            <div class="collapse navbar-collapse" id="navbarExample01">
            </div>
        </div>
    </nav>
    <section>
        <div class="container">
            <h2 class="mt-4">List of Voters</h2>
            <table class="table table-bordered table-hover table-success">
                <thead>
                    <tr>
                        <th scope="col" class="bg-success">Student ID</th>
                        <th scope="col" class="bg-success">Name</th>
                        <th scope="col" class="bg-success">Email</th>
                        <th scope="col" class="bg-success">Has Voted</th>
                    </tr>
                </thead>
                <tbody>
                    <?php
                    if ($result->num_rows > 0) {
                        while($row = $result->fetch_assoc()) {
                            echo "<tr>";
                            echo "<td>" . htmlspecialchars($row["student_id"]) . "</td>";
                            echo "<td>" . htmlspecialchars($row["name"]) . "</td>";
                            echo "<td>" . htmlspecialchars($row["email"]) . "</td>";
                            echo "<td>" . ($row["has_voted"] ? 'Yes' : 'No') . "</td>";
                            echo "</tr>";
                        }
                    } else {
                        echo "<tr><td colspan='4'>No voters found</td></tr>";
                    }
                    ?>
                </tbody>
            </table>
        </div>
    </section>
    <script>
    function logout() {
        window.location.href = "logout.php";
    }
</script>
<a href="index.php" class="btn btn-success">Return to Home</a>
</body>
</html>

<?php
$conn->close();
?>
