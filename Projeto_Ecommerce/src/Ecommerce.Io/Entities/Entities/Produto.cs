using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{

    [Table("Produto")]
    public class Produto : Notificacao
    {
        [Column("PRD_ID")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("PRD_NOME")]
        public string Nome { get; set; }

        [Column("PRD_VALOR")]
        public decimal Valor { get; set; }

        [Column("PRD_ESTADO")]
        [Display(Name ="Estado")]
        public bool Estado { get; set; }
    }
}
