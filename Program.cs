using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using DesafioTarget.Desafio03;
using Newtonsoft.Json;

namespace DesafioTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desafio 01 - Achando o valor final de Soma
            int indice = 13;
            int Soma = 0;
            int K = 0;

            //iniciando o loop para descobrir o valor de SOMA
            while (K < indice)
            {
                //Aumentando o valor de K para cada processo e repetir o loop
                K++;
                Soma = Soma + K;
            }
            //Valor final de Soma deve ser 91
            Console.WriteLine(Soma);

            //Desfio 02 - Sequência de Fibonacci a partir de qualquer número
            Console.Write("A partir de qual número será iniciada a contagem? ");
            int numero = int.Parse(Console.ReadLine());

            //Método para verificar qual número a sequência será iniciada
            Console.Write("A partir de qual número iremos realizar a sequência: ");
            int inicio = int.Parse(Console.ReadLine());
            int espiral = a + 1;

            //metodo de loop utilizando o for 
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine("{0}", inicio);

                int temporario = inicio;
                inicio = espiral;
                espiral = temporario + espiral;
            }

            //Desafio 03 - Calcular Faturamento a partir de dias marcados

            //Importante - Utilizado a biblioteca Newtonsoft Json para poder ler e extrair dados a partir do Json

            int dia = 0;
            int faturamentoDiario = 0;
            //Criação de uma string na qual pode ler o arquivo.json por completo
            string json = System.IO.File.ReadAllText("C:\\Users\\leona\\Downloads\\Dados.json");

            //Extração dos dados colocados no Json a partir de variáveis criadas no arquivo Faturamento.Cs na pasta Desafio03
            var deserialized = JsonConvert.DeserializeObject<List<Faturamento>>(json);
            double lowest = deserialized.Min(x => x.FaturamentoDiario);
            double highest = deserialized.Max(x => x.FaturamentoDiario);

            double soma = 0, media = 0;

            foreach (var dados in deserialized)
            {
                soma += dados.Valor;
                media = soma / 30;
            }

            Console.WriteLine("O menor faturamento possível foi: " + lowest);
            Console.WriteLine("O maior fautramento possível foi: " + highest);

            foreach (Faturamento fat in deserialized)
            {
                if(fat.Valor > media)
                {
                    Console.Write("Os dias de faturamento maiores que a média foram: {0}, \n", fat.Dia);
                }
            }

            //Exercicio05 - Inverter uma String

            string nova = Console.ReadLine();

            //Abrindo o stringBuilder
            StringBuilder sb = new StringBuilder();

            //Iterando a string do ultimo ao primeiro indice
            for(var i = nova.Length-1; i >= 0; i--)
            {
                sb.Append(nova[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
