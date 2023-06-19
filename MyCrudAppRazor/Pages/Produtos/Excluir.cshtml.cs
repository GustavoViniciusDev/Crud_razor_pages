using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCrudAppRazor.Contexto;
using MyCrudAppRazor.Models;

namespace MyCrudAppRazor.Pages.Produtos
{
    public class ExcluirModel : PageModel
    {
        private readonly ProdutoDbContext _dbContext;

        public ExcluirModel(ProdutoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Models.Produtos Produto { get; set; }

        public IActionResult OnGet(int id)
        {
            Produto = _dbContext.Produtos.Find(id);

            if (Produto == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            _dbContext.Produtos.Remove(Produto);
            _dbContext.SaveChanges();

            return RedirectToPage("Produtos");
        }
    }
}
