namespace POO{
    public abstract class pessoa{
        protected string nome;
        protected Endereco endereco;
        protected string nascimento;
        protected string cpf;
        protected string rg;
        public pessoa(){
            this.endereco = new Endereco();
        }
        public pessoa(string nome, Endereco endereco, string nascimento, string cpf, string rg){
            this.endereco = new Endereco();
        }
        public string GetNome(){
            return nome;
        }
        public void SetNome(string nome){
            this.nome = nome;
        }
        public Endereco GetEndereco(){
            return endereco;
        }
        public void SetEndereco(Endereco endereco){
            this.endereco = endereco;
        }
        public string GetNascimento(){
            return nascimento;
        }
        public void SetNascimento(string nascimento){
            this.nascimento = nascimento;
        }
        public string GetCpf(){
            return cpf;
        }
        public void SetCpf(string cpf){
            this.cpf = cpf;
        }
        public string GetRg(){
            return rg;
        }
        public void SetRg(string rg){
            this.rg = rg;
        }
        public void dados(){
            Console.WriteLine("informe seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("informe seu cpf");
            cpf = (Console.ReadLine());
            Console.WriteLine("informe seu rg");
            rg = ( Console.ReadLine());
            Console.WriteLine("informe sua data de nascimento");
            nascimento = Console.ReadLine();
            //Endereco teste = new Endereco();
            //teste.dadosEnd();
            //endereco = teste;
            endereco.dadosEnd();
        }
    }
}
