using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simpleBankWithMongoDB.models;
using simpleBankWithMongoDB.services;

namespace simpleBankWithMongoDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankAccountController : ControllerBase
    {
        private readonly  BankAccountServices _bankAccountServices;

        public BankAccountController(BankAccountServices bankAccountServices)
        {
            _bankAccountServices = bankAccountServices;
        }

        [HttpGet]
        public async Task<List<BankAccount>> GetBankAccount() =>
            await  _bankAccountServices.GetAsync();

        [HttpPost]
        public async Task<BankAccount> PostBankAccount(BankAccount bankAccount)
        {
            await _bankAccountServices.CreateAsync(bankAccount);

            return bankAccount;
        }
    }
}
