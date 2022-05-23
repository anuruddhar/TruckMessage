using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TruckMessage.Core.Cqrs {
    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery {
        Task<TResult> Handle(TQuery query);
    }
}
