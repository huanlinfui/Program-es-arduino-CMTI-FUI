async Task Main(){ //delay pra virar 90° pro lado é 950
string motor1 = "motor1";
string motor2 = "motor2";
string motor3 = "motor3";
string motor4 = "motor4";

destravar();
while(true){
	IO.OpenConsole();

double corv = ( ( Bot.GetComponent<ColorSensor>( "rc1" ).Analog ).Green );
double corv2 = ( ( Bot.GetComponent<ColorSensor>( "lc1" ).Analog ).Green );
string cor =  (Bot.GetComponent<ColorSensor>( "rc1" ).Analog.ToString() );
string cor2 = (Bot.GetComponent<ColorSensor>( "lc1" ).Analog.ToString() );
string cor3 = (Bot.GetComponent<ColorSensor>("rc2"). Analog.ToString());
string cor4 = (Bot.GetComponent<ColorSensor>("lc2"). Analog.ToString());
string corm = (Bot.GetComponent<ColorSensor>("sl"). Analog.ToString());
//IO.PrintLine("corv = " + corv);
//IO.PrintLine("corv2 = " + corv2);
await Time.Delay(50);


if ((cor == "Branco") && (cor2 == "Preto")){

esquerdaml(350, 350, -500, -500);
await Time.Delay(20);
}
else {
frente(100,100);
await Time.Delay(50);
}


if ((corm == "Preto") && (cor == "Preto") && (cor2 == "Branco")){
frente(70,70);
await Time.Delay(2000);
if (corm == "Preto" && cor2 == "Branco" && cor == "Branco");
frente(150,150);
await Time.Delay(500);
if (cor2 == "Branco" && corm == "Preto" && corv == 84);
frente(150,150);
}
if(corv2 == 84){
parar();
await Time.Delay(400);
destravar();
frente(150,150);
await Time.Delay(800);
esquerdaml(350,350,-500,-500);
await Time.Delay(950);
frente(150,150);
await Time.Delay(800);
}
if(corv == 84){
parar();
await Time.Delay(400);
destravar();
frente(150,150);
await Time.Delay(800);
direitaml(350,350,-500,-500);
await Time.Delay(950);
frente(150,150);
await Time.Delay(800);
}


if  (cor == "Preto"  && cor2 =="Branco") {
direitaml(350,350, -500, -500);
await Time.Delay(20);
}
else {
frente(100,100);
await Time.Delay(50);
}

/*
if (corv == <= 90 && corv >= 20 && corm == "Preto"){

parar();
await Time.Delay(1000);
destravar();
frente(150,150);
await Time.Delay(1000);
direitaml(350,350,-500,-500);
await Time.Delay(850);
frente(150,150);
await Time.Delay(400);
}
if (cor3 == "Verde" && corm == "Preto"){

parar();
await Time.Delay(1000);
destravar();
frente(150,150);
await Time.Delay(1000);
direitaml(350,350,-500,-500);
await Time.Delay(850);
frente(150,150);
await Time.Delay(400);
}

if (corm == "Verde"){
IO.PrintLine("corm =" + corm);
frente(-150,-150);
await Time.Delay(500);
}
*/
/*
if (corv <= 85 && corv >= 84 && corv2 <= 85 && corv2 >= 84){
parar();
await Time.Delay(500);
destravar();
frente(150,150);
await Time.Delay(200);
direitaml(350,350,-500,-500);
await Time.Delay(1900);
frente(150,150);
await Time.Delay(800);
direitaml(350,350,-500,-500);
await Time.Delay(500);
}
if (corv2 <= 90 && corv2 >= 20){
esquerdaml(350,350,-500,-500);
await Time.Delay(950);
}
*/
/*
if (cor2 == "Verde" && corm == "Preto"){

parar();
await Time.Delay(1000);
destravar();
frente(150,150);
await Time.Delay(1000);
esquerdaml(350,350,-500,-500);
await Time.Delay(850);
frente(150,150);
await Time.Delay(400);
}
/*
if (cor4 == "Verde" && corm == "Preto"){

parar();
await Time.Delay(1000);
destravar();
frente(150,150);
await Time.Delay(1000);
esquerdaml(350,350,-500,-500);
await Time.Delay(850);
frente(150,150);
await Time.Delay(400);
}
*/


if ((corv <= 60) && (corv2 <= 60)){
frente(150, 150);
await Time.Delay(50);
}

}
}

void frente(double forca, double velocidade){
Bot.GetComponent<Servomotor>("motor1").Apply(forca, velocidade);
Bot.GetComponent<Servomotor>("motor2").Apply(forca, velocidade);
Bot.GetComponent<Servomotor>("motor3").Apply(forca, velocidade);
Bot.GetComponent<Servomotor>("motor4").Apply(forca, velocidade);
}
void destravar(){
Bot.GetComponent<Servomotor>("motor1").Locked = false;
Bot.GetComponent<Servomotor>("motor2").Locked = false;
Bot.GetComponent<Servomotor>("motor3").Locked = false;
Bot.GetComponent<Servomotor>("motor4").Locked = false;
}
void direita(double forca, double velocidade){
Bot.GetComponent<Servomotor>("motor1").Locked = true;
Bot.GetComponent<Servomotor>("motor2").Locked = true;
Bot.GetComponent<Servomotor>("motor3").Apply(forca, velocidade);
Bot.GetComponent<Servomotor>("motor4").Apply(forca, velocidade);
}
void direitaml(double forca, double velocidade, double forca2, double velocidade2){
Bot.GetComponent<Servomotor>("motor1").Apply(forca, velocidade);
Bot.GetComponent<Servomotor>("motor2").Apply(forca, velocidade);
Bot.GetComponent<Servomotor>("motor3").Apply(forca2, velocidade2);
Bot.GetComponent<Servomotor>("motor4").Apply(forca2, velocidade2);
}
void esquerda(double forca, double velocidade){
Bot.GetComponent<Servomotor>("motor1").Locked = true;
Bot.GetComponent<Servomotor>("motor2").Locked = true;
Bot.GetComponent<Servomotor>("motor3").Apply(velocidade, forca);
Bot.GetComponent<Servomotor>("motor4").Apply(velocidade, forca);
}
void esquerdaml(double forca, double velocidade, double forca2, double velocidade2){
Bot.GetComponent<Servomotor>("motor1").Apply(forca2, velocidade2);
Bot.GetComponent<Servomotor>("motor2").Apply(forca2, velocidade2);
Bot.GetComponent<Servomotor>("motor3").Apply(forca, velocidade);
Bot.GetComponent<Servomotor>("motor4").Apply(forca, velocidade);
}
void parar(){
Bot.GetComponent<Servomotor>("motor1").Locked = true;
Bot.GetComponent<Servomotor>("motor2").Locked = true;
Bot.GetComponent<Servomotor>("motor3").Locked = true;
Bot.GetComponent<Servomotor>("motor4").Locked = true;
}
void tras(double forca, double velocidade){
Bot.GetComponent<Servomotor>("motor1").Apply(forca, velocidade);
Bot.GetComponent<Servomotor>("motor2").Apply(forca, velocidade);
}