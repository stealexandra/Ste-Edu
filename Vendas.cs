namespace POO{
    public class Venda{
        private cliente client;

        private Vendedor vende;

        private Produto produ;
        private int unidade;

        public cliente GetClient(){
            return client;
        } 
        public void SetClient(cliente client){
            this.client = client;
        }
        public Vendedor GetVende(){
            return vende;
        }
         public void SetVende(Vendedor vende){
            this.vende = vende;
        }
        public Produto GetProdu(){
            return produ;
        }
        public void SetProdu(Produto produ){
            this.produ = produ;
        }
        public int GetUnidade(){
            return unidade;
        } 
        public void SetUnidade(int unidade){
            this.unidade = unidade;
        }
    }
}
