using System;
using AbtractFactory.Enumerations;
using AbtractFactory.Models;

namespace AbtractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = ExecutaAbtractFactory.montarCarro(TipoDeCarro.Luxo);
            Carro c2 = ExecutaAbtractFactory.montarCarro(TipoDeCarro.Popular);

            Console.ReadKey();
        }
    }
}
