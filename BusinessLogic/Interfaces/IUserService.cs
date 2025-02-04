using BusinessLogic.Dtos;
using System.Collections.Generic;

namespace BusinessLogic.Interface
{
    public interface IUserService
    {
        bool AddUser(UserDto userDto);
        List<UserDto> GetUsers();
        bool EditUser(UserDto userDto);
        bool DeleteUser(int id);
        UserDto GetUser(int id);

    }
}
