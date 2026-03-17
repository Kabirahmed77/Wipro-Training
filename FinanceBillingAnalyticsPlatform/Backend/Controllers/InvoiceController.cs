using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Dapper;
using System.Data;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly IConfiguration _config;
        private string ConnString => _config.GetConnectionString("DefaultConnection");

        public InvoicesController(IConfiguration config) => _config = config;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            using IDbConnection db = new SqlConnection(ConnString);
            return Ok(await db.QueryAsync("SELECT * FROM Invoices"));
        }

        [HttpPost]
        public async Task<IActionResult> PostInvoice([FromBody] System.Text.Json.JsonElement inv)
        {
            try {
                using IDbConnection db = new SqlConnection(ConnString);
                var sql = "INSERT INTO Invoices (CustomerId, Amount, DueDate, Status) VALUES (@CustomerId, @Amount, @DueDate, @Status)";
                await db.ExecuteAsync(sql, new {
                    CustomerId = inv.GetProperty("CustomerId").GetInt32(),
                    Amount = inv.GetProperty("Amount").GetDecimal(),
                    DueDate = inv.GetProperty("DueDate").GetDateTime(),
                    Status = inv.GetProperty("Status").GetString()
                });
                return Ok();
            } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // NEW: Customer Management Endpoint
        [HttpPost("customer")]
        public async Task<IActionResult> PostCustomer([FromBody] System.Text.Json.JsonElement cust)
        {
            try {
                using IDbConnection db = new SqlConnection(ConnString);
                var sql = "INSERT INTO Customers (CustomerId, Name) VALUES (@Id, @Name)";
                await db.ExecuteAsync(sql, new { 
                    Id = cust.GetProperty("Id").GetInt32(), 
                    Name = cust.GetProperty("Name").GetString() 
                });
                return Ok(new { message = "Customer Registered" });
            } catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}