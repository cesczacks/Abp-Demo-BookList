using Abp.Domain.Entities.Auditing;

namespace Yoyosoft.BookList.BookListManagement.Books
{
	/// <summary>
	/// Book
	/// </summary>
	public class Book : CreationAuditedEntity<long>
	{
		public string Name { get; set; }

		public string Author { get; set; }

		public string Intro { get; set; }

		public string ImgStrUrl { get; set; }
	}
}
