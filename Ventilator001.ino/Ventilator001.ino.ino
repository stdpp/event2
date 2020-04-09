
// Ventilator v0.02 (c) MB    //rBase64 lib

#include <string.h>

bool DEBUG_MODE_0 = true;
bool ENABLE_OUTPUT_TO_PC = true;

char inData[512];    //serial input buffer
byte index = 0;

long runNumber = 0;   //"program counter"
int breathingCurve[100];

int t;  //current time
int tA=10, tB=20, tC=30, tD=40, tE=50, tF=100,   LA=-40, LB=120, LC=120, LD=40;
int mode=1;

// the setup function runs once when you press reset or power the board:
void setup() 
{
  //initialize digital pin LED_BUILTIN as an output.
  pinMode(LED_BUILTIN, OUTPUT);
  Serial.begin(9600);
  while (!Serial) 
  {
    ; // wait for serial port to connect. Needed for Arduino Leonardo only
  }  
  setupMotorsAndValves();

  closeValve('A');
  closeValve('B');
}

// the loop function runs over and over again forever
void loop() 
{
  Blink01();

  if (t==tF)
  {
    t=0;
    closeValve('A');
    closeValve('B');
  }
  if (t==tA) openValve('A');
  if (t==tB) closeValve('A');
  if (t==tD) openValve('B');

  runNumber++;
  t++;

  if (ENABLE_OUTPUT_TO_PC)
  {
    Serial.write("<FromArduino runNumber='");
    Serial.print(runNumber);
    Serial.write("' mode='");
    Serial.print(mode);
    Serial.write("' ");
    Serial.write(" t='");
    Serial.print(t);
    Serial.write("' ");
    Serial.write(" />\n\r");
  }


  while(Serial.available() > 0)
  {
     char aChar = Serial.read();
     if(aChar == '\n')
     {
        if (DEBUG_MODE_0) Serial.println((String) inData);
        parseInstructions();
      
        // End of record detected. Time to parse
        index = 0;
        inData[index] = NULL;
     }
     else
     {
        //Serial.println("Serial arrived:");
        //Serial.println(aChar);
        inData[index] = aChar;
        index++;
        inData[index] = '\0'; //keep the string null terminated
     }
  }  //end of while
  
}


int parseInstructions()
{
  String curr = "";
  //Serial.println("Parsing instructions:");
  //Serial.println(inData);

  if ( strstr(inData, "<FromPC DB br='") )
  {
    //we obtain the XML tag. We parse it.  <FromPC DB br=... go='go'/>    
    if (DEBUG_MODE_0)Serial.println("foundit");

    int ptrTag1 = strstr(inData, "<FromPC DB br='") + strlen("<FromPC DB br='");
    //Serial.println(ptrTag1);
    int ptrTag2 = strstr(inData, "' tA='");
    //Serial.println(ptrTag2);
    int ptrTag3 = strstr(inData, "' tB='");
    int ptrTag4 = strstr(inData, "' tC='");
    int ptrTag5 = strstr(inData, "' tD='");
    int ptrTag6 = strstr(inData, "' tE='");
    int ptrTag7 = strstr(inData, "' tF='");

    int ptrTag8 = strstr(inData, "' LA='");
    int ptrTag9 = strstr(inData, "' LB='");
    int ptrTag10 = strstr(inData, "' LC='");
    int ptrTag11 = strstr(inData, "' LD='");
    int ptrTag12 = strstr(inData, "' md='");
    
    int ptrTag13 = strstr(inData, "' go='");

    parseAndLoadNewMode(ptrTag1, ptrTag2, ptrTag3, ptrTag4, ptrTag5, ptrTag6, ptrTag7, ptrTag8, ptrTag9, ptrTag10, ptrTag11, ptrTag12, ptrTag13);
  } // if
  
  
}


