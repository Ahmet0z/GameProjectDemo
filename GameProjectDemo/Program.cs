using GameProjectDemo.Abstract;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entity;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonCheckService gamerCheckManager = new GamerCheckManager();
            IGamerManager gamerManager = new GamerManager(gamerCheckManager);

            gamerManager.Save(new Gamer { DateOfBirth = new DateTime(2059, 4, 17), FirstName = "Yasin", LastName = "Tilbaç", Id = 1, NationalityId = 123 });

            Console.ReadLine();
        }
    }
}
