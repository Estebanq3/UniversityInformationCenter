using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Core.Entities;

namespace Domain.Core.Repositories
{
    public interface IRepository<TAggregateRoot>where TAggregateRoot : AggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
