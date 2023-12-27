
using DesafioPOO.Models;

Console.WriteLine("Teste para o Iphone");
Iphone iphone = new Iphone("40028922", "Iphone 15 pro max", "123", 5000);
iphone.InstalarAplicativo("Apple Store");
iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine("\nTeste para o Nokia");
Nokia nokia = new Nokia("22982004", "nokia tijolão", "123", 6500);
nokia.InstalarAplicativo("Play Store");
nokia.Ligar();
nokia.ReceberLigacao();
