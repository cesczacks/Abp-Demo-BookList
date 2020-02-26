using System.ComponentModel.DataAnnotations;

namespace Yoyosoft.BookList.BookListManagement.Books.Dtos
{
	public class CreateOrUpdateBookInput
	{
		[Required]
		public BookEditDto Book { get; set; }
	}
}
