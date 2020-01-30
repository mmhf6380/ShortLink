using ShortLink.Core.Entities.Persons;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLink.Core.Entities.Links
{
    public class Link
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public string ShortText { get; set; }
        public int Count { get; set; }
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
