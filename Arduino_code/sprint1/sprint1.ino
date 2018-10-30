
// 29.751 MM PER REVOLUTION
// 0.018594 MM PER STEP
//float mmPerStep = 0.018594;
// numsteps per Rev = 3200
float mmPerStep = 29.751/3200;

int distance = 120; //DISTANCE IN MM

// defines pins numbers
const int xStepPin1 = 54; 
const int xDirPin1 = 55;
const int xEnablePin1 = 38; 

const int xStepPin2 = 60;
const int xDirPin2 = 61;
const int xEnablePin2 = 56; 


int numSteps = distance/mmPerStep;


void setup() {
  // Sets the two pins as Outputs
  pinMode(xStepPin1,OUTPUT); 
  pinMode(xDirPin1,OUTPUT);
  pinMode(xEnablePin1,OUTPUT);
  digitalWrite(xEnablePin1,LOW);

  pinMode(xStepPin2,OUTPUT); 
  pinMode(xDirPin2,OUTPUT);
  pinMode(xEnablePin2,OUTPUT);
  digitalWrite(xEnablePin2,LOW);
  Serial.begin(9600);
  Serial.print(numSteps);

//  FORWARD ONCE
  digitalWrite(xDirPin1,HIGH); // Enables the motor to move in a particular direction
  digitalWrite(xDirPin2,LOW);
  // Makes 3200 pulses for making one full cycle rotation
  for(int x = 0; x < numSteps; x++) {
    digitalWrite(xStepPin1,HIGH);
    digitalWrite(xStepPin2,HIGH);
    delayMicroseconds(500); 
    digitalWrite(xStepPin1,LOW);
    digitalWrite(xStepPin2,LOW);
    delayMicroseconds(500); 
  }
  delay(1000); // One second delay

//  BACKWARDS ONCE
  digitalWrite(xDirPin1,LOW); //Changes the rotations direction
  digitalWrite(xDirPin2,HIGH);
  for(int x = 0; x < numSteps; x++) {
    digitalWrite(xStepPin1,HIGH);
    digitalWrite(xStepPin2,HIGH);
    delayMicroseconds(500);
    digitalWrite(xStepPin1,LOW);
    digitalWrite(xStepPin2,LOW);
    delayMicroseconds(500);
  }
  delay(1000);
}
void loop() {
  
}
