using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "EREN";
            person1.LastName = "İNAL";
            person1.NationalIdenty = 32419122936;
            person1.DateOfBirthday = 1994;
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            Console.ReadLine();
            //TODO: webapi yazılacak.
        }
    }
    



}
