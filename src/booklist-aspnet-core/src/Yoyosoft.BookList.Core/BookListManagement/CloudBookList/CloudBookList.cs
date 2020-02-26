using Abp.Domain.Entities.Auditing;

namespace Yoyosoft.BookList.BookListManagement.CloudBookList
{
	public class CloudBookList: CreationAuditedEntity<long>
	{
		public string Name { get; set; }

		public string Info { get; set; }
	}
}
