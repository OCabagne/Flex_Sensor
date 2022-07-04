char code[8] = "00000000";
int i;

void setup() {
  // put your setup code here, to run once:
  int code[8];
  pinMode(2, INPUT);
  pinMode(3, INPUT);
  pinMode(4, INPUT);
  pinMode(5, INPUT);
  pinMode(6, INPUT);
  pinMode(7, INPUT);
  pinMode(8, INPUT);
  pinMode(9, INPUT);
  Serial.begin(9600);
}

void loop() {
  // put your main code here, to run repeatedly:
  if(digitalRead(2) == HIGH){code[0] = 1;}
  else{code[0] = 0;}
    if(digitalRead(3) == HIGH){code[1] = 1;}
  else{code[1] = 0;}
    if(digitalRead(4) == HIGH){code[2] = 1;}
  else{code[2] = 0;}
    if(digitalRead(5) == HIGH){code[3] = 1;}
  else{code[3] = 0;}
    if(digitalRead(6) == HIGH){code[4] = 1;}
  else{code[4] = 0;}
    if(digitalRead(7) == HIGH){code[5] = 1;}
  else{code[5] = 0;}
    if(digitalRead(8) == HIGH){code[6] = 1;}
  else{code[6] = 0;}
    if(digitalRead(9) == HIGH){code[7] = 1;}
  else{code[7] = 0;}
  
  Serial.print("");
  for(i = 0; i < 8; i++){
    if(code[i] == 1){Serial.print("0");}
    else{Serial.print("1");}
  }
  Serial.println();
  delay(1000);
}
