using AutoMapper;
using BooksWebApi.Dtos;
using BooksWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWebApi.Utilities
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            //Metodo constructor para inicializar CreateMap de autor
            //Recibe de donde hacia donde va a ser el mapeo en este caso los datos serán del dto hacia el modelo
            CreateMap<AutorDto, Autor>();
        }
    }
}
