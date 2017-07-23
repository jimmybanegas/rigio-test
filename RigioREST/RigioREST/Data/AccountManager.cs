using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RigioREST.Models;

namespace RigioREST.Data
{
    public class AccountManager
    {
        private readonly IAccountService _accountService;

        public AccountManager(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public Task<List<Account>> GetAccountsAsync()
        {
            return _accountService.GetAccountsAsync();
        }

        public Task SaveAccountAsync(Account item, bool isNewItem = false)
        {
            return _accountService.SaveAccountAsync(item, isNewItem);
        }

        public Task DeleteAccountAsync(Account item)
        {
            return _accountService.DeleteAccountAsync(item.id);
        }

    }
}
