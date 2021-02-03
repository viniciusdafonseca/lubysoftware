namespace maquinabebidas
{
   public class Bebida
    {
    
        public int bebidaID { get; set;} 

        public string nome { get; set; } = string.Empty;
        public double custo { get; set; }
        public int qtd { get; set; }

        public Bebida(int id, string nome,double custo, int qtd)
        {
           this.bebidaID = id;
           this.nome = nome;
           this.custo = custo;
           this.qtd = qtd;
        }
    }
}