using Abp.Application.Services;
using Abp.Application.Services.Dto;
using System.Threading.Tasks;
using Yoyosoft.BookList.BookListManagement.Books.Dtos;
using System.Collections.Generic;

namespace Yoyosoft.BookList.BookListManagement.Books
{
	public interface IBookAppService : IApplicationService
	{
		// Pagination
		Task<PagedResultDto<BookListDto>> GetPagedBookAsync(GetBookInput input);

		// Add or Modify
		Task CreateOrUpdateBookAsync(CreateOrUpdateBookInput input);

		// Delete
		Task DeleteBookAsync(EntityDto<long> input);

		Task BatchDeleteAsync(List<long> input);
	}
}
