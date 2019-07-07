using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TamiProjectA.Models;
using TamiProjectA.Data;

namespace TamiProjectA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class OrdersController : ControllerBase
        
    {
        //ApplicationDbContext _db = new ApplicationDbContext();

        private readonly ApplicationDbContext _db;

        public OrdersController(ApplicationDbContext db)
        {
            _db = db;
        }



        // Action Methods

        [HttpGet]
        public IActionResult GetOrders()
        //public ActionResult Index()
        {

            var model = _db.line_items.ToList();

            //return Ok(_db.line_Items.ToList());

            return Ok(model);
        }





        [HttpPost]
        public async Task<IActionResult> AddOrder([FromBody] line_item objline_item)
        {
            if (!ModelState.IsValid)
            {
                return new JsonResult("Error creating an order.");
            }
            _db.line_items.Add(objline_item);
            await _db.SaveChangesAsync();

            return new JsonResult("Order created successfully.");
        }

        
    }
}
