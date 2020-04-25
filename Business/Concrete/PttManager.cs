using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PttManager :ISupplierService
    {
        private IApplicanService _applicanService;
        public PttManager( IApplicanService applicanService)
        {
            _applicanService = _applicanService;
        }
        public void GiveMask(Person person)
        {
            if (_applicanService.CheckPerson(person))
            {

            }
        }
    }
}
