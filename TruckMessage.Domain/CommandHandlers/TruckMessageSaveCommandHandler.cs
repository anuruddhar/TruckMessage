using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TruckMessage.Core.Cqrs;
using TruckMessage.Core.Model;
using TruckMessage.Public.Commands;

namespace TruckMessage.Domain.CommandHandlers {
    public sealed class TruckMessageSaveCommandHandler : ICommandHandler<TruckMessageSaveCommand, AppResult> {
        public Task<AppResult> Handle(TruckMessageSaveCommand command) {
            throw new NotImplementedException();
        }
    }
}
