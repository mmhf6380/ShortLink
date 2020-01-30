using ShortLink.Core.Entities.Links;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLink.Core.Contracts
{
    public interface ILinkRepository
    {
        Link Get(string ShortText);
        int Add(Link link);
    }
}
