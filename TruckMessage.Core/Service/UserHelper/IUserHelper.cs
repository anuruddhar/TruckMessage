using System;
using System.Collections.Generic;
using System.Text;

namespace TruckMessage.Core.Service.UserHelper {
    public interface IUserHelper {
        string GetFullName();

        string GetUsername();

        string GetUsernameWithDomain();

        string GetWorkstation();
    }
}
