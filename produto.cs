namespace POO{
    public class Produto{
        public string marca, descricao, codigo; 
        public double valor;

        public string GetMarca(){
            return marca;
        }
        public void SetMarca(string marca){
            this.marca = marca;
        }
        public string GetDescricao(){
            return descricao;
        }
        public void SetDescricao(string descricao){
            this.descricao = descricao;
        }
        public string GetCodigo(){
            return codigo;
        }
        public void SetCodigo(string codigo){
            this.codigo = codigo;
        }
        public double GetValor(){
            return valor;
        }
        public void SetValor(double valor){
            this.valor = valor;
        }
        public void dadosprod(){
            Console.WriteLine("Qual a marca do produto? ");
            marca = Console.ReadLine();
            Console.WriteLine("Descreva o produto: ");
            descricao = (Console.ReadLine());
            Console.WriteLine("Qual o código? ");
            codigo = ( Console.ReadLine());
            Console.WriteLine("Qual o preço do produto em reais?");
            valor = int.Parse(Console.ReadLine());
        }
    }
}
