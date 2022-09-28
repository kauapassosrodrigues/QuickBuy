namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : entidade 
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
