using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
   public class Produto:Entidade
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdicionarCritica("Crítica - Nome do produto não foi informado");
            if (string.IsNullOrEmpty(Descricao))
                AdicionarCritica("Crítica Descricao do produto não foi informada");
            if (Preco == 0)
                AdicionarCritica("Crítica - Preco do produto não foi informada");
        }
    }
}
