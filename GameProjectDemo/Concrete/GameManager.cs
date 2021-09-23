using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName+" "+game.GamePrice+"TL'lik fiyati ile sisteme eklendi!");   
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adli oyun sistemden kaldirildi!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adli oyun guncellendi!");
        }
    }
}
