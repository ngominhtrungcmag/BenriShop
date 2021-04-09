using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BenriShop.Models;
using Microsoft.AspNetCore.Authorization;

namespace BenriShop.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly BenriShopContext _context;

        public AccountsController(BenriShopContext context)
        {
            _context = context;
        }

        #region Admin
        // GET: api/Accounts
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> GetAccount()
        {
            return await _context.Account.ToListAsync();
        }


        // DELETE: api/Accounts/5
        [Authorize]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Account>> DeleteAccount(string id)
        {
            var account = await _context.Account.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }

            _context.Account.Remove(account);
            await _context.SaveChangesAsync();

            return account;
        }

        #endregion

        #region User

        #region Authorize

        // GET: api/Accounts/5
        [Authorize]
        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> GetAccount(string id)
        {
            var account = await _context.Account.FindAsync(id);

            if (account == null)
            {
                return NotFound();
            }

            return account;
        }
        // PUT: api/Accounts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccount(string id, Account account)
        {
            if (id != account.Username)
            {
                return BadRequest();
            }

            _context.Entry(account).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        #endregion



        #region AllowAnonymous

        // POST: api/Accounts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost("CreateAccount")]
        [AllowAnonymous]
        public async Task<ActionResult<Account>> PostAccount(Account account)
        {
            _context.Account.Add(account);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AccountExists(account.Username))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAccount", new { id = account.Username }, account);
        }

        [HttpPost("CheckAccount")]
        [AllowAnonymous]
        public IActionResult CheckAccount(Account account)
        {
            if (AccountExists(account.Username))
            {
                return Conflict("Trùng tài khoản");
            }
            else
            {
                return Ok("Có thể tạo");
            }
        }

        #endregion

        #endregion

        #region Method

        private bool AccountExists(string id)
        {
            return _context.Account.Any(e => e.Username == id);
        }


        #endregion


    }
}
