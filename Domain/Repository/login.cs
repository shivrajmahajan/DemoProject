using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.IRepository;
using DataAccess;
using DataAccess.Models;
using Azure.Identity;

namespace Domain.Repository
{
    public class login : ILogin    {
        MatrimonyContext _context;
        public login(MatrimonyContext context) 
        {
            _context=context;

        }
        string ILogin.logins(string userName,string Password)
        {
            using (var ctx = new MatrimonyContext())
            {
                return "success";
            }
            return null;
        }
    }
}
