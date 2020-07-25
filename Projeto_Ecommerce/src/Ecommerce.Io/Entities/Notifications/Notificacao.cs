using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Notifications
{
   public class Notificacao
    {
        public Notificacao()
        {
            Notificacoes = new List<Notificacao>();
        }
        [NotMapped]
        private string NomePropriedade { get; set; }
        
        [NotMapped]
        private string Mensagem { get; set; }

        [NotMapped]
        public List<Notificacao> Notificacoes { get; set; }


        /// <summary>
        /// valida se a propriedade string é vazia
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="nomePropriedade"></param>
        /// <returns></returns>
        public bool ValidaPropriedadeString(string valor, string nomePropriedade)
        {
            if(string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notificacao
                {
                    Mensagem = "Campo Obrigátorio",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
             
            return true;
        }

        public bool ValidaPropriedadeInt(int valor, string nomePropriedade)
        {
            if(valor < 1 || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                Notificacoes.Add(new Notificacao
                {
                    Mensagem = "O Valor informado deve ser maior que 0.",
                    NomePropriedade = nomePropriedade

                });
                return false;
            }
            return true;
        }
        public bool ValidarPropriedadeDecimal(decimal valor, string nomePropriedade)
        {
            if(valor < 1 || string.IsNullOrWhiteSpace(NomePropriedade))
            {
                Notificacoes.Add(new Notificacao
                {
                    Mensagem = "O valor informado deve ser maior que 0.0",
                    NomePropriedade = nomePropriedade
                });
                return false;
            }
            return true;
        }
    }
}
