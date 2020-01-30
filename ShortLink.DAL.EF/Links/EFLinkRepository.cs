using ShortLink.Core.Contracts;
using ShortLink.Core.Entities.Links;
using ShortLink.DAL.EF.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShortLink.DAL.EF.Links
{
    public class EFLinkRepository : ILinkRepository
    {
        private readonly LinkDbContext context;

        public EFLinkRepository(LinkDbContext linkDbContext)
        {
           context = linkDbContext;
        }
        public long Add(Link link)
        {
            context.Links.Add(link);
            context.SaveChanges();
            return link.Id;
        }

        public Link Get(string Shorturl)
        {
            return context.Links.Where(x => x.ShortText == Shorturl).FirstOrDefault();
        }
    }
}
