using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TruckMessage.Core.Cqrs {
    public interface ICommandHandler<TCommand, TResult> where TCommand : ICommand {
        Task<TResult> Handle(TCommand command);
    }
}
