namespace POO{
    public abstract class Func:pessoa{
        
        public double salario;

        public double GetSalario(){
            return salario;
        }
        public void SetSalario(double salario){
            this.salario = salario;
        }
        public double aumentosalvend(Vendedor vendedor){
            Console.WriteLine("Salário atual do " + vendedor.GetNome() + ": " + vendedor.GetSalario());
            Console.WriteLine("Qual deve ser o valor do aumento");
            double aumento = Convert.ToDouble(Console.ReadLine());
            double salarionovo = vendedor.GetSalario() + aumento;
            return salarionovo;
        }
        public double diminuisalvend(Vendedor vendedor){
            Console.WriteLine("Salário atual do " + vendedor.GetNome() + ": " + vendedor.GetSalario());
            Console.WriteLine("Qual deve ser o valor do desconto?");
            double diminui = Convert.ToDouble(Console.ReadLine());
            double salariomenor = vendedor.GetSalario() - diminui;
            return salariomenor;
        }
        public double aumentosalGer(Gerente gerente){
            Console.WriteLine("Salário atual do " + gerente.GetNome() + ": " + gerente.GetSalario());
            Console.WriteLine("Qual deve ser o valor do aumento");
            double aumento = Convert.ToDouble(Console.ReadLine());
            double salarionovo = gerente.GetSalario() + aumento;
            return salarionovo;
        }
        public double diminuisalger(Gerente gerente){
            Console.WriteLine("Salário atual do " + gerente.GetNome() + ": " + gerente.GetSalario());
            Console.WriteLine("Qual deve ser o valor do desconto?");
            double diminui = Convert.ToDouble(Console.ReadLine());
            double salariomenor = gerente.GetSalario() - diminui;
            return salariomenor;
        }
    }
}
