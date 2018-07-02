using DeployStudy.DIA.Domain;
using DeployStudy.DIA.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DeployStudy.DIA.Service
{
    public class UserService : IUserService
    {
        public bool Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public User GetAById(int id)
        {
            return new User() { Id = 1, Active = true, Birth = Convert.ToDateTime("20/10/200"),Name = "Person 1" };
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetPaged(Expression<Func<User, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public User Insert(User entity)
        {
            throw new NotImplementedException();
        }

        public User Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
