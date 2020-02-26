
namespace Yoyosoft.BookList.BookListManagement.Books.Dtos
{
	public class BookEditDto
	{
		public long? Id { get; set; }

		public string Name { get; set; }

		public string Author { get; set; }

		public string Intro { get; set; }

		public string PriceUrl { get; set; }

		public string ImgStrUrl { get; set; }
	}
}
