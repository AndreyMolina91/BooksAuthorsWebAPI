using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWebApi.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int AutorId { get; set; }

        public Autor Autor { get; set; }


    }
}
