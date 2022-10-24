using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123", modelo: "Modelo 1", imei: "123", memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone Nokia:");
Smartphone iphone = new Iphone(numero: "321", modelo: "Modelo 2", imei: "321", memoria: 128 );
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

