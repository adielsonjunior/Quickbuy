using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Principal;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        public abstract void Validate();

        protected bool EhValido {
            get { return !mensagemValidacao.Any(); }
        }

        protected void AdicionarCritica(string mensagem) {
            mensagemValidacao.Add(mensagem);
        
        }

        protected void LimparmensagensValidacao() {
            mensagemValidacao.Clear();
        }


    }
}
