using ShortLink.Core.Entities.Links;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLink.Core.Contracts
{
    public interface ILinkRepository
    {
        Link Get(string Shorturl);
        long Add(Link link);
    }
}
