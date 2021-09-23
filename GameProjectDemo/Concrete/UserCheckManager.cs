using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class UserCheckManager : IUserCheckService
    {
        public bool CheckIfRealPerson(User user)
        {
            if (user.NationalityId.Length == 11)
                return true;

            else
                return false;
        }
    }
}
