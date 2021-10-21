#include <16F887.h>
#device ADC=10

#FUSES NOWDT                    //No Watch Dog Timer
#FUSES NOBROWNOUT               //No brownout reset
#FUSES NOLVP                    //No low voltage prgming, B3(PIC16) or B5(PIC18) used for I/O

#use delay(crystal=20000000)
//#use rs232(uart1, baud=9600)
#use rs232(baud=9600,parity=N,xmit=PIN_D0,rcv=PIN_D1,bits=8)
#include <lcd.h>
#include <DS18B20.c>

