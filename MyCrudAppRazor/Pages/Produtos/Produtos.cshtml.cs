using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCrudAppRazor.Contexto;
using MyCrudAppRazor.Models;

namespace MyCrudAppRazor.Pages.Produtos
{
    public class ProdutosModel : PageModel
    {
        private readonly ProdutoDbContext _dbContext;

        public ProdutosModel(ProdutoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Models.Produtos> Produtos { get; set; }
        public void OnGet()
        {
            Produtos = _dbContext.Produtos.ToList();
        }
    }
}
