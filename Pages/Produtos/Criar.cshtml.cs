using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorCRUD.Data;
using RazorCRUD.Models;

namespace RazorCRUD.Pages.Produtos
{
    public class Criar : PageModel
    {
        private readonly Contexto _db;

        public Criar(Contexto contexto)
        {
            _db = contexto;
        }
        [BindProperty]
        public Produto Producto { get; set; }

[TempData]
public string Mensagem {get; set;}

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Producto.DataCadastro = DateTime.Now;
            _db.Add(Producto);
            await _db.SaveChangesAsync();
            Mensagem = "Produto criado com sucesso";
            return RedirectToPage("Index");

        }
    }
}