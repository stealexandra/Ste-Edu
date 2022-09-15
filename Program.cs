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
            Console.WriteLine("Bem-vindo ao menu principal! ");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
            Console.WriteLine("* Para realizar o cadastro de um funcionário, digite 1; ");
            Console.WriteLine("* Para realizar o cadastro de um cliente, digite 2; ");
            Console.WriteLine("* Para realizar o cadastro de um produto, digite 3; ");
            Console.WriteLine("* Para a criação de uma venda, digite 4; ");
            Console.WriteLine("* Para gerenciar e ver detalhes sobre o aumento de um funcionário, digite 5;");
            Console.WriteLine("* Ou, digite 6 para sair. ");
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
                case 6:
                fim();
                break;

                default:

                break;
            }
        }
        
        public static void CadFuncionario(){
        Console.WriteLine("Seu funcionário é um gerente ou vendedor?");
        Console.WriteLine("Digite 1 para vendedor \n Digite 2 para Gerente");
        int opcao;
        opcao = int.Parse(Console.ReadLine());
        switch(opcao){
            case 1:
            Vendedor vend = new Vendedor();
                vend.dadosVen();
                Console.WriteLine("Cadastro concluído! \n Pressione qualquer botão para continuar...");
                Console.ReadKey();
                break;
                case 2:
                Gerente Ger = new Gerente();
                Ger.dadosGer();
                Console.WriteLine("Cadastro concluído! \n Pressione qualquer botão para continuar...");
                Console.ReadKey();
                break;


        }
        public static void CadCliente(){
            Console.WriteLine("Iniciando seu cadastro como cliente... por favor, preencha os dados solicitados.");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Cliente Felipe = new Cliente();
                Felipe.dados();
                Console.WriteLine("Cliente cadastrado com sucesso! ");
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
                MenuPrincipal();
        }
        public static void CadProduto(){
            Console.WriteLine("Iniciando o cadastro do produto...");
            Produto prod = new Produto();
            prod.dadosprod();
            
            Console.WriteLine("Cadastrando novo produto...");
            Console.WriteLine("---------------------------");
            
            Console.Clear();
            Console.WriteLine("Produto cadastrado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            MenuPrincipal();
        }
        public static void CadVenda(){
        }
        public static void GeFunc(){}
        public static void fim(){}
    }
}
