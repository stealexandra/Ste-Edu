using System;
using System.Collections.Generic;
namespace POO{
    class Program{

        static List<cliente> listaClientes = new List<cliente>();
        static List<Vendedor> listaVendedor = new List<Vendedor>();
        static List<Produto> listaProdutos = new List<Produto>();
        static List<Gerente> listaGerente = new List<Gerente>();
        static List<Venda> listaVendas = new List<Venda>();
        static bool loop = true;

        static void Main(string[] args){
            //Início
            Console.Clear();
            Console.WriteLine(" ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ");
            Console.WriteLine("|    Olá, seja bem-vindo ao sistema de vendas Edu&Ste  |");
            Console.WriteLine("|    Pressione qualquer tecla para continuar...        |");
            Console.WriteLine(" ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ~ ");
            Console.ReadKey();
            MenuPrincipal();   
        }
        public static void MenuPrincipal(){
            //Menu Principal
            int opcao;
            do{
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
                opcao = int.Parse(Console.ReadLine());
                //Escolha de ação
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
                        Console.WriteLine("Sistema finalizado!");
                    break;
                    default:
                    break;
                }
            }while(opcao != 6);
        }
        
        public static void CadFuncionario(){

            //Cadastro de Funcionário
            Console.WriteLine("Seu funcionário é um gerente ou vendedor?");
            Console.WriteLine("Digite 1 para vendedor \nDigite 2 para gerente");
            int opcao;
            opcao = int.Parse(Console.ReadLine());
            switch(opcao){
                case 1:
                Vendedor vend = new Vendedor();
                    vend.dadosVen();
                    listaVendedor.Add(vend);
                    Console.WriteLine("Cadastro concluído! \n ~ Pressione qualquer botão para continuar...");
                    Console.ReadKey();
                    break;
                    case 2:
                    Gerente Ger = new Gerente();
                    Ger.dadosGer();
                    listaGerente.Add(Ger);
                    Console.WriteLine("Cadastro concluído! \n ~ Pressione qualquer botão para continuar...");
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
            double novovalor = 0;

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
                    novovalor = produto.GetValor();

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
            Console.WriteLine("Quantas unidades você quer comprar?");
            venda.SetUnidade(int.Parse(Console.ReadLine()));

            if(verclient == true && verproduto == true && vervendedor == true){
                listaVendas.Add(venda);
                Console.WriteLine("A venda do produto de código " + nomeproduto + " e preço de R$" + (novovalor * venda.GetUnidade()) + " foi um sucesso!");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } else {
                Console.WriteLine("Erro!!!");
                Console.WriteLine("Digite qualquer tecla para voltar...");
                Console.ReadKey();
            }
            

            }
        static void GeFunc(){
            int a = 0;
            int escolha;
            int escolha2;

            //Aumentar ou reduzir salário
                Console.WriteLine("O que você deseja fazer?");
                Console.WriteLine("1 - Aumentar salário \n2 - Reduzir salário");
                escolha = int.Parse(Console.ReadLine());

                //Aumentar salário
                if(escolha == 1){

                    //Vendedor ou Gerente
                    Console.WriteLine("O funcionário é um vendedor ou gerente?");
                    Console.WriteLine("1 - Vendedor \n2- Gerente");
                    escolha2 = int.Parse(Console.ReadLine());

                    //Se Vendedor
                    if(escolha2 == 1){
                        foreach (Vendedor vendedor in listaVendedor){
                        Console.WriteLine(vendedor.GetNome() + " - " + vendedor.GetCpf() + "\n");
                        }
                    Console.WriteLine("Qual o funcionário que você deseja aumentar o salário?");
                    string nomeprocurado = Console.ReadLine();

                    foreach (Vendedor vendedor in listaVendedor){
                        if(vendedor.GetNome() == nomeprocurado){
                        vendedor.SetSalario(vendedor.aumentosalvend(vendedor));
                        Console.WriteLine("Salário atualizado com sucesso! \n Novo salário: " + vendedor.GetSalario());
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        }
                    }

                    //Se Gerente
                    } else if(escolha2 == 2){
                        foreach (Gerente gerente in listaGerente){
                            Console.WriteLine(gerente.GetNome() + " - " + gerente.GetCpf() + "\n");
                        }
                        Console.WriteLine("Qual o gerente que você deseja aumentar o salário?");
                        string nomeprocurado = Console.ReadLine();

                        foreach (Gerente gerente in listaGerente){
                            if(gerente.GetNome() == nomeprocurado);
                            gerente.SetSalario(gerente.aumentosalGer(gerente));
                            Console.WriteLine("Salário atualizado com sucesso! \n Novo salário: " + gerente.GetSalario());
                            Console.WriteLine("Pressione qualquer tecla para continuar...");
                            Console.ReadKey();
                            }
                        }

                    //Se diminuir salário
                    } else if(escolha == 2){
                        //Vendedor ou gerente?
                        Console.WriteLine("O funcionário é um vendedor ou gerente?");
                        Console.WriteLine("1 - Vendedor \n2- Gerente");
                        escolha2 = int.Parse(Console.ReadLine());

                        //Vendedor
                        if(escolha2 == 1){
                            foreach (Vendedor vendedor in listaVendedor){
                                Console.WriteLine(vendedor.GetNome() + " - " + vendedor.GetCpf() + "\n");
                                }

                            Console.WriteLine("Qual o funcionário que você deseja diminuir o salário?");
                            string nomeprocurado = Console.ReadLine();

                            foreach (Vendedor vendedor in listaVendedor){
                                if(vendedor.GetNome() == nomeprocurado){
                                    vendedor.SetSalario(vendedor.diminuisalvend(vendedor));
                                    Console.WriteLine("Salário atualizado com sucesso! \n Novo salário: " + vendedor.GetSalario());
                                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                                    Console.ReadKey();
                                }
                            }
                        //Gerente
                        } else if(escolha2 == 2){
                            foreach (Gerente gerente in listaGerente){
                                Console.WriteLine(gerente.GetNome() + " - " + gerente.GetCpf() + "\n");
                                }

                            Console.WriteLine("Qual o gerente que você deseja diminuir o salário?");
                            string nomeprocurado = Console.ReadLine();

                            foreach (Gerente gerente in listaGerente){
                                if(gerente.GetNome() == nomeprocurado){
                                    gerente.SetSalario(gerente.diminuisalger(gerente));
                                    Console.WriteLine("Salário atualizado com sucesso! \n Novo salário: " + gerente.GetSalario());
                                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                                    Console.ReadKey();
                                }
                            }
                                
                        }
                        }
                    
        //Fim do GeFunc
        }
            
        public static void fim(){}    
    }
}
