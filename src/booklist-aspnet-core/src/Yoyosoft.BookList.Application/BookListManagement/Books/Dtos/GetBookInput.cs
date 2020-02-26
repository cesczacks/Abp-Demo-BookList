using Abp.Runtime.Validation;
using Yoyosoft.BookList.Dtos;

namespace Yoyosoft.BookList.BookListManagement.Books.Dtos
{
	public class GetBookInput : PagedAndFilteredInputDto, IShouldNormalize
	{
		public void Normalize()
		{
			if (string.IsNullOrWhiteSpace(Sorting)) 
			{
				Sorting = "Id";
			}
		}
	}
}
