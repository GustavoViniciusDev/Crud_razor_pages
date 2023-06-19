using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MyCrudAppRazor.Models
{
    public class Produtos
    {
        
        public int Id { get; set; }


        [Required(ErrorMessage ="O nome do produto é obrigatório")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage ="A descrição do produto é obrigatório.")]
        public string Descricao { get; set; }

        [Range(0.01 , double.MaxValue, ErrorMessage ="O preço do produto deve ser maior que zero")]
        public decimal Preco { get; set; }
    }
}
