using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;

namespace Services
{
    internal interface IAccountService
    {
        AccountMember GetAccountByID(string accountID);
    }
}
