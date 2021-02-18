using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GameManager : IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " Başarıyla eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " Başarıyla silindi. ");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " Başarıyla güncellendi");
        }
    }
}
