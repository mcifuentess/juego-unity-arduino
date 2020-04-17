int Pin1 = A0;  // digital pin to attach the switch
int Pin2 = A3;  // digital pin to attach the switch

int data1;
int data2;

void setup()
{
  Serial.begin(9600);
  pinMode(Pin1, INPUT);  // set digital pin 0 as input
  pinMode(Pin2, INPUT);  // set digital pin 0 as input
  
}

void loop()
{
    data1 = analogRead(Pin1);
    data2 = analogRead(Pin2); 
    
    Serial.print(data2);
    Serial.print(",");
    Serial.println(data1);
    Serial.flush();
    delay(20);
  
}
