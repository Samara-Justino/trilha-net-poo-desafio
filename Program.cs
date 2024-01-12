using DesafioPOO.Models;

// IMPLEMENTADO
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "1111", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao(); 
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "2222", memoria: 256);

iphone.Ligar();
iphone.ReceberLigacao(); 
iphone.InstalarAplicativo("Whatsapp");