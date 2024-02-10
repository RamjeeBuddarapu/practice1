using AutoMapper;
using BookServiceWEBAPI.DTO;
using BookServiceWEBAPI.Entities;
namespace BookServiceWEBAPI.Profiles
{
    public class BookProfile : Profile
    {
        public BookProfile() 
        {
            CreateMap<Book, BookDTO>();
            CreateMap<BookDTO, Book>();
        }
    }
}
