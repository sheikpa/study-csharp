<?php
echo "<pre>";

class Operator {

  //Dependency Injection
  private $unten;
  //コンストラクタインジェクション
  public function __construct(IUnten $u){
    $this->unten = $u;
  }
  public function start(){
    $this->unten->soukou();
  }
  public function stop(){
  }
}

interface IUnten {
  public function soukou();
}

class Car implements IUnten {
  protected $hour = 0;
  protected $kyori = 0;
  public function soukou(){
    $this->hour++;
    $this->nenryo--;
    $this->kyori += $this->nenpi;
    echo "{$this->syamei}の燃費は{$this->nenpi}km／h。";
    echo "燃料残り{$this->nenryo}リットル。走行距離は{$this->kyori}km。";
    echo "{$this->hour}時間走行。\n";
  }
}

class Sedan extends Car {
  protected $syamei = 'セダン';
  protected $nenpi = 12;
  protected $nenryo = 40;
}
class Miniban extends Car {
  protected $syamei = 'ミニバン';
  protected $nenpi = 10;
  protected $nenryo = 50;
}
class Truck extends Car {
  protected $syamei = 'トラック';
  protected $nenpi = 8;
  protected $nenryo = 60;
}

$Sedan = new Sedan;
$Miniban = new Miniban;
$Truck = new Truck;
$op1 = new Operator($Sedan);
$op1->start();
$op1->start();
$op1->start();
$op2 = new Operator($Miniban);
$op2->start();
$op2->start();
$op3 = new Operator($Truck);
$op3->start();

?>

/*  出力
セダンの燃費は12km／h。燃料残り39リットル。走行距離は12km。1時間走行。
セダンの燃費は12km／h。燃料残り38リットル。走行距離は24km。2時間走行。
セダンの燃費は12km／h。燃料残り37リットル。走行距離は36km。3時間走行。
ミニバンの燃費は10km／h。燃料残り49リットル。走行距離は10km。1時間走行。
ミニバンの燃費は10km／h。燃料残り48リットル。走行距離は20km。2時間走行。
トラックの燃費は8km／h。燃料残り59リットル。走行距離は8km。1時間走行。
*/