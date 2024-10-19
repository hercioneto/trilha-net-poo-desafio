using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"123456", modelo:"Nokia",imei:"11111111",memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");


Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"67890", modelo:"Iphone 13",imei:"2222222",memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("Smartphone Samsung");
Smartphone samsung = new Iphone(numero:"67890", modelo:"Iphone 13",imei:"2222222",memoria:128);
samsung.Numero="74357834";
samsung.Ligar();
samsung.ReceberLigacao();
samsung.InstalarAplicativo("Telegram");