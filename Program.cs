using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testes com o Nokia");
Smartphone nokia = new Nokia(numero:"0000-9999", modelo: "Modelo 10", imei: "123abc", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
nokia.ReceberLigacao();

Console.WriteLine("\n");

Console.WriteLine("Testes com o Iphone");
Smartphone iphone = new Iphone(numero:"7777-5555", modelo: "Modelo 15", imei: "cab321", memoria: 100);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");
iphone.ReceberLigacao();

