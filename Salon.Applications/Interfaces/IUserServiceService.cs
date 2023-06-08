using Salon.Applications.Enums;


namespace Salon.Applications.Interfaces;

public interface IUserServiceService
{
    Task<BaseResponse<UserResponse>> Login(UserRequest request);

    Task<BaseResponse> Register(RegisterRequest request);

    Task<BaseResponse<TokenResponse>> ActivateAccount(ActivateAccountRequest request);
}