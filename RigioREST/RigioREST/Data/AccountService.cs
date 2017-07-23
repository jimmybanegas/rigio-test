using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RigioREST.Models;

namespace RigioREST.Data
{
    public class AccountService : IAccountService
    {
        private readonly HttpClient _client;
        public List<Account> Items { get; private set; }
        public Uri Uri { get; set; }

        public AccountService()
        {
            _client = new HttpClient {MaxResponseContentBufferSize = 256000};
            var restUrl = "https://rigio.azurewebsites.net/api/Accounts";

            Uri = new Uri(string.Format(restUrl, string.Empty));
        }
        

        public async Task<List<Account>> GetAccountsAsync()
        {
            Items = new List<Account>();

            try
            {
                var response = await _client.GetAsync(Uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Items = JsonConvert.DeserializeObject<List<Account>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }

            return Items;
        }

        public async Task SaveAccountAsync(Account item, bool isNewItem)
        {
            try
            {
                var json = JsonConvert.SerializeObject(item);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = null;
                if (isNewItem)
                {
                    response = await _client.PostAsync(Uri, content);
                }
                else
                {
                    response = await _client.PutAsync(Uri, content);
                }

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"Account successfully saved.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
        }

        public async Task DeleteAccountAsync(int id)
        {
            try
            {
                var response = await _client.DeleteAsync(Uri);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"Account successfully deleted.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"ERROR {0}", ex.Message);
            }
        }
    }
}
