void setup() {
  // initialize the serial communication:
  Serial.begin(2000000);
}

void loop() {
  // send the value of analog input 0:
  Serial.println(analogRead(A0));
  //Serial.write(analogRead(A0));
}



