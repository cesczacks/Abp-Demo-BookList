using Abp.Application.Services.Dto;

namespace Yoyosoft.BookList.BookListManagement.Books.Dtos
{
	public class BookListDto : EntityDto<long>
	{
		public string Name { get; set; }

		public string Author { get; set; }

		public string Intro { get; set; }

		public string ImgStrUrl { get; set; }
	}
}
