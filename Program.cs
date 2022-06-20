using System;
using System.IO;

namespace SISTEMAGERADORDEARQUIVO{

    class Program
    {
        static void Main(string[] args){
            string nome;
            string idade;
            string opcao;
            
            Console.Clear();

            Console.WriteLine($"Digite seu primeiro nome");
            nome = Console.ReadLine();

            Console.WriteLine($"Digite sua idade");
            idade = Console.ReadLine();

            using(StreamWriter sw = new StreamWriter($"pessoa/{nome}.txt")){
                sw.Write($"{nome}, {idade}");
            }
            Console.WriteLine($"cadastro realizado com sucesso!");
            Thread.Sleep(1000);

            Console.WriteLine($"Deseja ler o arquivo? 1 para sim ou 2 para não");
            opcao = Console.ReadLine();

            if(opcao == "1"){
                using(var reader = new StreamReader($"pessoa\\{nome}.txt"))
                {
                    Console.WriteLine(reader.ReadLine());
                    
                }
            }
        }
    }

}