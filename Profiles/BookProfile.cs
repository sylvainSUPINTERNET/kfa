using AutoMapper;
using Dto;
using Models;

namespace Profiles
{
    public class BookProfile: Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookDto>();
        }
        
    }
}