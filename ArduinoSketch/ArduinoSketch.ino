// Flex Pins
const int flexIndexPin = A0;
const int flexMiddlePin = A3;
const int flexRingPin = A6;
const int flexThumbPin = A7;
const int flexPinkyPin = A4;
// For 3.3V
const int vccPin = 13;

void setup()
{
  // Serial Initialization
  Serial.begin(9600);
  Serial.flush();

  // Initialize Pins
  pinMode(vccPin,OUTPUT);
  digitalWrite(vccPin, HIGH);

} 

void loop()
{ 
  float angle1 = map(analogRead(flexIndexPin), 0, 4095, 90, 0);
  float angle2 = map(analogRead(flexMiddlePin), 0, 4095, 90, 0);
  float angle3 = map(analogRead(flexRingPin), 0, 4095, 90, 0);
  float angle4 = map(analogRead(flexThumbPin), 0, 4095, 90, 0);
  float angle5 = map(analogRead(flexPinkyPin), 0, 4095, 90, 0);
  String cmd;

  // Sending data
  cmd = String(angle1);
  cmd += "|";
  cmd += String(angle2);
  cmd += "|";
  cmd += String(angle3);
  cmd += "|";
  cmd += String(angle4);
  cmd += "|";
  cmd += String(angle5);
  cmd += ";";
  Serial.println(cmd);

  delay(10);
  
} 