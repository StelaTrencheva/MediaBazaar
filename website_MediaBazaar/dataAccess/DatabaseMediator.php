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



}
?>