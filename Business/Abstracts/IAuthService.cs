using Core.Utilities.Security.Models;
using Core.DTOs;

namespace Business.Abstracts;

public interface IAuthService
{
    TokenModel SignIn(UserForLoginDto userForLoginDto);
    TokenModel Register(UserForRegisterDto userForRegisterDto);
}

