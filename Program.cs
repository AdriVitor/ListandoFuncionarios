using System;
using System.Collections.Generic;

namespace ListaFuncionarios
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            Preenchendo();   
        }
        public static List<Funcionario> funcionarios = new();
        public static void Preenchendo(){
            
            Console.Clear();

            Console.WriteLine("Olá");
            Console.WriteLine("");
            Console.WriteLine("Digite o nome do funcionário: ");
            string Nome = Console.ReadLine();
            //funcionarios.Add(new Funcionario(){nome = Nome});

            Console.WriteLine("Digite a idade do funcionário: ");
            int Idade = int.Parse(Console.ReadLine());
            //funcionarios.Add(new Funcionario(){idade = Idade});

            Console.WriteLine("Digite o setor do funcionário: ");
            string Setor = Console.ReadLine();
            //funcionarios.Add(new Funcionario(){setor = Setor});

            Console.WriteLine("Digite o cargo do funcionário: ");
            string Cargo = Console.ReadLine();
            //funcionarios.Add(new Funcionario(){cargo = Cargo});

            funcionarios.Add(new Funcionario(){nome = Nome,
            idade = Idade,
            setor = Setor,
            cargo = Cargo});

            Console.WriteLine("");
            Escolha();
        }
        
        static void Escolha(){

            Console.WriteLine("Deseja cadastrar outro funcionário?");
            Console.WriteLine("1 - SIM  |   0 - NÃO");
            int escolha = int.Parse(Console.ReadLine());
            Console.Clear();

            switch(escolha){
                case 1: Preenchendo(); break;
                case 0: Listando(); break;
                default: Saindo(); break;
            }
            
        }

        static void Listando(){
            Console.WriteLine("Lista de Funcionários");
            Console.WriteLine("");

            foreach(Funcionario i in funcionarios){
                Console.WriteLine($"Nome: {i.nome}");
                Console.WriteLine($"Idade: {i.idade}");
                Console.WriteLine($"Setor: {i.setor}");
                Console.WriteLine($"Cargo: {i.cargo}");
                Console.WriteLine("");
            }

            Console.WriteLine("Deseja sair do programa ou voltar para o Menu?");
            Console.WriteLine("1 - Menu  |   0 - Sair");
            int escolha2 = int.Parse(Console.ReadLine());

            switch(escolha2){
                case 1: Preenchendo(); break;
                case 0: Environment.Exit(0); break;
                default: Saindo(); break;
            }
        }

        static void Saindo(){
            Console.Clear();
            Console.WriteLine("Essa opção não existe");
            Thread.Sleep(2);
            Console.WriteLine("Saindo do programa...");
            Thread.Sleep(2);
            Console.ReadKey();
        }

        }

        
    }

