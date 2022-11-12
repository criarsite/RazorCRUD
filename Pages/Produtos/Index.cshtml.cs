using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RazorCRUD.Data;
using RazorCRUD.Models;

namespace RazorCRUD.Pages.Produtos
{
    public class Index : PageModel
    {
        private readonly Contexto _db;

        public Index(Contexto contexto)
        {
            _db = contexto;
        }

    public IEnumerable<Produto> Productos {get; set;}

        public async Task OnGet()
        {
        Productos = await _db.Produtos.ToListAsync();

        }
    }
}