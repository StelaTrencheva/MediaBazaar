<?php
class DatabaseMediatior {
    private $username = 'dbi467491';
    private $password = 'bulcari';
    private $host = 'studmysql01.fhict.local';
    private $dbName = 'dbi467491';
    private $conn;

    public function __construct() {
        $this->conn = new PDO("mysql:host=$this->host;dbname=$this->dbName", $this->username, $this->password);
        $this->conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    }

    public function GetEmployee(int $id)
    {
        $sql = 'SELECT * FROM  mb_employee WHERE id = :id;';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
            ':id' => $id
        ]);
        if( $sth->rowCount() == 1 )
        {
            $result = $sth->fetch();
            $employee = new Employee($result['id'], $result['bsn'], $result['fname'], $result['lname'], $result['gender'], $result['email'], $result['uname'], $result['pwd']
            , $result['birthdate'], $result['street'], $result['streetnumber'], $result['zipcode'], $result['town'], $result['country'], 
            $result['firstworkingday'], $result['emergphonenumber'], $result['iban'], $result['hourlywage'], $result['contractstartdate'], $result['contracttype'],
             $result['position']);   
            return $employee;    
        }
        else
        {
            return null;
        }
    }
    public function GetSchedulePerWeek(int $employeeId,string $date)
    {
        $shifts=array();
        $sql = 'SELECT * FROM `mb_shift_with_assigned_employee` WHERE mb_shift_with_assigned_employee.employeeID=:id and week(date, 1) = week(:date, 1);';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
            ':id' => $employeeId,
            ':date' => $date
        ]);
        $result = $sth->fetchAll();
        foreach ($result as $row) 
        {
            $shift= new Shift($row['shiftType'],$row['date']);
            array_push($shifts,$shift);
        }
        return $shifts;
    }

    public function GetAvailabilityPerWeek(int $employeeId,int $week)
    {
        $shifts=array();
        $sql = 'SELECT * FROM mb_employee_availability WHERE mb_employee_availability.employeeID=:id and week(date, 1) = :week;';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
            ':id' => $employeeId,
            ':week' => $week
        ]);
        $result = $sth->fetchAll();
        foreach ($result as $row) 
        {
            $shift= new Shift($row['shiftType'],$row['date']);
            array_push($shifts,$shift);
        }
        return $shifts;
    }

    public function LogInEmployee (string $uname, string $pwd)
    {
         $sql = 'SELECT * FROM mb_employee WHERE uname = :uname AND pwd = :pwd;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':uname' => $uname,
                ':pwd' => $pwd
            ]);
            if( $sth->rowCount() == 1 )
            {
                $result = $sth->fetch();
            $employee = new Employee($result['id'], $result['bsn'], $result['fname'], $result['lname'], $result['gender'], $result['email'], $result['uname'], $result['pwd']
            , $result['birthdate'], $result['street'], $result['streetnumber'], $result['zipcode'], $result['town'], $result['country'], 
            $result['firstworkingday'], $result['emergphonenumber'], $result['iban'], $result['hourlywage'], $result['contractstartdate'], $result['contracttype'],
             $result['position']);    
            return $employee;    
            }
            else
            {
                return null;
            }
    }

    public function UpdateUsername(string $username, int $id)
    {
        $sql = 'UPDATE mb_employee SET uname = :username WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':username' => $username,
                ':id' => $id
            ]);
            
            return null;
    }
    public function UpdatePassword(string $password, int $id)
    {
        $sql = 'UPDATE mb_employee SET pwd = :password WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':password' => $password,
                ':id' => $id
            ]);
            
            return null;
    }
    public function UpdateNames(string $fname, int $id)
    {
        $sql = 'UPDATE mb_employee SET fname = :fname WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':fname' => $fname,
                ':id' => $id
            ]);
            
            return null;
    }
    public function UpdateEmail(string $email, int $id)
    {
        $sql = 'UPDATE mb_employee SET email = :email WHERE id = :id ;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':email' => $email,
                ':id' => $id
            ]);
            
            return null;
    }
    public function AddShift(Shift $shift)
    {
        $sql = 'INSERT INTO `mb_shift`(`shiftType`, `date`,`assignableEmployees`) VALUES (:shiftType,:shiftDate,:assignableEmployees) on duplicate key update assignableEmployees=:assignableEmployees';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':shiftType' => $shift->getType(),
                ':shiftDate' => $shift->getDate(),
                ':assignableEmployees' => $shift->getAssignableEmployees()
            ]);
            
            return null;
    }

    public function AddAvailability(Shift $shift, int $id)
    {
        $sql = 'INSERT INTO `mb_employee_availability`(`employeeID`, `shiftType`, `date`) VALUES (:id,:shiftType,:shiftDate) on duplicate key update employeeID=:id,shiftType=:shiftType, `date`=:shiftDate;';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':shiftType' => $shift->getType(),
                ':shiftDate' => $shift->getDate(),
                ':id' => $id
            ]);
            
            return null;
    }
    public function DeleteAvailability(Shift $shift, int $id)
    {
        $sql = 'DELETE FROM `mb_employee_availability` WHERE employeeID=:id and shiftType=:shiftType and date=:shiftDate';
            $sth = $this->conn->prepare($sql);
            $sth->execute([
                ':shiftType' => $shift->getType(),
                ':shiftDate' => $shift->getDate(),
                ':id' => $id
            ]);
            
            return null;
    }


}
?>