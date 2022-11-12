using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorCRUD.Models
{
    public class Produto
    {
        [Key]
        public int Id {get; set;}
        [Required]
        [Display(Name ="Nome do Produto")]
        public string Nome {get; set;}
        [Display(Name ="Descrição")]
        public string Descricao {get; set;}
        [Display(Name ="Quantidade em estoque")]
        public int Estoque {get; set;}

        public int Preco {get; set;}
        [Display(Name ="Data do cadastro")]
        public DateTime DataCadastro {get; set;}
    }
}