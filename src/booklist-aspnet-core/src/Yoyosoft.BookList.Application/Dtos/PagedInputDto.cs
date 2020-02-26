using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace Yoyosoft.BookList.Dtos
{
	public class PagedInputDto : IPagedResultRequest
	{
		[Range(1, AppConsts.MaxPageSize)]
		public int SkipCount { get; set; }

		[Range(0, int.MaxValue)]
		public int MaxResultCount { get; set; }

		public PagedInputDto()
		{
			MaxResultCount = AppConsts.DefaultPageSize;
		}
	}
}
