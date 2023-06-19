using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCrudAppRazor.Contexto;
using MyCrudAppRazor.Models;

namespace MyCrudAppRazor.Pages.Produtos
{
    public class CriarModel : PageModel
    {
        private readonly ProdutoDbContext _dbContext;

        public CriarModel(ProdutoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Models.Produtos Produto { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _dbContext.Produtos.Add(Produto);
            _dbContext.SaveChanges();

            return RedirectToPage("Produtos");
        }
    }
}
