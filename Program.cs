using DesafioPOO.Models;


// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "11994455661", modelo: "nokia", imei: "8888888888", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");


Smartphone iphone = new Iphone(numero: "159955778811", modelo: "Iphone", imei: "31313131313", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
