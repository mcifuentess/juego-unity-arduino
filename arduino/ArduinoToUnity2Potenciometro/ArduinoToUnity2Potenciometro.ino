int switchPin1 = 8;  // digital pin to attach the switch
int switchPin2 = 4;  // digital pin to attach the switch

void setup()
{
  Serial.begin(9600);
  pinMode(switchPin1, INPUT);  // set digital pin 0 as input
  pinMode(switchPin2, INPUT);  // set digital pin 0 as input
  
}

void loop()
{
  if (digitalRead(switchPin1) == HIGH) // if the switch is pressed
    {
    //Serial.println("L");
    Serial.write(1);
    //flush= espera a que termine de enviar la información completamente
    Serial.flush();
    delay(20);
    }
  
  if (digitalRead(switchPin2) == HIGH) // if the switch is pressed
  {
    //Serial.println("R");
    Serial.write(2);
    Serial.flush();
    delay(20);
  }
  
}
