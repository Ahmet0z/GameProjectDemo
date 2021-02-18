using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    public class GamerManager : IGamerManager
    {

        private IPersonCheckService _personCheckService;
        public GamerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        public void Save(Gamer gamer)
        {

            if (_personCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName +" isimli kullanıcı başarıyla eklendi");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli kullanıcı başarıyla silindi.");
        }


        public void Update(Gamer gamer)
        {
            if (_personCheckService.CheckIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " isimli kullanıcı başarıyla güncellendi");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }
        }

    }
}
