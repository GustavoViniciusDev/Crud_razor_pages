using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyCrudAppRazor.Contexto;
using MyCrudAppRazor.Models;

namespace MyCrudAppRazor.Pages.Produtos
{
    public class EditarModel : PageModel
    {
        private readonly ProdutoDbContext _dbContext;

        public EditarModel(ProdutoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [BindProperty]
        public Models.Produtos Produto { get; set; }

        public IActionResult OnGet(int Id)
        {
            Produto = _dbContext.Produtos.Find(Id);

            if( Produto == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost() 
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _dbContext.Entry(Produto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dbContext.SaveChanges();

            return RedirectToPage("Produtos");
        }
    }
}
