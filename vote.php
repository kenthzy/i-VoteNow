<?php
session_start();

if (!isset($_SESSION['user_id'])) {
    header("Location: index.php");
    exit();
}
?>
<!DOCTYPE html>
<html>
<head>
    <title>i-VoteNow</title>
    <link rel="icon" type="image/x-icon" href="images/icon.png">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="css/vote.css">
</head>
<body>
<nav class="navbar navbar-expand-lg navbar-light custom-navbar pt-2" id="navbar">
    <div class="container">
        <img src="images/BRAND.png" height="70" alt="LOGO" loading="lazy" />
        <div class="collapse navbar-collapse" id="navbarExample01">
            <ul class="navbar-nav ms-auto mb-2 mb-lg-0"> 
                <div class="d-grid gap-2">
                     <button type="button" class="btn btn-warning" onclick="logout()">Sign Out</button>
                </div>
            </ul>
        </div>
    </div>
</nav>


<div class="container">
    <div class="paper-container">
        <img src="images/ivnLogo.png" alt="Logo" class="logo" />
        <div class="top-border"></div>
        <div class="bottom-border"></div>

        <div class="header">
            <h4>OFFICIAL IVN BALLOT FOR STUDENT COUNCIL</h4>
            <p>"Choosing the right candidate is not just about casting a vote; it's about shaping the future."</p>
        </div>
        <form action="submit_votes.php" method="post">
            <div class="box-container">
                <div class="box" id="1">
                    <div class="position">
                        PRESIDENT
                    </div>
                    <div class="text">
                        <div class="radio-group">
                            <input type="radio" id="candidate1" name="president" value="1">
                            <label for="candidate1">#18 - KENNETH GONZALES</label>
                        </div> 
                        <div class="radio-group">
                            <input type="radio" id="candidate2" name="president" value="2">
                            <label for="candidate2">#69 - JUSTIN FELIZARIO</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate3" name="president" value="3">
                            <label for="candidate3">#23 - SHAIREN JADE RIVERA</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate4" name="president" value="4">
                            <label for="candidate4">#51 - CHRISTIAN PASCUAL</label>
                        </div>
                    </div>
                </div>
                <div class="box" id="2">
                    <div class="position">
                        VICE-PRESIDENT
                    </div>
                    <div class="text">
                        <div class="radio-group">
                            <input type="radio" id="candidate1" name="vice-president" value="5">
                            <label for="candidate1">#12 - ALEXANDER SANTIAGO</label>
                        </div> 
                        <div class="radio-group">
                            <input type="radio" id="candidate2" name="vice-president" value="6">
                            <label for="candidate2">#47 - MARIA DELGADO</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate3" name="vice-president" value="7">
                            <label for="candidate3">#32 - JONATHAN CRUZ</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate4" name="vice-president" value="8">
                            <label for="candidate4">#89 - ELENA VASQUEZ</label>
                        </div>
                    </div>
                </div>
                <div class="box" id="3">
                    <div class="position">
                        SECRETARY
                    </div>
                    <div class="text">
                        <div class="radio-group">
                            <input type="radio" id="candidate1" name="secretary" value="9">
                            <label for="candidate1">#15 - FRANCISCO MENDOZA</label>
                        </div> 
                        <div class="radio-group">
                            <input type="radio" id="candidate2" name="secretary" value="10">
                            <label for="candidate2">#64 - ISABEL GARCIA</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate3" name="secretary" value="11">
                            <label for="candidate3">#29 - CARLOS RIVERA</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate4" name="secretary" value="12">
                            <label for="candidate4">#73 - LUCIA FERNANDEZ</label>
                        </div>
                    </div>
                </div>
                <div class="box" id="4">
                    <div class="position">
                        TREASURER
                    </div>
                    <div class="text">
                        <div class="radio-group">
                            <input type="radio" id="candidate1" name="treasurer" value="13">
                            <label for="candidate1">#38 - MIGUEL TORRES</label>
                        </div> 
                        <div class="radio-group">
                            <input type="radio" id="candidate2" name="treasurer" value="14">
                            <label for="candidate2">#54 - CAMILA MARTINEZ</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate3" name="treasurer" value="15">
                            <label for="candidate3">#21 - NICHOLAS RAMIREZ</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate4" name="treasurer" value="16">
                            <label for="candidate4">#45 - SOPHIA MORENO</label>
                        </div>
                    </div>
                </div>
                <div class="box" id="5">
                    <div class="position">
                        AUDITOR
                    </div>
                    <div class="text">
                        <div class="radio-group">
                            <input type="radio" id="candidate1" name="auditor" value="17">
                            <label for="candidate1">#33 - DANIEL ORTIZ</label>
                        </div> 
                        <div class="radio-group">
                            <input type="radio" id="candidate2" name="auditor" value="18">
                            <label for="candidate2">#87 - VICTORIA HERNANDEZ</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate3" name="auditor" value="19">
                            <label for="candidate3">#14 - JAVIER LOPEZ</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate4" name="auditor" value="20">
                            <label for="candidate4">#61 - GABRIELA FLORES</label>
                        </div>
                    </div>
                </div>
                <div class="box" id="6">
                    <div class="position">
                        PUBLIC INFORMATION OFFICE
                    </div>
                    <div class="text">
                        <div class="radio-group">
                            <input type="radio" id="candidate1" name="publicInformationOffice" value="21">
                            <label for="candidate1">#26 - ANTHONY GOMEZ</label>
                        </div> 
                        <div class="radio-group">
                            <input type="radio" id="candidate2" name="publicInformationOffice" value="22">
                            <label for="candidate2">#79 - VALERIA DIAZ</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate3" name="publicInformationOffice" value="23">
                            <label for="candidate3">#35 - DAVID PEREZ</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate4" name="publicInformationOffice" value="24">
                            <label for="candidate4">#94 - ISABELLA SANTOS</label>
                        </div>
                    </div>
                </div>
                <div class="box" id="7">
                    <div class="position">
                        PARTYLIST
                    </div>
                    <div class="text">
                        <div class="radio-group">
                            <input type="radio" id="candidate1" name="partylist" value="25">
                            <label for="candidate1">BAYANIHAN PARTYLIST</label>
                        </div> 
                        <div class="radio-group">
                            <input type="radio" id="candidate2" name="partylist" value="26">
                            <label for="candidate2">SANDIGAN PARTYLIST</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate3" name="partylist" value="27">
                            <label for="candidate3">KABABAIHAN PARTYLIST</label>
                        </div>
                        <div class="radio-group">
                            <input type="radio" id="candidate4" name="partylist" value="28">
                            <label for="candidate4">KALIKASAN PARTYLIST</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="submit-button">
                <button type="submit" class="btn btn-success" id="submit">Submit Ballot</button>
            </div>
        </form>
    </div>
</div>

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
<script>
    function logout() {
        window.location.href = "logout.php";
    }
</script>

</body>
</html>
