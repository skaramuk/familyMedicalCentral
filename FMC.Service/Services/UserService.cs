using FMC.Entity.Model;
using FMC.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMC.Service.Services
{
    public class UserService
    {

        private UserRepository userRepository = new UserRepository();

        public List<User> GetAll()
        {
            return userRepository.GetList(null);
        }

        public User GetById(int id)
        {
            return userRepository.Get(x => x.Id == id);
        }

        public User Create(User user)
        {
            return userRepository.Add(user);
        }

    }
}
