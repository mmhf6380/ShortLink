using ShortLink.Core.Entities.Links;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLink.Core.Contracts.Links
{
    public interface ILinkService
    {
        string CreateShortLink(int personId, string link);
        Link GetLink(string shortCode);
    }
}
