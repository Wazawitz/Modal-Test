#include <MCP3008.h>

#define INTERVAL_LENGTH_US 150UL   //fixed sampling set-up
unsigned long previousMicros;

//define pin connections
#define CS_PIN 12
#define CLOCK_PIN 9
#define MOSI_PIN 11
#define MISO_PIN 10

MCP3008 adc(CLOCK_PIN, MOSI_PIN, MISO_PIN, CS_PIN);

void setup()
{
  // open serial port
  Serial.begin(2000000);
}

void loop() {

  unsigned long currentMicros = micros();

  if ((currentMicros - previousMicros) >= INTERVAL_LENGTH_US)
    {
        previousMicros += INTERVAL_LENGTH_US;
          
  int pot1 = adc.readADC(0);
  int pot2 = adc.readADC(2);
  Serial.print(pot1);
  Serial.print(" ");
  Serial.print(pot2);
  Serial.print(" ");
  Serial.print(((double)currentMicros) / 1000000UL, 5);
  Serial.println();
    }

}

