using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Yoyosoft.BookList.BookListManagement.Books.Dtos;

namespace Yoyosoft.BookList.BookListManagement.Books
{
	public class BookAppService : BookListAppServiceBase, IBookAppService
	{
		private readonly IRepository<Book, long> _bookRepository;

		public BookAppService(IRepository<Book, long> bookRepository) 
		{
			_bookRepository = bookRepository;
		}

		public async Task<PagedResultDto<BookListDto>> GetPagedBookAsync(GetBookInput input)
		{
			var query = _bookRepository.GetAll()
				.AsNoTracking()
				.WhereIf(!input.FilterText.IsNullOrWhiteSpace(), a => a.Name.Contains(input.FilterText));

			var count = await query.CountAsync();

			var result = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

			var resultDto = result.MapTo<List<BookListDto>>();

			return new PagedResultDto<BookListDto>
			{
				TotalCount = count,
				Items = resultDto
			};
		}

		public async Task CreateOrUpdateBookAsync(CreateOrUpdateBookInput input)
		{
			if (input.Book.Id.HasValue)
			{
				await UpdateBookAsync(input.Book);
			}
			else
			{
				await CreateBookAsync(input.Book);
			}
		}

		public async Task DeleteBookAsync(EntityDto<long> input)
		{
			await _bookRepository.DeleteAsync(input.Id);
		}

		public async Task BatchDeleteAsync(List<long> input)
		{
			await _bookRepository.DeleteAsync(a => input.Contains(a.Id));
		}

		protected virtual async Task<BookEditDto> CreateBookAsync(BookEditDto input)
		{
			var entity = input.MapTo<Book>();

			await _bookRepository.InsertAsync(entity);

			var dto = entity.MapTo<BookEditDto>();

			return dto;
		}

		protected virtual async Task UpdateBookAsync(BookEditDto input) 
		{
			var entity = await _bookRepository.GetAsync(input.Id.Value);

			input.MapTo(entity);

			await _bookRepository.UpdateAsync(entity);
		}

	}
}

