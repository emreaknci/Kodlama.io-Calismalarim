using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    class UserManager :IUserService
    {

        UserCheckManager userCheck;
        public void Add(User user)
        {
            userCheck = new UserCheckManager();
            if (userCheck.CheckIfRealPerson(user))
            {
                Console.WriteLine(user.FirstName+" "+user.LastName+" adli kullanici eklendi!");     
            }
            else
            {
                Console.WriteLine(user.NationalityId+" numarali TC "+ user.FirstName + " " + user.LastName+ " ile uyusmuyor!");     
            }
        }

        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " adli oyuncu silindi!");
        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " adli oyuncunun bilgileri guncellendi!");
        }
    }
}
