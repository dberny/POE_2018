
// 29.751 MM PER REVOLUTION
// 0.018594 MM PER STEP
const int mmPerStep = 0.018594;

int distance = 150; //DISTANCE IN MM

// defines pins numbers
const int xStepPin1 = 54; 
const int xDirPin1 = 55;
const int xEnablePin1 = 38; 

const int xStepPin2 = 60;
const int xDirPin2 = 61;
const int xEnablePin2 = 56; 
 
void setup() {
  // Sets the two pins as Outputs
  pinMode(xStepPin1,OUTPUT); 
  pinMode(xDirPin1,OUTPUT);
  pinMode(xEnablePin1,OUTPUT);

  digitalWrite(xEnablePin1,LOW);

  int numSteps = distanceToSteps(distance)
}
void loop() {
  digitalWrite(xDirPin1,HIGH); // Enables the motor to move in a particular direction
  // Makes 200 pulses for making one full cycle rotation
  for(int x = 0; x < numSteps; x++) {
    digitalWrite(xStepPin1,HIGH); 
    delayMicroseconds(500); 
    digitalWrite(xStepPin1,LOW); 
    delayMicroseconds(500); 
  }
  delay(1000); // One second delay
  
  digitalWrite(xDirPin1,LOW); //Changes the rotations direction
  // Makes 400 pulses for making two full cycle rotation
  for(int x = 0; x < numSteps; x++) {
    digitalWrite(xStepPin1,HIGH);
    delayMicroseconds(500);
    digitalWrite(xStepPin1,LOW);
    delayMicroseconds(500);
  }
  delay(1000);
}

int distanceToSteps(int distance) {
  int steps = 0;
  steps = distance/mmPerStep;
  return steps;
}
