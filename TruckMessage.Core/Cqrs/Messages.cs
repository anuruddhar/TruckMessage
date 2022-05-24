using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TruckMessage.Core.Cqrs {
    public sealed class Messages {
        private readonly IServiceProvider _provider;

        public Messages(IServiceProvider provider) {
            _provider = provider;
        }

        public async Task<T> Dispatch<T>(ICommand command) {
            Type type = typeof(ICommandHandler<,>);
            Type[] typeArgs = { command.GetType() };
            Type handlerType = type.MakeGenericType(typeArgs);

            dynamic handler = _provider.GetService(handlerType);
            T result = await handler.Handle((dynamic)command);

            return result;
        }

        public async Task<T> Dispatch<T>(IQuery query) {
            Type type = typeof(IQueryHandler<,>);
            Type[] typeArgs = { query.GetType(), typeof(T) };
            Type handlerType = type.MakeGenericType(typeArgs);

            dynamic handler = _provider.GetService(handlerType);
            T result = await handler.Handle((dynamic)query);

            return result;
        }
    }
}
