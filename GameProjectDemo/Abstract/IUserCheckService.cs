using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    interface IUserCheckService
    {
        bool CheckIfRealPerson(User user);
    }
}
