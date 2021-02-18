using GameProjectDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Entity
{
    public class Game: IEntity
    {
        public int GameId { get; set; }
        public string GameName { get; set; }
        public int CategoryId { get; set; }
        public int Price { get; set; }

    }
}
