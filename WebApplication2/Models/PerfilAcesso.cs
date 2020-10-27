using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class PerfilAcesso
    {
        [Key]
        public int IdPerfilAcesso { get; set; }
        public string Descricao { get; set; }
    }
}