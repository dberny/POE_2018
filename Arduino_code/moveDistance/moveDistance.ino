
// 29.751 MM PER REVOLUTION
// 0.018594 MM PER STEP
float mmPerStep = 0.018594;

int distance = 50; //DISTANCE IN MM

// defines pins numbers
const int rStepPin = 54; 
const int rDirPin = 55;
const int rEnablePin = 38; 

const int uStepPin = 60;
const int uDirPin = 61;
const int uEnablePin = 56; 

const int yStepPin = 36;
const int yDirPin = 34;
const int yEnablePin = 30; 

int numSteps = distance/mmPerStep;
//int numSteps = distanceToSteps(distance);
//
//int distanceToSteps(int distance) {
//  int steps = 0;
//  steps = distance/mmPerStep;
//  return steps;
//}


void setup() {
  // Sets the two pins as Outputs
  pinMode(rStepPin,OUTPUT); 
  pinMode(rDirPin,OUTPUT);
  pinMode(rEnablePin,OUTPUT);
  digitalWrite(rEnablePin,LOW);

  pinMode(uStepPin,OUTPUT); 
  pinMode(uDirPin,OUTPUT);
  pinMode(uEnablePin,OUTPUT);
  digitalWrite(uEnablePin,LOW);

  pinMode(yStepPin,OUTPUT); 
  pinMode(yDirPin,OUTPUT);
  pinMode(yEnablePin,OUTPUT);
  digitalWrite(uEnablePin,LOW);
  
  Serial.begin(9600);
  Serial.print(numSteps);
  
}
void loop() {
//  digitalWrite(rDirPin,HIGH); // Enables the motor to move in a particular direction
//  // Makes 200 pulses for making one full cycle rotation
//  for(int x = 0; x < numSteps; x++) {
//    digitalWrite(rStepPin,HIGH); 
//    delayMicroseconds(500); 
//    digitalWrite(rStepPin,LOW); 
//    delayMicroseconds(500); 
//  }
//  digitalWrite(uDirPin,HIGH); // Enables the motor to move in a particular direction
//  // Makes 200 pulses for making one full cycle rotation
//  for(int x = 0; x < numSteps; x++) {
//    digitalWrite(uStepPin,HIGH); 
//    delayMicroseconds(500); 
//    digitalWrite(uStepPin,LOW); 
//    delayMicroseconds(500); 
//  }
  digitalWrite(yDirPin,HIGH); // Enables the motor to move in a particular direction
  // Makes 200 pulses for making one full cycle rotation
  for(int x = 0; x < numSteps; x++) {
    digitalWrite(yStepPin,HIGH); 
    delayMicroseconds(500); 
    digitalWrite(yStepPin,LOW); 
    delayMicroseconds(500); 
  }
  delay(1000); // One second delay
  
//  digitalWrite(rDirPin,LOW); //Changes the rotations direction
//  // Makes 400 pulses for making two full cycle rotation
//  for(int x = 0; x < numSteps; x++) {
//    digitalWrite(rStepPin,HIGH);
//    delayMicroseconds(500);
//    digitalWrite(rStepPin,LOW);
//    delayMicroseconds(500);
//  }
//  digitalWrite(uDirPin,LOW); //Changes the rotations direction
//  // Makes 400 pulses for making two full cycle rotation
//  for(int x = 0; x < numSteps; x++) {
//    digitalWrite(uStepPin,HIGH);
//    delayMicroseconds(500);
//    digitalWrite(uStepPin,LOW);
//    delayMicroseconds(500);
//  }
  digitalWrite(yDirPin,LOW); //Changes the rotations direction
  // Makes 400 pulses for making two full cycle rotation
  for(int x = 0; x < numSteps; x++) {
    digitalWrite(yStepPin,HIGH);
    delayMicroseconds(500);
    digitalWrite(yStepPin,LOW);
    delayMicroseconds(500);
  }
  delay(1000);
}
