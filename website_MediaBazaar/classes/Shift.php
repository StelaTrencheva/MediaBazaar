<?php
class Shift
{
        private $type;
        private $date;
       
    public function __construct(string $type, string $date)
    {
        $this->type= $type;
        $this->date= $date;
    }

    public function getType()
    {
        return $this->type;
    }
    public function getDate()
    {
        return $this->date;
    }
    
}
?>