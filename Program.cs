using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("(99)999999999","Modelo Nokia","999999999999",64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone("(77)977777777","Modelo iPhone","777777777777",256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Youtube");