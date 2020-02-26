using AutoMapper;
using Yoyosoft.BookList.BookListManagement.Books.Dtos;

namespace Yoyosoft.BookList.BookListManagement.Books.Mapper
{
	internal class BookMapper
	{
		public static void CreateMappings(IMapperConfigurationExpression configuration)
		{
			configuration.CreateMap<Book, BookListDto>();
			configuration.CreateMap<Book, BookEditDto>();
			configuration.CreateMap<BookEditDto, Book>();
		} 
	}
}
