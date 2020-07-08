using System;
using System.Collections.Generic;
using System.Text;

namespace FileReader.Interfaces
{
    public interface IRoleChecker
    {
        bool IsUserAllowedToReadFile(string filePath);

        void VerifyPermissions(string filePath);
    }
}
