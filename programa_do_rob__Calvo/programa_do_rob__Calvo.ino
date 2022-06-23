int s1 = A0;
int s2 = A1;
int s3 = A2;
int s4 = A3;
int in1 = 6;
int in2 = 7;
int in3 = 8;
int in4 = 9;
int pwm1 = 5;
int pwm2 = 10;
int sensor1;
int sensor2;
int sensor3;
int sensor4;
int vel1 = 70;
int vel12 = 220;
int vel2 = 240;
int vel3 = 130;
int trig = 2;
int corte = 500;
int echo = 3;
int tempo;
int distancia_cm;

void setup(){
  pinMode(s1, INPUT);
  pinMode(s2, INPUT);
  pinMode(s3, INPUT);
  pinMode(s4, INPUT);
  pinMode(in1, OUTPUT);
  pinMode(in2, OUTPUT);
  pinMode(in3, OUTPUT);
  pinMode(in4, OUTPUT);
  pinMode(pwm1, OUTPUT);
  pinMode(pwm2, OUTPUT);
  Serial.begin(9600);
}
void loop(){
  sensor1 = analogRead(s1);
  sensor2 = analogRead(s2);
  sensor3 = analogRead(s3);
  sensor4 = analogRead(s4);  

Serial.print(sensor2);
Serial.println(" ");
if(sensor3 >= corte && sensor4 <= corte){
parado();
delay(50);
mvd();
mvet();
delay(50);
}
if(sensor3 <= corte && sensor4 >= corte){
parado();
delay(50);
mve();
mvdt();
delay(50);
}
if(sensor3 <= corte && sensor4 <= corte){
frente();
}
/*
if(sensor3 >= corte && sensor4 >= corte){
  tras();
  delay(150);
}
*/

}

void frente(){
digitalWrite(in1, LOW);
digitalWrite(in2, HIGH);
analogWrite(pwm1, vel1);
digitalWrite(in3, LOW);
digitalWrite(in4, HIGH);
analogWrite(pwm2, vel1);
}
void direita(){
digitalWrite(in1, LOW);
digitalWrite(in2, HIGH);
analogWrite(pwm1, vel1);
digitalWrite(in3, LOW);
digitalWrite(in4, HIGH);
analogWrite(pwm2, vel2);
}

void esquerda(){
digitalWrite(in1, LOW);
digitalWrite(in2, HIGH);
analogWrite(pwm1, vel2);
digitalWrite(in3, LOW);
digitalWrite(in4, HIGH);
analogWrite(pwm2, vel1);
}
void tras(){
  digitalWrite(in1, HIGH);
digitalWrite(in2, LOW);
analogWrite(pwm1, vel2);
digitalWrite(in3, HIGH);
digitalWrite(in4, LOW);
analogWrite(pwm2, vel2);
}
void mvd(){
digitalWrite(in1, LOW);
digitalWrite(in2, HIGH);
analogWrite(pwm1, vel2);
}
void mvdt(){
  digitalWrite(in1, HIGH);
digitalWrite(in2, LOW);
analogWrite(pwm1, vel12);
}
void mve(){
digitalWrite(in3, LOW);
digitalWrite(in4, HIGH);
analogWrite(pwm2, vel2);
}
void mvet(){
  digitalWrite(in3, HIGH);
digitalWrite(in4, LOW);
analogWrite(pwm2, vel12);
}
void ultrassonico(){
  distancia_cm;
  digitalWrite(trig, HIGH);
  delayMicroseconds(10);
  digitalWrite(trig, LOW);
tempo = pulseIn(echo, HIGH);
distancia_cm = tempo / 29.4 / 2;
/*
Serial.print("Distancia");
Serial.print(distancia_cm);
delay(300);
Serial.prinln("CM");
*/
}
void parado(){
digitalWrite(in1, LOW);
digitalWrite(in2, LOW);
analogWrite(pwm1, vel2);
digitalWrite(in3, LOW);
digitalWrite(in4, LOW);
analogWrite(pwm2, vel1);
}
