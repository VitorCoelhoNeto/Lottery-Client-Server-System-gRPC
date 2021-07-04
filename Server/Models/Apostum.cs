using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Server.Models
{
    public partial class Apostum
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Chave { get; set; }
        [Required]
        [StringLength(200)]
        public string DataRegisto { get; set; }
        public bool? Arquivada { get; set; }
        public int? UtilizadorId { get; set; }

        [ForeignKey(nameof(UtilizadorId))]
        [InverseProperty("Aposta")]
        public virtual Utilizador Utilizador { get; set; }
    }
}
