namespace POO{
    public class Vendedor:Func{
        
        public void dadosVen(){
            dados();
            Console.WriteLine("Qual o salário do vendedor?");
            salario = int.Parse(Console.ReadLine());
        }
    }
}
