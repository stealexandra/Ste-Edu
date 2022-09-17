namespace POO{
    public class Endereco{
        //rua, número, bairro, cep, cidade e estado
        public string rua;
        public string numero;
        public string bairro;
        public string cep;
        public string cidade;
        public string estado;
        public string GetRua(){
            return rua;
        }
        public void SetRua(string rua){
            this.rua = rua;
        }
        public string GetNumero(){
            return numero;
        }
        public void SetNumero(string numero){
            this.numero = numero;
        }
        public string GetBairro(){
            return bairro;
        }
        public void SetBairro(string bairro){
            this.bairro = bairro;
        }
        public string GetCep(){
            return cep;
        }
        public void SetCep(string cep){
            this.cep = cep;
        }
        public string GetCidade(){
            return cidade;
        }
        public void SetCidade(string cidade){
            this.cidade = cidade;
        }
        public string GetEstado(){
            return estado;
        }
        public void SetEstado(string estado){
            this.estado = estado;
        }
        public void dadosEnd(){
            Console.WriteLine("Digite seu endereço");
            Console.WriteLine("Rua: ");
            rua = Console.ReadLine();
            Console.WriteLine("Número: ");
            numero = Console.ReadLine();
            Console.WriteLine("Bairro: ");
            bairro = Console.ReadLine();
            Console.WriteLine("Cep: ");
            cep = Console.ReadLine();
            Console.WriteLine("Cidade: ");
            cidade = Console.ReadLine();
            Console.WriteLine("Estado: ");
            estado = Console.ReadLine();

        }
    }
}
