#include <main.h>
#include <DS18B20.c>

#FUSES NOWDT                    //No Watch Dog Timer
#FUSES NOBROWNOUT               //No brownout reset
#FUSES NOLVP                    //No low voltage prgming, B3(PIC16) or B5(PIC18) used for I/O


void _Delay(char time);
void main()
{
   float NhietDo;
   lcd_init();
  // lcd_putc('\f');
   lcd_gotoxy(1,1);
   printf(lcd_putc,"HTGS MOI TRUONG");
   lcd_gotoxy(1,2);
   printf(lcd_putc,"GVHD:D.THI.TU.MY");
   _Delay(50);
   lcd_putc('\f');
   NhietDo = ds18b20_read();
   while(TRUE)
   {    
      NhietDo = ds18b20_read();
      lcd_gotoxy(1,1);
      printf(lcd_putc,"T1=%3.2f",NhietDo); 
      lcd_putc(223);
      lcd_putc('C');
      printf("%3.2f",NhietDo);
      
 }
 }
void _Delay(char time)
{
   int i;
   for(i=0;i<time;i++)
   {
      delay_ms(100);//tao tre 0.1s
   }
}
