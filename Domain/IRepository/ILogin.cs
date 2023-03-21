using Azure.Identity;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface ILogin
    {
        string logins(string userName,string password);
    }
}
