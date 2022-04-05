using System;
using System.Collections.Generic;

namespace Estruturas_CS
{
    internal class Program
    {

        // Struct
        struct Carro
        {
            public string Marca;
            public string Modelo;
            public string Cor;
            public string Placa;

            public Carro(string marca, string modelo, string cor, string placa) // construtor da Struct
            {
                Marca = marca;
                Modelo = modelo;
                Cor = cor;
                Placa = placa;
            }
            public void ExibirDados()
            {
                Console.WriteLine($"Marca.: {Marca} \nModelo: {Modelo} \nCor...: {Cor} \nPlaca.: {Placa}");
            }
        }

        static void Main(string[] args)
        {

            //Carro carro = new Carro();
            //carro.Marca = "Honda";
            //carro.Modelo = "Fit";
            //carro.Cor = "Vermelho";
            //carro.Placa = "ABC1253";
            Carro carro2 = new Carro("Ford","ka", "Azul", "EIG1234");
            //Console.WriteLine($"Marca: {carro2.Marca}");
            carro2.ExibirDados();




            // Array -> Matrizes

            // Queue -> Filas

            // Stack -> Pilhas


            // List - Listas
            List<Carro> carros = new List<Carro>();
            carros.Add(new Carro("Ford", "Ka", "Branco", "BGT7896"));
            carros.Add(new Carro("VW", "Fusca", "Azul", "ADE7985"));
            carros.Add(new Carro("Kia", "Soul", "Amarelo", "FLP4k52"));
            foreach (Carro carro in carros)
            {
                carro.ExibirDados();
                Console.WriteLine();
            }
            //List<object> list = new List<object>(); 
            //list.Add(carros);
            var teste = carros.Contains(
                new Carro("Ford", "Focus", "Branco", "BGT7896")
                ) ? "Tem sim, mano!" : "Tem não, Sangue!";
            Console.WriteLine(teste);
            Console.ReadKey();
        }
    }
}
