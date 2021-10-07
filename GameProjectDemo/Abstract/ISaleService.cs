using System;
using System.Collections.Generic;
using System.Text;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    interface ISaleService
    {
        void GameSale(Game game,User user,Campaign campaign);
    }
}