int parseAndLoadNewMode(int ptrTag1, int ptrTag2, int ptrTag3, int ptrTag4, int ptrTag5, int ptrTag6, int ptrTag7, int ptrTag8, int ptrTag9, int ptrTag10, int ptrTag11, int ptrTag12, int ptrTag13)
{
  // we receive something like this: 
  // <FromPC DB br='777777777770)$   $)07dt{}~~~~~QA:877777777777777777777777777777777777' tA='10' tB='20' tC='30' tD='60' tE='70' tF='100' LA='-40' LB='120' LC='120' LD='40' go='go'/>
  // ugly parsing: all parameters mandatory, order is important, whitespace should be kept as it is!
  
  //we parse between ptrTag1 and ptrTag2
  char strToParse[150];
  char strValue[5];
  strncpy(strToParse, ptrTag1, ptrTag2 - ptrTag1);
  strToParse[ptrTag2 - ptrTag1] = '\0';   //keep the string null terminated.
  if (DEBUG_MODE_0) Serial.println("strToParse:");
  if (DEBUG_MODE_0) Serial.println(strToParse);

  //we obtain: tA:
  strncpy(strValue, ptrTag2 + 6, ptrTag3 - ptrTag2 - 6);
  strValue[ptrTag3 - ptrTag2 - 6] = '\0';   //keep the string null terminated.
  if (DEBUG_MODE_0) Serial.println("tA:");
  if (DEBUG_MODE_0) Serial.println(strValue);
  tA = atoi(strValue);
  

  //we obtain: tB:
  strncpy(strValue, ptrTag3 + 6, ptrTag4 - ptrTag3 - 6);
  strValue[ptrTag4 - ptrTag3 - 6] = '\0';   //keep the string null terminated.
  if (DEBUG_MODE_0) Serial.println("tB:");
  if (DEBUG_MODE_0) Serial.println(strValue);
  tB = atoi(strValue);

  //we obtain: tC:
  strncpy(strValue, ptrTag4 + 6, ptrTag5 - ptrTag4 - 6);
  strValue[ptrTag5 - ptrTag4 - 6] = '\0';   //keep the string null terminated.
  if (DEBUG_MODE_0) Serial.println("tC:");
  if (DEBUG_MODE_0) Serial.println(strValue);
  tC = atoi(strValue);

  //we obtain: tD:
  strncpy(strValue, ptrTag5 + 6, ptrTag6 - ptrTag5 - 6);
  strValue[ptrTag6 - ptrTag5 - 6] = '\0';   //keep the string null terminated.
  if (DEBUG_MODE_0) Serial.println("tD:");
  if (DEBUG_MODE_0) Serial.println(strValue);
  tD = atoi(strValue);

  //we obtain: tE:
  strncpy(strValue, ptrTag6 + 6, ptrTag7 - ptrTag6 - 6);
  strValue[ptrTag7 - ptrTag6 - 6] = '\0';   //keep the string null terminated.
  if (DEBUG_MODE_0) Serial.println("tE:");
  if (DEBUG_MODE_0) Serial.println(strValue);
  tE = atoi(strValue);

  //we obtain: tF:
  strncpy(strValue, ptrTag7 + 6, ptrTag8 - ptrTag7 - 6);
  strValue[ptrTag8 - ptrTag7 - 6] = '\0';   //keep the string null terminated.
  if (DEBUG_MODE_0) Serial.println("tF:");
  if (DEBUG_MODE_0) Serial.println(strValue);
  tF = atoi(strValue);

  
  //we obtain: LA:
  strncpy(strValue, ptrTag8 + 6, ptrTag9 - ptrTag8 - 6);
  strValue[ptrTag9 - ptrTag8 - 6] = '\0';   //keep the string null terminated.
  if (DEBUG_MODE_0) Serial.println("LA:");
  if (DEBUG_MODE_0) Serial.println(strValue);
  LA = atoi(strValue);
  
  //we obtain: LB:
  strncpy(strValue, ptrTag9 + 6, ptrTag10 - ptrTag9 - 6);
  strValue[ptrTag10 - ptrTag9 - 6] = '\0';   //keep the string null terminated.
  if (DEBUG_MODE_0) Serial.println("LB:");
  if (DEBUG_MODE_0) Serial.println(strValue);
  LB = atoi(strValue);

  //we obtain: LC:
  strncpy(strValue, ptrTag10 + 6, ptrTag11 - ptrTag10 - 6);
  strValue[ptrTag11 - ptrTag10 - 6] = '\0';   //keep the string null terminated.
  if (DEBUG_MODE_0) Serial.println("LC:");
  if (DEBUG_MODE_0) Serial.println(strValue);
  LC = atoi(strValue);

  //we obtain: LD:
  strncpy(strValue, ptrTag11 + 6, ptrTag12 - ptrTag11 - 6);
  strValue[ptrTag12 - ptrTag11 - 6] = '\0';   //keep the string null terminated.
  if (DEBUG_MODE_0) Serial.println("LD:");
  if (DEBUG_MODE_0) Serial.println(strValue);
  LD = atoi(strValue);

  //we obtain: mode:
  strncpy(strValue, ptrTag12 + 6, ptrTag13 - ptrTag12 - 6);
  strValue[ptrTag13 - ptrTag12 - 6] = '\0';   //keep the string null terminated.
  if (DEBUG_MODE_0) Serial.println("mode:");
  if (DEBUG_MODE_0) Serial.println(strValue);
  mode = atoi(strValue);

  for (int i=0; i<100; i++)
  {
    breathingCurve[i] = strToParse[i];
    //Serial.println(breathingCurve[i]);
  }

  //reconvert breathingCurve to voltage values. LA=-40 is min. LB=100 is max.
  
}

int setupMotorsAndValves()
{

}


int setPistonTo(long position)
{
  //sets piston to spec. position
  
}


int openValve(char valve)
{
  //TODO
}

int closeValve(char valve)
{
  //TODO
}



int movePistonTo(long pos)
{
  //TODO
}

void Blink01()
{
  for (int i=0; i<5; i++)
  {
    digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
    delay(1);                       // wait for a second
    digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
    delay(1);                       // wait for a second
  }
}

void Blink02()
{
  for (int i=0; i<10; i++)
  {
    digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)
    delay(2);                       // wait for a second
    digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW
    delay(2);                       // wait for a second
  }
}
