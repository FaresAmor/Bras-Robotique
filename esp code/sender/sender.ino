
#include <ESP32Servo.h>
#include <Wire.h>


Servo monServox;
Servo monServoy;
Servo monServoz;
Servo monServo_pince;

const int brocheServox = 32;
const int brocheServoy = 27;
const int brocheServoz = 21;
const int brocheServo_pince = 33;

int variable1;
int variable2;
int variable3;
int variable4;

void setup() {
// Initialize Serial Monitor
Serial.begin(9600);
monServoz.attach(brocheServoz);
monServox.attach(brocheServox);
monServoy.attach(brocheServoy);
monServo_pince.attach(brocheServo_pince);
pinMode(13,OUTPUT);
}
void loop() {
if (Serial.available() > 0) {
String data = Serial.readStringUntil('\n'); // Lire les données jusqu'au caractère de nouvelle ligne

// Diviser les données en parties
int variable1;
int variable2;
int variable3;
int variable4;

sscanf(data.c_str(), "%d,%d,%d,%d?", &variable1, &variable2,&variable3,&variable4);
if(variable1==180||variable2==180||variable3==180||variable4==180){
digitalWrite(13,HIGH);
}
else{
digitalWrite(13,LOW);
}
monServox.write(variable1);
monServoy.write(variable2);
monServoz.write(variable3);
monServo_pince.write(variable4);
}

}
