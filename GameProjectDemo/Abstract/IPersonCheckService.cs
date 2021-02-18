using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Gamer gamer);
    }
}
