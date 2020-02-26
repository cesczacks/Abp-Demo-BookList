using Abp.Application.Services.Dto;

namespace Yoyosoft.BookList.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

