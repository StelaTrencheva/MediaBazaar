<?php
require 'views/Header.php';
$db=new DatabaseMediatior();
$employee=$db->GetEmployee($_GET['employeeId']);
if($employee->getPosition()!="STORE_WORKER" && $employee->getPosition()!="STOCK_WORKER" && $employee->getPosition()!="CASHIER"){
  session_destroy();  
  header('Location: LogInPage.php');
  exit;
}
else{
    $weeks=array();
    for($i=(($date->format("W"))+2); $i<=(($date->format("W"))+6); $i++){
        array_push($weeks,$i);
    }
    $daysOfWeek=['Monday','Tuesday','Wednesday','Thursday','Friday','Saturday','Sunday'];
    $defaultShifts=['Morning','Afternoon','Evening','Night'];
}
?>
<!doctype html>
<html>
<head>
<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="style/Availability.css" type="text/css" rel="stylesheet">
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
    
    
</head> 
<body>
<div class="container px-4 py-5 mx-auto">
    <div>   
    </div>
    <div class="card card0">
        <div class="margin-10px-top">
        <?php
                     if(isset($_GET['error'])) {
                        $error=$_GET['error'];
                    echo '<div class ="alert alert-primary" role="alert"> Error occured: '.$error.'</div>';
                        }
        ?>
            <p>Hi colleague!</p>
            <p>With this form you state on a weekly basis which days you are available to work. It is important that you always fill in the form on time. This way we can make a good planning and ensure that you get as many services as possible.</p>
            <p class="bold"> When do I have to fill in the form? </p>
            <p>You can fill in the form up to 6 weeks in advance, but the sooner the better. The deadline is always a maximum of 1 week in advance. Example: you submit your availability for week 3 before week 2 starts, so before Sunday 23:59 in week 1. </p>
            <ul>
                <li>If you have full contract - mark <b>at least 10</b> available shifts</li>
                <li>If you have 80% contract - mark <b>at least 8</b> available shifts</li>
            </ul>
        </div>
        <div class="d-flex flex-lg-row flex-column-reverse">
            <div class="container margin-10px-top margin-10px-bottom">
            <form method="post" action = "formHandlers/availabilityHandler.php">
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputState">Week</label>
                        <select id="inputState" class="form-control" name="week">
                            <option selected>Choose...</option>
                            <?php
                                for($i=0;$i<count($weeks);$i++){
                                    echo '<option>'.$weeks[$i].'</option>';
                                }
                            ?>
                        </select>
                    </div>                    
                </div>
                <div class="form-group col-md-6">
                <?php
                    for($i=0;$i<7;$i++){
                        echo '<h6 class="bold margin-10px-top">'.$daysOfWeek[$i].'</h6>';
                        for($j=0;$j<count($defaultShifts);$j++){
                            echo 
                            '<div class="form-check form-check-inline">
                            <input class="form-check-input" type="checkbox" id="inlineCheckbox1" name="'.$daysOfWeek[$i].'-'.$defaultShifts[$j].'">
                            <label class="form-check-label" for="inlineCheckbox1">'.$defaultShifts[$j].'</label>
                            </div>';
                        }
                    }
                ?>
                </div>
                <a><button type="submit" class="btn btn-primary">Submit</button></a>
</form>

            </div>
    </div>
</div>

</body>
</html>