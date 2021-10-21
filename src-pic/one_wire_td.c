#ifndef ONE_WIRE_C
#define ONE_WIRE_C
#define ONE_WIRE_PIN PIN_E2


void onewire_reset() 
{
    output_low(ONE_WIRE_PIN);       // keo chan onewire xuong muc thap cho nhan du lieu
    delay_us(500); //cho 500us
    output_float(ONE_WIRE_PIN);     
    delay_us(500);                   
    output_float(ONE_WIRE_PIN);
}

void onewire_write(int8 data) {
    int8 count;

    for(count = 0; count < 8; ++count) {
        output_low(ONE_WIRE_PIN);
        delay_us(2);                
        output_bit(ONE_WIRE_PIN, shift_right(&data, 1, 0)); 
        delay_us(60);               
        output_float(ONE_WIRE_PIN); 
        delay_us(2);                
    }
}


int onewire_read() {
    int count, data;

    for(count = 0; count < 8; ++count) {
        output_low(ONE_WIRE_PIN);//keo chan onewire xuong muc thap de doc du lieu o khe thoi gian
        delay_us(2);                // cho 2us
        output_float(ONE_WIRE_PIN);  
        delay_us(8);                
        shift_right(&data, 1, input(ONE_WIRE_PIN)); // xuat ket qua 
        delay_us(120);              // cho den khi doc xong
    }
    return data;
} 

#endif 
