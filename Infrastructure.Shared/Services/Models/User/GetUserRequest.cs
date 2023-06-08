using Infrastructure.Shared.Services.Pagination;


namespace Infrastructure.Shared.Services.Models.User;

public class GetUserRequest : IPaginationRequest
{
    public long? Id { get; set; } = null;

    public Page Page { get; set; } = new Page();
}
