using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TruckMessage.Core.Service.RequestContext {
    public sealed class RequestContextService : IRequestContextService {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RequestContextService(IHttpContextAccessor accessor) {
            _httpContextAccessor = accessor;
        }

        public string UserName { get; set; }

        public string Email { get; set; }

        public int CountryId { get; set; }

        public string ApplicationId { get; set; }

        public string ApplicationName { get; set; }

        public string ApplicationModuleId { get; set; }

        /// <summary>
        /// ApplicationModuleDescription
        /// </summary>
        public string Application { get; set; }

        public string EndpointFunctions { get; set; }

        public Guid RequestId { get; set; }

        public string ClientVersion => _httpContextAccessor.HttpContext.Request.Headers["ClientVersion"].ToString();

        public string HostName {
            get {
                try {
                    var fullQualifiedName = System.Net.Dns.GetHostEntry(_httpContextAccessor.HttpContext.Connection.RemoteIpAddress).HostName;
                    var nameComponents = fullQualifiedName.Split('.');
                    var hostName = nameComponents.Length > 0 ? nameComponents.First().ToUpper() : fullQualifiedName.ToUpper();
                    return hostName;
                } catch (Exception) {
                    return _httpContextAccessor.HttpContext?.Connection?.RemoteIpAddress?.ToString();
                }
            }
        }

        public string AuthHeader => _httpContextAccessor.HttpContext.Request.Headers["Authorization"].ToString();

        public string ApplicationFunctions { get; set; }

    }
}
