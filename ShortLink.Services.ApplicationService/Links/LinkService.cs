using ShortLink.Core.Contracts;
using ShortLink.Core.Contracts.Common;
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
        private readonly IUnitOfWork _unitOfWork;

        public LinkService(ILinkRepository linkRepository,IUnitOfWork unitOfWork)
        {
            linkRepo = linkRepository;
            _unitOfWork = unitOfWork;
        }
        public string CreateShortLink(int personId,string link)
        {
            string randomCode = RandomCode();
            while (linkRepo.Get(randomCode) !=null)
            {
                randomCode = RandomCode();
            }
            Link newlink = new Link()
            {
                Text = link,
                ShortText = randomCode,
                PersonId = personId
            };
            linkRepo.Add(newlink);
            return newlink.ShortText;
        }

        public Link GetLink(string shortCode)
        {
           Link fulllink =  linkRepo.Get(shortCode);
            fulllink.Count++;
            _unitOfWork.Commit();
            return fulllink;
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
    }
}
