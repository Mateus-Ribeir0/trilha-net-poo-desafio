using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nokia:");
        Smartphone nokia = new Nokia(numero: "1111111", modelo: "Nokia", imei: "111111111", memoria: 128);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Xp investimentos");

        Console.WriteLine("\niPhone:");
        Smartphone iphone = new Iphone(numero: "1111111", modelo: "iPhone 15", imei: "11111111", memoria: 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Xp investimentos");
    }
}
