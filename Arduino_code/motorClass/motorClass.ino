float mmPerStep = 29.751/3200;

int stepCount(int distance) {
  int num = distance/mmPerStep;
  return num;
}

class Motor {
  int stepPin;
  int directionPin;
  int enablePin;
  int forwardDir;
  int pos;

  public:
  Motor(int stp, int dir, int ebl, int forward) { // initialize motor
    stepPin = stp;
    pinMode(stepPin,OUTPUT);
    directionPin = dir;
    pinmode(directionPin,OUTPUT);
    enablePin = ebl;
    pinMode(enablePin,OUTPUT);
    digitalWrite(enablePin,LOW);
    digtalWrite(enablePin, forward);
    pos = 0;
  }
}

void moveToPos(motor1, motor2, newPos) {
  if (newPos > motor1.pos) {
    digitalWrite(motor1.directionPin, motor1.forwardDir);
    digitalWrite(motor2.directionPin, motor2.forwardDir);
    
    int distance = abs(newPos - motor1.pos);
    int numSteps = stepCount(distance);
    for(int x = 0; x < numSteps; x++) {
      digtalWrite(motor1.stepPin,HIGH);
      digtalWrite(motor2.stepPin,HIGH);
      delayMicroseconds(500);
      digtalWrite(motor1.stepPin,LOW);
      digtalWrite(motor2.stepPin,LOW);
    }
  }
}

void setup() {
  // put your setup code here, to run once:

}

void loop() {
  // put your main code here, to run repeatedly:

}
