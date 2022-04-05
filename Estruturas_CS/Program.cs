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
            //carro.Modelo = "ABC";
            //carro.Cor = "Preto";
            //carro.Placa = "ABC1253";
            Carro carro2 = new Carro("Ford", "ka", "Azul", "EIG1234");
            //Console.WriteLine($"Marca: {carro2.Marca}");
            carro2.ExibirDados();

            // Array -> Matrizes

            // List - Listas-------------------------------------------------------------------------------------------------------
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

            // Queue -> Filas-------------------------------------------------------------------------------------------------------
            Queue<string> fila = new Queue<string>();
            fila.Enqueue("A");
            fila.Enqueue("B");
            fila.Enqueue("C");

            Console.WriteLine($"Numeros de pessoas na fila: {fila.Count}"); // Numero de pessoas na fila
            Console.WriteLine($"Proximo da fila: {fila.Peek()}"); // Proxima pessoa da fila
            Console.WriteLine($"Numeros de pessoas na fila: {fila.Count}"); // Numero de pessoas na fila
            Console.WriteLine($"Proximo da fila: {fila.Dequeue()}"); // Chama o proximo 
            Console.WriteLine($"Numeros de pessoas na fila: {fila.Count}"); // Numero de pessoas na fila
            Console.WriteLine($"Proximo da fila: {fila.Peek()}"); // Proxima pessoa da fila
            fila.Enqueue("D");
            Console.WriteLine($"Cliente acabou de ingressar: {fila.Count}"); // Proxima pessoa da fila
            Console.WriteLine($"Proximo da fila: {fila.Peek()}"); // Proxima pessoa da fila

            // Stack -> Pilhas-------------------------------------------------------------------------------------------------------
            Stack<int> pilha = new Stack<int>();
            pilha.Push(12); // Adiciona elemento na fila
            pilha.Push(13);
            pilha.Push(14);
            pilha.Push(15);
            //foreach (int item in pilha)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine($"Removemos elemento: {pilha.Pop()}"); // Remove primeiro elemento da pilha
            Console.WriteLine($"Proximo elemento: {pilha.Peek()}");



            Console.ReadKey();
        }
    }
}
