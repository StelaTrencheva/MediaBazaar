<?php
require 'views/Header.php';
$db=new DatabaseMediatior();
$employee;
$employeeId; 
$employee=$db->GetEmployee($_GET['employeeId']);
  $employeeId=$employee->getId();
    $fname = $employee->getFname();
    $lname = $employee->getLname();
    $email = $employee->getEmail();
    $username = $employee->getUsername();
    $street = $employee->getStreet();
    $streetNum = $employee->getStreetNumber();
    $zipcode = $employee->getZipcode();
    $town = $employee->getTown();
    $country = $employee->getCountry();
    $phone = $employee->getPhone();
    $picture="other_.png";
if($employee->getGender()=="MALE"){
    $picture="male.png";
}else if($employee->getGender()=="FEMALE"){
    $picture="female.png";
}
?>
<!doctype html>
<html>
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta charset="windows-1252" /> 
        <meta charset="UTF-8">
        <link href="style/ProfilePageStyle.css"   type="text/css"   rel="stylesheet">
        <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"   type="text/css"   rel="stylesheet">
       <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.bundle.min.js"></script> 
       <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
</head> 
<body>
<div class="container px-4 py-5 mx-auto">
    <div class="card card0">
        <div class="d-flex flex-lg-row flex-column-reverse">
            <div class="card card1">
                <div class="row justify-content-center my-auto">
                    <div class="col-md-8 col-10 my-5">
                    <?php
                    echo
                    '<img src="photos/'.$picture.'" alt="profilePicture">';
                    ?>
                    
                    </div>
                </div>
                
            </div>
            <div class="card card2">
                <div class="my-auto mx-md-5 px-md-5 right">
                    <div class="row justify-content-center px-3 mb-3"> </div>
                        <h3 class="mb-5 text-center heading">Account information</h3>
                        <?php
                        echo '<div class="form-group"> <h3 class="form-control-label text-muted">Name(s):</h3> <h5 class="text-dark" >'.$fname.' '.$lname.'</h5> </div>
                        <div class="form-group"> <h3 class="form-control-label text-muted">Email:</h3> <h5 class="text-dark">'.$email.'</h5> </div>
                        <div class="form-group"> <h3 class="form-control-label text-muted">Adress:</h3> <h5 class="text-dark">'.$street.' '.$streetNum.' '.$zipcode.' 
                        '.$town.', '.$country.'</h5> </div>
                        <div class="form-group"> <h3 class="form-control-label text-muted">Phone:</h3> <h5 class="text-dark">'.$phone.'</h5> </div>';
                         ?>
                </div>
            </div>
        </div>
    </div>
</div>

</body>
</html>