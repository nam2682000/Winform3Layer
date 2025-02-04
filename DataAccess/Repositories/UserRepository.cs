using Dapper;
using DataAccess.DbContext;
using DataAccess.Entities;
using DataAccess.Interfaces;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbContexApplication _context;

        public UserRepository(DbContexApplication context)
        {
            _context = context;
        }

        public IEnumerable<User> GetUsers()
        {
            using (var connection = _context.CreateConnection())
            {
                const string query = "SELECT * FROM Users";
                return connection.Query<User>(query);
            }
        }

        public User GetUser(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                const string query = "SELECT * FROM Users WHERE Id = @Id";
                return connection.QueryFirstOrDefault<User>(query, new { Id = id });
            }
        }

        public bool AddUser(User user)
        {
            using (var connection = _context.CreateConnection())
            {
                const string query = "INSERT INTO Users (UserName, Email, Password, FullName) VALUES (@UserName, @Email, @Password, @FullName)";
                int check = connection.Execute(query, user);
            }
            return true;
        }

        public bool UpdateUser(User user)
        {
            using (var connection = _context.CreateConnection())
            {
                const string query = "Update Users SET UserName = @UserName, Email = @Email, Password = @Password, FullName = @FullName WHERE Id = @Id";
                int check = connection.Execute(query, user);
            }
            return true;
        }

        public bool DeleteUser(int id)
        {
            using (var connection = _context.CreateConnection())
            {
                const string query = "DELETE Users WHERE Id = @Id";
                int check = connection.Execute(query, new { Id = id });
            }
            return true;
        }
    }
}
