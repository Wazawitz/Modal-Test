#include <MCP3008.h>

//define pin connections
#define CS_PIN 12
#define CLOCK_PIN 9
#define MOSI_PIN 11
#define MISO_PIN 10

MCP3008 adc(CLOCK_PIN, MOSI_PIN, MISO_PIN, CS_PIN);

void setup()
{
  // open serial port
  Serial.begin(19200);
}

void loop() {


  //int val = adc.readADC(0); // read Chanel 0 from MCP3008 ADC
  //Serial.println(val);


  // iterate thru all channels


  int pot1 = adc.readADC(0);
  int pot2 = adc.readADC(2);
  Serial.print(pot1);
  Serial.print(" ");
  Serial.print(pot2);

  Serial.println();


}

