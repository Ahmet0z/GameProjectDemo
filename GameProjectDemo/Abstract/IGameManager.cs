using System;
using GameProjectDemo.Entity;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IGameManager
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
