using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Security;

namespace UserAccessService
{
    public class UserAccessService : IUserAccessService, IDisposable
    {
        private string _applicationName = "WSRB";

        public UserPermissions GetUserPermissionsByUserId(Guid UserId)
        {
            return GetPermissions(UserId);
        }

        public UserPermissions GetUserPermissionsByUserName(string UserName)
        {
            string Userid = "";
            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataReader drUser;

           //DO the thing 

            Guid UserId = new Guid(Userid);

            return GetPermissions(UserId);
        }

        private UserPermissions GetPermissions(Guid UserId)
        {
            List<Permissions> Perms = new List<Permissions>();

            SqlConnection objConn = new SqlConnection();
            SqlCommand objCmd = new SqlCommand();
            SqlDataReader drPerms;

           //DO THE THING

            UserPermissions UP = new UserPermissions();

            UP.UserId = UserId;
            UP.AppPermissions = Perms.ToArray();

            return UP;
        }

        public void Dispose()
        {
            //TODO any cleanup necessary
        }
    }
}
