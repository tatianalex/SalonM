using Infrastructure.Shared.Services.Pagination;

namespace Infrastructure.Shared.Services.Models.User;


public class UserGetModel : IPaginationRequest
{    
        public string Search { get; set; } = string.Empty;

        public Page Page { get; set; } = new Page();
    
}
    
