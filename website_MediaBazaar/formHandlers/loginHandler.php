<?php
 require '../LogInPage.php';
 require '../dataAccess/DatabaseMediator.php';
 require '../classes/Employee.php';
 $errorMessage = [];
  if(!empty($_POST['username']) && !empty($_POST['password']))
  {
    $username=$_POST['username'];
    $password=$_POST['password'];
   
    $db = new DatabaseMediatior();
    $employee = $db->LogInEmployee( $username, $password );
    $employeeId = $employee->getId();
    header('Location: ../ProfilePage.php?employeeId='. $employeeId);
        exit;
  }
  else
  { $errorMessage= 'Make sure all required fields have a value'; 
    header('Location: ../LogInPage.php?error='.$errorMessage);
    exit;
  }
    
    
?>