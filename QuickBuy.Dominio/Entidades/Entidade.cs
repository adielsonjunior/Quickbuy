using System.IO;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {

        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

    }
}
