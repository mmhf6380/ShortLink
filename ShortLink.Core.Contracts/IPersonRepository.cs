using ShortLink.Core.Entities.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLink.Core.Contracts
{
    public interface IPersonRepository
    {
        List<Person> GetAll(); 
    }
}
