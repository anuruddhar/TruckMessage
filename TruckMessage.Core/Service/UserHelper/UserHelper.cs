using System;
using System.Collections.Generic;
using System.Text;
using TruckMessage.Core.Service.RequestContext;

namespace TruckMessage.Core.Service.UserHelper {
    public class UserHelper : IUserHelper {
        private readonly IRequestContextService _requestContextService;

        public UserHelper(IRequestContextService requestContextService) {
            _requestContextService = requestContextService;
        }
        public string GetUsername() {
            if (!string.IsNullOrEmpty(_requestContextService.UserName)) {
                return _requestContextService.UserName.ToUpper();
            }
            return string.Empty;
        }

        public string GetUsernameWithDomain() {
            var hostNameWithUser = "";

            if (!string.IsNullOrEmpty(_requestContextService.UserName)) {
                hostNameWithUser += $"Domain\\{ _requestContextService.UserName}";
            }
            return hostNameWithUser.ToUpper();
        }

        public string GetFullName() {
            return GetUsername();
        }

        public string GetWorkstation() {

            if (!string.IsNullOrEmpty(_requestContextService.HostName)) {
                return _requestContextService.HostName.ToUpper();
            }

            return string.Empty;
        }
    }
}
