using Abp.Domain.Entities.Auditing;

namespace Yoyosoft.BookList.BookListManagement.BookTags
{
	public class BookTag : CreationAuditedEntity<long>
	{
		public string TagName { get; set; }
	}
}
