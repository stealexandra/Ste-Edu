namespace POOL{
    public class produto{
        public string marca, descricao, codigo, valor;

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
        public string GetValor(){
            return valor;
        }
        public void SetValor(string valor){
            this.valor = valor;
        }
    }
}
