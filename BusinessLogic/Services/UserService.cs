using BusinessLogic.Dtos;
using BusinessLogic.Interface;
using DataAccess.Entities;
using DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool AddUser(UserDto userDto)
        {
            var user = new User
            {
                UserName = userDto.UserName,
                Email = userDto.Email,
                FullName = userDto.FullName,
                Password = userDto.Password,
            };
            return _userRepository.AddUser(user);
        }

        public bool DeleteUser(int id)
        {
            return _userRepository.DeleteUser(id);
        }

        public bool EditUser(UserDto userDto)
        {
            return _userRepository.UpdateUser(new User
            {
                Id = userDto.Id,
                Email = userDto.Email,
                FullName = userDto.FullName,
                Password = userDto.Password,
                UserName = userDto.UserName,
            });
        }

        public UserDto GetUser(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<UserDto> GetUsers()
        {
            var users = _userRepository.GetUsers();
            return users.Select(m => new UserDto
            {
                Id = m.Id,
                UserName = m.UserName,
                Email = m.Email,
                FullName = m.FullName,
                Password = m.Password,
            }).ToList();
        }
    }
}
