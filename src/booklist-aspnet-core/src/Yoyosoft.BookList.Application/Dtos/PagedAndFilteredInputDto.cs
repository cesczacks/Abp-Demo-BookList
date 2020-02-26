using Abp.Application.Services.Dto;

namespace Yoyosoft.BookList.Dtos
{
	public class PagedAndFilteredInputDto : PagedAndSortedResultRequestDto
	{
		public string FilterText { get; set; }
	}
}
