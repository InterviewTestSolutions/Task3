using FileReader.Constants;
using FileReader.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace FileReader
{
    public sealed class BasicRoleChecker : IRoleChecker
    {
        private readonly string userRole;

        public BasicRoleChecker(string userRole)
        {
            this.userRole = userRole;
        }

        public bool IsUserAllowedToReadFile(string filePath)
        {
            bool isAdminRequired = filePath.IndexOf(UserRoles.Admin, StringComparison.InvariantCultureIgnoreCase) != -1;
            bool isCurrentUserAdmin = userRole.Equals(UserRoles.Admin, StringComparison.InvariantCultureIgnoreCase);

            return isCurrentUserAdmin || !isAdminRequired;
        }

        public void VerifyPermissions(string filePath)
        {
            if (!IsUserAllowedToReadFile(filePath))
            {
                throw new UnauthorizedAccessException(FormattableString.Invariant($@"User role ""{userRole}"" doesn't have permissions to open the selected file."));
            }
        }
    }
}
