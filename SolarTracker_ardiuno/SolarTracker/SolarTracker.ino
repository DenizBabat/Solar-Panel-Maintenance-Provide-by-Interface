#include <Servo.h> 
#include <String.h>
#include <Thread.h>


const float mapvalue = 1023.0;
const float referenceVolts = 6; 
int resistance = 10; //76 Kohms
const int p1volt = 9;
const int p1amper = 8;
const int p2volt = 10;


//Servo
Servo hor; 
Servo ver;
int pinver = 7; //üsteki motor
int pinhor = 5; // alttaki motor

int led1 = 8;   // 1. ledin bağlı olduğu dijital pin
int led2 = 9;   // 2. ledin bağlı olduğu dijital pin

// LDR pin connections
//  name  = analogpin;
int ldrlt = 0; //LDR top left
int ldrrt = 1; //LDR top rigt 
int ldrld = 2; //LDR down left 
int ldrrd = 3; //ldr down rigt 

double sethor;
double setver;

char msj;
String sopen = "o";
String sclose = "c";
String sauto = "a";
String snotauto = "n";

bool flag_open = false;
bool flag_auto = false;

String str="";

//My simple Thread
Thread myThread = Thread();

void setup() {
  
    Serial.begin(9600);


    
    //servo pinleri 
    ver.attach(pinver);
    hor.attach(pinhor); 
    setver = 30;
    sethor = 70; 
    hor.write(sethor);
    ver.write(setver);
    delay(3000);
    
    pinMode(led1,OUTPUT);    // ledleri OUTPUT olarak tanımladık
    pinMode(led2,OUTPUT);

    myThread.onRun(niceCallback);
    myThread.setInterval(1000);
  

}

void loop() {

    // checks if thread should run
    if(myThread.shouldRun())
        myThread.run();

    if(Serial.available()>0){
        str = Serial.readString(); 
    }

    if( str == sclose){
        flag_open = false;
        flag_auto = false;
        digitalWrite(led1,LOW);
        digitalWrite(led2,LOW);
    }
    if(str == sopen){
        flag_open = true;
        flag_auto = false;
        digitalWrite(led1,HIGH);
    }
    if(str == sauto && flag_open == true){
        flag_auto = true;
        digitalWrite(led2,HIGH);
    }
    if(str == snotauto && flag_open == true ){
        flag_auto = false;
        digitalWrite(led2,LOW);
    }

    //flag_open = true;
    //flag_auto = true;
    
    if(flag_open && flag_auto){
      //  Serial.println("1_DEBUG-------------------------------------------------------------------------------------------------------------------\n");
        int lt = analogRead(ldrlt); // top left
        int rt = analogRead(ldrrt); // top right
        int ld = analogRead(ldrld); // down left
        int rd = analogRead(ldrrd); // down rigt
    /*
        Serial.print("LT=>");
        Serial.println(lt);
        
        Serial.print("RT=>");
        Serial.println(rt);
        
        Serial.print("LD=>");
        Serial.println(ld);
        
        Serial.print("RD=>");
        Serial.println(rd);
        */
        // int dtime = analogRead(4)/20; // read potentiometers  
        // int tol = analogRead(5)/4;
        int dtime = 10;
        int tol = 3; // tolerans
    
        int avt = (lt + rt) / 2; // average value top
        int avd = (ld + rd) / 2; // average value down
        int avl = (lt + ld) / 2; // average value left
        int avr = (rt + rd) / 2; // average value right
        
        int dvert = avt - avd; // check the diffirence of up and down
        int dhoriz = avr - avl;// check the diffirence of left and rigt
    
      /*   
        Serial.print("---------------------------------------------------------\n");
        Serial.print("DVERT=>");
        Serial.println(dvert);
        Serial.print("DHORIZ=>");
        Serial.println(dhoriz);
        */
        
        if(((-tol)>dhoriz) || (dhoriz>tol)){
          //  Serial.println("Vertical");
            if(dhoriz>0){
               
                sethor += 3; 
                if(sethor>180){
                    sethor=180;           
                }
                           
            }else{
               sethor-=3;
               if(sethor<0){
                 sethor = 0;
               }
            }     
            hor.write(sethor);    
        }
         if(((-tol)>dvert) || (dvert>tol)){
            //Serial.println("Vertical");
            if(dvert>0){
               
                setver += 3; 
                if(setver>80){
                    setver=80;           
                }          
                           
            }else{
               setver-=3;
               if(setver<20){
                setver = 20;
               }
            }     
            ver.write(setver);    
        }
        delay(100);
    }
    if(flag_open && !flag_auto){
        
        String direct  =  strtok(&str[0], ",");
        String strangle =strtok(NULL, ",");
        if(direct == "UP")
        {
            setver = setver + atoi(&strangle[0]);
            ver.write(setver);
        }
        if(direct == "DOWN"){
            setver = setver - atoi(&strangle[0]);
            ver.write(setver);
        }
        if(direct == "RIGHT"){
            sethor = sethor + atoi(&strangle[0]);
            hor.write(sethor);
        }
        if(direct == "LEFT"){
            sethor -= atoi(&strangle[0]);
            hor.write(sethor);
        }     
    }
   
    str= "";
}


void niceCallback(){

    //voltaj ölçümü
    int p1v = analogRead(p1volt); // read the value from the sensor 
    float p1vlt = ((p1v / mapvalue) * referenceVolts)*2; // calculate the ratio
    String strvolt = ""; 
    strvolt = p1vlt;
    
    //amper ölçümü
    int p1a = analogRead(p1amper);
    float p1ampr  = (p1a / mapvalue) * referenceVolts;
    float  p1amperRes = (p1vlt-p1ampr)/resistance;
    String stramper = "";
    stramper = p1amperRes;
    
    String strsend = strvolt + "|"+stramper;
    String direct = "";

     String strhor = "";
    strhor = sethor;

    String strver = "";
    strver = setver;

    strhor = "|"+ strhor +"|";

    if(sethor>90){
        direct = "East ";
        strver = setver;
       // direct += setver;
        
    }else{
        direct = "West ";
        strver = setver;
        //direct += setver;
        
    }
   
    strsend += "|"+ direct;

    //panel 1'in dead olup olmadığını ölçüyoruz.
    int p2v = analogRead(p2volt);    
    float p2vlt =  p2vlt=(p2v / mapvalue) * referenceVolts;
    String strp2 = "";
    strp2 = p2vlt;
    strsend += "|"+strp2;

    strsend += strhor;

    strsend += strver;

   // Serial.print("\nPanel1: "); Serial.print(strp2); Serial.print("  Voltaj "); Serial.println(p2v);
    
    int bytesSent = Serial.write(&strsend[0]);
  

    
}


