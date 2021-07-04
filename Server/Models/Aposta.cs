using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class Aposta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Chave { get; set; }
        [Required]
        public string DataRegisto { get; set; }
        public bool Arquivada { get; set; } = false;
        public int UtilizadorID { get; set; }
        public Utilizador Utilizador { get; set; }
    }
}
