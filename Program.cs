using System;
using System.Collections.Generic;
namespace POOL{
    class Program{
        static void Main(string[] args){
            Console.Clear();
            Console.WriteLine("Olá, seja bem-vindo ao sistema de vendas Edu&Ste");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            MenuPrincipal();   
        }
        public static void MenuPrincipal(){
            Console.Clear();
            Console.WriteLine("Bem-vindo ao menu principal. ");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
            Console.WriteLine("* Digite 1 para cadastrar funcionário; ");
            Console.WriteLine("* Digite 2 para cadastrar cliente; ");
            Console.WriteLine("* Digite 3 para cadastrar produto; ");
            Console.WriteLine("* Digite 4 para criar venda; ");
            Console.WriteLine("* Digite 5 para gerenciar funcionários;");
            int opcao;
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    CadFuncionario();
                break;

                case 2:
                    CadCliente();
                break;

                case 3:
                    CadProduto();
                break;

                case 4:
                    CadVenda();
                break;

                case 5:
                    GeFunc();
                break;

                default:

                break;
            }
        }
        
        public static void CadFuncionario(){

        }
        public static void CadCliente(){}
        public static void CadProduto(){}
        public static void CadVenda(){}
        public static void GeFunc(){}
    }
}
