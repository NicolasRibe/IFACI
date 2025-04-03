//Serial temperatura 
//IFACI SENAI SAO CARLOS CURSO SUPERIOR ADS 02/04/2025
//Autor Nicolas Moreira Ribeiro 

int sensor= 0;//define o pino analogico A0 como entrada do sensor 


float d = 0; // variavel para armazenar o valor lido do sensor (0-1023)
int  T = 0;// variavel para armazenar a temperatura calculada;

void setup(){
  Serial.begin(9600);// inicia a comunicação com baudrate de 9600

  pinMode(A0, INPUT);
  
  int sensor = A0;




}
void loop(){

  d= analogRead(sensor);
  T= (d * 5 *100)/1023; //conversao de sinal em temperatura 
  Serial.print(T);// envia o valor da temperatura para a serial
  delay(1000);// coloca um delay para processamento
 

}


int main(void){

  init(); // inicializa hardware (funçao interna do arduino)
  setup();// chama a funçãao setup 

  for (;;)//loop infinito 
    loop();//CHAMA O LOOP 

}