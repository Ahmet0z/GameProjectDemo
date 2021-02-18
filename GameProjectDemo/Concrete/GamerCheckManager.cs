using GameProjectDemo.Abstract;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concrete
{
    class GamerCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient(MernisServiceReference.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new MernisServiceReference.TCKimlikNoDogrulaRequest(new MernisServiceReference.TCKimlikNoDogrulaRequestBody
                (gamer.NationalityId,gamer.FirstName.ToUpper(),gamer.LastName.ToUpper(),gamer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
            return true;
        }

    }
}
