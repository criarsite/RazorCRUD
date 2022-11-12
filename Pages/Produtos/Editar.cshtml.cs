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
    public class Editar : PageModel
    {
        private readonly Contexto _db;

        public Editar(Contexto contexto)
        {
            _db = contexto;
        }


        [BindProperty]
        public Produto Producto { get; set; }

        [TempData]
public string Mensagem {get; set;}

        public async Task OnGet(int id)
        {
            Producto = await _db.Produtos.FindAsync(id);
        }

 public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
              var ProdutosDb = await _db.Produtos.FindAsync(Producto.Id);
              ProdutosDb.Nome =Producto.Nome;
              ProdutosDb.Descricao =Producto.Descricao;
              ProdutosDb.Estoque =Producto.Estoque;
              ProdutosDb.Preco =Producto.Preco;

            await _db.SaveChangesAsync();
            Mensagem = "Produto editado com sucesso";
            return RedirectToPage("Index");
            }

            return RedirectToPage();

        }

       
    }
}