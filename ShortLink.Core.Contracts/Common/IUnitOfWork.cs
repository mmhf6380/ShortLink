using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLink.Core.Contracts.Common
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
