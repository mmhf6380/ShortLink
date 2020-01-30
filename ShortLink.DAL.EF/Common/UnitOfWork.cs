using ShortLink.Core.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShortLink.DAL.EF.Common
{
   public class UnitOfWork:IUnitOfWork
    {
        private readonly LinkDbContext context;

        public UnitOfWork(LinkDbContext linkDbContext)
        {
            context = linkDbContext;
        }

        public void Commit()
        {
            context.SaveChanges();
        }
    }
}
