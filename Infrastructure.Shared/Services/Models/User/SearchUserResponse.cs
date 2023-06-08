using Infrastructure.Shared.Services.Pagination;

namespace Infrastructure.Shared.Services.Models.User;

public class SearchUserResponse : IPaginationResponse<UserShortModel>
{
    public Page Page { get; set; } = new Page();

    public long Count { get; set; }

    public IReadOnlyCollection<UserShortModel> Items { get; set; }
}

