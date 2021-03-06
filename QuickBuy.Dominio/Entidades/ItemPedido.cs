﻿namespace QuickBuy.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int ItemPedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int  Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Crítica não foi indentificado referência do produto");
            if (Quantidade == 0)
                AdicionarCritica("Crítica quantidade do produto não foi informada");            
        }
    }
}
