using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RigioREST.Models;

namespace RigioREST.Data
{
    public interface IAccountService
    {
        Task<List<Account>> GetAccountsAsync();

        Task SaveAccountAsync(Account item, bool isNewItem);

        Task DeleteAccountAsync(int id);
    }
}
