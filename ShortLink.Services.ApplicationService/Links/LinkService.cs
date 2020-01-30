using ShortLink.Core.Contracts;
using ShortLink.Core.Contracts.Links;
using ShortLink.Core.Entities.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShortLink.Services.ApplicationService.Links
{
    public class LinkService : ILinkService
    {
        private readonly ILinkRepository linkRepo;

        public LinkService(ILinkRepository linkRepository)
        {
            linkRepo = linkRepository;
        }
        public string CreateShortLink(int personId,string link)
        {
            Link newlink = new Link()
            {
                Text = link,
                ShortText = RandomCode(),
                PersonId = personId
            };
            linkRepo.Add(newlink);
            return newlink.ShortText;
        }
        private string RandomCode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var random = new Random();
            var result = new string(
            Enumerable.Repeat(chars, 8)
                      .Select(s => s[random.Next(s.Length)])
                      .ToArray());
            return result;
        }
        private int CountPlus(int count)
        {
            count++;
            return count;
        }
    }
}
