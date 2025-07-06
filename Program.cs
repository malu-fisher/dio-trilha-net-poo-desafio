// TODO: Realizar os testes com as classes Nokia e Iphone

using System;
using dio_trilha_net_poo_desafio.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Teste com Nokia:");
        Smartphone nokia = new Nokia(numero: "11999999999", modelo: "3310", marca: "Nokia", imei: "123456789012345", memoria: 16);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine("\nTeste com iPhone:");
        Smartphone iphone = new Iphone(numero: "11988888888", modelo: "14 Pro", marca: "Apple", imei: "987654321098765", memoria: 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}


