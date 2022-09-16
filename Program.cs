using System;
using System.Collections.Generic;
namespace POOL{
    class Program{

        static List<cliente> listaClientes = new List<cliente>();
        static List<Vendedor> listaVendedor = new List<Vendedor>();
        static List<Produto> listaProdutos = new List<Produto>();
        static List<Gerente> listaGerente = new List<Gerente>();
        static List<Venda> listaVendas = new List<Venda>();
        static bool loop = true;

        static void Main(string[] args){

            Console.Clear();
            Console.WriteLine("Olá, seja bem-vindo ao sistema de vendas Edu&Ste");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            MenuPrincipal();   
        }
        public static void MenuPrincipal(){
            
            int opcao;
            do{
                
                Console.WriteLine("Bem-vindo ao menu principal! ");
                Console.WriteLine("----------------------------");
                Console.WriteLine("");
                Console.WriteLine("* Para realizar o cadastro de um funcionário, digite 1; ");
                Console.WriteLine("* Para realizar o cadastro de um cliente, digite 2; ");
                Console.WriteLine("* Para realizar o cadastro de um produto, digite 3; ");
                Console.WriteLine("* Para a criação de uma venda, digite 4; ");
                Console.WriteLine("* Para gerenciar e ver detalhes sobre o aumento de um funcionário, digite 5;");
                Console.WriteLine("* Ou, digite 6 para sair. ");
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
            }while(opcao != 6);
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
                listaVendedor.Add(vend);
                break;
                case 2:
                Gerente Ger = new Gerente();
                Ger.dadosGer();
                listaGerente.Add(Ger);
                Console.WriteLine("Cadastro concluído! \n Pressione qualquer botão para continuar...");
                Console.ReadKey();
                break;

        }
        }
        public static void CadCliente(){
            Console.WriteLine("Iniciando seu cadastro como cliente... por favor, preencha os dados solicitados.");
            Console.WriteLine("--------------------------------------------------------------------------------");
            cliente clie = new cliente();
                clie.dados();
                listaClientes.Add(clie);
                Console.WriteLine("Cliente cadastrado com sucesso! ");
                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
                MenuPrincipal();
        }
        public static void CadProduto(){
            Console.WriteLine("Iniciando o cadastro do produto...");
            Produto prod = new Produto();
            prod.dadosprod();
            listaProdutos.Add(prod);
            Console.WriteLine("Cadastrando novo produto...");
            Console.WriteLine("------------------------------");
            Console.Clear();
            Console.WriteLine("Produto cadastrado com sucesso!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            MenuPrincipal();
        }
        public static void CadVenda(){
            Venda venda = new Venda();
            string clienteproc;
            string codigoproc;
            string vendeproc;
            bool verclient = false;
            bool verproduto = false;
            bool vervendedor = false;
            string nomeproduto = "";

            Console.Clear();
            Console.WriteLine("Digite o nome do cliente");
            clienteproc = Console.ReadLine();
            foreach(cliente Cliente in listaClientes){
                if(Cliente.GetNome() == clienteproc){
                    cliente novocliente = Cliente;
                    venda.SetClient(novocliente);
                    verclient = true;
                }
            }
            Console.WriteLine("Digite o código do produto");
            codigoproc = Console.ReadLine();
            foreach (Produto produto in listaProdutos){
                if(produto.GetCodigo() == codigoproc){
                    Produto novoproduto = produto;
                    venda.SetProdu(novoproduto);
                    verproduto = true;
                    nomeproduto = novoproduto.GetCodigo();
                }
            }
            Console.WriteLine("Digite o nome do vendedor");
            vendeproc = Console.ReadLine();
            foreach (Vendedor vendedor in listaVendedor){
                if(vendedor.GetNome() == vendeproc){
                    Vendedor novovendedor = vendedor;
                    venda.SetVende(novovendedor);
                    vervendedor = true;
                }
            }
            if(verclient == true && verproduto == true && vervendedor == true){
                listaVendas.Add(venda);
                Console.WriteLine("A venda do produto de número " + nomeproduto + " foi um sucesso!");
            } else {
                Console.WriteLine("Erro!!!");
                Console.WriteLine("Digite qualquer tecla para voltar...");
                Console.ReadKey();
            }
            

            }
        static void GeFunc(){
            int a = 0;
            int escolha;
            foreach (Vendedor vend in listaVendedor){
                Console.WriteLine(a + ": " + vend.GetNome());
                a++;}
                Console.WriteLine("Qual funcionário você quer? (Número)");
                listaVendedor.ElementAt(int.Parse(Console.ReadLine()));
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("1 - Aumentar salário \n 2 - Reduzir salário \n 3 - Demitir");
                escolha = int.Parse(Console.ReadLine());
                MenuPrincipal();
            }
        public static void fim(){}
        
    }
}
