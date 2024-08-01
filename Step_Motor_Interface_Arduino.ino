#define IN1 11
#define IN2 10
#define IN3 9
#define IN4 8

void setup() {
  Serial.begin(9600);
  pinMode(IN1, OUTPUT);
  pinMode(IN2, OUTPUT);
  pinMode(IN3, OUTPUT);
  pinMode(IN4, OUTPUT);
}

void loop() {
  while(!Serial.available());
  String count_str = Serial.readString();
  int count = count_str.toInt();
  while(!Serial.available());
  String step_str = Serial.readString();
  int step = step_str.toInt();
  step++; // for index
  Serial.print(count);
  Serial.print(" , ");
  Serial.println(step);
  for(int i = 0; i < count; i++) {
    for(int j = 0; j < step; j++) {
      for(int k = 0; k < 4; k++){
        stepMotor(k);
        delay(10);
      }
    }
    delay(1000);
    Serial.print("Image ");
    Serial.print(i + 1);
    Serial.println(" is taken!");
    delay(1000);
  }
  Serial.println("OK");
}

void stepMotor(int step) {
  switch (step) {
    case 0:
      digitalWrite(IN1, HIGH);
      digitalWrite(IN2, LOW);
      digitalWrite(IN3, LOW);
      digitalWrite(IN4, LOW);
      break;
    case 1:
      digitalWrite(IN1, LOW);
      digitalWrite(IN2, HIGH);
      digitalWrite(IN3, LOW);
      digitalWrite(IN4, LOW);
      break;
    case 2:
      digitalWrite(IN1, LOW);
      digitalWrite(IN2, LOW);
      digitalWrite(IN3, HIGH);
      digitalWrite(IN4, LOW);
      break;
    case 3:
      digitalWrite(IN1, LOW);
      digitalWrite(IN2, LOW);
      digitalWrite(IN3, LOW);
      digitalWrite(IN4, HIGH);
      break;
  }
}