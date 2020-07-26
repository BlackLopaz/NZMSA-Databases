using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NZMSA_mkmu260_Databases.Data;
using NZMSA_mkmu260_Databases.Models;

namespace NZMSA_mkmu260_Databases.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly AddressContext _context;

        public AddressesController(AddressContext context)
        {
            _context = context;
        }

        // GET: api/Addresses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address>>> GetAddress()
        {
            return await _context.Address.ToListAsync();
        }

        // GET: api/Addresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetAddress(int id)
        {
            var address = await _context.Address.FindAsync(id);

            if (address == null)
            {
                return NotFound();
            }

            return address;
        }

        // PUT: api/Addresses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddress(int id, Address address)
        {
            if (id != address.addressId)
            {
                return BadRequest();
            }

            _context.Entry(address).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressExists(id))
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

        // POST: api/Addresses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Address>> PostAddress(Address address)
        {
            _context.Address.Add(address);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAddress", new { id = address.addressId }, address);
        }

        // DELETE: api/Addresses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Address>> DeleteAddress(int id)
        {
            var address = await _context.Address.FindAsync(id);
            if (address == null)
            {
                return NotFound();
            }

            _context.Address.Remove(address);
            await _context.SaveChangesAsync();

            return address;
        }

        private bool AddressExists(int id)
        {
            return _context.Address.Any(e => e.addressId == id);
        }

        // Post with studentId
        [HttpPost("{studentId}")]
        public async Task<ActionResult<Address>> PostAddressStudentId(int studentId, Address address)
        {
            address.studentId = studentId;
            string connectionString = "Server=tcp:nzmsa-mkmu260-server.database.windows.net,1433;Initial Catalog=NZMSA_mkmu260_Databases;Persist Security Info=False;User ID=manoj;Password=AGoodPassword123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand checkStudentId = new SqlCommand("SELECT * FROM Student WHERE studentId = studentId;", con);
            SqlDataReader rdr = checkStudentId.ExecuteReader();
            con.Close();
            if (rdr.HasRows)
            {
                _context.Address.Add(address);
                await _context.SaveChangesAsync();
                return CreatedAtAction("GetAddress", new { id = address.addressId }, address);
            }
            else
            {
                return NotFound();
            }
        }


        [HttpPut("{studentId}")]
        public async Task<IActionResult> PutAddressStudentId(int studentId, Address address)
        {
            address.studentId = studentId;
            string connectionString = "Server=tcp:nzmsa-mkmu260-server.database.windows.net,1433;Initial Catalog=NZMSA_mkmu260_Databases;Persist Security Info=False;User ID=manoj;Password=AGoodPassword123!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand checkStudentId = new SqlCommand("SELECT * FROM Address WHERE studentId = studentId", con);
            SqlDataReader rdr = checkStudentId.ExecuteReader();
            con.Close();
            if (!rdr.HasRows)
            {
                return NotFound();
            }

            else
            {
                while (rdr.Read())
                {
                    address.addressId = rdr.GetInt32(0);
                }
            }

            if (studentId != address.studentId)
            {
                return BadRequest();
            }

            _context.Entry(address).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddressExists(studentId))
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
    }
}
