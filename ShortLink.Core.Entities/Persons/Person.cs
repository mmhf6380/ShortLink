using ShortLink.Core.Entities.Links;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLink.Core.Entities.Persons
{
    public class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Link> Links { get; set; } = new List<Link>();
    }
}
