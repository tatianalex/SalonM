using Salon.Application.Enums;


namespace Salon.Application.Interfaces;

public interface IUserServiceService
{
    Task<BaseResponse<UserResponse>> Login(UserRequest request);

    Task<BaseResponse> Register(RegisterRequest request);

    Task<BaseResponse<TokenResponse>> ActivateAccount(ActivateAccountRequest request);
}