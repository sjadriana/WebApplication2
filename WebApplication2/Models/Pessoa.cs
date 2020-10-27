using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace WebApplication2.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public List<string> camposErro = new List<string>();
        public PerfilAcesso PerfilAcesso {get; set;}

        public virtual List<string> Validacao()
        {
            if (!Regex.IsMatch(this.Cpf, "([0 - 9]{​​​​​2}​​​​​[\\.]?[0 - 9]{​​​​​3}​​​​​[\\.]?[0 - 9]{​​​​​3}​​​​​[\\//]?[0 - 9]{​​​​​4}​​​​​[-]?[0 - 9]{​​​​​2}​​​​​)| ([0 - 9]{​​​​​3}​​​​​[\\.]?[0 - 9]{​​​​​3}​​​​​[\\.]?[0 - 9]{​​​​​3}​​​​​[-]?[0 - 9]{​​​​​2}​​​​​)"))
            {
                camposErro.Add("CPF invalido");
            }

            return camposErro;
        }
    }
}