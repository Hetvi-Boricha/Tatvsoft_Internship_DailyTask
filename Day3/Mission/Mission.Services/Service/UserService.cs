using Mission.Entities.ViewModels;
using Mission.Entities.ViewModels.Login;
using Mission.Repositories.IRepository;
using Mission.Services.IService;

namespace Mission.Services.Service
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;

        public async Task<ResponseResult> LogiUser(UserLoginRequestModel model)
        {
            var (response, message) = await _userRepository.LogiUser(model);

            var result = new ResponseResult
            {
                Data = response,
                Message = message,
                Result = response == null ? ResponseStatus.Error : ResponseStatus.Success
            };

            return result;
        }
    }
}
