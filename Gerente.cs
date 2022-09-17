namespace POO{
    public class Gerente:Func{

        public void dadosGer(){
            dados();
            Console.WriteLine("Qual o salário do Gerente?");
            salario = int.Parse(Console.ReadLine());
        }
    }
}
