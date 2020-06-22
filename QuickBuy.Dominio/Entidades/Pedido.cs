using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
   public  class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }

        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }

        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }
        public ICollection<ItemPedido> ItensPedido { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento  FormaPagamento { get; set; }

        public override void Validate()
        {
            LimparmensagensValidacao();
            if (!ItensPedido.Any())              
                AdicionarCritica("Crítica - Pedido não pode ficar sem item de pedido.");            
            
            if (string.IsNullOrEmpty(Cep))         
                AdicionarCritica("Crítica - CEP não foi preenchido");
            if (FormaPagamentoId == 0)
                AdicionarCritica("Crítica -não foi informado a forma de pagamento");
        }
    }
}
