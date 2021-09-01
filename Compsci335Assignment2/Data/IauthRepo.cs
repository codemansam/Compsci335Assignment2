using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compsci335Assignment2.Data
{
    public interface IauthRepo
    {
        public bool ValidLogin(string userName, string password);
    }
}
