﻿using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PersonManager : IApplicanService
    {
        public void ApplyForMask(Person person)
        {

        }
        public List<Person> GetList()
        {
            return null;
        }
        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdenty,person.FirstName,person.LastName,person.DateOfBirthday)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
