<?php
session_start();
require 'dataAccess/DatabaseMediator.php';
require 'classes/Employee.php';
require 'classes/Shift.php';
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

$db=new DatabaseMediatior();
if(!isset($_SESSION["employeeId"])){
  header('Location: LogInPage.php');
  exit;
}else
if(!is_numeric($_GET['employeeId'])||$_SESSION["employeeId"]!=$_GET['employeeId']){
    session_destroy();
    header('Location: LogInPage.php');
    exit;
  }else if($db->GetEmployee($_GET['employeeId']) == null){
    session_destroy();
    header('Location: LogInPage.php');
    exit;
  }
  else{
    $employee=$db->GetEmployee($_GET['employeeId']);
    $date=date("Y-m-d");
    $date=new DateTime($date);
    $week = $date->format("W");
  }
    
?>
<!DOCTYPE html>
<html>
<head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<link href="style/headerStyles.css"   type="text/css"   rel="stylesheet">
</head>
<body>

<div class="Top-navigation">
<h2>Media Bazaar</h2>
<div class="pill-nav">
    <?php
  echo '<a href="ProfilePage.php?employeeId='.$_GET['employeeId'].'">Profile</a>';
  if($employee->getPosition()=="STORE_WORKER"||$employee->getPosition()=="STOCK_WORKER"||$employee->getPosition()=="CASHIER"){
      echo '<a href="Schedule.php?employeeId='.$_GET['employeeId'].'&week='.$week.'">Schedule</a>';
  }
  echo
  '<a>Contact</a>
   <a href="LogOutPage.php">Log out</a>';
  ?>
</div>
</div>

</body>
</html>