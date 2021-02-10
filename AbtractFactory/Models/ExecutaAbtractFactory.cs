using System;
using AbtractFactory.Enumerations;

namespace AbtractFactory.Models
{
    public class ExecutaAbtractFactory
    {
        public static Carro montarCarro(TipoDeCarro tipo)
        {
            CarroFactory carroFactory = null;
            Carro carro;

            switch (tipo)
            {
                case TipoDeCarro.Luxo: carroFactory = new CarroLuxoFactory(); break;
                case TipoDeCarro.Popular: carroFactory = new CarroPopularFactory(); break;
            }

            carro = new Carro();
            carro.TipoDeRoda = carroFactory.MontarRoda();
            carro.TipoDeSom = carroFactory.MontarSom();

            return carro;
        }
    }
}
