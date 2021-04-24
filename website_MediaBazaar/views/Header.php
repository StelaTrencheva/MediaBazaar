<?php
$profile = "active";
$schedule = "inactive";
$contact = "inactive";
$logOut = "inactive";
if(isset($_GET['profile']))
{
    $profile = "active";
    $schedule = "inactive";
    $contact = "inactive";
}
else if(isset($_GET['schedule']))
{
    $profile = "inactive";
    $schedule = "active";
    $contact = "inactive";
}
else if (isset($_GET['contact']))
{
    $profile = "inactive";
    $schedule = "inactive";
    $contact = "active";
}
?>
<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">
</head>
<body>

<div class="Top-navigation">
<h2>Media Bazaar</h2>
<div class="pill-nav">
    <?php
  echo '<a class="active">Profile</a>
  <a>Schedule</a>
  <a>Contact</a>
  <a href="LogInPage.php">Log out</a>';
  ?>
</div>
</div>

</body>
</html>