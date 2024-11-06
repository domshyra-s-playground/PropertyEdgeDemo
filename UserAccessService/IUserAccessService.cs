using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace UserAccessService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    public interface IUserAccessService: IDisposable
    {
        UserPermissions GetUserPermissionsByUserId(Guid UserId);

        UserPermissions GetUserPermissionsByUserName(string UserName);
    }

    public class UserPermissions
    {
        private Guid userid;
        private Permissions[] apppermissions;

        public Guid UserId
        {
            get { return userid; }
            set { userid = value; }
        }

        public Permissions[] AppPermissions
        {
            get { return apppermissions; }
            set { apppermissions = value; }
        }
    }

    public class Permissions
    {
        public string AppNm { get; set; }
        public string AppFunctionNm { get; set; }
        public string StateCd { get; set; }
    }
}
