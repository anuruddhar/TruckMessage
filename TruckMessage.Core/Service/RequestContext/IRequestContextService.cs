using System;
using System.Collections.Generic;
using System.Text;

namespace TruckMessage.Core.Service.RequestContext {
    public interface IRequestContextService {
        string HostName { get; }

        string UserName { get; set; }

        string Email { get; set; }

        string AuthHeader { get; }

        int CountryId { get; set; }

        string ApplicationId { get; set; }

        string ApplicationName { get; set; }

        string ApplicationModuleId { get; set; }

        /// <summary>
        /// ApplicationModuleName
        /// </summary>
        string Application { get; set; }

        string EndpointFunctions { get; set; }

        Guid RequestId { get; set; }

        string ClientVersion { get; }
        string ApplicationFunctions { get; set; }
    }
}
