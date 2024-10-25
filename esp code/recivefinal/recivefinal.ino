#include <esp_now.h>
#include <WiFi.h>
#include <ESP32Servo.h>

Servo monServox;
Servo monServoy;
Servo monServoz;
Servo monServow;
  int angle_x = 30;
  int angle_y = 30;
  int angle_z = 30;
  int angle_w = 30;

const int brocheServox = 32;
const int brocheServoy = 27;
const int brocheServoz = 21;
const int brocheServow = 23;

// Structure example to receive data
// Must match the sender structure
typedef struct struct_message {
    int a;
    int b;
    int c;
    int d;
} struct_message;

// Create a struct_message called myData
struct_message myData;

// callback function that will be executed when data is received
void OnDataRecv(const uint8_t * mac, const uint8_t *incomingData, int len) {
  memcpy(&myData, incomingData, sizeof(myData));
  Serial.print("Bytes received: ");
  Serial.println(len);

  Serial.print("variable a = ");
  Serial.print(myData.a);

  Serial.print("variable b = ");
  Serial.print(myData.b);

   Serial.print("variable c = ");
  Serial.print(myData.c);

   Serial.print("variable d = ");
  Serial.print(myData.d);
  Serial.println();
}
 
void setup() {
  // Initialize Serial Monitor
  Serial.begin(115200);
  monServoz.attach(brocheServoz);
  monServox.attach(brocheServox);
  monServoy.attach(brocheServoy);
  monServow.attach(brocheServow);
  // Set device as a Wi-Fi Station
  WiFi.mode(WIFI_STA);

  // Init ESP-NOW
  if (esp_now_init() != ESP_OK) {
    Serial.println("Error initializing ESP-NOW");
   angle_x = 30;
   angle_y = 30;
   angle_z = 30;
   angle_w = 30;
    return;
  }
  
  // Once ESPNow is successfully Init, we will register for recv CB to
  // get recv packer info
  esp_now_register_recv_cb(OnDataRecv);
}
 
void loop() {
   angle_x = myData.a;
   angle_y = myData.b;
   angle_z = myData.c;
   angle_w = myData.d;
monServox.write(angle_x);
monServoy.write(angle_y);
monServoz.write(angle_z);
monServow.write(angle_w);
delay(20);
}
