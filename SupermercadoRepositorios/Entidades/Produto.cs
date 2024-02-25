namespace SupermercadoRepositorios.Entidades
{
    public class Produto : EntidadeBase
    {
        public string Nome { get; set; }
        public decimal PrecoUnitario { get; set; }
        public Categoria Categoria { get; set; }
    }
}
