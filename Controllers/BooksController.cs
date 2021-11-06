using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BooksWebApi;
using BooksWebApi.Models;

namespace BooksWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Books
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBooks(int id)
        {
            return await _context.Books.Include(x => x.Autor).FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> PostBooks(Book book)
        {
            var existAutor = await _context.Autores.AnyAsync(x => x.Id == book.AutorId);

            if(!existAutor)
            {
                return BadRequest("El autor no existe");
            }

            _context.Add(book);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
