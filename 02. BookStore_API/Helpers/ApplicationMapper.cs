using _02._BookStore_API.Data;
using _02._BookStore_API.Models;
using AutoMapper;

namespace _02._BookStore_API.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Books, BookModel>().ReverseMap();
        }
    }
}
