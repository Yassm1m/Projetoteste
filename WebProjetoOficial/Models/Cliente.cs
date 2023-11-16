using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProjetoOficial.Models
{
    public class Cliente
    {
        public int CodCliente { get; set; }

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "Campo Nome de prenchimento obrigatório")]
        [StringLength(150, MinimumLength = 2)]
        public string Nome { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Preencha o campo Endereço")]
        [StringLength(500)]
        public string Endereco { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Preencha o campo Telefone")]
        [RegularExpression("([0-9]{2,3})?(\\([0-9]{2}\\))([0-9]{4,5})([0-9]{4})")]
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        [StringLength(500)]
        public string Email { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Preencha o campo CPF")]
        [RegularExpression("^\\d{3}\\.\\d{3}\\.\\d{3}-\\d{2}$")]
        public string CPF { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Preencha o campo Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public int DataNasc { get; set; }
    }
}
